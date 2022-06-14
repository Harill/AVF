using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Telerik.Web.Mvc;
//using Vfi.Client.Module.Purchasing.Interfaces;
using Vfi.Server.Core.CrossCutting.UnitOfWork;
using Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models;
using Vfi.Ui.Mvc.Vfi.Models;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Controllers {
    public class VendorController : Controller {
        private readonly IUnitOfWork _unitOfWork;
        [InjectionConstructor]
        public VendorController(IUnitOfWork unitOfWork
            //, IVendorService vendorService
            ) {
            if (unitOfWork == null) throw new ArgumentNullException("unitOfWork");

            _unitOfWork = unitOfWork;
        }

        ViewDataDictionary GetPageConfigData() {
            var viewModel = MyUtilities.MySystem.GetPageConfig(HttpContext.User.Identity.Name);
            foreach (var property in viewModel.GetType().GetProperties()) {
                ViewData[property.Name] = property.GetValue(viewModel, null);
            }
            return ViewData;
        }
        // View
        public ActionResult VendorManagement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }

        #region Vendor

        [GridAction]
        public ActionResult SelectAllVendor() {
            var models = GetAllVendor();
            return View(new GridModel(models));
        }
        List<VendorModel> GetAllVendor() {
            var model = new List<VendorModel>();
            using (var vfi = new tammaContext()) {
                model.AddRange(vfi.Vendors.Select(vendor => new VendorModel {
                    CompanyName = vendor.CompanyName,
                    BankAccount = vendor.BankAccount,
                    ContactName = vendor.ContactName,
                    Active = vendor.Active,
                    Address = vendor.Address,
                    MaterialClassifiedId = vendor.MaterialClassifiedId ?? 0,
                    MaterialClassifiedName = vendor.MaterialClassified.MaterialClassifiedName,
                    ModifiedDate = vendor.ModifiedDate,
                    ModifiedUser = vendor.ModifiedUser,
                    MaxCredit = vendor.MaxCredit,
                    Note = vendor.Note,
                    Eaddress = vendor.Eaddress,
                    Email = vendor.Email,
                    Fax = vendor.Fax,
                    Phone = vendor.Phone,
                    ShortName = vendor.ShortName,
                    SpecialInfo = vendor.SpecialInfo,
                    TaxCode = vendor.TaxCode,
                    VendorCode = vendor.VendorCode,
                    VendorName = vendor.VendorName,
                    VendorId = vendor.VendorId
                }));
            }
            return model.OrderBy(m => m.MaterialClassifiedName).ThenBy(m => m.VendorCode).ToList();
        }

        [HttpPost]
        [GridAction]
        public ActionResult InsertVendor(VendorModel newVendor) {
            if (!Request.IsAuthenticated) {
                ModelState.AddModelError("CreatePlatingDetail",
                                         @"Bạn đã bị mất quyền đăng nhập. \r\n " +
                                         "1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                         "Xin vui lòng đăng nhập lại hệ thống.");
                return View(new GridModel(new List<VendorModel>()));
            }
            try {
                using (var vfi = new tammaContext()) {
                    var vendor = vfi.Vendors.FirstOrDefault(v => v.VendorCode.Equals(newVendor.VendorCode));
                    if (vendor == null) {
                        int classtifiedId = 1;
                        try {
                            classtifiedId = Convert.ToInt32(newVendor.MaterialClassifiedName);
                        }
                        catch (Exception) {
                            classtifiedId =
                                vfi.MaterialClassifieds.FirstOrDefault(
                                    a => a.MaterialClassifiedName.Equals(newVendor.MaterialClassifiedName))
                                   .MaterialClassifiedId;
                        }

                        vendor = new Vendor {
                            CompanyName = newVendor.CompanyName,
                            BankAccount = newVendor.BankAccount,
                            ContactName = newVendor.ContactName,
                            Active = true,
                            Address = newVendor.Address,
                            MaterialClassifiedId = classtifiedId,
                            ModifiedDate = DateTime.Now,
                            ModifiedUser = HttpContext.User.Identity.Name,
                            MaxCredit = newVendor.MaxCredit,
                            Note = newVendor.Note,
                            Eaddress = newVendor.Eaddress,
                            Email = newVendor.Email,
                            Fax = newVendor.Fax,
                            Phone = newVendor.Phone,
                            ShortName = newVendor.ShortName,
                            SpecialInfo = newVendor.SpecialInfo,
                            TaxCode = newVendor.TaxCode,
                            VendorCode = newVendor.VendorCode,
                            VendorName = newVendor.VendorName,
                        };
                        vfi.Vendors.Add(vendor);
                        vfi.SaveChanges();
                    }
                    else
                        throw new AggregateException("Thêm mới thất bại !Mã nhà cung cấp đã tồn tại ! Vui lòng dùng mã khác!");
                }

            }
            catch (Exception ex) {
                ModelState.AddModelError("InsertVendor", ex.Message);
            }
            return View(new GridModel(GetAllVendor()));

        }

        [HttpPost]
        [GridAction]
        public ActionResult UpdateVendor(VendorModel updateVendor) {
            if (!Request.IsAuthenticated) {
                ModelState.AddModelError("CreatePlatingDetail",
                                         @"Bạn đã bị mất quyền đăng nhập. \r\n " +
                                         "1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                         "Xin vui lòng đăng nhập lại hệ thống.");
                return View(new GridModel(new List<VendorModel>()));
            }
            try {
                using (var vfi = new tammaContext()) {
                    var vendor =
                        vfi.Vendors.FirstOrDefault(
                            v => v.VendorCode.Equals(updateVendor.VendorCode) && v.VendorId != updateVendor.VendorId);
                    if (vendor == null) {
                        int classtifiedId = 1;
                        try {
                            classtifiedId = Convert.ToInt32(updateVendor.MaterialClassifiedName);
                        }
                        catch (Exception) {
                            classtifiedId =
                                vfi.MaterialClassifieds.FirstOrDefault(
                                    a => a.MaterialClassifiedName.Equals(updateVendor.MaterialClassifiedName))
                                   .MaterialClassifiedId;
                        }
                        vendor = vfi.Vendors.FirstOrDefault(v => v.VendorId == updateVendor.VendorId);
                        if (vendor == null)
                            throw new AggregateException("Lỗi nhà cung cấp ! ");
                        vendor.CompanyName = updateVendor.CompanyName;
                        vendor.BankAccount = updateVendor.BankAccount;
                        vendor.ContactName = updateVendor.ContactName;
                        vendor.Active = updateVendor.Active;
                        vendor.Address = updateVendor.Address;
                        vendor.MaterialClassifiedId = classtifiedId;
                        vendor.ModifiedDate = DateTime.Now;
                        vendor.ModifiedUser = HttpContext.User.Identity.Name;
                        vendor.MaxCredit = updateVendor.MaxCredit;
                        vendor.Note = updateVendor.Note;
                        vendor.Eaddress = updateVendor.Eaddress;
                        vendor.Email = updateVendor.Email;
                        vendor.Fax = updateVendor.Fax;
                        vendor.Phone = updateVendor.Phone;
                        vendor.ShortName = updateVendor.ShortName;
                        vendor.SpecialInfo = updateVendor.SpecialInfo;
                        vendor.TaxCode = updateVendor.TaxCode;
                        vendor.VendorCode = updateVendor.VendorCode;
                        vendor.VendorName = updateVendor.VendorName;
                        vfi.SaveChanges();
                    }
                    else
                        throw new AggregateException("Cập nhật thất bại ! Mã nhà cung cấp đã tồn tại ! Vui lòng dùng mã khác!");
                }

            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateVendor", ex.Message);
            }
            return View(new GridModel(GetAllVendor()));
        }
        List<VendorModel> GetVendorCombobox(int materialClasstified) {
            var model = new List<VendorModel>();
            using (var vfi = new tammaContext()) {
                model.AddRange(vfi.Vendors.Where(v => v.MaterialClassifiedId == materialClasstified).Select(vendor => new VendorModel {
                    VendorCode = vendor.VendorCode,
                    VendorName = vendor.VendorName,
                    VendorId = vendor.VendorId,
                    Active = vendor.Active
                }));
            }
            return model;
        }
        public ActionResult SelectComboBoxAllVendor() {
            return new JsonResult {
                Data = new SelectList(GetAllVendor().Where(f => f.Active), "VendorId", "VendorName")
            };
        }
        public ActionResult SelectComboBoxVendorByClasstified(int classified) {
            try {
                if (classified > 0)
                    return new JsonResult {
                        Data = new SelectList(GetVendorCombobox(classified).Where(f => f.Active), "VendorId", "VendorCodeName")
                    };
            }
            catch (Exception ex) { return Json(ex.Message); }
            return new JsonResult {
                Data = new SelectList(new List<object>())
            };
        }

        public ActionResult SelectComboBoxMaterialVendor() {
            return new JsonResult {
                Data =
                    new SelectList(
                        GetVendorCombobox(1).Where(f => f.Active),
                        "VendorId", "VendorCodeName")
            };
        }

        public ActionResult SelectComboBoxToolVendor() {
            return new JsonResult {
                Data =
                    new SelectList(
                        GetVendorCombobox(3).Where(f => f.Active),
                        "VendorId", "VendorCodeName")
            };
        }

        public ActionResult SelectComboBoxFuelVendor() {
            return new JsonResult {
                Data =
                    new SelectList(
                        GetVendorCombobox(2).Where(f => f.Active),
                        "VendorId", "VendorCodeName")
            };
        }

        public ActionResult SelectComboBoxPlatingVendor() {
            return new JsonResult {
                Data =
                    new SelectList(
                        GetVendorCombobox(4).Where(f => f.Active),
                        "VendorId", "VendorCodeName")
            };
        }
        #endregion
    }
}
