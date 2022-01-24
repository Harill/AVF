using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Telerik.Web.Mvc;
using Vfi.Client.Module.Inv.Interfaces;
using Vfi.Server.Core.CrossCutting.UnitOfWork;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;
using Vfi.Ui.Mvc.Vfi.Models;
using Vfi.Ui.Mvc.Vfi.Utilities;

//using Warehouse = Vfi.Server.Core.DataModel.BaseEntities.Warehouse;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Controllers {
    public class WarehouseController : Controller {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IWarehouseService _warehouseService;
        [InjectionConstructor]
        public WarehouseController(IUnitOfWork unitOfWork
            //, IWarehouseService warehouseService
            ) {
            if (unitOfWork == null) throw new ArgumentNullException("unitOfWork");
            //if (warehouseService == null) throw new ArgumentNullException("warehouseService");

            _unitOfWork = unitOfWork;
            //_warehouseService = warehouseService;
        }

        // View
        public ActionResult WarehouseManagement() {
            return View();
        }
        public ActionResult ProcessErrorManagement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View();
        }

        #region Warehouse

        [GridAction]
        public ActionResult SelectWarehouse() {
            return View(new GridModel(GetWarehouseModels()));
        }

        // Data
        public List<WarehouseModel> GetWarehouseModels() {
            var model = new List<WarehouseModel>();
            using (var vfi = new tammaContext()) {
                model = vfi.Warehouses.Select(x => new WarehouseModel {
                    Idx = x.Idx,
                    WarehouseId = x.WarehouseId,
                    WarehouseName = x.WarehouseName,
                    ShortName = x.ShortName,
                    ModifiedUser = x.ModifiedUser,
                    ModifiedDate = x.ModifiedDate,

                    Active = x.Active,
                    IsMainProcess = x.IsMainProcess,
                    IsHeatTreatment = x.IsHeatTreatment,
                    IsPolish = x.IsPolish,
                    IsProduction = x.IsProduction,
                    IsProduction2 = x.IsProduction2,
                    IsProduction2Process = x.IsProduction2Process,
                    IsReprocessing = x.IsReprocessing,
                    IsPlating = x.IsPlating,
                    IsQC = x.IsQC,
                    CanInternal = x.CanInternal,
                    CanPurchase = x.CanPurchase,
                    CanStock = x.CanStock,
                    IsOutOfProcess = x.IsOutOfProcess,
                    IsCncMilling = x.IsCncMilling
                }).ToList();
            }
            return model.OrderByDescending(m => m.Active).ThenBy(m => m.Idx).ThenBy(m => m.WarehouseName).ToList();
        }
        [GridAction]
        public ActionResult SelectActiveWarehouse() {
            return View(new GridModel(GetWarehouseModels().Where(x=> x.Active).ToList()));
        }

        [GridAction]
        public ActionResult SelectWarehouse_user() {
            return View(new GridModel(GetWarehouseModels().Where(w => w.WarehouseTypeId != 1)));
        }

        [HttpPost]
        [GridAction]
        public ActionResult InsertWarehouse(WarehouseModel inserted) {

            if (!Request.IsAuthenticated) {
                ModelState.AddModelError("InsertWarehouse",
                                         "Bạn đã bị mất quyền đăng nhập. " +
                                         "\r\n 1 trong các nguyên nhân như mất thời gian chờ. " +
                                         "\r\n Xin vui lòng đăng nhập lại hệ thống.");
                return View(new GridModel(new List<WarehouseModel>()));
            }
            //var model = new Warehouse();
            //if (TryUpdateModel(model))
            //{
            try {
                using (var vfi = new tammaContext()) {
                    if (string.IsNullOrWhiteSpace(inserted.WarehouseName))
                        throw new AggregateException("Lỗi! Tên kho phải có");

                    var entity = new Mvc.Vfi.Models.Warehouse {
                        WarehouseName = inserted.WarehouseName.Trim(),
                        ShortName = inserted.ShortName.Trim(),
                        Idx = inserted.Idx,
                        Active = true,
                        CanInternal = inserted.CanInternal,
                        CanPurchase = inserted.CanPurchase,
                        CanStock = inserted.CanStock,
                        IsHeatTreatment = inserted.IsHeatTreatment,
                        IsPolish = inserted.IsPolish,
                        IsProduction = inserted.IsProduction,
                        IsCncMilling = inserted.IsCncMilling,
                        IsProduction2 = inserted.IsProduction2,
                        IsProduction2Process = inserted.IsProduction2Process,
                        IsReprocessing = inserted.IsReprocessing,
                        IsMainProcess = inserted.IsMainProcess,
                        IsQC = inserted.IsQC,
                        IsPlating = inserted.IsPlating,
                        IsOutOfProcess = inserted.IsOutOfProcess,
                        ModifiedUser = HttpContext.User.Identity.Name,
                        ModifiedDate = DateTime.Now,
                    };
                    if (string.IsNullOrWhiteSpace(entity.ShortName))
                        entity.ShortName = entity.WarehouseName;
                    vfi.Warehouses.Add(entity);
                    vfi.SaveChanges();
                }
            }
            catch (Exception exception) {
                ModelState.AddModelError("WarehouseName", @"Lỗi giá trị nhập. (try-catch). " + exception.Message);
            }
            return View(new GridModel(GetWarehouseModels()));
        }

        [HttpPost]
        [GridAction]
        public ActionResult UpdateWarehouse(WarehouseModel updated) {

            if (!Request.IsAuthenticated) {
                ModelState.AddModelError("UpdateWarehouse",
                                         "Bạn đã bị mất quyền đăng nhập. " +
                                         "\r\n 1 trong các nguyên nhân như mất thời gian chờ. " +
                                         "\r\n Xin vui lòng đăng nhập lại hệ thống.");
                return View(new GridModel(new List<WarehouseModel>()));
            }
            try {
                using (var vfi = new tammaContext()) {
                    if (string.IsNullOrWhiteSpace(updated.WarehouseName))
                        throw new AggregateException("Lỗi! Tên kho phải có");

                    var entity = vfi.Warehouses.FirstOrDefault(w => w.WarehouseId == updated.WarehouseId);
                    entity.WarehouseName = updated.WarehouseName.Trim();
                    entity.ShortName = updated.ShortName.Trim();
                    entity.Idx = updated.Idx;
                    entity.Active = updated.Active;
                    entity.CanInternal = updated.CanInternal;
                    entity.CanPurchase = updated.CanPurchase;
                    entity.CanStock = updated.CanStock;
                    entity.IsHeatTreatment = updated.IsHeatTreatment;
                    entity.IsPolish = updated.IsPolish;
                    entity.IsProduction = updated.IsProduction;
                    entity.IsCncMilling = updated.IsCncMilling;
                    entity.IsProduction2 = updated.IsProduction2;
                    entity.IsProduction2Process = updated.IsProduction2Process;
                    entity.IsReprocessing = updated.IsReprocessing;
                    entity.IsMainProcess = updated.IsMainProcess;
                    entity.IsQC = updated.IsQC;
                    entity.IsPlating = updated.IsPlating;
                    entity.IsOutOfProcess = updated.IsOutOfProcess;
                    entity.ModifiedUser = HttpContext.User.Identity.Name;
                    entity.ModifiedDate = DateTime.Now;
                    if (string.IsNullOrWhiteSpace(entity.ShortName))
                        entity.ShortName = entity.WarehouseName;
                    //vfi.Warehouses.Add(entity);
                    vfi.SaveChanges();
                }
            }
            catch (Exception exception) {
                ModelState.AddModelError("WarehouseName", @"Lỗi giá trị nhập.\r\n(try-catch)\r\n" + exception.Message);
            }
            return View(new GridModel(GetWarehouseModels()));
        }

        public List<WarehouseCboModel> GetActiveWarehouseModels(WarehouseConfiguration config) {
            var model = new List<WarehouseCboModel>();
            using (var vfi = new tammaContext()) {
                model = (from x in vfi.Warehouses
                         where x.Active
                             && (config.IsMainProcess == null || x.IsMainProcess == config.IsMainProcess)
                             && (config.IsProduction == null || x.IsProduction == config.IsProduction)
                             && (config.IsCncMilling == null || x.IsCncMilling == config.IsCncMilling)
                             && (config.IsProduction2 == null || x.IsProduction2 == config.IsProduction2)
                             && (config.IsProduction2Process == null || x.IsProduction2Process == config.IsProduction2Process)
                             && (config.IsHeatTreatment == null || x.IsHeatTreatment == config.IsHeatTreatment)
                             && (config.IsPolish == null || x.IsPolish == config.IsPolish)
                             && (config.IsQC == null || x.IsQC == config.IsQC)
                             && (config.IsPlating == null || x.IsPlating == config.IsPlating)
                             && (config.IsReprocessing == null || x.IsReprocessing == config.IsReprocessing)
                             && (config.IsOutOfProcess == null || x.IsOutOfProcess == config.IsOutOfProcess)
                             && (config.CanInternal == null || x.CanInternal == config.CanInternal)
                             && (config.CanPurchase == null || x.CanPurchase == config.CanPurchase)
                             && (config.CanStock == null || x.CanStock == config.CanStock)
                             && (!config.Ids.Any() || config.Ids.Contains(x.WarehouseId))
                         orderby x.Idx, x.WarehouseName
                         select new WarehouseCboModel {
                             WarehouseId = x.WarehouseId,
                             WarehouseName = x.WarehouseName,
                             Idx = x.Idx,
                         }).ToList();
            }
            if (!model.Any()) {
                model.Insert(0, new WarehouseCboModel {
                    WarehouseId = 0,
                    WarehouseName = "Chưa có thiết lập",
                    Idx = 0
                });
            }
            else if (config.AddFirstAll == true) {
                model.Insert(0, new WarehouseCboModel {
                    WarehouseId = 0,
                    WarehouseName = "Tất cả",
                    Idx = 0
                });
            }
            return model;
        }

        public List<int> GetActiveWarehouseIds(WarehouseConfiguration config) {
            return GetActiveWarehouseModels(config).Where(x => x.WarehouseId > 0).Select(x => x.WarehouseId).ToList();
        }

        public ActionResult SelectComboBoxWarehouseMainProcess() {
            return new JsonResult {
                Data = new SelectList(GetActiveWarehouseModels(new WarehouseConfiguration { IsMainProcess = true }), "WarehouseId", "WarehouseName")
            };
        }

        public ActionResult SelectComboBoxWarehouseProductionTesting() {
            var warehouseIds = new List<int>();
            warehouseIds.Add(GetActiveWarehouseModels(new WarehouseConfiguration { IsProduction = true }).Select(x => x.WarehouseId).FirstOrDefault());
            warehouseIds.Add(GetActiveWarehouseModels(new WarehouseConfiguration { IsQC = true }).Select(x => x.WarehouseId).FirstOrDefault());
            return new JsonResult {
                Data = new SelectList(GetActiveWarehouseModels(new WarehouseConfiguration { Ids = warehouseIds }), "WarehouseId", "WarehouseName")
            };
        }
        public ActionResult SelectComboBoxWarehouseProduction() {
            return new JsonResult {
                Data = new SelectList(GetActiveWarehouseModels(new WarehouseConfiguration { IsProduction = true }), "WarehouseId", "WarehouseName")
            };
        }
        public ActionResult SelectComboBoxWarehouseCncMilling() {
            return new JsonResult {
                Data = new SelectList(GetActiveWarehouseModels(new WarehouseConfiguration { IsCncMilling = true }), "WarehouseId", "WarehouseName")
            };
        }
        public ActionResult SelectComboBoxWarehouseProduction2() {
            return new JsonResult {
                Data = new SelectList(GetActiveWarehouseModels(new WarehouseConfiguration { IsProduction2 = true }), "WarehouseId", "WarehouseName")
            };
        }
        public ActionResult SelectComboBoxWarehouseProduction2Processing() {
            return new JsonResult {
                Data = new SelectList(GetActiveWarehouseModels(new WarehouseConfiguration { IsProduction2Process = true }), "WarehouseId", "WarehouseName")
            };
        }
        public ActionResult SelectComboBoxWarehouseHeatTreatment() {
            return new JsonResult {
                Data = new SelectList(GetActiveWarehouseModels(new WarehouseConfiguration { IsHeatTreatment = true }), "WarehouseId", "WarehouseName")
            };
        }
        public ActionResult SelectComboBoxWarehousePolish() {
            return new JsonResult {
                Data = new SelectList(GetActiveWarehouseModels(new WarehouseConfiguration { IsPolish = true }), "WarehouseId", "WarehouseName")
            };
        }
        public ActionResult SelectComboBoxWarehouseReprocessing() {
            return new JsonResult {
                Data = new SelectList(GetActiveWarehouseModels(new WarehouseConfiguration { IsReprocessing = true }), "WarehouseId", "WarehouseName")
            };
        }
        public ActionResult SelectComboBoxWarehouseQc() {
            return new JsonResult {
                Data = new SelectList(GetActiveWarehouseModels(new WarehouseConfiguration { IsQC = true, AddFirstAll = true }), "WarehouseId", "WarehouseName")
            };
        }
        public ActionResult SelectComboBoxWarehousePlating() {
            return new JsonResult {
                Data = new SelectList(GetActiveWarehouseModels(new WarehouseConfiguration { IsPlating = true }), "WarehouseId", "WarehouseName")
            };
        }
        public ActionResult SelectComboBoxInternalWarehouse() {
            return new JsonResult {
                Data = new SelectList(GetActiveWarehouseModels( new WarehouseConfiguration { CanInternal = true }), "WarehouseId", "WarehouseName")
            };
        }
        public ActionResult SelectComboBoxPurchaseWarehouse() {
            return new JsonResult {
                Data = new SelectList(GetActiveWarehouseModels(new WarehouseConfiguration { CanPurchase = true }), "WarehouseId", "WarehouseName")
            };
        }
        public ActionResult SelectAllComboBoxWarehouse() {
            return new JsonResult {
                Data = new SelectList(GetActiveWarehouseModels(new WarehouseConfiguration { AddFirstAll = true }), "WarehouseId", "WarehouseName")
            };
        }

        public ActionResult SelectComboBoxImportWarehouse() {
            var model = new List<WarehouseCboModel>();
            using (var vfi = new tammaContext()) {
                var user = vfi.Users.FirstOrDefault(u => u.Username.Equals(HttpContext.User.Identity.Name));
                if (user == null)
                    throw new AggregateException("Vui lòng đăng nhập lại");
                var warehouseIds =
                    vfi.WarehousePermissions.Where(wp => wp.UserId == user.UserId && wp.Import == true)
                       .Select(wp => wp.WarehouseId.Value)
                       .ToList();
                model = GetActiveWarehouseModels(new WarehouseConfiguration { Ids = warehouseIds });
            }
            return new JsonResult {
                Data = new SelectList(model, "WarehouseId", "WarehouseName")
            };
        }


        public ActionResult SelectComboBoxWarehouseRotateById(int warehouseId) {
            var warehouseIds = new List<int>();
            using (var vfi = new tammaContext()) {
                var isInvManager = MyUtilities.UserRole.CheckRole(HttpContext.User.Identity.Name, MyUtilities.UserRole.InvManagement);
                if (isInvManager) {
                    warehouseIds = vfi.Warehouses.Select(x => x.WarehouseId).ToList();
                }
                else {
                    var user = vfi.Users.FirstOrDefault(u => u.Username.Equals(HttpContext.User.Identity.Name));
                    if (user == null) {
                        return new JsonResult {
                            Data = new SelectList(new List<WarehouseCboModel>(), "WarehouseId", "WarehouseName")
                        };
                    }
                    warehouseIds = vfi.WarehouseRotates.Where(x => x.Active && x.WarehouseId == warehouseId)
                                                        .Select(x => x.ToWarehouseId)
                                                        .ToList();
                    //warehouseIds.AddRange(MyUtilities.Warehouse.GetWarehouseId_ExceptionRotate());
                    warehouseIds = vfi.WarehousePermissions.Where(x => x.UserId == user.UserId
                                                                    && x.Rotate == true
                                                                    && warehouseIds.Contains(x.WarehouseId.Value))
                                                            .Select(x => x.WarehouseId.Value).ToList();
                }
            }

            var model = GetActiveWarehouseModels(new WarehouseConfiguration {Ids = warehouseIds });
            return new JsonResult {
                Data = new SelectList(model, "WarehouseId", "WarehouseName")
            };
        }

        public ActionResult SelectComboBoxCncRotateWarehouse() {
            return SelectComboBoxWarehouseRotateById(MyUtilities.Warehouse.Cnc);
        }

        public ActionResult SelectComboBoxRotateWarehouse() {
            var model = new List<WarehouseCboModel>();
            using (var vfi = new tammaContext()) {
                var user = vfi.Users.FirstOrDefault(u => u.Username.Equals(HttpContext.User.Identity.Name));
                if (user == null)
                    throw new AggregateException("Vui lòng đăng nhập lại");
                var warehouseIds =
                    vfi.WarehousePermissions.Where(wp => wp.UserId == user.UserId && wp.Rotate == true)
                       .Select(wp => wp.WarehouseId.Value)
                       .ToList();
                model = GetActiveWarehouseModels(new WarehouseConfiguration { Ids = warehouseIds });
            }
            return new JsonResult {
                Data = new SelectList(model, "WarehouseId", "WarehouseName")
            };
        }

        public ActionResult SelectComboBoxProgressWarehouseByUser() {
            var model = new List<WarehouseCboModel>();
            using (var vfi = new tammaContext()) {
                var user = vfi.Users.FirstOrDefault(u => u.Username.Equals(HttpContext.User.Identity.Name));
                if (user == null)
                    throw new AggregateException("Vui lòng đăng nhập lại");
                var warehouseIds =
                    vfi.WarehousePermissions.Where(wp => wp.UserId == user.UserId && wp.OrderProgress == true)
                       .Select(wp => wp.WarehouseId.Value)
                       .ToList();
                model = GetActiveWarehouseModels(new WarehouseConfiguration { Ids = warehouseIds });
            }
            return new JsonResult {
                Data = new SelectList(model, "WarehouseId", "WarehouseName")
            };
        }

        #endregion

        #region process error

        [GridAction]
        public ActionResult SelectProcessError() {
            var model = new List<ProcessErrorModel>();
            try {
                model = GetProcessErrorModel();
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectProcessError", ex.Message);
            }
            return View(new GridModel(model));

        }

        private List<ProcessErrorModel> GetProcessErrorModel() {
            var model = new List<ProcessErrorModel>();
            using (var vfi = new tammaContext()) {
                var processErrors = vfi.ProcessErrors
                                       .OrderByDescending(pe => pe.Active)
                                       .ThenBy(pe => pe.Description);
                foreach (var processError in processErrors) {
                    var entity = new ProcessErrorModel {
                        Description = processError.Description,
                        Active = processError.Active,
                        ErrorId = processError.ErrorId,
                        ModifiedDate = processError.ModifiedDate,
                        ModifiedUser = processError.ModifiedUser
                    };
                    model.Add(entity);
                }
            }
            return model;
        }

        [GridAction]
        public ActionResult InsertProcessError(ProcessErrorModel insert) {
            try {

                using (var vfi = new tammaContext()) {
                    var error = vfi.ProcessErrors.FirstOrDefault(pe => pe.Description.Equals(insert.Description.Trim()));
                    if (error == null) {
                        error = new ProcessError {
                            Active = true,
                            Description = insert.Description,
                            ModifiedDate = DateTime.Now,
                            ModifiedUser = HttpContext.User.Identity.Name,
                        };
                        vfi.ProcessErrors.Add(error);
                        vfi.SaveChanges();
                    }
                    else {
                        if (!error.Active) {
                            error.Active = true;
                            vfi.SaveChanges();
                        }
                        else throw new AggregateException("Lỗi! Mô tả lỗi bị trùng.");
                    }

                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("InsertProcessError", ex.Message);
            }
            return View(new GridModel(GetProcessErrorModel()));
        }

        [GridAction]
        public ActionResult UpdateProcessError(ProcessErrorModel update) {
            try {

                using (var vfi = new tammaContext()) {
                    var error =
                        vfi.ProcessErrors.FirstOrDefault(
                            pe => pe.Description.Equals(update.Description.Trim()) && pe.ErrorId != update.ErrorId);
                    if (error == null) {
                        error = vfi.ProcessErrors.FirstOrDefault(pe => pe.ErrorId == update.ErrorId);
                        if (error == null)
                            throw new AggregateException("Lỗi! Không tìm thấy dữ liệu cần cập nhật!");
                        error.Active = update.Active;
                        error.Description = update.Description;
                        error.ModifiedDate = DateTime.Now;
                        error.ModifiedUser = HttpContext.User.Identity.Name;
                        vfi.SaveChanges();
                    }
                    else {
                        if (!error.Active) {
                            error.Active = true;
                            vfi.SaveChanges();
                        }
                        else throw new AggregateException("Lỗi! Mô tả lỗi bị trùng.");
                    }
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateProcessError", ex.Message);
            }
            return View(new GridModel(GetProcessErrorModel()));
        }

        public ActionResult SelectComboBoxProductError() {
            var model = new List<ProcessErrorModel>();
            using (var vfi = new tammaContext()) {
                var errors = vfi.ProcessErrors.Where(pe => pe.Active).OrderBy(pe => pe.Description);
                foreach (var error in errors) {
                    var entity = new ProcessErrorModel {
                        ErrorId = error.ErrorId,
                        Description = error.Description
                    };
                    model.Add(entity);
                }
                return new JsonResult {
                    Data =
                        new SelectList(model, "ErrorId", "Description")
                };
            }
        }
        #endregion

    }
}
