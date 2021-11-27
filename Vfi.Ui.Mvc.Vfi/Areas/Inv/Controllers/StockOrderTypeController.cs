using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Telerik.Web.Mvc;
using Vfi.Client.Module.Inv.Interfaces;
using Vfi.Server.Core.CrossCutting.UnitOfWork;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Controllers
{
    public class StockOrderTypeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStockOrderService _stockOrderService;
        [InjectionConstructor]
        public StockOrderTypeController(IUnitOfWork unitOfWork, IStockOrderService stockOrderService)
        {
            if (unitOfWork == null) throw new ArgumentNullException("unitOfWork");
            if (stockOrderService == null) throw new ArgumentNullException("stockOrderService");

            _unitOfWork = unitOfWork;
            _stockOrderService = stockOrderService;
        }

        // View
        public ActionResult StockOrderTypeManagement()
        {
            return View();
        }

        // Data
        public IEnumerable<StockOrderTypeModel> GetStockOrderTypeModels()
        {
            try
            {
                return _stockOrderService.GetAllStockOrderTypes().Select(
                    entity => new StockOrderTypeModel
                                  {
                                      StockOrderTypeId = entity.StockOrderTypeId,
                                      StockOrderTypeName = entity.StockOrderTypeName,
                                      EoI = entity.EoI,
                                      Active = entity.Active,
                                      ModifiedUser = entity.ModifiedUser,
                                      ModifiedDate = entity.ModifiedDate
                                  });
            }
            catch(Exception)
            {
                return null;
            }
        }


        #region StockOrderType

        [GridAction]
        public ActionResult SelectStockOrderType()
        {
            return View(new GridModel(GetStockOrderTypeModels()));
        }

        [HttpPost]
        [GridAction]
        public ActionResult InsertStockOrderType()
        {
            var model = new StockOrderType();
            if(TryUpdateModel(model))
            {
                try
                {
                    model.StockOrderTypeName = model.StockOrderTypeName.Trim();
                    model.ModifiedUser = HttpContext.User.Identity.Name;
                    model.ModifiedDate = DateTime.Now;

                    var rs = _stockOrderService.CreateStockOrderType(model);
                    if(rs == "1")
                    {
                        if (_unitOfWork.SaveChanges() <= 0)
                            ModelState.AddModelError("StockOrderTypeName", @"Không thể tạo giá trị mới. Xin vui lòng nhập lại. (savechanges). " + rs);
                    }
                    else
                        ModelState.AddModelError("StockOrderTypeName", @"Không thể tạo giá trị mới. Xin vui lòng nhập lại. (create). " + rs);
                }
                catch(Exception exception)
                {
                    ModelState.AddModelError("StockOrderTypeName", @"Lỗi giá trị nhập. (try-catch). " + exception.Message);
                }
            }
            else
                ModelState.AddModelError("StockOrderTypeName", @"Lỗi giá trị nhập. (TryUpdateModel)");

            return View(new GridModel(GetStockOrderTypeModels()));
        }

        [HttpPost]
        [GridAction]
        public ActionResult UpdateStockOrderType(int stockOrderTypeId)
        {
            var model = new StockOrderType { StockOrderTypeId = stockOrderTypeId };
            if (TryUpdateModel(model))
            {
                try
                {
                    model.StockOrderTypeName = model.StockOrderTypeName.Trim();
                    model.ModifiedUser = HttpContext.User.Identity.Name;
                    model.ModifiedDate = DateTime.Now;

                    var rs = _stockOrderService.UpdateStockOrderType(model);
                    if (rs == "1")
                    {
                        var s = _unitOfWork.SaveChanges();
                        if (s <= 0)
                            ModelState.AddModelError("StockOrderTypeName", @"Không thể cập nhật giá trị.\r\nXin vui lòng nhập lại.\r\n(savechanges)\r\n " + rs);
                    }
                    else
                        ModelState.AddModelError("StockOrderTypeName", @"Không thể cập nhật giá trị.\r\nXin vui lòng nhập lại.\r\n(update)\r\n" + rs);
                }
                catch (Exception exception)
                {
                    ModelState.AddModelError("StockOrderTypeName", @"Lỗi giá trị nhập.\r\n(try-catch)\r\n" + exception.Message);
                }
            }
            else
                ModelState.AddModelError("StockOrderTypeName", @"Lỗi giá trị nhập. (TryUpdateModel)");

            return View(new GridModel(GetStockOrderTypeModels()));
        }

        public ActionResult SelectComboBoxStockOrderType()
        {
            return new JsonResult
            {
                Data = new SelectList(_stockOrderService.GetAllStockOrderTypes()
                    .Where(f => f.Active), "StockOrderTypeId", "StockOrderTypeName")
            };
        }

        #endregion

    }
}
