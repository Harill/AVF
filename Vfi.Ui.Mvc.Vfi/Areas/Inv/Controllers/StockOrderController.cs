using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Telerik.Web.Mvc;
using Telerik.Web.Mvc.Extensions;
using Vfi.Client.Module.Inv.Interfaces;
using Vfi.Client.Module.Production.Interfaces;
using Vfi.Server.Core.CrossCutting.UnitOfWork;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Inv;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Controllers
{
    public class StockOrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStockOrderService _stockOrderService;
        private readonly IMaterialInventoryService _materialInventoryService;
        private readonly IMaterialService _materialService;

        private readonly IParameterService _parameterService;
        [InjectionConstructor]
        public StockOrderController(IUnitOfWork unitOfWork, IStockOrderService stockOrderService,
                                    IMaterialInventoryService materialInventoryService,
                                    IMaterialService materialService,
            IParameterService parameterService)
        {
            if (unitOfWork == null) throw new ArgumentNullException("unitOfWork");
            if (stockOrderService == null) throw new ArgumentNullException("stockOrderService");
            if (materialInventoryService == null) throw new ArgumentNullException("materialInventoryService");
            if (materialService == null) throw new ArgumentNullException("materialService");

            if (parameterService == null) throw new ArgumentNullException("parameterService");

            _unitOfWork = unitOfWork;
            _stockOrderService = stockOrderService;
            _materialInventoryService = materialInventoryService;
            _materialService = materialService;

            _parameterService = parameterService;
        }

        // View
        
        public ActionResult ExportStockOrderMaterial()
        {
            return View();
        }
        public ActionResult ImportStockOrderMaterial()
        {
            return View();
        }
        public ActionResult RotateStockOrderMaterial()
        {
            return View();
        }

        public ActionResult StockOrderMaterialManagement()
        {
            return View();
        }
        public ActionResult ApproveStockOrderMaterial()
        {
            return View();
        }

        /////
        /// 
        /////
        public ActionResult ExportStockOrderProduct()
        {
            return View();
        }
        public ActionResult ImportStockOrderProduct()
        {
            return View();
        }
        public ActionResult RotateStockOrderProduct()
        {
            return View();
        }
        public ActionResult StockOrderProductManagement()
        {
            return View();
        }
        public ActionResult ApproveStockOrderProduct()
        {
            return View();
        }


        // GetData
        public IEnumerable<MaterialInventoryModel> ConvertMaterialInventoryToModels(
            IEnumerable<MaterialInventory> materialInventories)
        {
            try
            {
                return materialInventories.Select(
                    entity => new MaterialInventoryModel
                    {
                        MaterialInventoryId = entity.MaterialInventoryId,

                        MaterialId = entity.MaterialId,
                        MaterialCode = entity.Material != null ? entity.Material.MaterialCode : "",
                        MaterialName = entity.Material != null ? entity.Material.MaterialName : "",

                        WarehouseId = entity.WarehouseId,
                        WarehouseName = entity.Warehouse != null ? entity.Warehouse.WarehouseName : "",

                        TotalQty = entity.TotalQty??0,
                        AvailableQty = entity.AvailableQty ?? 0,
                        UnavailableQty = entity.UnavailableQty ?? 0,

                        UnitMeasure = entity.UnitMeasure,
                        Status = entity.Status,

                        Active = entity.Active,
                        ModifiedUser = entity.ModifiedUser,
                        ModifiedDate = entity.ModifiedDate?? DateTime.Now,
                    });
            }
            catch
            {
                return null;
            }
        }

        #region GenParamCode

        [HttpPost]
        public ActionResult GenStockOrderParam()
        {
            string stockOrderCode;

            var stockOrderNum = _parameterService.GetAllParameters().Where(f => f.ParamCode == "StockOrderNum").FirstOrDefault();

            var y = DateTime.Today.Year;
            var m = DateTime.Today.Month;
            var d = DateTime.Today.Day;

            if (stockOrderNum != null)
                stockOrderCode = y + "." + m + "." + d + "." + stockOrderNum.Value;
            else
                stockOrderCode = y + "." + m + "." + d + "." + "ERROR";

            return Json(stockOrderCode);
        }

        #endregion

        #region StockOrder

        [HttpPost]
        public ActionResult ApproveStockOrderMaterial(long[] checkedRecords)
        {
            try
            {
                if(!Request.IsAuthenticated)
                    return Json(@"Vui lòng đăng nhập hệ thống. ");

                var modifiedUser = HttpContext.User.Identity.Name;
                if(string.IsNullOrWhiteSpace(modifiedUser))
                    ModelState.AddModelError("StockOrderCode", @"Vui lòng đăng nhập hệ thống. (user null). ");

                var rs = _stockOrderService.UpdateStatusStockOrder(checkedRecords, (byte)StockOrderStatusEnumModel.Approved, modifiedUser);
                if (rs == "1")
                {
                    if (_unitOfWork.SaveChanges() <= 0)
                        return Json(@"Không thể cập nhật trạng thái lệnh. Xin vui lòng thử lại. (savechanges). " + rs);
                }
                else
                    return Json(@"Không thể cập nhật trạng thái lệnh. Xin vui lòng thử lại. (udpate-status). " + rs);
            }
            catch (Exception exception)
            {
                return Json(@"Lỗi giá trị nhập. (try-catch). " + exception.Message);
            }

            return Json("okie");
        }

        [HttpPost]
        public ActionResult AutoCompletedStockOrderCode(string text, bool mop, byte status)
        {
            IEnumerable<string> model = null;
            if (text.HasValue())
            {
                if(status == 0)
                {
                    model =
                    _stockOrderService.GetStockOrderByMoP(mop).Where(
                        f => f.StockOrderCode.StartsWith(text, StringComparison.OrdinalIgnoreCase)).Select(
                            f => f.StockOrderCode);
                }
                else
                {
                    model =
                    _stockOrderService.GetStockOrderByMoP(mop).Where(
                        f => f.StockOrderCode.StartsWith(text, StringComparison.OrdinalIgnoreCase) &&
                            f.Status == status).Select(
                            f => f.StockOrderCode);
                }
            }
            return new JsonResult
            {
                Data = model
            };
        }

        public ActionResult CheckStockOrderCode(string stockOrderCode)
        {
            if(string.IsNullOrWhiteSpace(stockOrderCode))
                return Json(2);

            var models = _stockOrderService.GetStockOrderByCode(stockOrderCode);

            return Json(models != null ? 1 : 0);
        }

        [GridAction]
        public ActionResult SelectStockOrderByStatus(byte? status, string stockOrderCode, bool mop)
        {
            if (status == null)
            {
                return View(new GridModel(new List<StockOrderModel>()));
            }
            IEnumerable<StockOrder> entities;
            if(status != 0)
            {
                entities =
                    _stockOrderService.GetStockOrderByStatus((byte)status).Where(f => f.MoP == mop && f.Active);
            }
            else
            {
                entities = _stockOrderService.GetAllStockOrders().Where(f => f.MoP == mop && f.Active);
            }

            

            if(!string.IsNullOrWhiteSpace(stockOrderCode))
            {
                entities = entities.Where(f => f.StockOrderCode.Equals(stockOrderCode, StringComparison.OrdinalIgnoreCase));
            }

            
            var models = _stockOrderService.ConvertStockOrderToModels(entities);

            return View(new GridModel(models));
        }

        public ActionResult SelectComboBoxStockOrderStatus()
        {
            var val = from StockOrderStatusEnumModel stt in Enum.GetValues(typeof (StockOrderStatusEnumModel))
                      select new
                                 {
                                     Value = (int)Enum.Parse(typeof(StockOrderStatusEnumModel), stt.ToString()),
                                     Text = stt.ToString()
                                 };

            return new JsonResult
            {
                Data = new SelectList(val, "Value", "Text")
            };
        }

        #endregion

        #region StockOrderDetail

        [GridAction]
        public ActionResult SelectStockOrderDetail()
        {
            return View(new GridModel(new List<StockOrderDetailModel>()));
        }

        [GridAction]
        public ActionResult SelectStockOrderDetailByStockOrderId(long stockOrderId)
        {
            if (stockOrderId == 0)
                return View(new GridModel(new List<StockOrderDetailModel>()));

            var entities = _stockOrderService.GetStockOrderDetailByStockOrderId(stockOrderId);
            var models = _stockOrderService.ConvertStockOrderDetailToModels(entities);


            return View(new GridModel(models));
        }

        #endregion

        #region Input Inventory
        
        [GridAction]
        public ActionResult SelectStockOrderMaterialInventory(string ids
        //public ActionResult SelectStockOrderMaterialInventory(int[] checkedRecords
            //, int warehouseId, bool eoi
            )
        {
            if (string.IsNullOrWhiteSpace(ids))
                return View(new GridModel(new List<MaterialInventoryModel>()));

            int[] checkedRecords;
            try
            {
                
                //checkedRecords = Convert.ToInt32(ids.Split(':'));
                //checkedRecords = Convert.ToInt32(ids.Split(':'));
                var lst = ids.Split(':');
                checkedRecords = new int[lst.Count()];
                for(var i =0; i< lst.Count() ; i++ )
                {
                    checkedRecords[i] = Convert.ToInt32(lst.ElementAt(i));
                }
            }
            catch(FormatException)
            {
                return View(new GridModel(new List<MaterialInventoryModel>()));
            }

            if (checkedRecords.Count() <= 0)
                return View(new GridModel(new List<MaterialInventoryModel>()));
            if (checkedRecords[0] == 0)
            {
                return View(new GridModel(new List<MaterialInventoryModel>()));
            }

            var entityMaterialInventories = _materialInventoryService.GetAllMaterialInventories().Where(f => checkedRecords.Contains(f.MaterialId));
            var entityMaterial = _materialService.GetAllMaterials().Where(f => checkedRecords.Contains(f.MaterialId));
            var rightJoin = from em in entityMaterial
                            join emi in entityMaterialInventories on em.MaterialId equals emi.MaterialId into ps
                            from emi in ps.DefaultIfEmpty()
                            select new MaterialInventory
                            {
                                MaterialId = em.MaterialId,
                                Material = em,

                                MaterialInventoryId = emi != null ? emi.MaterialInventoryId : 0,
                                TotalQty = emi != null ? (emi.TotalQty ?? 0) : 0,
                                AvailableQty = emi != null ? (emi.AvailableQty ?? 0) : 0,
                                UnavailableQty = emi != null ? (emi.UnavailableQty ?? 0) : 0,

                                Active = emi != null && emi.Active
                            };

            var models = ConvertMaterialInventoryToModels(rightJoin);

            return View(new GridModel(models));
        }

        [GridAction]
        public ActionResult UpdateStockOrderMaterialInventory(
            [Bind(Prefix = "inserted")]IEnumerable<MaterialInventoryModel> insertedMaterialInventoryDetails,
            [Bind(Prefix = "updated")]IEnumerable<MaterialInventoryRotateModel> updatedMaterialInventoryDetails,
            [Bind(Prefix = "deleted")]IEnumerable<MaterialInventoryModel> deletedMaterialInventoryDetails
            , string stockOrderCode
            , int? warehouseIssueId, int? warehouseReceiptId
            , int? warehouseId
            , bool materialOrProduct, string exportOrImport
            )
        {
            
            return View(new GridModel(new List<MaterialInventoryModel>()));
        }

        [GridAction]
        public ActionResult UpdateStockOrderProductInventory(
            [Bind(Prefix = "inserted")]IEnumerable<MaterialInventoryModel> insertedMaterialInventoryDetails,
            [Bind(Prefix = "updated")]IEnumerable<ProductInventoryRotateModel> updatedProductInventoryDetails,
            [Bind(Prefix = "deleted")]IEnumerable<MaterialInventoryModel> deletedMaterialInventoryDetails
            , string stockOrderCode
            , int? warehouseIssueId, int? warehouseReceiptId
            , int? warehouseId
            , bool materialOrProduct, string exportOrImport
            )
        {
            
            return View(new GridModel(new List<MaterialInventoryModel>()));
        }
        #endregion

    }
}