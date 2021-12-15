using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Web.Mvc;
using Vfi.Server.Core.DataModel.Models.Inv;
using Vfi.Ui.Mvc.Vfi.Areas.Factory.Models;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;
using Vfi.Ui.Mvc.Vfi.Models;
using Vfi.Ui.Mvc.Vfi.Models.Production;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Controllers {
    public class ProductionController : Controller {

        #region view


        #endregion

        #region heat treatment management

        [GridAction]
        public ActionResult SelectProductionHeatTreatment(int customerId, int productId, string productCode) {
            var model = new List<ProductionHeatTreatmentModel>();
            try {
                model = GetProductionHeatTreatmentByProductId(customerId, productId, productCode);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectProductionHeatTreatment", ex.Message);
            }
            return View(new GridModel(model));
        }

        List<ProductionHeatTreatmentModel> GetProductionHeatTreatmentByProductId(int customerId, int productId, string productCode) {
            var model = new List<ProductionHeatTreatmentModel>();
            using (var vfi = new tammaContext()) {
                model = (from x in vfi.ProductionHeatTreatments
                         where (productId == 0 || x.ProductId == productId) &&
                             (customerId == 0 || x.Product.CustomerId == customerId)
                         select new ProductionHeatTreatmentModel {
                             Id = x.Id,
                             Name = x.Name,
                             Section = x.Section,
                             Rate = x.Rate,
                             Timing = x.Timing,
                             Note = x.Note,
                             Temperature = x.Temperature,
                             Stiffness = x.Stiffness,
                             ModifiedDate = x.ModifiedDate,
                             ModifiedUser = x.ModifiedUser,
                             Active = x.Active,
                             ProductId = x.ProductId,
                             ProductCode = x.Product.ProductCode,
                             CustomerId = x.Product.CustomerId,
                             CustomerCode = x.Product.Customer.CustomerCode,
                             MachineId = x.MachineId ?? 0,
                             MachineName = x.MachineId != null ? x.Machine.MachineName : ""
                         }).ToList();
                if (!string.IsNullOrWhiteSpace(productCode)) {
                    model = model.Where(x => x.ProductCode.Contains(productCode)).ToList();
                }
            }
            return model.OrderBy(x => x.CustomerCode).ThenBy(x => x.ProductCode).ThenBy(m => m.Section).ToList();
        }

        [HttpPost]
        [GridAction]
        public ActionResult InsertProductionHeatTreatment(ProductionHeatTreatmentModel insert, int productId) {
            if (!Request.IsAuthenticated) {
                throw new AggregateException("Bạn đã bị mất quyền đăng nhập. \r\n " +
                                             "1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                             "Xin vui lòng đăng nhập lại hệ thống.");
            }
            try {
                using (var vfi = new tammaContext()) {
                    var user = vfi.Users.FirstOrDefault(u => u.Username.Equals(HttpContext.User.Identity.Name));
                    if (user == null)
                        throw new AggregateException("Vui lòng đăng nhập lại");

                    var entity = new ProductionHeatTreatment {
                        Name = insert.Name,
                        Section = insert.Section,
                        Rate = insert.Rate,
                        Timing = insert.Timing,
                        Note = insert.Note,
                        Temperature = insert.Temperature,
                        Stiffness = insert.Stiffness,
                        Active = true,
                        ProductId = productId,
                        ModifiedDate = DateTime.Now,
                        ModifiedUser = HttpContext.User.Identity.Name
                    };
                    var machineId = 0;
                    try { machineId = Convert.ToInt32(insert.MachineName); }
                    catch (Exception) { }
                    if (machineId != 0) { entity.MachineId = machineId; }

                    vfi.ProductionHeatTreatments.Add(entity);
                    vfi.SaveChanges();
                }
                MyUtilities.Product.UpdateProductDesign(productId);
            }
            catch (Exception ex) {
                ModelState.AddModelError("InsertProductionHeatTreatment", ex.Message);
            }

            return View(new GridModel(GetProductionHeatTreatmentByProductId(0, productId, "")));
        }

        [HttpPost]
        [GridAction]
        public ActionResult UpdateProductionHeatTreatment(ProductionHeatTreatmentModel update, int productId) {
            if (!Request.IsAuthenticated) {
                throw new AggregateException("Bạn đã bị mất quyền đăng nhập. \r\n " +
                                             "1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                             "Xin vui lòng đăng nhập lại hệ thống.");
            }
            try {
                using (var vfi = new tammaContext()) {
                    var user = vfi.Users.FirstOrDefault(u => u.Username.Equals(HttpContext.User.Identity.Name));
                    if (user == null)
                        throw new AggregateException("Vui lòng đăng nhập lại");
                    var entity = vfi.ProductionHeatTreatments.FirstOrDefault(pt => pt.Id == update.Id);
                    if (entity == null)
                        throw new AggregateException("Lỗi! Không tìm thấy công cụ trong sản phấm! Liên hệ admin");
                    entity.Name = update.Name;
                    entity.Section = update.Section;
                    entity.Rate = update.Rate;
                    entity.Timing = update.Timing;
                    entity.Note = update.Note;
                    entity.Temperature = update.Temperature;
                    entity.Stiffness = update.Stiffness;
                    entity.Active = update.Active;
                    entity.ModifiedDate = DateTime.Now;
                    entity.ModifiedUser = HttpContext.User.Identity.Name;
                    var machineId = 0;
                    try { machineId = Convert.ToInt32(update.MachineName); }
                    catch (Exception) { }
                    if (machineId != 0 && machineId != entity.MachineId) { entity.MachineId = machineId; }

                    vfi.SaveChanges();
                }
                MyUtilities.Product.UpdateProductDesign(productId);
            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateProductionHeatTreatment", ex.Message);
            }

            return View(new GridModel(GetProductionHeatTreatmentByProductId(0, productId, "")));
        }

        #endregion

        #region polish management

        [GridAction]
        public ActionResult SelectProductionPolish(int customerId, int productId, string productCode) {
            var model = new List<ProductionPolishModel>();
            try {
                model = GetProductionPolishByProductId(customerId, productId, productCode);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectProductionPolish", ex.Message);
            }
            return View(new GridModel(model));
        }
        List<ProductionPolishModel> GetProductionPolishByProductId(int customerId, int productId, string productCode) {
            var model = new List<ProductionPolishModel>();
            using (var vfi = new tammaContext()) {
                model = (from x in vfi.ProductionPolishes
                         where (productId == 0 || x.ProductId == productId) &&
                                 (customerId == 0 || x.Product.CustomerId == customerId)
                         select new ProductionPolishModel {
                             Id = x.Id,
                             Name = x.Name,
                             Section = x.Section,
                             Rate = x.Rate,
                             Timing = x.Timing,
                             Note = x.Note,
                             Rock = x.Rock,
                             Using = x.Using,
                             ModifiedDate = x.ModifiedDate,
                             ModifiedUser = x.ModifiedUser,
                             Active = x.Active,
                             ProductId = x.ProductId,
                             ProductCode = x.Product.ProductCode,
                             CustomerId = x.Product.CustomerId,
                             CustomerCode = x.Product.Customer.CustomerCode,
                             MachineId = x.MachineId ?? 0,
                             MachineName = x.MachineId != null ? x.Machine.MachineName : ""
                         }).ToList();
                if (!string.IsNullOrWhiteSpace(productCode)) {
                    model = model.Where(x => x.ProductCode.Contains(productCode)).ToList();
                }
            }
            return model.OrderBy(x => x.CustomerCode).ThenBy(x => x.ProductCode).ThenBy(m => m.Section).ToList();
        }

        [HttpPost]
        [GridAction]
        public ActionResult InsertProductionPolish(ProductionPolishModel insert, int productId) {
            if (!Request.IsAuthenticated) {
                throw new AggregateException("Bạn đã bị mất quyền đăng nhập. \r\n " +
                                             "1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                             "Xin vui lòng đăng nhập lại hệ thống.");
            }
            try {
                using (var vfi = new tammaContext()) {
                    var user = vfi.Users.FirstOrDefault(u => u.Username.Equals(HttpContext.User.Identity.Name));
                    if (user == null)
                        throw new AggregateException("Vui lòng đăng nhập lại");

                    var entity = new ProductionPolish {
                        Name = insert.Name,
                        Section = insert.Section,
                        Rate = insert.Rate,
                        Timing = insert.Timing,
                        Note = insert.Note,
                        Rock = insert.Rock,
                        Using = insert.Using,
                        Active = true,
                        ProductId = productId,
                        ModifiedDate = DateTime.Now,
                        ModifiedUser = HttpContext.User.Identity.Name
                    };

                    var machineId = 0;
                    try { machineId = Convert.ToInt32(insert.MachineName); }
                    catch (Exception) { }
                    if (machineId != 0) { entity.MachineId = machineId; }

                    vfi.ProductionPolishes.Add(entity);
                    vfi.SaveChanges();
                }
                MyUtilities.Product.UpdateProductDesign(productId);
            }
            catch (Exception ex) {
                ModelState.AddModelError("InsertProductionPolish", ex.Message);
            }

            return View(new GridModel(GetProductionPolishByProductId(0, productId, "")));
        }

        [HttpPost]
        [GridAction]
        public ActionResult UpdateProductionPolish(ProductionPolishModel update, int productId) {
            if (!Request.IsAuthenticated) {
                throw new AggregateException("Bạn đã bị mất quyền đăng nhập. \r\n " +
                                             "1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                             "Xin vui lòng đăng nhập lại hệ thống.");
            }
            try {
                using (var vfi = new tammaContext()) {
                    var user = vfi.Users.FirstOrDefault(u => u.Username.Equals(HttpContext.User.Identity.Name));
                    if (user == null)
                        throw new AggregateException("Vui lòng đăng nhập lại");
                    var entity = vfi.ProductionPolishes.FirstOrDefault(pt => pt.Id == update.Id);
                    if (entity == null)
                        throw new AggregateException("Lỗi! Không tìm thấy công cụ trong sản phấm! Liên hệ admin");
                    entity.Name = update.Name;
                    entity.Section = update.Section;
                    entity.Rate = update.Rate;
                    entity.Timing = update.Timing;
                    entity.Note = update.Note;
                    entity.Rock = update.Rock;
                    entity.Using = update.Using;
                    entity.Active = update.Active;
                    entity.ModifiedDate = DateTime.Now;
                    entity.ModifiedUser = HttpContext.User.Identity.Name;

                    var machineId = 0;
                    try { machineId = Convert.ToInt32(update.MachineName); }
                    catch (Exception) { }
                    if (machineId != 0 && machineId != entity.MachineId) { entity.MachineId = machineId; }

                    vfi.SaveChanges();
                }
                MyUtilities.Product.UpdateProductDesign(productId);
            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateProductionPolish", ex.Message);
            }

            return View(new GridModel(GetProductionPolishByProductId(0, productId, "")));
        }

        #endregion

        #region plating management

        [GridAction]
        public ActionResult SelectProductionPlating(int customerId, int productId, string productCode) {
            var model = new List<ProductionPlatingModel>();
            try {
                model = GetProductionPlatingByProductId(customerId, productId, productCode);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectProductionPlating", ex.Message);
            }
            return View(new GridModel(model));
        }
        List<ProductionPlatingModel> GetProductionPlatingByProductId(int customerId, int productId, string productCode) {
            var model = new List<ProductionPlatingModel>();
            using (var vfi = new tammaContext()) {
                model = (from x in vfi.ProductionPlatings
                         where (productId == 0 || x.ProductId == productId) &&
                                (customerId == 0 || x.Product.CustomerId == customerId)
                         select new ProductionPlatingModel {
                             ModifiedDate = x.ModifiedDate,
                             ModifiedUser = x.ModifiedUser,
                             Active = x.Active,
                             ProductId = x.ProductId,
                             PlatingId = x.PlatingId,
                             PlatingName = x.PlatingName,
                             Description = x.Description + "",
                             PlatingCost = x.PlatingCost,
                             PlatingIndex = x.PlatingIndex,
                             PlatingDay = x.PlatingDay,
                             SaltSprayTime = x.SaltSprayTime,
                             Thickness = x.Thickness,
                             ProductCode = x.Product.ProductCode,
                             CustomerCode = x.Product.Customer.CustomerCode,
                             IsMainProcess = x.IsMainProcess
                         }).ToList();
                if (!string.IsNullOrWhiteSpace(productCode)) {
                    model = model.Where(x => x.ProductCode.Contains(productCode)).ToList();
                }
            }
            return model.OrderBy(x => x.CustomerCode).ThenBy(x => x.ProductCode).ThenBy(m => m.PlatingIndex).ToList();
        }

        [HttpPost]
        [GridAction]
        public ActionResult InsertProductionPlating(ProductionPlatingModel insert, int productId) {
            if (!Request.IsAuthenticated) {
                throw new AggregateException("Bạn đã bị mất quyền đăng nhập. \r\n " +
                                             "1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                             "Xin vui lòng đăng nhập lại hệ thống.");
            }
            try {
                using (var vfi = new tammaContext()) {
                    var user = vfi.Users.FirstOrDefault(u => u.Username.Equals(HttpContext.User.Identity.Name));
                    if (user == null)
                        throw new AggregateException("Vui lòng đăng nhập lại");

                    var entity = new ProductionPlating {
                        ProductId = productId,
                        Active = true,
                        PlatingName = insert.PlatingName,
                        Description = insert.Description + "",
                        InsertDate = DateTime.Now,
                        InserUser = HttpContext.User.Identity.Name,
                        PlatingCost = insert.PlatingCost,
                        ModifiedDate = DateTime.Now,
                        ModifiedUser = HttpContext.User.Identity.Name,
                        PlatingIndex = insert.PlatingIndex,
                        PlatingDay = insert.PlatingDay,
                        SaltSprayTime = insert.SaltSprayTime,
                        Thickness = insert.Thickness,
                    };
                    vfi.ProductionPlatings.Add(entity);
                    vfi.SaveChanges();
                }
                MyUtilities.Product.UpdateProductDesign(productId);
            }
            catch (Exception ex) {
                ModelState.AddModelError("InsertProductionPlating", ex.Message);
            }

            return View(new GridModel(GetProductionPlatingByProductId(0, productId, "")));
        }

        [HttpPost]
        [GridAction]
        public ActionResult UpdateProductionPlating(ProductionPlatingModel update, int productId) {
            if (!Request.IsAuthenticated) {
                throw new AggregateException("Bạn đã bị mất quyền đăng nhập. \r\n " +
                                             "1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                             "Xin vui lòng đăng nhập lại hệ thống.");
            }
            try {
                using (var vfi = new tammaContext()) {
                    var user = vfi.Users.FirstOrDefault(u => u.Username.Equals(HttpContext.User.Identity.Name));
                    if (user == null)
                        throw new AggregateException("Vui lòng đăng nhập lại");
                    var entity = vfi.ProductionPlatings.FirstOrDefault(pt => pt.PlatingId == update.PlatingId);
                    if (entity == null)
                        throw new AggregateException("Lỗi! Không tìm thấy công cụ trong sản phấm! Liên hệ admin");
                    entity.Active = update.Active;
                    entity.ModifiedDate = DateTime.Now;
                    entity.ModifiedUser = HttpContext.User.Identity.Name;

                    entity.PlatingName = update.PlatingName;
                    entity.PlatingIndex = update.PlatingIndex;
                    entity.Description = update.Description + "";
                    entity.PlatingDay = update.PlatingDay;
                    entity.SaltSprayTime = update.SaltSprayTime;
                    entity.Thickness = update.Thickness;
                    entity.PlatingCost = update.PlatingCost;
                   
                    vfi.SaveChanges();
                }
                MyUtilities.Product.UpdateProductDesign(productId);
            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateProductionPlating", ex.Message);
            }

            return View(new GridModel(GetProductionPlatingByProductId(0, productId, "")));
        }

        #endregion

        #region production section management

        [GridAction]
        public ActionResult SelectProductionSection(int productId) {
            var model = new List<ProductionSectionModel>();
            try {
                model = GetProductionSectionByProductId(productId);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectProductionSection", ex.Message);
            }
            return View(new GridModel(model));
        }

        List<ProductionSectionModel> GetProductionSectionByProductId(int productId) {
            var model = new List<ProductionSectionModel>();
            using (var vfi = new tammaContext()) {
                model = vfi.ProductionSections.Where(x => productId == 0 || x.ProductId == productId).Select(entity => new ProductionSectionModel {
                    ProductionSectionId = entity.ProductionSectionId,
                    SectionName = entity.Section.SectionName,
                    SectionCost = entity.Section.SaleFactor * entity.Productivity,
                    UpdateDate = entity.UpdateDate ?? DateTime.Now,
                    UpdateUser = entity.UpdateUser,
                    Description = entity.Description,
                    Active = entity.Active,
                    IsProductionManagement = 1,
                    IsSaleManagement = 1,
                    SectionIndex = entity.SectionIndex,
                    Productivity = entity.Productivity,
                    Weight = entity.Weight,
                    IsMainProcess = entity.IsMainProcess,
                    MachineId = entity.MachineId ?? 0,
                    MachineName = entity.MachineId != null ? entity.Machine.MachineName : ""
                }).ToList();
            }
            return model.OrderBy(m => m.SectionIndex).ToList();
        }

        [HttpPost]
        [GridAction]
        public ActionResult InsertProductionSection(ProductionSectionModel insert, int productId) {
            if (!Request.IsAuthenticated) {
                throw new AggregateException("Bạn đã bị mất quyền đăng nhập. \r\n " +
                                             "1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                             "Xin vui lòng đăng nhập lại hệ thống.");
            }
            try {
                using (var vfi = new tammaContext()) {
                    var user = vfi.Users.FirstOrDefault(u => u.Username.Equals(HttpContext.User.Identity.Name));
                    if (user == null)
                        throw new AggregateException("Vui lòng đăng nhập lại");
                    int sectionId = 1;
                    try {
                        sectionId = Convert.ToInt32(insert.SectionName);
                    }
                    catch (Exception) {
                        var section2 = vfi.Sections.FirstOrDefault(w => w.SectionName.Equals(insert.SectionName));
                        if (section2 == null)
                            throw new AggregateException("Lỗi công đoạn ! Chọn lại công đoạn");
                        sectionId = section2.SectionId;
                    }


                    var entity = new ProductionSection {
                        ProductId = productId,
                        Active = true,
                        Description = insert.Description + "",
                        UpdateDate = DateTime.Now,
                        UpdateUser = HttpContext.User.Identity.Name,
                        Productivity = insert.Productivity,
                        SectionIndex = insert.SectionIndex,
                        SectionId = sectionId,
                        InsertDate = DateTime.Now,
                        InsertUser = HttpContext.User.Identity.Name,
                        Weight = insert.Weight,
                        IsMainProcess = insert.IsMainProcess
                    };

                    var machineId = 0;
                    try { machineId = Convert.ToInt32(insert.MachineName); }
                    catch (Exception) { }
                    if (machineId != 0) { entity.MachineId = machineId; }

                    var productionProgress =
                            vfi.ProductionProcesses.FirstOrDefault(
                                pp =>
                                pp.ProductId == productId && pp.WarehouseId == MyUtilities.Warehouse.Production2);
                    if (productionProgress == null) {
                        productionProgress = new ProductionProcess {
                            IsAlert = true,
                            IsNecessary = true,
                            ModifiedDate = DateTime.Now,
                            ModifiedUser = HttpContext.User.Identity.Name,
                            ProductId = productId,
                            WarehouseId = MyUtilities.Warehouse.Production2,
                            ProcessIndex = 10
                        };
                        vfi.ProductionProcesses.Add(productionProgress);
                    }
                    else {
                        if (!productionProgress.IsNecessary) productionProgress.IsNecessary = true;
                    }
                    vfi.ProductionSections.Add(entity);
                    vfi.SaveChanges();
                }
                MyUtilities.Product.UpdateProductDesign(productId);
            }
            catch (Exception ex) {
                ModelState.AddModelError("InsertProductionSection", ex.Message);
            }

            return View(new GridModel(GetProductionSectionByProductId(productId)));
        }

        [HttpPost]
        [GridAction]
        public ActionResult UpdateProductionSection(ProductionSectionModel update, int productId) {
            if (!Request.IsAuthenticated) {
                throw new AggregateException("Bạn đã bị mất quyền đăng nhập. \r\n " +
                                             "1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                             "Xin vui lòng đăng nhập lại hệ thống.");
            }
            try {
                using (var vfi = new tammaContext()) {
                    var user = vfi.Users.FirstOrDefault(u => u.Username.Equals(HttpContext.User.Identity.Name));
                    if (user == null)
                        throw new AggregateException("Vui lòng đăng nhập lại");
                    var entity =
                        vfi.ProductionSections.FirstOrDefault(
                            ps => ps.ProductionSectionId == update.ProductionSectionId);
                    if (entity == null)
                        throw new AggregateException("Lỗi! Không tìm thấy công cụ trong sản phấm! Liên hệ admin");
                    int sectionId = 0;
                    if (!string.IsNullOrWhiteSpace(update.SectionName)) {
                        try {
                            sectionId = Convert.ToInt32(update.SectionName);
                        }
                        catch (Exception) {
                            var section2 =
                                vfi.Sections.FirstOrDefault(w => w.SectionName.Equals(update.SectionName));
                            if (section2 == null)
                                throw new AggregateException("Lỗi ! Chọn lại gia công");
                            sectionId = section2.SectionId;
                        }
                    }
                    if (sectionId != 0)
                        entity.SectionId = sectionId;

                    var machineId = 0;
                    try { machineId = Convert.ToInt32(update.MachineName); }
                    catch (Exception) { }
                    if (machineId != 0 && machineId != entity.MachineId) { entity.MachineId = machineId; }

                    entity.Active = update.Active;
                    entity.Description = update.Description;
                    entity.UpdateDate = DateTime.Now;
                    entity.UpdateUser = HttpContext.User.Identity.Name;
                    entity.SectionIndex = update.SectionIndex;
                    entity.Weight = update.Weight;
                    entity.IsMainProcess = update.IsMainProcess;
                    var productionProgress =
                                vfi.ProductionProcesses.FirstOrDefault(
                                    pp =>
                                    pp.ProductId == productId && pp.WarehouseId == MyUtilities.Warehouse.Production2);
                    if (productionProgress == null) {
                        productionProgress = new ProductionProcess {
                            IsAlert = true,
                            IsNecessary = true,
                            ModifiedDate = DateTime.Now,
                            ModifiedUser = HttpContext.User.Identity.Name,
                            ProductId = productId,
                            WarehouseId = MyUtilities.Warehouse.Production2
                        };
                        vfi.ProductionProcesses.Add(productionProgress);
                    }
                    else {
                        if (!productionProgress.IsNecessary) productionProgress.IsNecessary = true;
                    }
                    if (entity.Productivity != update.Productivity && update.Productivity != 0) {
                        var log = new SectionLog {
                            ModifiedDate = DateTime.Now,
                            ModifiedUser = HttpContext.User.Identity.Name,
                            NewProductivity = update.Productivity,
                            OldProductivity = entity.Productivity,
                            ProductionSectionId = entity.ProductionSectionId
                        };
                        entity.Productivity = update.Productivity;
                        vfi.SectionLogs.Add(log);
                    }
                    vfi.SaveChanges();
                }
                MyUtilities.Product.UpdateProductDesign(productId);
            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateProductionSection", ex.Message);
            }

            return View(new GridModel(GetProductionSectionByProductId(productId)));
        }

        #endregion

        #region production packing
        [GridAction]
        public ActionResult SelectProductionFuel(int customerId, int productId, string productCode) {
            var model = new List<ProductionFuelModel>();
            try {
                model = GetProductionFuelByProductId(customerId, productId, productCode);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectProductionFuel", ex.Message);
            }
            return View(new GridModel(model));
        }

        List<ProductionFuelModel> GetProductionFuelByProductId(int customerId, int productId, string productCode) {
            var model = new List<ProductionFuelModel>();
            using (var vfi = new tammaContext()) {
                var packings = vfi.ProductionFuels.Where(pt => 
                    pt.Active && 
                    (productId == 0 || pt.ProductId == productId) &&
                    (customerId ==0 || pt.Product.CustomerId == customerId)
                    ).ToList();
                if (!string.IsNullOrWhiteSpace(productCode)) {
                    packings = packings.Where(x => x.Product.ProductCode.Contains(productCode)).ToList();
                }
                foreach (var productionFuel in packings) {
                    var entity = new ProductionFuelModel {
                        RealId = productionFuel.RealId,
                        FuelId = productionFuel.FuelId,
                        ProductId = productionFuel.ProductId,
                        ProductCode = productionFuel.Product.ProductCode,
                        CustomerId = productionFuel.Product.CustomerId,
                        CustomerCode = productionFuel.Product.Customer.CustomerCode,
                        Priority = productionFuel.Priority,
                        Active = productionFuel.Active,
                        ModifiedDate = productionFuel.ModifiedDate,
                        ModifiedUser = productionFuel.ModifiedUser,
                        FuelFullCode = productionFuel.Fuel.FuelFullCode,
                        FuelCode = productionFuel.Fuel.FuelCode,
                        FuelName = productionFuel.Fuel.FuelName,
                        FuelDesign = productionFuel.Fuel.FuelDesignNo,
                        Note = productionFuel.Note,
                        Quota = productionFuel.Quota,

                        Fuel2Id = productionFuel.Fuel2Id,
                        CrossWeight = productionFuel.CrossWeight,
                        CrossWeight2 = productionFuel.CrossWeight2,
                        Quota2 = productionFuel.Quota2,
                    };
                    if (productionFuel.Fuel2Id != null) {
                        entity.FuelFullCode2 = productionFuel.Fuel1.FuelFullCode;
                        entity.FuelCode2 = productionFuel.Fuel1.FuelCode;
                        entity.FuelName2 = productionFuel.Fuel1.FuelName;
                    }
                    model.Add(entity);
                }
            }
            return model.OrderBy(x => x.CustomerCode).ThenBy(x => x.ProductCode).ThenBy(m => m.Priority).ToList();

        }

        [HttpPost]
        [GridAction]
        public ActionResult InsertProductionFuel(ProductionFuelModel insert, int productId) {
            if (!Request.IsAuthenticated) {
                throw new AggregateException("Bạn đã bị mất quyền đăng nhập. \r\n " +
                                             "1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                             "Xin vui lòng đăng nhập lại hệ thống.");
            }
            try {
                using (var vfi = new tammaContext()) {
                    var user = vfi.Users.FirstOrDefault(u => u.Username.Equals(HttpContext.User.Identity.Name));
                    if (user == null)
                        throw new AggregateException("Vui lòng đăng nhập lại");
                    int fuelId = 1;
                    try {
                        fuelId = Convert.ToInt32(insert.FuelName);
                    }
                    catch (Exception) {
                        fuelId = vfi.Fuels.FirstOrDefault(w => w.FuelFullCode.Equals(insert.FuelName)).FuelId;
                    }
                    Nullable<int> fuelId2 = null;
                    try {
                        fuelId2 = Convert.ToInt32(insert.FuelName2);
                    }
                    catch (Exception) { }
                    var entity =
                        vfi.ProductionFuels.FirstOrDefault(
                            pt => pt.ProductId == productId && pt.FuelId == fuelId && pt.Fuel2Id == fuelId2 && !pt.Active);
                    if (entity == null) {
                        entity = new ProductionFuel {
                            FuelId = fuelId,
                            ProductId = productId,
                            ModifiedDate = DateTime.Now,
                            ModifiedUser = HttpContext.User.Identity.Name,
                            Active = true,
                            Priority = insert.Priority,
                            Note = insert.Note,
                            Quota = insert.Quota,

                            Fuel2Id = fuelId2,
                            CrossWeight = insert.CrossWeight,
                            CrossWeight2 = insert.CrossWeight2,
                            Quota2 = insert.Quota2,
                        };
                        vfi.ProductionFuels.Add(entity);
                    }
                    else {
                        entity.ModifiedDate = DateTime.Now;
                        entity.ModifiedUser = HttpContext.User.Identity.Name;
                        entity.Active = true;
                        entity.Priority = insert.Priority;
                        entity.Note = insert.Note;
                        entity.Quota = insert.Quota;
                        entity.CrossWeight = insert.CrossWeight;
                        entity.CrossWeight2 = insert.CrossWeight2;
                        entity.Quota2 = insert.Quota2;
                    }
                    vfi.SaveChanges();
                }
                MyUtilities.Product.UpdateProductDesign(productId);
            }
            catch (Exception ex) {
                ModelState.AddModelError("InsertProductionFuel", ex.Message);
            }

            return View(new GridModel(GetProductionFuelByProductId(0, productId, "")));
        }

        [HttpPost]
        [GridAction]
        public ActionResult UpdateProductionFuel(ProductionFuelModel update, int productId) {
            if (!Request.IsAuthenticated) {
                throw new AggregateException("Bạn đã bị mất quyền đăng nhập. \r\n " +
                                         "1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                         "Xin vui lòng đăng nhập lại hệ thống.");
            }
            try {
                using (var vfi = new tammaContext()) {
                    var user = vfi.Users.FirstOrDefault(u => u.Username.Equals(HttpContext.User.Identity.Name));
                    if (user == null)
                        throw new AggregateException("Vui lòng đăng nhập lại");
                    var entity = vfi.ProductionFuels.FirstOrDefault(pt => pt.RealId == update.RealId);
                    int fuelId = 1;
                    try {
                        fuelId = Convert.ToInt32(update.FuelName);
                    }
                    catch (Exception) {
                        fuelId = entity.FuelId;
                    }
                    Nullable<int> fuelId2 = null;
                    try {
                        if (!string.IsNullOrWhiteSpace(update.FuelName2))
                            fuelId2 = Convert.ToInt32(update.FuelName2);
                    }
                    catch (Exception) {
                        fuelId2 = entity.Fuel2Id;
                    }
                    if (entity == null)
                        throw new AggregateException("Lỗi! Không tìm thấy công cụ trong sản phấm! Liên hệ admin");
                    entity.FuelId = fuelId;
                    //entity.ProductId = productId;
                    entity.ModifiedDate = DateTime.Now;
                    entity.ModifiedUser = HttpContext.User.Identity.Name;
                    entity.Active = update.Active;
                    entity.Priority = update.Priority;
                    entity.Note = update.Note;
                    entity.Quota = update.Quota;
                    entity.Fuel2Id = fuelId2;
                    entity.CrossWeight = update.CrossWeight;
                    entity.CrossWeight2 = update.CrossWeight2;
                    entity.Quota2 = update.Quota2;
                    vfi.SaveChanges();
                }
                MyUtilities.Product.UpdateProductDesign(productId);
            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateProductionFuel", ex.Message);
            }

            return View(new GridModel(GetProductionFuelByProductId(0, productId, "")));
        }

        #endregion

        [HttpPost]
        public ActionResult PrintProductionForm(int productId) {
            try {
                return PartialView("PageProductionForm", null);
            }
            catch (Exception exception) {
                throw new Exception(exception.Message);
            }
        }
    }
}
