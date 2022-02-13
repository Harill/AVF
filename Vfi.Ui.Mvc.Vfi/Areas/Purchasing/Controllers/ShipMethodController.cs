using System;
using System.Collections.Generic;
//using System.Linq;
using System.Linq;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Telerik.Web.Mvc;
using Vfi.Client.Module.Purchasing.Interfaces;
using Vfi.Server.Core.CrossCutting.UnitOfWork;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Controllers {
    public class ShipMethodController : Controller {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IShipMethodService _shipMethodService;
        [InjectionConstructor]
        public ShipMethodController(IUnitOfWork unitOfWork, IShipMethodService shipMethodService) {
            if (unitOfWork == null) throw new ArgumentNullException("unitOfWork");
            if (shipMethodService == null) throw new ArgumentNullException("shipMethodService");

            _unitOfWork = unitOfWork;
            _shipMethodService = shipMethodService;
        }
        ViewDataDictionary GetPageConfigData() {
            var viewModel = MyUtilities.MySystem.GetPageConfig();
            foreach (var property in viewModel.GetType().GetProperties()) {
                ViewData[property.Name] = property.GetValue(viewModel, null);
            }
            return ViewData;
        }
        // View
        public ActionResult ShipMethodManagement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }

        // Data
        public IEnumerable<ShipMethodModel> GetShipMethodByModels() {
            try {
                return _shipMethodService.GetAllShipMethods().Select(
                    entity => new ShipMethodModel {
                        ShipMethodId = entity.ShipMethodId,
                        Name = entity.Name,
                        ShipBase = entity.ShipBase,
                        ShipRate = entity.ShipRate,

                        Active = entity.Active,
                        ModifiedUser = entity.ModifiedUser,
                        ModifiedDate = entity.ModifiedDate
                    });
            }
            catch (Exception) {
                return null;
            }
        }

        #region ShipMethod

        [GridAction]
        public ActionResult SelectShipMethod() {
            return View(new GridModel(GetShipMethodByModels()));
        }

        [HttpPost]
        [GridAction]
        public ActionResult InsertShipMethod() {
            if (!Request.IsAuthenticated) {
                ModelState.AddModelError("CreatePlatingDetail",
                                         @"Bạn đã bị mất quyền đăng nhập. \r\n " +
                                         "1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                         "Xin vui lòng đăng nhập lại hệ thống.");
                return View(new GridModel(new List<ShipMethodModel>()));
            }
            var model = new ShipMethod();
            if (TryUpdateModel(model)) {
                try {
                    model.Name = model.Name.Trim();
                    model.ModifiedUser = HttpContext.User.Identity.Name;
                    model.ModifiedDate = DateTime.Now;

                    var rs = _shipMethodService.CreateShipMethod(model);
                    if (rs == "1") {
                        if (_unitOfWork.SaveChanges() <= 0)
                            ModelState.AddModelError("ShipMethodName", @"Không thể tạo giá trị mới. Xin vui lòng nhập lại. (savechanges). " + rs);
                    }
                    else
                        ModelState.AddModelError("ShipMethodName", @"Không thể tạo giá trị mới. Xin vui lòng nhập lại. (create). " + rs);
                }
                catch {
                    ModelState.AddModelError("ShipMethodName", @"Lỗi giá trị nhập. (TryUpdateModel)");
                }
            }
            else
                ModelState.AddModelError("ShipMethodName", @"Lỗi giá trị nhập. (TryUpdateModel)");

            return View(new GridModel(GetShipMethodByModels()));
        }

        [HttpPost]
        [GridAction]
        public ActionResult UpdateShipMethod(int shipMethodId) {
            if (!Request.IsAuthenticated) {
                ModelState.AddModelError("CreatePlatingDetail",
                                         @"Bạn đã bị mất quyền đăng nhập. \r\n " +
                                         "1 trong các nguyên nhân như mất thời gian chờ. \r\n " +
                                         "Xin vui lòng đăng nhập lại hệ thống.");
                return View(new GridModel(new List<ShipMethodModel>()));
            }
            var model = new ShipMethod { ShipMethodId = shipMethodId };
            if (TryUpdateModel(model)) {
                try {
                    model.Name = model.Name.Trim();
                    model.ModifiedUser = HttpContext.User.Identity.Name;
                    model.ModifiedDate = DateTime.Now;

                    var rs = _shipMethodService.UpdateShipMethod(model);
                    if (rs == "1") {
                        if (_unitOfWork.SaveChanges() <= 0)
                            ModelState.AddModelError("ShipMethodName", @"Không thể cập nhật giá trị. Xin vui lòng nhập lại. (savechanges). " + rs);
                    }
                    else
                        ModelState.AddModelError("ShipMethodName", @"Không thể cập nhật giá trị. Xin vui lòng nhập lại. (create). " + rs);
                }
                catch {
                    ModelState.AddModelError("ShipMethodName", @"Lỗi giá trị nhập. (TryUpdateModel)");
                }
            }
            else
                ModelState.AddModelError("ShipMethodName", @"Lỗi giá trị nhập. (TryUpdateModel)");

            return View(new GridModel(GetShipMethodByModels()));
        }

        public ActionResult SelectComboBoxShipMethod() {
            return new JsonResult {
                Data = new SelectList(_shipMethodService.GetAllShipMethods().Where(f => f.Active), "ShipMethodId", "Name")
            };
        }

        #endregion
    }
}
