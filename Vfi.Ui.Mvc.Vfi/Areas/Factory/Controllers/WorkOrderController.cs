using Microsoft.Practices.Unity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Telerik.Web.Mvc;
using Vfi.Ui.Mvc.Vfi.Areas.Factory.Models;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Controllers;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;
using Vfi.Ui.Mvc.Vfi.Models;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Controllers {
    public class WorkOrderController : Controller {
        TransactionController transactionController;
        MachineController machineController;
        //[InjectionConstructor]
        public WorkOrderController(TransactionController _transactionController, MachineController _machineController) {
            this.transactionController = _transactionController;
            this.machineController = _machineController;
        }
        // GET: /Factory/WorkOrder/

        #region View
        ViewDataDictionary GetPageConfigData() {
            var viewModel = MyUtilities.MySystem.GetPageConfig(HttpContext.User.Identity.Name);
            foreach (var property in viewModel.GetType().GetProperties()) {
                ViewData[property.Name] = property.GetValue(viewModel, null);
            }
            return ViewData;
        }

        public ActionResult WorkOrderManagement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }

        public ActionResult ActivateWorkOrder() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }

        public ActionResult WorkOrderMaterialAssignment() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderMaterialUsing() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderProductionProcess() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            var roundNumberConfig = Convert.ToInt32(MyUtilities.Monitor.GetParameterValue(MyUtilities.Monitor.RoundMaterialMaterialDesign));
            return View(roundNumberConfig);
        }
        public ActionResult WorkOrderProductionManagement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderProductionApprovement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderProduction2Management() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderProduction2Confirmation() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderProduction2Process() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderProduction2Approvement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderCleanManagement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderCleanConfirmation() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderCleanProcess() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderCleanApprovement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderQCManagement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderQCConfirmation() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderQCProcess() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderQCApprovement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderPackingManagement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderPackingConfirmation() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderPackingProcess() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            Session["SessionPackingProcesses"] = new List<WorkOrderRoutingModel>();
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderPackingApprovement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderFinishConfirmation() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderProductionProcessManagement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderProduction2ProcessManagement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderCleanProcessManagement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderQCProcessManagement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }
        public ActionResult WorkOrderPackingProcessManagement() {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            return View();
        }

        public ActionResult AddWorkOrder(long orderDetailId) {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            var entity = new EditWorkOrderModel();
            using (var vfi = new tammaContext()) {
                var orderDetail = vfi.OrderDetails.FirstOrDefault(x => x.OrderDetailId == orderDetailId);
                if (orderDetail != null) {
                    entity = new EditWorkOrderModel {
                        OrderDetailId = orderDetailId,
                        ProductId = orderDetail.ProductId,
                        ProductCode = orderDetail.Product.ProductCode,
                        MaterialId = orderDetail.Product.MaterialId ?? 0,
                        OrderNumber = orderDetail.Order.OrderNumber,
                        DueDate = orderDetail.Order.DueDate.Value,
                        CustomerCode = orderDetail.Order.Customer.CustomerCode,
                        //List = workOrders.Select(x => new EditWorkOrderDetail {
                        //    WorkOrderId = x.WorkOrderId,
                        //    SerialNumber = x.SerialNumber,
                        //    Quantity = x.OrderQty
                        //}).ToList(),
                        //SerialNumber = string.Join("+", workOrders.Select(x => x.SerialNumber)),
                        Quantity = orderDetail.Product.MaxQuantityInTray,
                        Info = new WorkOrderProductionInfo {
                            NS = orderDetail.Product.Productivity ?? 0,
                            DM = orderDetail.Product.ProductionRate ?? 0,
                            DC = orderDetail.Product.KnifeCut ?? 0,
                            CDSP = orderDetail.Product.Length ?? 0,
                            PD = 300
                        },
                    };
                }
            }
            return View(entity);
        }

        public ActionResult EditWorkOrder(string ids) {
            if (!Request.IsAuthenticated) {
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            ViewData = GetPageConfigData();
            var entity = new EditWorkOrderModel();
            var checkedRecords = MyUtilities.Function.StringToIds(ids, ':');
            using (var vfi = new tammaContext()) {
                var workOrders = (from x in vfi.WorkOrders
                                  where checkedRecords.Contains(x.WorkOrderId)
                                  orderby x.SerialNumber
                                  select new {
                                      x.WorkOrderId,
                                      x.SerialNumber,
                                      x.OrderQty,
                                      x.StartDate,
                                      EndDate = x.DueDate,

                                      x.ProductId,
                                      x.Product.ProductCode,
                                      x.Product.Productivity,
                                      x.Product.ProductionRate,
                                      x.Product.KnifeCut,
                                      x.Product.Length,
                                      MaterialId = x.Product.MaterialId ?? 0,

                                      x.OrderDetail.Order.OrderNumber,
                                      x.OrderDetail.Order.Customer.CustomerCode,
                                      OrderDueDate = x.OrderDetail.Order.DueDate.Value,
                                  }).ToList();
                if (workOrders.Any()) {
                    var workOrder = workOrders.FirstOrDefault();
                    entity = new EditWorkOrderModel {
                        WorkOrderIds = checkedRecords,
                        Ids = ids,
                        ProductId = workOrder.ProductId,
                        ProductCode = workOrder.ProductCode,
                        MaterialId = workOrder.MaterialId,
                        OrderNumber = workOrder.OrderNumber,
                        DueDate = workOrder.OrderDueDate,
                        StartDate = workOrder.StartDate,
                        EndDate = workOrder.EndDate,
                        CustomerCode = workOrder.CustomerCode,
                        List = workOrders.Select(x => new EditWorkOrderDetail {
                            WorkOrderId = x.WorkOrderId,
                            SerialNumber = x.SerialNumber,
                            Quantity = x.OrderQty,
                        }).ToList(),
                        SerialNumber = string.Join("+", workOrders.Select(x => x.SerialNumber)),
                        Quantity = workOrders.FirstOrDefault().OrderQty,
                        TotalQuantity = workOrders.Sum(x => x.OrderQty),
                        Info = new WorkOrderProductionInfo {
                            NS = workOrder.Productivity ?? 0,
                            DM = workOrder.ProductionRate ?? 0,
                            DC = workOrder.KnifeCut ?? 0,
                            CDSP = workOrder.Length ?? 0,
                            PD = 300
                        },

                    };
                }
            }
            return View(entity);
        }

        #endregion

        #region Work Order Management

        public MyUtilities.Monitor.MyJsonResult CheckValidProductValue(List<int> productIds) {
            using (var vfi = new tammaContext()) {
                var products = vfi.Products.Where(x => productIds.Contains(x.ProductId)).ToList();
                var errorMessage = "";
                foreach (var product in products) {
                    if (product.Length == null || product.Length <= 0 ||
                        product.KnifeCut == null || product.KnifeCut <= 0) {
                        errorMessage += product.ProductCode + " thiếu thông tin chiều dài, dao cắt để tạo Work Order\n";
                    }
                    if (product.Productivity == null || product.Productivity <= 0 ||
                        product.ProductionRate == null || product.ProductionRate <= 0) {
                        errorMessage += product.ProductCode + " thiếu thông tin năng suất, định mức để tạo Work Order\n";
                    }
                    if (product.MaxQuantityInTray <= 0) {
                        errorMessage += product.ProductCode + " thiếu thông tin số lượng tối đa tạo Work Order\n";
                    }
                    if (product.ProductionWeight == 0 || product.ProductionWeight <= 0) {
                        errorMessage += product.ProductCode + " thiếu trọng lượng SP để tạo Work Order\n";
                    }
                    if (product.ProductionProcesses.Any(x => x.IsNecessary && x.IsAlert && x.Warehouse.IsProduction2)
                        && !product.ProductionSections.Any()) {
                        errorMessage += product.ProductCode + " thiếu thông tin SX2 để tạo Work Order\n";
                    }
                }
                if (!string.IsNullOrWhiteSpace(errorMessage)) {
                    return new MyUtilities.Monitor.MyJsonResult(
                            (int)MyUtilities.Monitor.ErrorCode.Exception,
                            errorMessage,
                            0);
                }
                return new MyUtilities.Monitor.MyJsonResult(
                        (int)MyUtilities.Monitor.ErrorCode.NoError,
                        "",
                        0);
            }
        }

        public List<WorkOrderModel> CalculateWorkOrderFromOrder(int orderId, long orderDetailId) {
            var model = new List<WorkOrderModel>();
            using (var vfi = new tammaContext()) {
                var orderDetails = vfi.OrderDetails.Where(x => x.OrderId == orderId || x.OrderDetailId == orderDetailId);
                var productIds = orderDetails.Select(x => x.ProductId).Distinct().ToList();
                var products = vfi.Products.Where(x => productIds.Contains(x.ProductId)).ToList();
                var workOrderTolerance = MyUtilities.Monitor.GetParameterValue(MyUtilities.Monitor.WorkOrderTolerance);
                foreach (var orderDetail in orderDetails) {
                    var maxOrderQuantity = MyUtilities.Function.RoundUp(orderDetail.RequiedNumber * (1 + workOrderTolerance / 100));
                    if (maxOrderQuantity <= 0) continue;
                    var product = products.FirstOrDefault(x => x.ProductId == orderDetail.ProductId);
                    if ((product.ProductionRate ?? 0) == 0) { continue; } // bỏ qua data lỗi

                    var maxMaterial = MyUtilities.Function.Round((double)product.MaxQuantityInTray / (product.ProductionRate ?? 1));
                    if (maxMaterial <= 0) maxMaterial = 1;
                    var maxQuantityInTray = maxMaterial * product.ProductionRate ?? 1;
                    var maxTray = 1;
                    if (product.MaxQuantityInTray > 0) {
                        maxTray = MyUtilities.Function.RoundUp((double)maxOrderQuantity / maxQuantityInTray);
                    }
                    // tray index 1 -> n-1
                    //var index = 0;
                    //var quantity = 0;
                    var index = vfi.WorkOrders.Count(x => x.ProductId == orderDetail.ProductId && x.ModifiedDate.Year == DateTime.Now.Year);
                    for (int i = 1; i < maxTray; i++) {
                        var entity = new WorkOrderModel {
                            ProductId = orderDetail.ProductId,
                            OrderDetailId = orderDetail.OrderDetailId,
                            SerialNumber = product.IdentityCode + DateTime.Today.ToString("yy") + String.Format("{0:000}", index + i),
                            PlannedTime = 0,
                            RunTime = 0,
                            Status = (byte)MyUtilities.WorkOrder.Status.Pending,
                            StartDate = orderDetail.VFIDueDate ?? orderDetail.CustomerDueDate ?? DateTime.Now,
                            DueDate = orderDetail.VFIDueDate ?? orderDetail.CustomerDueDate ?? DateTime.Now,

                            ModifiedDate = DateTime.Now,
                            ModifiedUser = "Auto",
                            OrderQty = maxMaterial * (product.ProductionRate ?? 1),
                        };
                        model.Add(entity);
                    }
                    // tray index n
                    var lastTray = new WorkOrderModel {
                        ProductId = orderDetail.ProductId,
                        OrderDetailId = orderDetail.OrderDetailId,
                        SerialNumber = product.IdentityCode + DateTime.Today.ToString("yy") + String.Format("{0:000}", index + maxTray),
                        PlannedTime = 0,
                        RunTime = 0, 
                        Status = (byte)MyUtilities.WorkOrder.Status.Pending,
                        StartDate = orderDetail.VFIDueDate ?? orderDetail.CustomerDueDate ?? DateTime.Now,
                        DueDate = orderDetail.VFIDueDate ?? orderDetail.CustomerDueDate ?? DateTime.Now,

                        ModifiedDate = DateTime.Now,
                        ModifiedUser = "Auto",
                        OrderQty = maxOrderQuantity - ((maxTray - 1) * maxMaterial * (product.ProductionRate ?? 1))
                    };
                    model.Add(lastTray);
                }
            }
            return model;
        }

        public void SaveWorkOrders(int orderId, long orderDetailId) {
            var list = CalculateWorkOrderFromOrder(orderId, orderDetailId);
            if (!list.Any()) return;
            var workorders = new List<WorkOrder>();
            //var workorders = list.Select(x => new WorkOrder() {
            //    ProductId = x.ProductId,
            //    OrderDetailId = x.OrderDetailId,
            //    PlannedTime = x.PlannedTime,
            //    RunTime = x.RunTime,
            //    SerialNumber = x.SerialNumber,
            //    DueDate = x.DueDate,
            //    StartDate = x.StartDate,
            //    ModifiedDate = DateTime.Now,
            //    //ModifiedUser = HttpContext.User.Identity.Name,
            //    ModifiedUser = System.Web.HttpContext.Current.User.Identity.Name,
            //    OrderQty = x.OrderQty,
            //    Status  = x.Status,
            //});

            using (var vfi = new tammaContext()) {
                var order = vfi.Orders.FirstOrDefault(x => x.OrderId == orderId);
                if (order == null) { throw new AggregateException("Lỗi! Không tìm thấy đơn hàng"); }

                var productIds = list.Select(x => x.ProductId).Distinct().ToList();
                foreach (var productId in productIds) {
                    var listById = list.Where(x => x.ProductId == productId).ToList();
                    var scheduleDate = order.OrderDate.AddDays(1);
                    foreach (var entity in listById) {
                        var lastWorkOrder = vfi.WorkOrders.Where(x => x.Status != (byte)MyUtilities.WorkOrder.Status.Cancel
                                                                    && x.ProductId == entity.ProductId
                                                                    && x.DueDate > scheduleDate)
                                                        .OrderByDescending(x => x.DueDate)
                                                        .FirstOrDefault();
                        if (lastWorkOrder != null) {
                            scheduleDate = lastWorkOrder.DueDate;
                        }
                        var workorder = new WorkOrder() {
                            ProductId = entity.ProductId,
                            OrderDetailId = entity.OrderDetailId,
                            PlannedTime = entity.PlannedTime,
                            RunTime = entity.RunTime,
                            SerialNumber = entity.SerialNumber,
                            DueDate = entity.DueDate,
                            StartDate = scheduleDate,
                            ModifiedDate = DateTime.Now,
                            ModifiedUser = System.Web.HttpContext.Current.User.Identity.Name,
                            OrderQty = entity.OrderQty,
                            Status = entity.Status,
                        };
                        workorders.Add(workorder);
                        var routings = CalculateWorkOrderRouting(entity);
                        foreach (var routing in routings) {
                            workorder.WorkOrderRoutings.Add(routing);
                        }
                        workorder.PlannedTime = MyUtilities.Function.RoundUp(workorder.WorkOrderRoutings.Sum(x => x.ActualResourceHrs));
                        workorder.DueDate = workorder.StartDate.AddHours(workorder.PlannedTime);
                        scheduleDate = workorder.DueDate;
                    }
                    vfi.WorkOrders.AddRange(workorders);
                }
                vfi.SaveChanges();
            }

        }

        List<WorkOrderRouting> CalculateWorkOrderRouting(WorkOrderModel workorder) {
            var list = new List<WorkOrderRouting>();
            var workpieceDesign = MyUtilities.Monitor.GetParameterValue(MyUtilities.Monitor.MaterialWorkPieceDesign);
            using (var vfi = new tammaContext()) {

                WorkOrderRouting previousRoute = null;
                // assign material
                {
                    var product = vfi.Products.FirstOrDefault(x => x.ProductId == workorder.ProductId);
                    var routing = new WorkOrderRouting {
                        ProductId = workorder.ProductId,
                        RoutingName = "Phát nguyên liệu",
                        Status = workorder.Status,

                        ActualCost = 0,
                        ActualResourceHrs = 0,
                        PlannedCost = MyUtilities.Function.RoundUp(product.MaxQuantityInTray / (product.ProductionRate ?? 1)),

                        ModifiedDate = workorder.ModifiedDate,
                        ModifiedUser = workorder.ModifiedUser,
                        ScheduledStartDate = workorder.StartDate,
                        ScheduledEndDate = workorder.StartDate,
                        RoutingIndex = 0,
                    };
                    var info = new WorkOrderProductionInfo {
                        DM = product.ProductionRate ?? 1,
                        NS = product.Productivity ?? 1,
                        CDSP = product.Length ?? 0,
                        DC = product.KnifeCut ?? 0,
                        PD = workpieceDesign,
                    };
                    routing.MoreInfo = JsonConvert.SerializeObject(info);
                    list.Add(routing);
                    previousRoute = routing;
                }
                // production process design
                var processes = vfi.ProductionProcesses.Where(x => x.ProductId == workorder.ProductId && x.IsAlert && x.IsNecessary)
                                                        .OrderBy(x => x.ProcessIndex).ToList();
                foreach (var process in processes) {

                    if (process.Warehouse.IsProduction) {
                        var routing = new WorkOrderRouting {
                            ProductId = workorder.ProductId,
                            WarehouseId = process.WarehouseId,
                            RoutingName = process.Warehouse.ShortName,
                            Status = workorder.Status,

                            ActualCost = 0,
                            ActualResourceHrs = process.Product.Productivity > 0
                                                        ? workorder.OrderQty * process.Product.Productivity.Value / 3600
                                                        : 0,
                            PlannedCost = workorder.OrderQty,

                            ModifiedDate = workorder.ModifiedDate,
                            ModifiedUser = workorder.ModifiedUser,
                            ScheduledStartDate = workorder.StartDate,
                            ScheduledEndDate = workorder.StartDate,
                            RoutingIndex = process.ProcessIndex,
                        };
                        var info = new WorkOrderProductionInfo {
                            DM = process.Product.ProductionRate ?? 1,
                            NS = process.Product.Productivity ?? 1,
                            CDSP = process.Product.Length ?? 0,
                            DC = process.Product.KnifeCut ?? 0,
                            PD = workpieceDesign,
                        };
                        routing.MoreInfo = JsonConvert.SerializeObject(info);
                        routing.ScheduledEndDate = routing.ScheduledStartDate.AddHours(routing.ActualResourceHrs);
                        list.Add(routing);
                        previousRoute.WorkOrderRouting2 = routing;
                        previousRoute = routing;
                    }
                    else if (process.Warehouse.IsProduction2) {
                        var productionSections = vfi.ProductionSections.Where(x => x.ProductId == process.ProductId && x.Active)
                                                                        .OrderBy(x => x.SectionIndex)
                                                                        .ToList();
                        foreach (var productionSection in productionSections) {

                            var routing = new WorkOrderRouting {
                                ProductId = workorder.ProductId,
                                WarehouseId = process.WarehouseId,
                                RoutingName = process.Warehouse.ShortName + ": " + productionSection.Section.SectionName,
                                Status = workorder.Status,

                                ActualCost = 0,
                                ActualResourceHrs = productionSection.Productivity > 0
                                                        ? workorder.OrderQty * productionSection.Productivity / 3600
                                                        : 0,
                                PlannedCost = workorder.OrderQty,

                                ModifiedDate = workorder.ModifiedDate,
                                ModifiedUser = workorder.ModifiedUser,
                                ScheduledStartDate = workorder.StartDate,
                                ScheduledEndDate = workorder.StartDate,
                                RoutingIndex = process.ProcessIndex + ((double)productionSection.SectionIndex / 10),
                            };
                            var info = new WorkOrderRoutingInfo {
                                NS = productionSection.Productivity
                            };
                            routing.MoreInfo = JsonConvert.SerializeObject(info);
                            routing.ScheduledEndDate = routing.ScheduledStartDate.AddHours(routing.ActualResourceHrs);
                            list.Add(routing);
                            previousRoute.WorkOrderRouting2 = routing;
                            previousRoute = routing;
                        }
                    }
                    else if (process.Warehouse.IsQC) {
                        var routing = new WorkOrderRouting {
                            ProductId = workorder.ProductId,
                            WarehouseId = process.WarehouseId,
                            RoutingName = process.Warehouse.ShortName,
                            Status = workorder.Status,

                            ActualCost = 0,
                            ActualResourceHrs = process.Product.QcProductivity > 0
                                                        ? workorder.OrderQty * process.Product.QcProductivity / 3600
                                                        : 0,
                            PlannedCost = workorder.OrderQty,

                            ModifiedDate = workorder.ModifiedDate,
                            ModifiedUser = workorder.ModifiedUser,
                            ScheduledStartDate = workorder.StartDate,
                            ScheduledEndDate = workorder.StartDate,
                            RoutingIndex = process.ProcessIndex,
                        };
                        var info = new WorkOrderRoutingInfo {
                            NS = MyUtilities.Function.RoundUp(process.Product.QcProductivity),
                        };
                        routing.MoreInfo = JsonConvert.SerializeObject(info);
                        routing.ScheduledEndDate = routing.ScheduledStartDate.AddHours(routing.ActualResourceHrs);
                        list.Add(routing);
                        previousRoute.WorkOrderRouting2 = routing;
                        previousRoute = routing;
                    }
                    else {
                        var routing = new WorkOrderRouting {
                            ProductId = workorder.ProductId,
                            WarehouseId = process.WarehouseId,
                            RoutingName = process.Warehouse.WarehouseName,
                            Status = workorder.Status,

                            ActualCost = 0,
                            ActualResourceHrs = 0,
                            PlannedCost = workorder.OrderQty,

                            ModifiedDate = workorder.ModifiedDate,
                            ModifiedUser = workorder.ModifiedUser,
                            ScheduledStartDate = workorder.StartDate,
                            ScheduledEndDate = workorder.StartDate,
                            MoreInfo = "",

                            RoutingIndex = process.ProcessIndex,
                        };
                        routing.ScheduledEndDate = routing.ScheduledStartDate.AddHours(routing.ActualResourceHrs);
                        list.Add(routing);
                        previousRoute.WorkOrderRouting2 = routing;
                        previousRoute = routing;
                    }
                }
            }
            return list;
        }

        //public List<WorkOrderRoutingModel> CalculateWorkOrderRouting(){
        //    var model = new List<WorkOrderRoutingModel>();
        //    return model;
        //}

        [GridAction]
        public ActionResult SelectActivateWorkOrder(int customerId, string productCode, int status) {
            var model = new List<ActivateWorkOrderModel>();
            try {
                model = GetActivateWorkOrderByOrder(customerId, productCode, status);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectActivateWorkOrder", ex.Message);
            }

            return View(new GridModel(model));
        }

        public List<ActivateWorkOrderModel> GetActivateWorkOrderByOrder(int customerId,string  productCode, int status) {
            var model = new List<ActivateWorkOrderModel>();
            var statuses = MyUtilities.WorkOrder.ActivatedStatus;
            if (status > 0) { statuses = statuses.Where(x => x == status).ToList(); }
            using (var vfi = new tammaContext()) {
                model = (from x in vfi.OrderDetails
                         where x.WorkOrders.Any(y => statuses.Contains(y.Status))
                            && (customerId == 0 || x.Order.CustomerId == customerId)
                         //&& (productId == 0 || x.ProductId == productId)
                         select new ActivateWorkOrderModel {
                             OrderDetailId = x.OrderDetailId,
                             ProductId = x.ProductId,
                             ProductCode = x.Product.ProductCode,
                             DueDate = x.Order.DueDate.Value,
                             OrderNumber = x.Order.OrderNumber,
                             OrderQuantity = x.OrderQty ?? 0,
                             WorkOrderQuantity = x.WorkOrders.Sum(y => y.OrderQty),
                             WorkOrderCount = x.WorkOrders.Count,
                             //TotalInv = x.Product.ProductInventories.Where(y=> y.TotalQty > 0 && y.Warehouse.CanStock).Sum(y=> y.TotalQty)
                         }).ToList();
                if (!string.IsNullOrWhiteSpace(productCode)) {
                    model = model.Where(x => x.ProductCode.Contains(productCode)).ToList();
                }
                //var workOrders = vfi.WorkOrders.Where(x => orderDetailIds.Contains(x.OrderDetailId)).ToList();
                var productIds = model.Select(x => x.ProductId).Distinct().ToList();
                var productInvs = vfi.ProductInventories
                    .Where(x => productIds.Contains(x.ProductId) && x.TotalQty > 0 && x.Warehouse.CanStock)
                    .Select(x => new { x.ProductId, x.TotalQty })
                    .ToList();
                foreach (var entity in model) {
                    var productInvsById = productInvs.Where(x => x.ProductId == entity.ProductId).ToList();
                    entity.TotalInv = productInvsById.Sum(x => x.TotalQty);
                }
            }

            return model;
        }

        [GridAction]
        public ActionResult SelectWorkOrders(long orderDetailId, bool isActive = false) {
            var model = new List<WorkOrderModel>();
            try {
                model = GetWorkOrders(orderDetailId, isActive);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrder", ex.Message);
            }

            return View(new GridModel(model));
        }

        List<WorkOrderModel> GetWorkOrders(long orderDetailId, bool isActive) {
            var model = new List<WorkOrderModel>();
            using (var vfi = new tammaContext()) {
                var workOrders = (from x in vfi.WorkOrders
                                  where x.OrderDetailId == orderDetailId
                                    && (!isActive || x.Status != (byte)MyUtilities.WorkOrder.Status.Cancel)
                                  orderby x.Status
                                  select x).ToList();
                var isProductionManager = MyUtilities.UserRole.CheckRole(HttpContext.User.Identity.Name, MyUtilities.UserRole.ProductionManagement);
                foreach (var workOrder in workOrders) {
                    var entity = new WorkOrderModel {
                        WorkOrderId = workOrder.WorkOrderId,
                        SerialNumber = workOrder.SerialNumber,
                        OrderDetailId = workOrder.OrderDetailId,
                        OrderQty = workOrder.OrderQty,
                        Status = workOrder.Status,
                        RoutingCount = workOrder.WorkOrderRoutings.Count,
                        PlannedTime = workOrder.PlannedTime,
                        StartDate = workOrder.StartDate,
                        EndDate = workOrder.EndDate,
                        DueDate = workOrder.DueDate,
                        ModifiedDate = workOrder.ModifiedDate,
                        ModifiedUser = workOrder.ModifiedUser,
                    };
                    entity.CanChoose = entity.Status == (byte)MyUtilities.WorkOrder.Status.Pending;
                    if (isProductionManager) { entity.CanCancel = true; }
                    else { entity.CanCancel = entity.Status <= (byte)MyUtilities.WorkOrder.Status.Actived; }
                    if (workOrder.WorkOrderRoutings.Any()) {
                        var finishRoutes = workOrder.WorkOrderRoutings
                            .Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.Finish).ToList();
                        if (finishRoutes.Any()) {
                            entity.GoodQuantity = finishRoutes.OrderByDescending(x => x.RoutingIndex).FirstOrDefault().ActualCost;
                            //entity.GoodQuantity = finishRoutes.OrderByDescending(x => x.RoutingIndex).FirstOrDefault()
                            //    .WorkOrderProcesses.Where(y => y.Status == (byte)MyUtilities.WorkOrder.Status.Finish)
                            //    .Sum(y => y.GoodQuantity);
                            //entity.GoodQuantity = finishRoutes.OrderByDescending(x => x.RoutingIndex).FirstOrDefault()
                            //    .WorkOrderProcesses.Where(y => y.Status == (byte)MyUtilities.WorkOrder.Status.Finish)
                            //    .Sum(y => y.GoodQuantity * y.UnitWeight);
                            entity.NGQuantity = finishRoutes.Sum(x =>
                                x.WorkOrderProcesses.Where(y => y.Status == (byte)MyUtilities.WorkOrder.Status.Finish)
                                .Sum(y => y.NGQuantity));
                            //entity.NGWeight = finishRoutes.Sum(x =>
                            //    x.WorkOrderProcesses.Where(y => y.Status == (byte)MyUtilities.WorkOrder.Status.Finish)
                            //    .Sum(y => y.NGQuantity * y.UnitWeight));
                            entity.DefectQuantity = finishRoutes.Sum(x =>
                                x.WorkOrderProcesses.Where(y => y.Status == (byte)MyUtilities.WorkOrder.Status.Finish)
                                .Sum(y => y.DefectQuantity));
                            //entity.DefectWeight = finishRoutes.Sum(x =>
                            //    x.WorkOrderProcesses.Where(y => y.Status == (byte)MyUtilities.WorkOrder.Status.Finish)
                            //    .Sum(y => y.DefectQuantity * y.UnitWeight));
                        }
                        if (workOrder.Status == (byte)MyUtilities.WorkOrder.Status.Actived 
                            || workOrder.Status == (byte) MyUtilities.WorkOrder.Status.InProcess) {
                            var lastProcesRoute = workOrder.WorkOrderRoutings
                                .Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.Actived
                                        || x.Status == (byte)MyUtilities.WorkOrder.Status.InProcess)
                                .OrderBy(x=> x.RoutingIndex)
                                .FirstOrDefault();
                            if (lastProcesRoute != null) {
                                entity.RoutingName = lastProcesRoute.RoutingName;
                                if (lastProcesRoute.MachineId != null) {
                                    entity.RoutingName += "-" + lastProcesRoute.Machine.MachineName;
                                }
                                //if (lastProcesRoute.WarehouseId != null) {
                                //}
                                //else { }
                            }

                        }
                    }
                    model.Add(entity);
                }
            }

            return model;
        }

        public ActionResult ForceFinishWorkOrderRouting(int routingId) {
            try {
                using (var vfi = new tammaContext()) {
                    var statuses = MyUtilities.WorkOrder.ActivatedStatus;
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    //if (routing.PlannedCost > 0 && !routing.WorkOrderProcesses.Any()) {
                    //    throw new AggregateException("Lỗi! Công đoạn chưa nhập liệu không thể hoàn thành");
                    //}
                    if (routing.WorkOrderProcesses.Any(x => statuses.Contains(x.Status))) {
                        throw new AggregateException("Lỗi! Nhập liệu công đoạn chưa hoàn thành không thể hoàn thành công đoạn");
                    }
                }

                var saved = UpdateStatusWorkOrderRoutingProduction(new List<int> { routingId }, true);
                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NoError, "Hoàn thành công đoạn ", saved));
            }
            catch (Exception ex) {
                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.Exception, ex.Message, 0));
            }
        }

        [GridAction]
        public ActionResult DeleteWorkOrder(int workOrderId, bool isActive) {
            long orderDetailId = 0;
            try {
                using (var vfi = new tammaContext()) {
                    var workOrder = vfi.WorkOrders.FirstOrDefault(x => x.WorkOrderId == workOrderId);
                    if (workOrder == null) {
                        throw new AggregateException("Lỗi! Không tìm thấy data");
                    }
                    //if (workOrder.Status > (byte)MyUtilities.WorkOrder.Status.Actived) {
                    //    throw new AggregateException("Lỗi! Tình trạng Work order không thể hủy");
                    //}
                    if (workOrder.WorkOrderRoutings.Any(x => x.WarehouseId != null // skip assign material
                        && x.WorkOrderProcesses.Any(y => y.Status != (byte)MyUtilities.WorkOrder.Status.Cancel))) {
                        throw new AggregateException("Lỗi! Workorder đã có xử lý nhập liệu không thể hủy");
                    }
                    workOrder.Status = (byte)MyUtilities.WorkOrder.Status.Cancel;
                    foreach (var routing in workOrder.WorkOrderRoutings) {
                        if (routing.Status != (byte)MyUtilities.WorkOrder.Status.Finish) {
                            routing.Status = (byte)MyUtilities.WorkOrder.Status.Cancel;
                        }
                    }
                    vfi.SaveChanges();
                    orderDetailId = workOrder.OrderDetailId;
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrder", ex.Message);
            }

            return View(new GridModel(GetWorkOrders(orderDetailId, isActive)));
        }
        
        [GridAction]
        public ActionResult SelectWorkOrderRouting(string ids, bool isActive = false) {
            var model = new List<WorkOrderRoutingModel>();
            try {
                model = GetWorkOrderRoutings(ids, isActive).OrderBy(x => x.RoutingIndex).ToList();
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderRouting", ex.Message);
            }
            return View(new GridModel(model));
        }

        public List<WorkOrderRoutingModel> GetWorkOrderRoutings(string ids, bool isActive) {
            var model = new List<WorkOrderRoutingModel>(); 
            try {
                var checkedRecords = MyUtilities.Function.StringToIds(ids, ':');
                var productionManager = MyUtilities.UserRole.CheckRole(HttpContext.User.Identity.Name ,MyUtilities.UserRole.ProductionManagement);
                using (var vfi = new tammaContext()) {

                    var workOrder = vfi.WorkOrders.FirstOrDefault(x => checkedRecords.Contains(x.WorkOrderId));
                    foreach (var x in workOrder.WorkOrderRoutings.Where(x=> !isActive || x.Status!=(byte) MyUtilities.WorkOrder.Status.Cancel)) {
                        var entity = new WorkOrderRoutingModel {
                            RoutingId = x.RoutingId,
                            RoutingName = x.RoutingName,
                            WarehouseId = x.WarehouseId ?? 0,
                            PlannedCost = x.PlannedCost,
                            MoreInfo = x.MoreInfo,
                            RoutingIndex = x.RoutingIndex > 0 ? x.RoutingIndex * 10 : 1,
                            ActualResourceHrs = x.ActualResourceHrs,
                            ActualCost = x.ActualCost,
                            //UsingQuantity = x.WorkOrderProcesses.Any(y=> y.stat ) ? x.WorkOrderProcesses.Sum(y => y.UsingQuantity) : 0,
                            //GoodQuantity = x.WorkOrderProcesses.Any() ? x.WorkOrderProcesses.Sum(y => y.GoodQuantity) : 0,
                            //NGQuantity = x.WorkOrderProcesses.Any() ? x.WorkOrderProcesses.Sum(y => y.NGQuantity) : 0,
                            //DefectQuantity = x.WorkOrderProcesses.Any() ? x.WorkOrderProcesses.Sum(y => y.DefectQuantity) : 0,
                            Status = x.Status,
                            //NextRouteName = MyUtilities.WorkOrder.GetText(x.Status),
                            CanCancel = false,
                        };
                        if (entity.ActualCost == 0) entity.ActualCost = entity.GoodQuantity;
                        var processes = x.WorkOrderProcesses.Where(y => y.Status != (byte)MyUtilities.WorkOrder.Status.Cancel).ToList();
                        if (processes.Any()) {
                            entity.UsingQuantity = processes.Sum(y => y.UsingQuantity);
                            entity.GoodQuantity = processes.Sum(y => y.GoodQuantity);
                            entity.GoodWeight = processes.Sum(y => y.GoodQuantity * y.UnitWeight);
                            entity.NGQuantity = processes.Sum(y => y.NGQuantity);
                            entity.NGWeight = processes.Sum(y => y.NGQuantity * y.UnitWeight);
                            entity.DefectQuantity = processes.Sum(y => y.DefectQuantity);
                            entity.DefectWeight = processes.Sum(y => y.DefectQuantity * y.UnitWeight);
                        }
                        if (x.WarehouseId == null && x.MaterialInvId != null) {
                            x.MoreInfo = MyUtilities.Material.GetMaterialInvDesignNo(x.MaterialInventory);
                        }
                        else if (x.MachineId != null) {
                            x.MoreInfo = x.Machine.MachineName + "-" + x.MoreInfo;
                        }
                        if (!x.WorkOrderProcesses.Any(y => y.Status != (byte)MyUtilities.WorkOrder.Status.Cancel)
                            && x.Status != (byte)MyUtilities.WorkOrder.Status.Cancel
                            && x.Status != (byte)MyUtilities.WorkOrder.Status.Finish
                            && productionManager) {
                            entity.CanCancel = true;
                        }
                        model.Add(entity);
                    }
                }
                model = model.OrderBy(x => x.RoutingIndex).ToList();
            }
            catch (Exception ex) {
                throw ex;
            }
            return model;
        }

        [GridAction]
        public ActionResult InsertWorkOrderRouting(WorkOrderRoutingModel newRouting, int workOrderId, bool isActive) {
            try {
                using (var vfi = new tammaContext()) {
                    var workOrder = vfi.WorkOrders.FirstOrDefault(x => x.WorkOrderId == workOrderId);
                    if (workOrder == null
                        || workOrder.Status == (byte)MyUtilities.WorkOrder.Status.Finish
                        || workOrder.Status == (byte)MyUtilities.WorkOrder.Status.Cancel) {
                            throw new AggregateException("Lỗi! Work Order không thể điều chỉnh công đoạn.");
                    }
                    newRouting.RoutingIndex /= 10;
                    var productionRouting = workOrder.WorkOrderRoutings.FirstOrDefault(x => x.WarehouseId != null && x.Warehouse.IsProduction);
                    if (newRouting.RoutingIndex <= productionRouting.RoutingIndex) {
                        throw new AggregateException("Lỗi! Công đoạn thêm không được trước sản xuất 1");
                    }
                    var finishRouting = workOrder.WorkOrderRoutings.FirstOrDefault(x => x.WarehouseId != null && x.Warehouse.IsFinish);
                    if (newRouting.RoutingIndex >= finishRouting.RoutingIndex) {
                        throw new AggregateException("Lỗi! Công đoạn thêm không được sau thành phẩm");
                    }
                    var previousRouting = workOrder.WorkOrderRoutings.Where(x => x.RoutingIndex <= newRouting.RoutingIndex)
                        .OrderByDescending(x => x.RoutingIndex)
                        .FirstOrDefault();
                    if (previousRouting == null) { throw new AggregateException("Lỗi! Không tìm thấy công đoạn trước đó!"); }
                    var nextRouting = previousRouting.WorkOrderRouting2;
                    if (nextRouting.Status == (byte)MyUtilities.WorkOrder.Status.InProcess
                        || nextRouting.Status == (byte)MyUtilities.WorkOrder.Status.Finish) {
                            throw new AggregateException("Lỗi! Không thể chèn giữa công đoạn đang xử lý!");
                    }
                    var splits = newRouting.RoutingName.Split('|');
                    var warehouseId = Convert.ToInt32(splits[0]);
                    var sectionId = 0;
                    if (splits.Length > 1) {
                        try {
                            sectionId = Convert.ToInt32(splits[1]);
                        }
                        catch (FormatException) { }
                    }
                    //var process = vfi.ProductionProcesses.FirstOrDefault(x => x.WarehouseId == warehouseId
                    //    && x.ProductId == workOrder.ProductId);
                    var product = vfi.Products.FirstOrDefault(x => x.ProductId == workOrder.ProductId);
                    var warehouse = vfi.Warehouses.FirstOrDefault(x => x.WarehouseId == warehouseId);
                    if (warehouse.IsProduction || warehouse.IsFinish) {
                        throw new AggregateException("Lỗi! Không thể thêm công đoạn sản xuất 1 và thành phẩm!");
                    }
                    var routing = new WorkOrderRouting() {
                        WorkOrderId = workOrderId,
                        ProductId = workOrder.ProductId,
                        WarehouseId = warehouse.WarehouseId,
                        MaterialInvId = previousRouting.MaterialInvId,
                        RoutingName = warehouse.WarehouseName,
                        Status = (byte)MyUtilities.WorkOrder.Status.Pending,

                        ActualCost = 0,
                        ActualResourceHrs = 0,
                        PlannedCost = nextRouting.PlannedCost,

                        ModifiedDate = DateTime.Now,
                        ModifiedUser = HttpContext.User.Identity.Name,
                        ScheduledStartDate = DateTime.Now,
                        ScheduledEndDate = DateTime.Now,
                        RoutingIndex = newRouting.RoutingIndex,
                        RoutingLot = previousRouting.RoutingLot,
                    };
                    if (warehouse.IsProduction2 && sectionId > 0) {
                        var productionSection = vfi.ProductionSections.FirstOrDefault(x => x.ProductionSectionId == sectionId);
                        routing.RoutingName = warehouse.ShortName + ": " + productionSection.Section.SectionName;
                        routing.ActualResourceHrs = productionSection.Productivity > 0
                                                    ? workOrder.OrderQty * productionSection.Productivity / 3600
                                                    : 0;
                        routing.MoreInfo = JsonConvert.SerializeObject(new WorkOrderRoutingInfo { 
                            NS = productionSection.Productivity 
                        });
                    }
                    else if (warehouse.IsQC) {
                        routing.RoutingName = warehouse.ShortName;
                        routing.ActualResourceHrs = product.QcProductivity > 0
                                                        ? workOrder.OrderQty * product.QcProductivity / 3600
                                                        : 0;
                        routing.MoreInfo = JsonConvert.SerializeObject(new WorkOrderRoutingInfo {
                            NS = MyUtilities.Function.RoundUp(product.QcProductivity),
                        });
                    }
                    else { }
                    routing.ScheduledEndDate = routing.ScheduledStartDate.AddHours(routing.ActualResourceHrs);
                    if (previousRouting.RoutingIndex == routing.RoutingIndex) {
                        routing.RoutingIndex += 0.05;
                    }
                    previousRouting.WorkOrderRouting2 = routing;
                    routing.NextRouteId = nextRouting.RoutingId;
                    if (nextRouting.Status == (byte)MyUtilities.WorkOrder.Status.Actived) {
                        routing.Status = nextRouting.Status;
                        nextRouting.Status = (byte)MyUtilities.WorkOrder.Status.Pending;
                    }
                    vfi.WorkOrderRoutings.Add(routing);
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("InsertWorkOrderRouting", ex.Message);
            }
            return View(new GridModel(GetWorkOrderRoutings(workOrderId + "", isActive).OrderBy(x => x.RoutingIndex).ToList()));
        }

        [GridAction]
        public ActionResult UpdateWorkOrderRouting(WorkOrderRoutingModel updateRouting, long workOrderId, bool isActive) {
            try {
                using (var vfi = new tammaContext()) {
                    var workOrder = vfi.WorkOrders.FirstOrDefault(x => x.WorkOrderId == workOrderId);
                    if (workOrder == null
                        || workOrder.Status == (byte)MyUtilities.WorkOrder.Status.Finish
                        || workOrder.Status == (byte)MyUtilities.WorkOrder.Status.Cancel) {
                        throw new AggregateException("Lỗi! Work Order không thể điều chỉnh công đoạn.");
                    }
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == updateRouting.RoutingId);
                    if (routing == null
                        || routing.Status == (byte)MyUtilities.WorkOrder.Status.Finish
                        || routing.Status == (byte)MyUtilities.WorkOrder.Status.InProcess) {
                        throw new AggregateException("Lỗi! Tình trạng công đoạn không thể điều chỉnh");
                    }
                    updateRouting.RoutingIndex /= 10;
                    var productionRouting = workOrder.WorkOrderRoutings.FirstOrDefault(x => x.WarehouseId != null 
                        && x.Warehouse.IsProduction
                        && x.RoutingId != updateRouting.RoutingId);
                    if (productionRouting !=null && updateRouting.RoutingIndex <= productionRouting.RoutingIndex) {
                        throw new AggregateException("Lỗi! Công đoạn không được trước sản xuất 1");
                    }
                    var finishRouting = workOrder.WorkOrderRoutings.FirstOrDefault(x => x.WarehouseId != null 
                        && x.Warehouse.IsFinish
                        && x.RoutingId != updateRouting.RoutingId);
                    if (finishRouting!=null && updateRouting.RoutingIndex >= finishRouting.RoutingIndex) {
                        throw new AggregateException("Lỗi! Công đoạn không được sau thành phẩm");
                    }
                    routing.RoutingIndex = updateRouting.RoutingIndex; 
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateWorkOrderRouting", ex.Message);
            }
            return View(new GridModel(GetWorkOrderRoutings(workOrderId + "", isActive).OrderBy(x => x.RoutingIndex).ToList()));
        }
        [GridAction]
        public ActionResult CancelWorkOrderRouting(int routingId, long workOrderId, bool isActive) {
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    if (routing == null
                        || routing.WorkOrderProcesses.Any(x => x.Status != (byte)MyUtilities.WorkOrder.Status.Cancel)
                        || routing.Status == (byte)MyUtilities.WorkOrder.Status.Finish
                        || routing.Status == (byte)MyUtilities.WorkOrder.Status.Cancel) {
                        throw new AggregateException("Lỗi! Tình trạng công đoạn không thể điều chỉnh");
                    }
                    var previousRouting = routing.WorkOrderRouting1.FirstOrDefault();
                    previousRouting.NextRouteId = routing.NextRouteId;
                    if (routing.Status == (byte)MyUtilities.WorkOrder.Status.InProcess && routing.NextRouteId != null) {
                        if (routing.WorkOrderRouting2.Warehouse.IsFinish) {
                            routing.WorkOrderRouting2.Status = (byte)MyUtilities.WorkOrder.Status.Finish;
                        }
                        else {
                            routing.WorkOrderRouting2.Status = routing.Status;                            
                        }
                        routing.WorkOrderRouting2.PlannedCost = routing.PlannedCost;
                        routing.WorkOrderRouting2.ActualStartDate = DateTime.Now;
                    }
                    routing.Status = (byte)MyUtilities.WorkOrder.Status.Cancel;
                    routing.ActualEndDate = DateTime.Now;
                    vfi.SaveChanges();


                    var workOrder = vfi.WorkOrders.FirstOrDefault(x => x.WorkOrderId == workOrderId);
                    if (workOrder.WorkOrderRoutings.All(x => x.Status == (byte)MyUtilities.WorkOrder.Status.Finish 
                                                          || x.Status == (byte)MyUtilities.WorkOrder.Status.Cancel)) {
                        workOrder.Status = (byte)MyUtilities.WorkOrder.Status.Finish;
                        workOrder.EndDate = DateTime.Now;
                        vfi.SaveChanges();
                    }
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateWorkOrderRouting", ex.Message);
            }
            return View(new GridModel(GetWorkOrderRoutings(workOrderId + "", isActive).OrderBy(x => x.RoutingIndex).ToList()));
        }

        public ActionResult SaveEditWorkOrders(
            string ids, int materialInvId, int machineId,
            double productivity, int productionRate, double knifeCut, int workPiece,
            int newAssign,
            bool isActive, string startDate) {

            //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NoError, ids, 0));
            var saved = 0;
            try {
                if (newAssign <= 0) {
                    throw new AggregateException("Lỗi! Phát nguyên liệu = 0");
                }

                DateTime? newStartDate = null;
                if (!string.IsNullOrWhiteSpace(startDate)) {
                    newStartDate = MyUtilities.Function.ParseDate(startDate);
                    if (newStartDate < DateTime.Now) {
                        throw new AggregateException("Lỗi! Không thể bắt đầu thời điểm trước hiện tại");
                    }
                }
                var checkedRecords = MyUtilities.Function.StringToIds(ids, ':');
                var track = new TrackUpMachineModel {
                    MachineId = machineId,
                    MaterialInvId = materialInvId,
                    ModifiedDate = DateTime.Now,
                    ModifiedUser = HttpContext.User.Identity.Name,
                    ProductRate = productionRate,
                    RealProductivity = productivity,
                    RealRate = productionRate,
                    Productivity = productivity,
                    KnifeCut = knifeCut,
                    WorkPiece = workPiece,
                    ForecastDay = 0,
                    Phase = "",
                    RoundPerMinute = 0,
                };
                using (var vfi = new tammaContext()) {
                    var materialInv = vfi.MaterialInventories.FirstOrDefault(x => x.MaterialInventoryId == materialInvId);
                    if (materialInv == null) {
                        throw new AggregateException("Lỗi! Không tìm thấy lô nguyên liệu");
                    }
                    var availableInv = materialInv.TotalQty;
                    var waitingTransactions = vfi.ExportMaterialDetails.Where(x => x.MaterialInvId == materialInvId &&
                                                        x.TransactionDetail.Transaction.Status == (byte)MyUtilities.Transaction.Status.Open)
                                            .ToList()
                                            .Sum(x => x.Quantity);
                    var waitingAssignWO = vfi.WorkOrderRoutings.Where(x => x.MaterialInvId == materialInvId
                                                                        && x.WarehouseId == null
                                                                        && x.Status == (byte)MyUtilities.WorkOrder.Status.Actived)
                                            .ToList()
                                            .Sum(x => x.PlannedCost);
                    var workOrders = vfi.WorkOrders.Where(x => checkedRecords.Contains(x.WorkOrderId))
                                                    .OrderBy(x => x.SerialNumber)
                                                    .ToList();
                    //var newAssign = workOrders.Sum(x => x.WorkOrderRoutings.Where(y => y.WarehouseId == null)
                    //                            .ToList()
                    //                            .Sum(y => y.PlannedCost));
                    availableInv -= Math.Round(waitingTransactions + waitingAssignWO + workOrders.Count * newAssign, 2);
                    if (availableInv < 0) {
                        throw new AggregateException("Lỗi! Tồn nguyên liệu ko đủ phát");
                    }
                    track.MaterialId = materialInv.MaterialId;
                    foreach (var workOrder in workOrders) {
                        if (!string.IsNullOrWhiteSpace(startDate)) {
                            workOrder.StartDate = newStartDate.Value;
                            workOrder.DueDate = workOrder.StartDate.AddHours(workOrder.PlannedTime);
                            newStartDate = workOrder.DueDate;
                        }
                        else if (workOrder.StartDate < DateTime.Now) {
                            throw new AggregateException("Lỗi! Không thể bắt đầu thời điểm trước hiện tại");
                        }
                        workOrder.ModifiedDate = DateTime.Now;
                        workOrder.ModifiedUser = HttpContext.User.Identity.Name;
                        if (track.ProductId == 0) {
                            track.ProductId = workOrder.ProductId;
                            track.StartDate = workOrder.StartDate;
                            track.DeliveryDate = workOrder.StartDate;
                        }
                        track.Quantity += workOrder.OrderQty;
                        if (isActive) { 
                            workOrder.Status = (byte)MyUtilities.WorkOrder.Status.Actived;
                            var firstRoute = workOrder.WorkOrderRoutings.OrderBy(x => x.RoutingIndex).FirstOrDefault();
                            firstRoute.Status = (byte)MyUtilities.WorkOrder.Status.Actived;
                        }

                        foreach (var routing in workOrder.WorkOrderRoutings.OrderBy(x=> x.RoutingIndex)) {
                            routing.MaterialInvId = materialInvId;
                            routing.ModifiedDate = workOrder.ModifiedDate;
                            routing.ModifiedUser = workOrder.ModifiedUser;
                            routing.RoutingLot = workOrder.SerialNumber + "-" + materialInv.LotNumber;
                            if (routing.WarehouseId == null) { // material routing
                                routing.Status = workOrder.Status;

                                var info = JsonConvert.DeserializeObject<WorkOrderProductionInfo>(routing.MoreInfo);
                                info.NS = productivity;
                                info.DM = productionRate;
                                info.DC = knifeCut;
                                info.PD = workPiece;
                                routing.MoreInfo = JsonConvert.SerializeObject(info);
                                routing.PlannedCost = newAssign;
                                //routing.PlannedCost = MyUtilities.Function.RoundUp((double)workOrder.OrderQty / productionRate);
                                workOrder.OrderQty = MyUtilities.Function.RoundDown(routing.PlannedCost * productionRate);
                                routing.MachineId = machineId;
                            }
                            else if (routing.Warehouse.IsProduction) {

                                var info = JsonConvert.DeserializeObject<WorkOrderProductionInfo>(routing.MoreInfo);
                                info.NS = productivity;
                                info.DM = productionRate;
                                info.DC = knifeCut;
                                info.PD = workPiece;
                                routing.MoreInfo = JsonConvert.SerializeObject(info);

                                routing.MachineId = machineId;
                                routing.PlannedCost = workOrder.OrderQty;
                            }
                            else if (routing.Warehouse.IsProduction2) {
                                routing.PlannedCost = workOrder.OrderQty;
                            }
                            else {
                                routing.PlannedCost = workOrder.OrderQty;
                            }
                        }
                    }
                    saved = vfi.SaveChanges();
                }

                saved += machineController.SaveTrack(track, HttpContext.User.Identity.Name);

                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NoError, "", saved));
            }
            catch (Exception ex) {
                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.Exception, ex.Message, null));
            }
            //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NotImplement, "", null));
        }

        public List<WorkOrderRoutingModel> GetWorkOrderRoutingModel(
            RoutingConfiguration config, byte status, int workOrderId, int routingId,
            string productCode,
            string fromDate, string toDate) {
            var model = new List<WorkOrderRoutingModel>();
            using (var vfi = new tammaContext()) {
                //var routings = vfi.WorkOrderRoutings.Where(x => x.WarehouseId == warehouseId).ToList();
                //var routings4 = vfi.WorkOrderRoutings.Where(x => (x.WarehouseId ?? 0) == 0).ToList();
                //var routings3 = vfi.WorkOrderRoutings.Where(x => x.WarehouseId == null).ToList();
                //var routings5 = vfi.WorkOrderRoutings.Where(x => x.Warehouse == null).ToList();
                var productIds = new List<int>();
                if (!string.IsNullOrWhiteSpace(productCode)) {
                    productIds = vfi.Products.Where(x => x.ProductCode.Contains(productCode)).Select(x => x.ProductId).ToList();
                }
                var routings = vfi.WorkOrderRoutings.Where(x => (status == 0 || x.Status == status)
                                                                && (workOrderId == 0 || x.WorkOrderId == workOrderId)
                                                                && (routingId == 0 || x.RoutingId == routingId)
                                                                && (!productIds.Any() || productIds.Contains(x.ProductId))
                                                    ).ToList();
                if (config != null) {
                    if (config.IsMainProcess == true) {
                        routings = routings.Where(x => x.WarehouseId == null).ToList(); // work
                    }
                    else {
                        routings = routings.Where(x => x.WarehouseId != null &&
                            (config.IsProduction == null || x.Warehouse.IsProduction == config.IsProduction) &&
                            (config.IsProduction2 == null || x.Warehouse.IsProduction2 == config.IsProduction2) &&
                            (config.IsPolish == null || x.Warehouse.IsPolish == config.IsPolish) &&
                            (config.IsQC == null || x.Warehouse.IsQC == config.IsQC) &&
                            (config.IsPacking == null || x.Warehouse.IsPacking == config.IsPacking) &&
                            (config.IsFinish == null || x.Warehouse.IsFinish == config.IsFinish)).ToList();
                    }
                }
                if (!string.IsNullOrWhiteSpace(toDate)) {
                    var fDate = MyUtilities.Function.ParseDate(fromDate);
                    var tDate = MyUtilities.Function.ParseDate(toDate).AddDays(1).AddSeconds(-1);
                    routings = routings.Where(x => (x.ActualStartDate == null && x.ModifiedDate >= fDate && x.ModifiedDate <= tDate)
                        || (x.ActualEndDate == null && x.ActualStartDate >= fDate && x.ActualStartDate <= tDate)
                        || (x.ActualEndDate >= fDate && x.ActualStartDate <= tDate)
                        )
                        .ToList();
                }
                if (routings.Count > 1500) {
                    throw new AggregateException("Lỗi! Dữ liệu quá lớn (>1500)");
                }
                foreach (var routing in routings) {
                    var entity = new WorkOrderRoutingModel {
                        RoutingId = routing.RoutingId,
                        RoutingName = routing.RoutingName,
                        WorkOrderId = routing.WorkOrderId,
                        SerialNumber = routing.WorkOrder.SerialNumber,
                        WarehouseId = routing.WarehouseId ?? 0,
                        WarehouseName = routing.WarehouseId != null ? routing.Warehouse.WarehouseName : "",
                        ProductId = routing.ProductId,
                        ProductCode = routing.Product.ProductCode,
                        MachineId = routing.MachineId ?? 0,
                        MachineName = routing.MachineId != null ? routing.Machine.MachineName : "",
                        MaterialInvId = routing.MaterialInvId ?? 0,
                        MaterialInvCode = routing.MaterialInvId != null
                                            ? routing.MaterialInventory.Material.MaterialCode
                                                + "x" + (routing.MaterialInventory.Length / 1000)
                                                + "-" + routing.MaterialInventory.LotNumber
                                            : "",
                        PlannedCost = routing.PlannedCost,
                        Status = routing.Status,
                        MoreInfo = routing.MoreInfo,
                        //MoreInfoObject = JsonConvert.DeserializeObject<WorkOrderProductionInfo>(routing.MoreInfo),
                        NextRouteId = routing.NextRouteId ?? 0,
                        NextRouteName = routing.NextRouteId != null ? routing.WorkOrderRouting2.RoutingName : "",
                        //PreviousRouteQuantity = routing.WorkOrderRouting1.Any()
                        //                            ? routing.WorkOrderRouting1.Sum(x => x.ActualCost)
                        //                            : 0,
                        //ActualCost = routing.WorkOrderProcesses.Sum(x => x.GoodQuantity + x.NGQuantity + x.DefectQuantity),
                        //ActualResources = 0,
                        ProductWeight = MyUtilities.Product.GetProductInvWeight(routing.ProductId, routing.WarehouseId ?? 0),
                        ActualResourceHrs = routing.ActualResourceHrs,
                        ScheduledStartDate = routing.ScheduledStartDate,
                        ScheduledEndDate = routing.ScheduledEndDate,
                        ActualStartDate = routing.ActualStartDate,
                        ActualEndDate = routing.ActualEndDate,
                    };
                    var moreInfo = JsonConvert.DeserializeObject<WorkOrderProductionInfo>(routing.MoreInfo);
                    entity.MoreInfoObject = moreInfo;
                    if (routing.WorkOrderRouting1.Any()) {
                        var previouseRoute = routing.WorkOrderRouting1.FirstOrDefault();
                        entity.ActualResources = previouseRoute.ActualCost;
                        if (previouseRoute.Status == (byte)MyUtilities.WorkOrder.Status.Finish) {
                            entity.PlannedWeight = previouseRoute.WorkOrderProcesses
                                .Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.Finish)
                                .Sum(x => x.GoodQuantity * x.UnitWeight);
                        }
                    }
                    else {
                        entity.PlannedWeight = entity.PlannedCost * entity.ProductWeight;
                    }
                    if (routing.WorkOrderProcesses.Any()) {
                        var processes = routing.WorkOrderProcesses.Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.Finish);
                        if (processes.Any()) {
                            entity.UsingQuantity = processes.Sum(x => x.UsingQuantity);
                            entity.GoodQuantity = processes.Sum(x => x.GoodQuantity);
                            entity.GoodWeight = processes.Sum(x => x.GoodQuantity * x.UnitWeight);
                            entity.NGQuantity = processes.Sum(x => x.NGQuantity);
                            entity.NGWeight = processes.Sum(x => x.NGQuantity * x.UnitWeight);
                            entity.DefectQuantity = processes.Sum(x => x.DefectQuantity);
                            entity.DefectWeight = processes.Sum(x => x.DefectQuantity * x.UnitWeight);
                        }
                        entity.ActualCost = entity.GoodQuantity;
                        entity.WaitingApproveQuantity = routing.WorkOrderProcesses.Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.InProcess)
                                                                        .Sum(x=> x.UsingQuantity);
                    }
                    if (routing.WarehouseId != null) {
                        if (routing.Warehouse.IsProduction) {
                            // production 1 case
                            entity.MaxQuantity = entity.UsingQuantity * moreInfo.DM;
                            entity.DiffQuantity = entity.TotalQuantity - entity.MaxQuantity;
                        }
                        else {
                            entity.PreviousRouteQuantity = entity.PlannedCost - entity.UsingQuantity;
                            entity.RequireQuantity = entity.PreviousRouteQuantity;
                        }
                    }
                    else {
                        // assign material case
                    }
                    model.Add(entity);
                }
                //model = (from x in vfi.WorkOrderRoutings
                //         where x.Status == status
                //         && x.WarehouseId == warehouseId // some kind of stupid thing

                //         select new WorkOrderRoutingModel {
                //             WorkOrderId = x.WorkOrderId,
                //             SerialNumber = x.WorkOrder.SerialNumber,
                //             WarehouseId = x.WarehouseId ?? 0,
                //             WarehouseName = x.WarehouseId != null ? x.Warehouse.WarehouseName : "",
                //             ProductId = x.ProductId,
                //             ProductCode = x.Product.ProductCode,
                //             MachineId = x.MachineId ?? 0,
                //             MachineName = x.MachineId != null ? x.Machine.MachineName : "",
                //             MaterialInvId = x.MaterialInvId ?? 0,
                //             MaterialInvCode = x.MaterialInvId != null
                //                                 ? x.MaterialInventory.Material.MaterialCode
                //                                     + x.MaterialInventory.Length
                //                                     + x.MaterialInventory.LotNumber
                //                                 : "",
                //             PlannedCost = x.PlannedCost,
                //             Status = x.Status,
                //             MoreInfo = x.MoreInfo,
                //         }).ToList();
                //model = model.Where(x => x.WarehouseId == warehouseId).ToList();
            }
            return model;
        }

        [GridAction]
        public ActionResult SelectWorkOrderRoutingByOrderDetail(long orderDetailId, int quantity) {
            var model = new List<WorkOrderRoutingModel>();
            try {
                using (var vfi = new tammaContext()) {
                    var orderDetail = vfi.OrderDetails.FirstOrDefault(x => x.OrderDetailId == orderDetailId);
                    if (orderDetail == null) { throw new AggregateException("Lỗi! Không tìm thấy data"); }
                    var workOrder = new WorkOrderModel {
                        ProductId = orderDetail.ProductId,
                        OrderDetailId = orderDetail.OrderDetailId,
                        PlannedTime = 0,
                        RunTime = 0,
                        Status = (byte)MyUtilities.WorkOrder.Status.Pending,
                        StartDate = orderDetail.VFIDueDate ?? orderDetail.CustomerDueDate ?? DateTime.Now,
                        DueDate = orderDetail.VFIDueDate ?? orderDetail.CustomerDueDate ?? DateTime.Now,

                        ModifiedDate = DateTime.Now,
                        ModifiedUser = "Auto",
                        OrderQty = quantity
                    };
                    var list = CalculateWorkOrderRouting(workOrder);
                    foreach (var routing in list.OrderBy(x => x.RoutingIndex)) {
                        var entity = new WorkOrderRoutingModel {
                            RoutingName = routing.RoutingName,
                            WarehouseId = routing.WarehouseId ?? 0,
                            PlannedCost = routing.PlannedCost,
                            MoreInfo = routing.MoreInfo,
                            RoutingIndex = routing.RoutingIndex,
                            ActualResourceHrs = routing.ActualResourceHrs,
                        };
                        var info = JsonConvert.DeserializeObject<WorkOrderProductionInfo>(routing.MoreInfo);
                        if (quantity > 0 && info != null) {
                            if (routing.WarehouseId == null) {
                                if (info.DM > 0) {
                                    entity.PlannedCost = MyUtilities.Function.RoundUp(quantity / info.DM);
                                    quantity = MyUtilities.Function.RoundUp(entity.PlannedCost * info.DM);
                                }
                            }
                            else {
                                entity.PlannedCost = quantity;
                                entity.ActualResourceHrs = (entity.PlannedCost * info.NS) / 3600;
                            }
                        }
                        entity.PlannedCost = quantity;
                        model.Add(entity);
                    }
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderRoutingByOrderDetail", ex.Message);
            }
            return View(new GridModel(model));
        }

        public ActionResult SaveAddWorkOrders(
            int orderDetailId, int quantity, int materialInvId, int machineId,
            double productivity, int productionRate, double knifeCut, int workPiece,
            bool isActive) {
            var saved = 0;
            try {
                using (var vfi = new tammaContext()) {
                    var orderDetail = vfi.OrderDetails.FirstOrDefault(x => x.OrderDetailId == orderDetailId);
                    if (orderDetail == null) { }
                    var qty = 0;
                    var scheduleDate = orderDetail.Order.OrderDate.AddDays(1);

                    var lastWorkOrder = vfi.WorkOrders.Where(x => x.Status != (byte)MyUtilities.WorkOrder.Status.Cancel
                                                                && x.ProductId == orderDetail.ProductId
                                                                && x.DueDate > scheduleDate)
                                                    .OrderByDescending(x => x.DueDate)
                                                    .FirstOrDefault();
                    if (lastWorkOrder != null) {
                        scheduleDate = lastWorkOrder.DueDate;
                    }
                    var i = 1;
                    var index = vfi.WorkOrders.Count(x => x.ProductId == orderDetail.ProductId && x.ModifiedDate.Year == DateTime.Now.Year);
                    while (qty < quantity) {
                        var orderQty = orderDetail.Product.MaxQuantityInTray;
                        if (qty + orderQty > quantity) {
                            orderQty = quantity - qty;
                        }
                        var workOrder = new WorkOrder {
                            ProductId = orderDetail.ProductId,
                            OrderDetailId = orderDetail.OrderDetailId,
                            PlannedTime = 0,
                            RunTime = 0,
                            SerialNumber = orderDetail.Product.IdentityCode + DateTime.Today.ToString("yy") + String.Format("{0:000}", index + i),
                            DueDate = orderDetail.VFIDueDate ?? orderDetail.CustomerDueDate ?? DateTime.Now,
                            StartDate = scheduleDate,
                            ModifiedDate = DateTime.Now,
                            ModifiedUser = System.Web.HttpContext.Current.User.Identity.Name,
                            OrderQty = orderQty,
                            Status = (byte)MyUtilities.WorkOrder.Status.Pending,
                        };
                        var routings = CalculateWorkOrderRouting(new WorkOrderModel { 
                            ProductId = workOrder.ProductId,
                            OrderQty = workOrder.OrderQty,
                            ModifiedDate = workOrder.ModifiedDate,
                            ModifiedUser = workOrder.ModifiedUser,
                             StartDate = workOrder.StartDate,
                        });
                        foreach (var routing in routings) {
                            workOrder.WorkOrderRoutings.Add(routing);
                        }
                        workOrder.PlannedTime = MyUtilities.Function.RoundUp(workOrder.WorkOrderRoutings.Sum(x => x.ActualResourceHrs));
                        workOrder.DueDate = workOrder.StartDate.AddHours(workOrder.PlannedTime);
                        vfi.WorkOrders.Add(workOrder);
                        qty += orderQty;
                    }
                    saved += vfi.SaveChanges();
                }
                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NoError, "", saved));
            }
            catch (Exception ex) {
                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.Exception, ex.Message, null));
            }
            //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NotImplement, "", null));
        }


        public long RotatePreviousWorkOrderInventory(int routingId) {
            long transactionId = 0;
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    var previousRoute = routing.WorkOrderRouting1.FirstOrDefault();
                    if (routing.WarehouseId == previousRoute.WarehouseId) return transactionId;
                    if (previousRoute == null || previousRoute.ActualCost == 0) return transactionId;
                    var transaction = new Transaction {
                        TransactionCode = MyUtilities.AutoIncrease.GetParam((int)MyUtilities.AutoIncrease.IncreaseNum.Product, 1),
                        CreatedUser = HttpContext.User.Identity.Name,
                        CreatedDate = DateTime.Now,
                        WarehouseIssueId = previousRoute.WarehouseId,
                        WarehouseReceiptId = routing.WarehouseId,
                        ModifiedUser = HttpContext.User.Identity.Name,
                        ModifiedDate = DateTime.Now,
                        Status = (byte)MyUtilities.Transaction.Status.Open,
                        Active = true,
                        EoI = "0",
                        MoP = false,
                        ReferenceId = routing.RoutingId,
                        Description = routing.WorkOrder.SerialNumber + "-" + routing.RoutingName,
                    };
                    var transactionDetail = new TransactionDetail {
                        ReferenceId = routing.ProductId,
                        MoP = false,
                        Quantity = previousRoute.ActualCost,
                        UnitMeasure = null,
                        Active = true,
                        ModifiedUser = HttpContext.User.Identity.Name,
                        ModifiedDate = DateTime.Now,
                        QuantityKg = 0,
                        Note = transaction.Description,
                        LotNumber = routing.RoutingLot,
                        MachineId = previousRoute.MachineId
                    };
                    var productInv =
                                vfi.ProductInventories.FirstOrDefault(
                                    pi =>
                                        pi.WarehouseId == (previousRoute.WarehouseId ?? 0) &&
                                        pi.ProductId == routing.ProductId &&
                                        pi.LotNumber.Equals(routing.RoutingLot));
                    if (productInv == null) {
                        productInv = new ProductInventory {
                            WarehouseId = transaction.WarehouseIssueId.Value,
                            ProductId = routing.ProductId,
                            ImportDate = transaction.CreatedDate,
                            ModifiedDate = transaction.ModifiedDate,
                            ModifiedUser = transaction.CreatedUser,
                            TotalQty = 0,
                            LotNumber = routing.RoutingLot,
                            MachineId = routing.MachineId,
                            MaterialInvId = routing.MaterialInvId,
                        };
                        vfi.ProductInventories.Add(productInv);
                    }
                    transactionDetail.ProductInventory = productInv;
                    transaction.TransactionDetails.Add(transactionDetail);
                    vfi.Transactions.Add(transaction);
                    vfi.SaveChanges();

                    transactionId = transaction.TransactionId;
                }
            }
            catch (Exception ex) { ModelState.AddModelError("transaction rotate errror", ex.Message); }
            try {
                transactionController.UpdateProductInvByTransaction(transactionId, HttpContext.User.Identity.Name);
            }
            catch (Exception ex) { ModelState.AddModelError("transaction inventory errror", ex.Message); }
            return transactionId;
        }

        //public void RotateNextWorkOrdersInventory(List<int> routingIds) {
        //    try {
        //        using (var vfi = new tammaContext()) {
        //            var routings = vfi.WorkOrderRoutings.Where(x => routingIds.Contains(x.RoutingId) && x.Status == (byte)MyUtilities.WorkOrder.Status.Finish);
        //            if (!routings.Any()) return;
        //            var transactions = new List<Transaction>();
        //            foreach (var routing in routings) {
        //                var nextRoute = routing.WorkOrderRouting2;
        //                if (routing.WarehouseId == nextRoute.WarehouseId) continue;
        //                var transaction = transactions.FirstOrDefault(x => x.WarehouseIssueId == routing.WarehouseId
        //                                                                && x.WarehouseReceiptId == nextRoute.WarehouseId);
        //                if (transaction == null) {
        //                    transaction = new Transaction {
        //                        TransactionCode = MyUtilities.AutoIncrease.GetParam((int)MyUtilities.AutoIncrease.IncreaseNum.Product, 1),
        //                        CreatedUser = HttpContext.User.Identity.Name,
        //                        CreatedDate = DateTime.Now,
        //                        WarehouseIssueId = routing.WarehouseId,
        //                        WarehouseReceiptId = nextRoute.WarehouseId,
        //                        ModifiedUser = HttpContext.User.Identity.Name,
        //                        ModifiedDate = DateTime.Now,
        //                        Status = (byte)MyUtilities.Transaction.Status.Open,
        //                        Active = true,
        //                        EoI = "0",
        //                        MoP = false,
        //                    };
        //                    transactions.Add(transaction);
        //                }
        //                var transactionDetail = new TransactionDetail {
        //                    ReferenceId = routing.ProductId,
        //                    MoP = false,
        //                    Quantity = routing.ActualCost,
        //                    UnitMeasure = null,
        //                    Active = true,
        //                    ModifiedUser = HttpContext.User.Identity.Name,
        //                    ModifiedDate = DateTime.Now,
        //                    QuantityKg = 0,
        //                    Note = transaction.Description,
        //                    LotNumber = routing.RoutingLot,
        //                    MachineId = routing.MachineId
        //                };
        //                var productInv =
        //                            vfi.ProductInventories.FirstOrDefault(
        //                                pi =>
        //                                    pi.WarehouseId == (transaction.WarehouseIssueId ?? 0) &&
        //                                    pi.ProductId == routing.ProductId &&
        //                                    pi.LotNumber.Equals(routing.RoutingLot));
        //                if (productInv == null) {
        //                    productInv = new ProductInventory {
        //                        WarehouseId = transaction.WarehouseIssueId.Value,
        //                        ProductId = routing.ProductId,
        //                        ImportDate = transaction.CreatedDate,
        //                        ModifiedDate = transaction.ModifiedDate,
        //                        ModifiedUser = transaction.CreatedUser,
        //                        TotalQty = 0,
        //                        LotNumber = routing.RoutingLot,
        //                        MachineId = routing.MachineId,
        //                        MaterialInvId = routing.MaterialInvId,
        //                    };
        //                    vfi.ProductInventories.Add(productInv);
        //                }
        //                transactionDetail.ProductInventory = productInv;
        //                transaction.TransactionDetails.Add(transactionDetail);
        //                vfi.Transactions.Add(transaction);

        //            }
        //            foreach (var transaction in transactions) {
        //                transactionController.UpdateProductInvByTransaction(transaction.TransactionId, HttpContext.User.Identity.Name);
        //            }
        //        }
        //    }
        //    catch (Exception ex) { throw ex; }
        //}
        
        [GridAction]
        public ActionResult SelectWorkOrderProcess(int routingId, double productWeight, double weight) {
            if (routingId == 0) {
                return View(new GridModel(new List<WorkOrderRoutingModel>()));
            }
            var model = new List<WorkOrderRoutingModel>();
            try {
                using (var vfi = new tammaContext()) {
                    model = GetWorkOrderRoutingModel(null, 0, 0, routingId, "", "", "");
                    model.ForEach(x => {
                        x.ProductWeight = productWeight;
                        x.UsingQuantity = 0;
                        x.GoodQuantity = productWeight > 0 ? MyUtilities.Function.RoundDown(weight / productWeight) : 0;
                        x.GoodWeight = weight;
                        x.NGQuantity = 0;
                        x.NGWeight = 0;
                        x.DefectQuantity = 0;
                        x.DefectWeight = 0;
                        x.DiffQuantity = weight > 0 ? x.RequireQuantity - x.GoodQuantity : 0;
                    });
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderProcess", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult SelectWorkOrderProcesses(int status, int routingId = 0,
            string productCode = "", string fromDate = "", string toDate = "",
            string config = "") {
                if (routingId == 0 && string.IsNullOrWhiteSpace(toDate)) {
                    return View(new GridModel(new List<WorkOrderProcessModel>()));
                }
            var model = new List<WorkOrderProcessModel>();
            try {
                RoutingConfiguration routingConfig = null;
                if (!string.IsNullOrWhiteSpace(config)) {
                    routingConfig = JsonConvert.DeserializeObject<RoutingConfiguration>(config);
                }
                model = GetWorkOrderProcesses(status, routingId, productCode, fromDate, toDate, routingConfig);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderProcesses", ex.Message);
            }
            return View(new GridModel(model));
        }

        bool WorkOrderRoutingConfigCheck(RoutingConfiguration config, Warehouse warehouse) {
            if (config == null) return false;
            if (config != null) {
                if (config.IsMainProcess == true) {
                    return warehouse == null;
                }
                else {
                    return warehouse != null &&
                        (config.IsProduction == null || warehouse.IsProduction == config.IsProduction) &&
                        (config.IsProduction2 == null || warehouse.IsProduction2 == config.IsProduction2) &&
                        (config.IsPolish == null || warehouse.IsPolish == config.IsPolish) &&
                        (config.IsQC == null || warehouse.IsQC == config.IsQC) &&
                        (config.IsPacking == null || warehouse.IsPacking == config.IsPacking) &&
                        (config.IsFinish == null || warehouse.IsFinish == config.IsFinish);
                }
            }
            return false;
        }

        List<WorkOrderProcessModel> GetWorkOrderProcesses(int status, int routingId,
            string productCode, string fromDate, string toDate,
            RoutingConfiguration config) {
            var model = new List<WorkOrderProcessModel>();
            //var activatedStatus = MyUtilities.WorkOrder.ActivatedStatus;
            var round = Convert.ToInt32(MyUtilities.Monitor.GetParameterValue(MyUtilities.Monitor.RoundMaterialMaterialDesign));
            using (var vfi = new tammaContext()) {
                var processes = vfi.WorkOrderProcesses
                    .Where(x => (routingId == 0 || x.RoutingId == routingId)
                        && ((status == 0 && x.Status != (byte)MyUtilities.WorkOrder.Status.Cancel) || status == x.Status)
                    ).OrderBy(x => x.Date)
                    .Select(x => new {
                        ProcessId = x.ProcessId,
                        Date = x.Date,
                        UsingQuantity = x.UsingQuantity,
                        GoodQuantity = x.GoodQuantity,
                        GoodWeight = x.GoodQuantity * x.UnitWeight,
                        NGQuantity = x.NGQuantity,
                        NGWeight = x.NGQuantity * x.UnitWeight,
                        DefectQuantity = x.DefectQuantity,
                        DefectWeight = x.DefectQuantity * x.UnitWeight,
                        UnitWeight = x.UnitWeight,
                        EmployeeName = x.Employee.EmployeeName,
                        ModifiedDate = x.ModifiedDate,
                        Status = x.Status,
                        MachineName = x.WorkOrderRouting.MachineId != null ? x.WorkOrderRouting.Machine.MachineName : "",
                        ProductCode = x.WorkOrderRouting.Product.ProductCode,
                        x.WorkOrderRouting,
                        x.WorkOrderRouting.MoreInfo,
                    })
                    .ToList();
                if (!string.IsNullOrWhiteSpace(toDate)) {
                    var fDate = MyUtilities.Function.ParseDateTime(fromDate);
                    var tDate = MyUtilities.Function.ParseDateTime(toDate);
                    processes = processes.Where(x => x.Date >= fDate && x.Date <= tDate).ToList();
                }
                if (!string.IsNullOrWhiteSpace(productCode)) {
                    processes = processes.Where(x => x.ProductCode.Contains(productCode)).ToList();
                }
                if (config != null) {
                    processes = processes.Where(x => WorkOrderRoutingConfigCheck(config, x.WorkOrderRouting.Warehouse)).ToList();
                }
                if (processes.Count > 1500) {
                    throw new AggregateException("Lỗi! Dữ liệu quá lớn (>1500)");
                }
                foreach (var process in processes) {
                    var entity = new WorkOrderProcessModel {
                        ProcessId = process.ProcessId,
                        Date = process.Date,
                        UsingQuantity = process.UsingQuantity,
                        GoodQuantity = process.GoodQuantity,
                        GoodWeight = process.GoodQuantity * process.UnitWeight,
                        NGQuantity = process.NGQuantity,
                        NGWeight = process.NGQuantity * process.UnitWeight,
                        DefectQuantity = process.DefectQuantity,
                        DefectWeight = process.DefectQuantity * process.UnitWeight,
                        UnitWeight = process.UnitWeight,
                        EmployeeName = process.EmployeeName,
                        ModifiedDate = process.ModifiedDate,
                        Status = process.Status,
                        MachineName = process.MachineName,
                        ProductCode = process.ProductCode,
                        WorkOrderSerial = process.WorkOrderRouting.WorkOrder.SerialNumber,
                    };
                    if ((config != null && config.IsProduction == true)
                        || (process.WorkOrderRouting.Warehouse != null && process.WorkOrderRouting.Warehouse.IsProduction)) {
                        var moreInfo = JsonConvert.DeserializeObject<WorkOrderProductionInfo>(process.MoreInfo);
                        entity.MaxQuantity = entity.UsingQuantity * moreInfo.DM;
                        entity.DiffQuantity = entity.TotalQuantity - entity.MaxQuantity;
                        entity.UsingQuantityStr = string.Format("{0:n" + round + "}", entity.UsingQuantity);
                    }
                    else {
                        entity.UsingQuantityStr = string.Format("{0:n0}", entity.UsingQuantity);
                    }
                    model.Add(entity);
                }
            }
            return model;
        }

        [GridAction]
        public ActionResult ImportWorkOrderProcess(
            [Bind(Prefix = "inserted")] IEnumerable<WorkOrderRoutingModel> inserteds,
            [Bind(Prefix = "updated")] IEnumerable<WorkOrderRoutingModel> updateds,
            [Bind(Prefix = "deleted")] IEnumerable<WorkOrderRoutingModel> deleteds,
            int routingId, int employeeId, int machineId, double productWeight,
            string processDate
        ) {
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    var import = updateds.FirstOrDefault();
                    var round = Convert.ToInt32( MyUtilities.Monitor.GetParameterValue(MyUtilities.Monitor.RoundMaterialMaterialDesign));
                    import.UsingQuantity = Math.Round(import.UsingQuantity, round);
                    var usedQuantity = 0.0;
                    var usingQuantity = 0.0;
                    if (routing.WorkOrderRouting1.Any()) {
                        usingQuantity = routing.WorkOrderRouting1.Sum(x => x.ActualCost);
                    }
                    if (routing.WorkOrderProcesses.Any()) {
                        usedQuantity = routing.WorkOrderProcesses.Where(x => x.Status != (byte)MyUtilities.WorkOrder.Status.Cancel)
                                                                    .Sum(x => x.UsingQuantity);
                    }
                    if (usedQuantity + import.UsingQuantity > usingQuantity) {
                        if (routing.WarehouseId != null && routing.Warehouse.IsProduction) {
                            throw new AggregateException("Lỗi! Đã sử dụng quá số lượng nguyên liệu");
                        }
                        throw new AggregateException("Lỗi! Đã sử dụng quá số lượng cho phép");
                    }
                    var date = MyUtilities.Function.ParseDate(processDate);
                    var process = new WorkOrderProcess {
                        RoutingId = routingId,
                        EmployeeId = employeeId,
                        UsingQuantity = import.UsingQuantity,
                        GoodQuantity = import.GoodQuantity,
                        NGQuantity = import.NGQuantity,
                        DefectQuantity = import.DefectQuantity,
                        Date = date,
                        ModifiedDate = DateTime.Now,
                        ModifiedUser = HttpContext.User.Identity.Name,
                        Status = (byte)MyUtilities.WorkOrder.Status.InProcess,
                        UnitWeight = productWeight
                    };
                    if (machineId > 0 && routing.MachineId == null) {
                        routing.MachineId = machineId;
                    }
                    routing.WorkOrderProcesses.Add(process);
                    routing.Status = (byte)MyUtilities.WorkOrder.Status.InProcess;
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("ImportWorkOrderProcess", ex.Message);
            }
            return View(new GridModel(new List<WorkOrderRoutingModel>()));
        }

        public ActionResult SaveWorkOrderProcess(
            int routingId, int employeeId, int machineId, 
            double productWeight,string processDate,
            double usingQuantity, double goodQuantity, double ngQuantity, double defectQuantity
        ) {
            var saved = 0;
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    //var import = updateds.FirstOrDefault();
                    var round = Convert.ToInt32(MyUtilities.Monitor.GetParameterValue(MyUtilities.Monitor.RoundMaterialMaterialDesign));
                    //usingQuantity = Math.Round(usingQuantity, round);
                    var usedQuantity = 0.0;
                    var assignQuantity = routing.WorkOrderRouting1.Sum(x => x.ActualCost);
                    if (routing.WorkOrderProcesses.Any()) {
                        usedQuantity = routing.WorkOrderProcesses.Where(x => x.Status != (byte)MyUtilities.WorkOrder.Status.Cancel)
                                                                    .Sum(x => x.UsingQuantity);
                    }
                    if (usedQuantity + usingQuantity > assignQuantity) {
                        if (routing.WarehouseId != null && routing.Warehouse.IsProduction) {
                            return Json(new MyUtilities.Monitor.MyJsonResult(
                                (byte)MyUtilities.Monitor.ErrorCode.StatusChanged,
                                "Lỗi! Đã sử dụng quá số lượng nguyên liệu",
                                0));
                        }
                        return Json(new MyUtilities.Monitor.MyJsonResult(
                            (byte)MyUtilities.Monitor.ErrorCode.StatusChanged,
                            "Lỗi! Đã sử dụng quá số lượng cho phép",
                            0));
                    }
                    var date = MyUtilities.Function.ParseDate(processDate);
                    var process = new WorkOrderProcess {
                        RoutingId = routingId,
                        EmployeeId = employeeId,
                        UsingQuantity = usingQuantity,
                        GoodQuantity = goodQuantity,
                        NGQuantity = ngQuantity,
                        DefectQuantity = defectQuantity,
                        Date = date,
                        ModifiedDate = DateTime.Now,
                        ModifiedUser = HttpContext.User.Identity.Name,
                        Status = (byte)MyUtilities.WorkOrder.Status.InProcess,
                        UnitWeight = productWeight
                    };
                    if (machineId > 0 && routing.MachineId == null) {
                        routing.MachineId = machineId;
                    }
                    routing.WorkOrderProcesses.Add(process);
                    routing.Status = (byte)MyUtilities.WorkOrder.Status.InProcess;
                    saved += vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                return Json(new MyUtilities.Monitor.MyJsonResult(
                    (byte)MyUtilities.Monitor.ErrorCode.Exception,
                    ex.Message,
                    0));
            }
            return Json(new MyUtilities.Monitor.MyJsonResult(
                (byte)MyUtilities.Monitor.ErrorCode.NoError,
                "",
                saved));
        }

        List<WorkOrderProcessModel> GetWorkOrderProcessApprovement(RoutingConfiguration config, byte status) {
            var model = new List<WorkOrderProcessModel>();
            var shift1StartTime = MyUtilities.Product.StartShift1_HOUR;
            var shift2StartTime = MyUtilities.Product.StartShift2_HOUR;
            var round = Convert.ToInt32(MyUtilities.Monitor.GetParameterValue(MyUtilities.Monitor.RoundMaterialMaterialDesign));
            using (var vfi = new tammaContext()) {
                model = (from x in vfi.WorkOrderProcesses
                         where (status == 0 || x.Status == status)
                                 && x.WorkOrderRouting.WarehouseId != null
                                 && (config.IsProduction == null || x.WorkOrderRouting.Warehouse.IsProduction == true)
                                 && (config.IsProduction2 == null || x.WorkOrderRouting.Warehouse.IsProduction2 == true)
                                 && (config.IsPolish == null || x.WorkOrderRouting.Warehouse.IsPolish == true)
                                 && (config.IsQC == null || x.WorkOrderRouting.Warehouse.IsQC == true)
                                 && (config.IsPacking == null || x.WorkOrderRouting.Warehouse.IsPacking == true)
                                 && (config.IsFinish == null || x.WorkOrderRouting.Warehouse.IsFinish == true)
                         select new WorkOrderProcessModel {
                             ProcessId = x.ProcessId,
                             WorkOrderSerial = x.WorkOrderRouting.WorkOrder.SerialNumber,
                             Status = x.Status,
                             RoutingId = x.RoutingId,
                             ProductCode = x.WorkOrderRouting.Product.ProductCode,
                             UnitWeight = x.UnitWeight,
                             UsingQuantity = x.UsingQuantity,
                             //UsingQuantityStr = string.Format("{0:n" + round + "}", x.UsingQuantity),
                             GoodQuantity = x.GoodQuantity,
                             GoodWeight = x.GoodQuantity * x.UnitWeight,
                             NGQuantity = x.NGQuantity,
                             NGWeight = x.NGQuantity * x.UnitWeight,
                             DefectQuantity = x.DefectQuantity,
                             DefectWeight = x.DefectQuantity * x.UnitWeight,
                             Date = x.Date,
                             ModifiedDate = x.ModifiedDate,
                             ModifiedUser = x.ModifiedUser,
                             EmployeeId = x.EmployeeId,
                             EmployeeName = x.Employee.EmployeeName,
                             Shift = (x.Date.Hour >= shift2StartTime || x.Date.Hour < shift1StartTime) ? 2 : 1,
                             MachineName = x.WorkOrderRouting.MachineId > 0 ? x.WorkOrderRouting.Machine.MachineName : "",
                             MaterialInvCode = x.WorkOrderRouting.MaterialInvId > 0
                             ? x.WorkOrderRouting.MaterialInventory.Material.MaterialCode
                                 + "x" + (x.WorkOrderRouting.MaterialInventory.Length / 1000)
                                 + "-" + x.WorkOrderRouting.MaterialInventory.LotNumber
                             : "",
                             Info = x.WorkOrderRouting.MoreInfo
                         }).ToList();
                foreach (var entity in model) {
                    if (!string.IsNullOrWhiteSpace(entity.Info)) {
                        var info = JsonConvert.DeserializeObject<WorkOrderProductionInfo>(entity.Info);
                        entity.DiffQuantity = entity.GoodQuantity + entity.NGQuantity + entity.DefectQuantity - entity.UsingQuantity * info.DM;
                    }
                    entity.UsingQuantityStr = string.Format("{0:n" + round + "}", entity.UsingQuantity);
                }
                //if (!processes.Any()) return model;
                model = model.OrderBy(x => x.Date).ThenBy(x => x.MachineName).ThenBy(x => x.ProductCode).ToList();
            }
            return model;
        }

        public int UpdateStatusWorkOrderRoutingProduction(List<int> routingIds, bool isForce) {
            var saved = 0;
            try {
                using (var vfi = new tammaContext()) {
                    var routings = vfi.WorkOrderRoutings.Where(x => routingIds.Contains(x.RoutingId));
                    foreach (var routing in routings) {
                        var processes = routing.WorkOrderProcesses.Any(x => x.Status == (byte)MyUtilities.WorkOrder.Status.InProcess);
                        if (processes) continue;
                        var finishProcesses = routing.WorkOrderProcesses.Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.Finish);
                        if (finishProcesses.Any()) {
                            var previousRouteQuantity = routing.WorkOrderRouting1.Any() ? routing.WorkOrderRouting1.Sum(x => x.ActualCost) : 0;
                            var usingQuantity = finishProcesses.Sum(x => x.UsingQuantity);
                            if (isForce || usingQuantity >= previousRouteQuantity) {
                                if (routing.Warehouse.IsPacking) {
                                    routing.ActualCost = finishProcesses.Sum(x => x.GoodQuantity + x.NGQuantity);
                                }
                                //else if (!isForce && routing.Warehouse.IsProduction) {
                                //    var info = JsonConvert.DeserializeObject<WorkOrderProductionInfo>(routing.MoreInfo);
                                //    var maxQuantity = usingQuantity * info.DM;
                                //    var diff = finishProcesses.Sum(x => x.GoodQuantity + x.NGQuantity + x.DefectQuantity) / maxQuantity - 1 * 100;
                                //    //(TotalQuantity / MaxQuantity - 1) * 100;
                                //    if (Math.Abs(diff) > 5) { continue; }
                                //    routing.ActualCost = finishProcesses.Sum(x => x.GoodQuantity);
                                //}
                                else {
                                    routing.ActualCost = finishProcesses.Sum(x => x.GoodQuantity);
                                }
                                //routing.ActualCost = finishProcesses.Sum(x => x.GoodQuantity);
                                routing.Status = (byte)MyUtilities.WorkOrder.Status.Finish;
                                routing.WorkOrderRouting2.PlannedCost = routing.ActualCost;
                                routing.ActualEndDate = DateTime.Now;
                                routing.WorkOrderRouting2.Status = (byte)MyUtilities.WorkOrder.Status.Actived;
                                routing.WorkOrderRouting2.ScheduledStartDate = DateTime.Now;
                                routing.WorkOrderRouting2.ScheduledEndDate = routing.WorkOrderRouting2.ScheduledStartDate.AddHours(routing.WorkOrderRouting2.ActualResourceHrs);
                            }
                        }
                        else {
                            if (isForce) {
                                routing.Status = (byte)MyUtilities.WorkOrder.Status.Finish;
                                routing.ActualEndDate = DateTime.Now;
                                routing.WorkOrderRouting2.Status = (byte)MyUtilities.WorkOrder.Status.Actived;
                                routing.WorkOrderRouting2.PlannedCost = 0;
                                routing.WorkOrderRouting2.ScheduledStartDate = DateTime.Now;
                                routing.WorkOrderRouting2.ScheduledEndDate = DateTime.Now;
                            }
                            else {
                                routing.Status = (byte)MyUtilities.WorkOrder.Status.InProcess;
                            }
                            if (routing.ActualStartDate == null) routing.ActualStartDate = DateTime.Now;
                        }
                    }
                    saved += vfi.SaveChanges();
                    return saved;
                }
            }
            catch (Exception ex) {
                throw ex;
            }
        }


        [HttpPost]
        public ActionResult PrintWorkOrder(int workOrderId) {
            var entity = new WorkOrderModel();
            try {
                using (var vfi = new tammaContext()) {
                    //entity = vfi.WorkOrders.Where(x => x.WorkOrderId == workOrderId)
                    //    .Select(x => new WorkOrderModel {
                    //        SerialNumber = x.SerialNumber,
                    //        ProductCode = x.Product.ProductCode,
                    //        CustomerCode = x.OrderDetail.Order.Customer.CustomerCode,
                    //        OrderQty = x.OrderQty,
                    //        RunTime = x.RunTime,
                    //        StartDate = x.StartDate,
                    //        EndDate = x.EndDate,
                    //    }).FirstOrDefault();
                    var workOrder = vfi.WorkOrders.FirstOrDefault(x => x.WorkOrderId == workOrderId);
                    if (workOrder == null) { throw new AggregateException("Lỗi! Không tìm thấy data"); }
                    entity = new WorkOrderModel {
                        SerialNumber = workOrder.SerialNumber,
                        ProductCode = workOrder.Product.ProductCode,
                        CustomerCode = workOrder.OrderDetail.Order.Customer.CustomerCode,
                        OrderQty = workOrder.OrderQty,
                        RunTime = workOrder.RunTime > 0 ? workOrder.RunTime : workOrder.PlannedTime,
                        StartDate = workOrder.StartDate,
                        EndDate = workOrder.EndDate ?? workOrder.DueDate,
                        Routings =  new List<WorkOrderRoutingModel>(),
                        MaterialName = "",
                        MaterialLot = "",
                    };

                    foreach (var routing in workOrder.WorkOrderRoutings.OrderBy(x=> x.RoutingIndex)) {
                        if (routing.WarehouseId == null) {
                            if (routing.MaterialInvId != null) {
                                entity.MaterialName = routing.MaterialInventory.Material.MaterialCode + "x" + (routing.MaterialInventory.Length / 1000);
                                entity.MaterialLot = routing.MaterialInventory.LotNumber;
                            }
                        }
                        var info = JsonConvert.DeserializeObject<WorkOrderProductionInfo>(routing.MoreInfo);
                        var detail = new WorkOrderRoutingModel {
                            RoutingIndex = routing.RoutingIndex * 10,
                            RoutingName = routing.RoutingName,
                            PlannedCost = routing.PlannedCost,
                            ActualCost = routing.ActualCost,
                            MoreInfoObject = info,
                            MachineName = routing.MachineId != null ? routing.Machine.MachineName : "",
                            Status = routing.Status,
                        };
                        if (routing.WarehouseId == null) {
                            detail.GoodQuantity = routing.PlannedCost;
                            detail.RoutingIndex = 1;
                            detail.MoreInfoObject.NS = 0;
                        }
                        var processes = routing.WorkOrderProcesses.Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.Finish);
                        if (processes.Any()) {
                            detail.UsingQuantity = processes.Sum(x => x.UsingQuantity);
                            detail.GoodQuantity = processes.Sum(x => x.GoodQuantity);
                            detail.NGQuantity = processes.Sum(x => x.NGQuantity);
                            detail.DefectQuantity = processes.Sum(x => x.DefectQuantity);
                        }
                        entity.Routings.Add(detail);
                    }
                }
            }
            catch (Exception ex) {
                return PartialView("PageWorkOrder", ex.Message);
            }
            return PartialView("PageWorkOrder", entity);
        }

        #endregion

        #region Assign Material
        [GridAction]
        public ActionResult SelectWorkOrderMaterialAssignment() {
            var model = new List<WorkOrderRoutingModel>();
            try {
                model = GetWorkOrderRoutingModel(new RoutingConfiguration { IsMainProcess = true },
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"", "", "");
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderMaterialAssignment", ex.Message);
            }
            return View(new GridModel(model));
        }
        
        [GridAction]
        public ActionResult CancelWorkOrderMaterialAssignment(int routingId) {
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    if (routing == null || routing.Status != (byte)MyUtilities.WorkOrder.Status.Actived) {
                        throw new AggregateException("Lỗi! Công đoạn đã bị thay đổi! Vui lòng F5 lại trang");
                    }
                    routing.Status = (byte)MyUtilities.WorkOrder.Status.Pending;
                    routing.ActualStartDate = null;
                    routing.ActualCost = 0;
                    routing.WorkOrder.Status = (byte)MyUtilities.WorkOrder.Status.Pending;
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("CancelWorkOrderMaterialAssignment", ex.Message);
            }
            return View(new GridModel(GetWorkOrderRoutingModel(new RoutingConfiguration { IsMainProcess = true },
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"", "", "")));
        }
        public ActionResult AssignMaterialWorkOrders(string ids, int employeeId) {
            try {

                using (var vfi = new tammaContext()) {
                    var checkedReports = MyUtilities.Function.StringToIds(ids, ':');
                    var routings = vfi.WorkOrderRoutings.Where(x => checkedReports.Contains(x.RoutingId));
                    var materialInvIds = routings.Select(x => x.MaterialInvId.Value).Distinct().ToList();
                    var materialInvs = (from x in vfi.MaterialInventories
                                        where materialInvIds.Contains(x.MaterialInventoryId)
                                        select new {
                                            x.MaterialInventoryId,
                                            x.MaterialId,
                                            x.UnitWeight,
                                            x.TotalQty,
                                            x.LotNumber,
                                        }).ToList();

                    foreach (var materialInv in materialInvs) {
                        var updateds = routings.Where(u => u.MaterialInvId == materialInv.MaterialInventoryId);
                        var exportMaterialQuantity = Math.Round(updateds.Sum(u => u.PlannedCost) - materialInv.TotalQty, 2);
                        //if (exportMaterialQuantity > 0) {
                        //    throw new AggregateException("Nguyên liệu " +
                        //                                 updateds.FirstOrDefault().MaterialInventoryCode +
                        //                                 " không đủ!\n"
                        //                                 + updateds.FirstOrDefault().MachineName + " thiếu " +
                        //                                 Math.Abs(exportMaterialQuantity));
                        //}
                    }
                    var transactionMaterial = new Transaction {
                        TransactionCode = MyUtilities.AutoIncrease.GetParam((int)MyUtilities.AutoIncrease.IncreaseNum.Material, 1),
                        EoI = Convert.ToChar(MyUtilities.Transaction.EoIEnum.Export).ToString(),
                        MoP = true,
                        CreatedUser = HttpContext.User.Identity.Name,
                        CreatedDate = DateTime.Now,
                        Status = (byte)MyUtilities.Transaction.Status.Open,
                        Active = true,
                        ModifiedUser = HttpContext.User.Identity.Name,
                        ModifiedDate = DateTime.Now,
                    };
                    //
                    var exportMaterial = new ExportMaterial {
                        ModifiedUser = HttpContext.User.Identity.Name,
                        ModifiedDate = DateTime.Now,
                        Transaction = transactionMaterial,
                        TransactionId = transactionMaterial.TransactionId,
                        ExportDate = transactionMaterial.CreatedDate,
                        ShiftName = "",
                        ShiftType = 0,
                    };

                    foreach (var routing in routings) {
                        var smartProduction = vfi.SmartProductions.FirstOrDefault(sp => sp.MachineId == routing.MachineId);
                        if (smartProduction == null) {
                            smartProduction = new SmartProduction();
                            smartProduction.MachineId = routing.MachineId.Value;
                            smartProduction.MaterialInvId = routing.MaterialInvId.Value;
                            vfi.SmartProductions.Add(smartProduction);
                        }
                        else {
                            smartProduction.MaterialInvId = routing.MaterialInvId.Value;
                        }
                        var materialInv = materialInvs.FirstOrDefault(m => m.MaterialInventoryId == routing.MaterialInvId);
                        var transactionMaterialDetail = new TransactionDetail {
                            Transaction = transactionMaterial,
                            TransactionId = transactionMaterial.TransactionId,
                            ReferenceId = materialInv.MaterialId,
                            MoP = true,
                            Quantity = routing.PlannedCost,
                            QuantityKg = routing.PlannedCost * materialInv.UnitWeight,
                            Active = true,
                            ModifiedUser = HttpContext.User.Identity.Name,
                            ModifiedDate = DateTime.Now,
                            Note = routing.WorkOrder.SerialNumber + "-" + routing.Machine.MachineName,
                            LotNumber = materialInv.LotNumber,
                            VendorId = routing.RoutingId,
                        };
                        transactionMaterial.TransactionDetails.Add(transactionMaterialDetail);
                        var exportDetail = new ExportMaterialDetail {
                            MachineId = routing.MachineId.Value,
                            ExportId = exportMaterial.ExportId,
                            ExportMaterial = exportMaterial,
                            MaterialInvId = routing.MaterialInvId.Value,
                            MaterialId = materialInv.MaterialId,
                            Quantity = transactionMaterialDetail.Quantity,
                            QuantityKg =  transactionMaterialDetail.QuantityKg,
                            TransactionDetailId = transactionMaterialDetail.TransactionDetailId,
                            TransactionDetail = transactionMaterialDetail,
                        };
                        exportMaterial.ExportMaterialDetails.Add(exportDetail);
                    }
                    var saved = 0;
                    if (transactionMaterial.TransactionDetails.Any()) {
                        vfi.Transactions.Add(transactionMaterial);
                        vfi.ExportMaterials.Add(exportMaterial);
                        saved = vfi.SaveChanges();

                        foreach (var routing in routings) {
                            var transactionDetail = transactionMaterial.TransactionDetails.FirstOrDefault(x => x.VendorId == routing.RoutingId);
                            var exportDetail = exportMaterial.ExportMaterialDetails.FirstOrDefault(x => x.TransactionDetailId == transactionDetail.TransactionDetailId);
                            if (exportDetail == null) { // something error
                            }
                            var routingProcess = new WorkOrderProcess {
                                Date = transactionMaterial.CreatedDate,
                                RoutingId = routing.RoutingId,
                                UsingQuantity = 0,
                                GoodQuantity = routing.PlannedCost,
                                DefectQuantity = 0,
                                NGQuantity = 0,
                                ModifiedDate = transactionMaterial.ModifiedDate,
                                ModifiedUser = transactionMaterial.ModifiedUser,
                                EmployeeId = employeeId,
                                ReferenceDetailId = exportDetail.ExportDetailId,
                                Status = (byte)MyUtilities.WorkOrder.Status.InProcess,
                                UnitWeight = transactionDetail.QuantityKg.Value / transactionDetail.Quantity * 1000
                            };
                            routing.WorkOrderProcesses.Add(routingProcess);
                            routing.Status = (byte)MyUtilities.WorkOrder.Status.InProcess;
                            routing.ActualStartDate = transactionMaterial.CreatedDate;
                            routing.WorkOrder.Status = (byte)MyUtilities.WorkOrder.Status.InProcess;
                            transactionDetail.VendorId = null;
                        }
                        vfi.SaveChanges();
                    }
                    return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NoError, "", saved));
                }
            }
            catch (Exception ex) {
                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.Exception, ex.Message, null));
            }
        }

        public ActionResult PrintWOAssignMaterial2(string printDate, bool isAll, bool haveInventory, bool haveWorkOrder) {
            var model = new List<SmartProductionModel>();
            try {
                using (var vfi = new tammaContext()) {
                    var date = MyUtilities.Function.ParseDate(printDate);
                    var unassignWorkOrders = (from x in vfi.WorkOrderRoutings
                                              where x.WarehouseId == null
                                                && x.MachineId != null
                                                && x.Status == (byte)MyUtilities.WorkOrder.Status.Actived
                                              select x).ToList();
                    var machineIds = unassignWorkOrders.Select(x => x.MachineId.Value).Distinct().ToList();

                    var lastDate = (from mud in vfi.MaterialUseDetails
                                    where mud.MaterialUseInShift.Status != (byte)MyUtilities.Transaction.Status.Cancel &&
                                          mud.MaterialUseInShift.UsedDate < date &&
                                          mud.MaterialUseInShift.Type == (byte)MyUtilities.Material.UseType.Using
                                    orderby mud.MaterialUseInShift.UsedDate
                                    select mud.MaterialUseInShift.UsedDate).Take(1).FirstOrDefault();
                    var lastUse = (from mud in vfi.MaterialUseDetails
                                   where mud.MaterialUseInShift.Status != (byte)MyUtilities.Transaction.Status.Cancel &&
                                         mud.MaterialUseInShift.UsedDate == lastDate &&
                                             mud.MaterialUseInShift.Type == (byte)MyUtilities.Material.UseType.Using
                                   orderby mud.MaterialUseInShift.UsedDate
                                   select new {
                                       mud.MachineId,
                                       mud.EditQuantity,
                                       mud.EditQuantity2,
                                       mud.MaterialUseInShift.UsedDate,
                                       mud.MaterialInventory.MaterialId,
                                   }).ToList();
                    var lastDateString = lastDate.ToString("dd/MM");
                    var onShelves = vfi.OnShelves.Where(x => x.InventoryDrawer.InventoryShelf.ClassifiedId == 1 && x.Active)
                                                .Select(x => new InventoryDrawerModel {
                                                    ColumnName = x.InventoryDrawer.ColumnName,
                                                    RowName = x.InventoryDrawer.RowName,
                                                    AdditionName = x.InventoryDrawer.AdditionName,
                                                    ShelfName = x.InventoryDrawer.InventoryShelf.ShelfName,
                                                    ReferenceInvId = x.ReferenceInvId
                                                }).ToList();
                    var requireRunTime = 36 * 3600; // 36h
                    var materialInvOnMachines = vfi.MaterialInvOnMachines.Where(mim => machineIds.Contains(mim.MachineId.Value)
                                                                                    && mim.TotalQuantity > 0)
                                                                        .ToList();
                    var materialIds = materialInvOnMachines.Select(x=> x.MaterialInventory.MaterialId).Distinct().ToList();
                    var materialInvs = vfi.MaterialInventories.Where(x => materialIds.Contains(x.MaterialId) && x.TotalQty > 0).ToList();
                    var machines = vfi.Machines.Where(x => x.Active)
                        .Select(x => new { x.MachineId, x.MachineName })
                        .OrderBy(x => x.MachineName).ToList();
                    foreach (var machine in machines) {
                        var onMachinesById = materialInvOnMachines.Where(x => x.MachineId == machine.MachineId).ToList();
                        foreach (var invOnMachine in onMachinesById) {
                            var entity = new SmartProductionModel {
                                MachineName = machine.MachineName,
                                MachineId = machine.MachineId,
                                UseDateString = date.ToString("dd/MM"),
                                UseDateString2 = lastDateString,
                                MaterialId = invOnMachine.MaterialInventory.MaterialId,
                                MaterialCode = invOnMachine.MaterialInventory.Material.MaterialCode,

                                MaterialInventoryId = invOnMachine.MaterialInvId.Value,
                                MaterialInventoryCode = invOnMachine.MaterialInventory.Material.MaterialCode,
                                LotNumber = invOnMachine.MaterialInventory.LotNumber,
                                Length = invOnMachine.MaterialInventory.Length / 1000,
                                VendorCode = invOnMachine.MaterialInventory.Vendor.VendorCode,
                                MaterialInvOnMachine = invOnMachine.TotalQuantity,

                                DiffProduction = 0,
                                ProductAlert = 0,
                                LimitColor = 1,
                            };
                            var lastTrack = MyUtilities.Machine.LastTrackUpMachine(machine.MachineId, invOnMachine.MaterialInventory.MaterialId, null, date);
                            if (lastTrack != null) {
                                entity.ProductId = lastTrack.ProductId;
                                entity.ProductCode = lastTrack.ProductCode;
                                entity.Productivity = lastTrack.RealProductivity;
                                entity.ProductionRate = lastTrack.RealRate;
                                entity.KnifeCut = lastTrack.KnifeCut;
                                entity.WorkPiece = lastTrack.WorkPiece;
                            }
                            entity.DiffProduction =
                                    MyUtilities.Product.GetMaterialRateInFactoryFullShiftTime(entity.Productivity, entity.ProductionRate);
                            entity.MaterialLimitQuantity = entity.DiffProduction;
                            var materialInvsById = materialInvs.Where(pi => pi.MaterialId == entity.MaterialId && pi.TotalQty > 0);
                            if (materialInvsById.Any()) {
                                entity.MaterialAllInvTotal = materialInvsById.Sum(mi => mi.TotalQty);
                            }
                            var onShelvesById = onShelves.Where(x => x.ReferenceInvId == entity.MaterialInventoryId).ToList();
                            if (onShelvesById.Any()) {
                                entity.StoreCode = string.Join("+", onShelvesById.Select(x => x.DrawerCode).Distinct().OrderBy(x => x));
                            }
                            else {
                                entity.StoreCode = "Ngoài kệ";
                            }

                            entity.DiffMaterial = lastUse.Where(x => x.MachineId == entity.MachineId
                                                                && x.MaterialId == entity.MaterialId)
                                                        .ToList()
                                                        .Sum(mud => mud.EditQuantity + mud.EditQuantity2);
                            
                            model.Add(entity);

                        }
                    }


                }

                if (model.Any()) {
                    var first = model.FirstOrDefault();
                    first.TotalCames = model.Where(m => !m.MachineName.Contains("CNC") && m.DiffMaterial > 0).Count();
                    first.TotalCnc = model.Where(m => m.MachineName.Contains("CNC") && m.DiffMaterial > 0).Count();
                }
            }
            catch (Exception ex) {
                return PartialView(ex.Message);
            }
            return PartialView("PageWOAssignMaterial", model);
        }

        public ActionResult PrintWOAssignMaterial(string printDate,bool isAll,bool haveInventory,bool haveWorkOrder) {
            var model = new List<SmartProductionModel>();
            try {
                using (var vfi = new tammaContext()) {
                    var date = MyUtilities.Function.ParseDate(printDate).AddDays(1).AddHours(7).AddSeconds(-1);

                    var machines = (from m in vfi.Machines
                                    where m.Active && m.ProcessingType.Warehouse.IsProduction
                                    orderby m.MachineName
                                    select new {
                                        m.MachineId,
                                        m.MachineName
                                    }).ToList();
                    var assignWorkOrders = (from x in vfi.WorkOrderRoutings
                                            where x.WarehouseId == null
                                               && x.MachineId != null
                                               && x.MaterialInvId != null
                                               && x.Status == (byte)MyUtilities.WorkOrder.Status.Actived
                                            select x).ToList();

                    var lastDate = new DateTime();
                    var lastUse = (from mud in vfi.MaterialUseDetails
                                   where mud.MaterialUseInShift.Status != (byte)MyUtilities.Transaction.Status.Cancel &&
                                         mud.MaterialUseInShift.UsedDate < date &&
                                         mud.MaterialUseInShift.Type == (byte)MyUtilities.Material.UseType.Using
                                   orderby mud.MaterialUseInShift.UsedDate
                                   select new {
                                       mud.MachineId,
                                       mud.EditQuantity,
                                       mud.EditQuantity2,
                                       mud.MaterialUseInShift.UsedDate,
                                       mud.MaterialInventory.MaterialId,
                                   }).ToList();
                    if (lastUse.Any()) {
                        lastDate = lastUse.LastOrDefault().UsedDate;
                    }
                    lastUse = (from mud in vfi.MaterialUseDetails
                               where mud.MaterialUseInShift.Status != (byte)MyUtilities.Transaction.Status.Cancel &&
                                     mud.MaterialUseInShift.UsedDate == lastDate &&
                                         mud.MaterialUseInShift.Type == (byte)MyUtilities.Material.UseType.Using
                               orderby mud.MaterialUseInShift.UsedDate
                               select new {
                                   mud.MachineId,
                                   mud.EditQuantity,
                                   mud.EditQuantity2,
                                   mud.MaterialUseInShift.UsedDate,
                                   mud.MaterialInventory.MaterialId,
                               }).ToList();
                    var lastDateString = lastDate.ToString("dd/MM");
                    var onShelves = vfi.OnShelves.Where(x => x.InventoryDrawer.InventoryShelf.ClassifiedId == 1 && x.Active)
                                                .Select(x => new InventoryDrawerModel {
                                                    ColumnName = x.InventoryDrawer.ColumnName,
                                                    RowName = x.InventoryDrawer.RowName,
                                                    AdditionName = x.InventoryDrawer.AdditionName,
                                                    ShelfName = x.InventoryDrawer.InventoryShelf.ShelfName,
                                                    ReferenceInvId = x.ReferenceInvId
                                                }).ToList();
                    var requireRunTime = 36 * 3600; // 36h
                    foreach (var machine in machines) {
                        var isAdded = false;
                        var machineRunTime = 0.0;
                        var materialInvIds = new List<int>();

                        #region inv on machines case
                        if (haveInventory || isAll) {
                            var materialInvOnmachines =
                                vfi.MaterialInvOnMachines.Where(
                                    mim =>
                                    mim.MachineId == machine.MachineId && mim.TotalQuantity > 0).ToList();
                            materialInvIds = materialInvOnmachines.Select(x => x.MaterialInvId.Value).Distinct().ToList();
                            foreach (var invOnMachine in materialInvOnmachines) {
                                var entity = new SmartProductionModel {
                                    MachineName = machine.MachineName,
                                    MachineId = machine.MachineId,
                                    UseDateString = date.ToString("dd/MM"),
                                    UseDateString2 = lastDateString,
                                    //ProductId = lastTrack.ProductId,
                                    //ProductCode = lastTrack.ProductCode,
                                    //Productivity = lastTrack.RealProductivity,
                                    //ProductionRate = lastTrack.RealRate,
                                    //KnifeCut = lastTrack.KnifeCut,
                                    //WorkPiece = lastTrack.WorkPiece,

                                    MaterialId = invOnMachine.MaterialInventory.MaterialId,
                                    MaterialCode = invOnMachine.MaterialInventory.Material.MaterialCode,

                                    MaterialInventoryId = invOnMachine.MaterialInvId.Value,
                                    MaterialInventoryCode = invOnMachine.MaterialInventory.Material.MaterialCode,
                                    LotNumber = invOnMachine.MaterialInventory.LotNumber,
                                    Length = invOnMachine.MaterialInventory.Length / 1000,
                                    VendorCode = invOnMachine.MaterialInventory.Vendor.VendorCode,
                                    MaterialInvOnMachine = invOnMachine.TotalQuantity,

                                    DiffProduction = 0,
                                    ProductAlert = 0,
                                    LimitColor = 1,
                                    Note = "không có Work Order"
                                };
                                var lastTrack = MyUtilities.Machine.LastTrackUpMachine(machine.MachineId, invOnMachine.MaterialInventory.MaterialId, null, date);
                                if (lastTrack != null) {
                                    entity.ProductId = lastTrack.ProductId;
                                    entity.ProductCode = lastTrack.ProductCode;
                                    entity.Productivity = lastTrack.RealProductivity;
                                    entity.ProductionRate = lastTrack.RealRate;
                                    entity.KnifeCut = lastTrack.KnifeCut;
                                    entity.WorkPiece = lastTrack.WorkPiece;
                                }
                                entity.DiffProduction =
                                        MyUtilities.Product.GetMaterialRateInFactoryFullShiftTime(entity.Productivity, entity.ProductionRate);
                                entity.MaterialLimitQuantity = entity.DiffProduction;
                                var materialInvs = vfi.MaterialInventories.Where(pi => pi.MaterialId == entity.MaterialId && pi.TotalQty > 0);
                                if (materialInvs.Any()) {
                                    entity.MaterialAllInvTotal = materialInvs.Sum(mi => mi.TotalQty);
                                }

                                var onShelvesById = onShelves.Where(x => x.ReferenceInvId == entity.MaterialInventoryId).ToList();
                                if (onShelvesById.Any()) {
                                    entity.StoreCode = string.Join("+", onShelvesById.Select(x => x.DrawerCode).Distinct().OrderBy(x => x));
                                }
                                else {
                                    entity.StoreCode = "Ngoài kệ";
                                }

                                var lastUseBy =
                                    lastUse.Where(
                                        mud =>
                                        mud.MachineId == entity.MachineId &&
                                        mud.MaterialId == entity.MaterialId);
                                if (lastUseBy.Any()) {
                                    entity.DiffMaterial = lastUseBy.Sum(mud => mud.EditQuantity + mud.EditQuantity2);
                                }
                                entity.RunTime = MyUtilities.Function.RoundUp(entity.MaterialInvOnMachine * entity.Productivity * entity.ProductionRate);
                                machineRunTime = entity.RunTime;
                                model.Add(entity);

                                isAdded = true;
                            }
                        }
                        #endregion

                        #region work order with diff MaterialInvId on case 1
                        var assignWOById = assignWorkOrders.Where(x => x.MachineId == machine.MachineId
                                                                    && !materialInvIds.Contains(x.MaterialInvId.Value))
                                                            .ToList();
                        var loops = (from x in assignWOById
                                     group x by
                                         new {
                                             x.MachineId,
                                             x.ProductId,
                                             x.MaterialInvId,
                                         }
                                         into y
                                         select y).ToList();
                        foreach (var loop in loops) {
                            var entity = model.FirstOrDefault(x => x.MachineId == loop.Key.MachineId
                                                                && x.MaterialInventoryId == loop.Key.MaterialInvId
                                                                && x.ProductId == loop.Key.ProductId);
                            var assignWOById3 = assignWOById.Where(x => x.MachineId == loop.Key.MachineId
                                                                && x.MaterialInvId == loop.Key.MaterialInvId
                                                                && x.ProductId == loop.Key.ProductId).ToList();
                            if (entity == null) {
                                var routing = assignWOById3.FirstOrDefault();
                                entity = MapMaterialAssignModel(new SmartProductionModel {
                                    UseDateString = date.ToString("dd/MM"),
                                    UseDateString2 = lastDateString,
                                }, routing);
                                var materialInvs = vfi.MaterialInventories.Where(pi => pi.MaterialId == entity.MaterialId && pi.TotalQty > 0);
                                if (materialInvs.Any()) {
                                    entity.MaterialAllInvTotal = materialInvs.Sum(mi => mi.TotalQty);
                                }

                                var onShelvesById = onShelves.Where(x => x.ReferenceInvId == entity.MaterialInventoryId).ToList();
                                if (onShelvesById.Any()) {
                                    entity.StoreCode = string.Join("+", onShelvesById.Select(x => x.DrawerCode).Distinct().OrderBy(x => x));
                                }
                                else {
                                    entity.StoreCode = "Ngoài kệ";
                                }

                                var allmaterialInvOnMachines =
                                    vfi.MaterialInvOnMachines.Where(mim => mim.MachineId == entity.MachineId
                                                                        && mim.MaterialInventory.MaterialId == entity.MaterialId)
                                                             .Select(x => x.TotalQuantity).ToList();
                                if (allmaterialInvOnMachines.Any()) {
                                    entity.MaterialInvOnMachine = allmaterialInvOnMachines.Sum(mim => mim);
                                }
                                var lastUseBy =
                                    lastUse.Where(
                                        mud =>
                                        mud.MachineId == entity.MachineId &&
                                        mud.MaterialId == entity.MaterialId);
                                if (lastUseBy.Any()) {
                                    entity.DiffMaterial = lastUseBy.Sum(mud => mud.EditQuantity + mud.EditQuantity2);
                                }
                                entity.RunTime = MyUtilities.Function.RoundUp(entity.MaterialInvOnMachine * entity.Productivity * entity.ProductionRate);
                                model.Add(entity);
                                isAdded = true;
                            }
                            var serials = new List<string>();
                            foreach (var woRouting in assignWOById3) {
                                entity.Require += woRouting.PlannedCost;
                                serials.Add(woRouting.WorkOrder.SerialNumber);

                                machineRunTime += (entity.MaterialInvOnMachine + entity.Require) * entity.Productivity * entity.ProductionRate;
                                if (machineRunTime >= requireRunTime) break;
                            }
                            entity.Note = string.Join("-", serials);
                        }
                        #endregion

                        #region empty case
                        if (!isAdded && isAll) {
                            var entity = new SmartProductionModel {
                                MachineName = machine.MachineName,
                                MachineId = machine.MachineId,
                                UseDateString = date.ToString("dd/MM"),
                                UseDateString2 = lastDateString,
                                ProductId = 0,
                                ProductCode = "",
                                KnifeCut = 0,
                                WorkPiece = 0
                            };
                            var lastTrack = MyUtilities.Machine.LastTrackUpMachine(machine.MachineId, null, null, date);
                            if (lastTrack != null) {
                                entity.ProductCode = lastTrack.ProductCode;
                                entity.MaterialInventoryCode = lastTrack.MaterialCode;
                                entity.KnifeCut = lastTrack.KnifeCut;
                                entity.WorkPiece = lastTrack.WorkPiece;
                                entity.Productivity = lastTrack.RealProductivity;
                                entity.ProductionRate = lastTrack.RealRate;
                            }
                            model.Add(entity);
                            machineRunTime = requireRunTime;
                        }
                        #endregion

                        #region check require run time for new assignment
                        var routingIds = assignWOById.Select(x => x.RoutingId).ToList();
                        if (machineRunTime < requireRunTime) {
                            var assignWOById2 = assignWorkOrders.Where(x => x.MachineId == machine.MachineId
                                                                        && !routingIds.Contains(x.RoutingId))
                                                                .ToList();

                            var loops2 = (from x in assignWOById
                                          group x by
                                              new {
                                                  x.MachineId,
                                                  x.ProductId,
                                                  x.MaterialInvId,
                                              }
                                              into y
                                              select y).ToList();
                            foreach (var loop in loops2) {
                                var entity = model.FirstOrDefault(x => x.MachineId == loop.Key.MachineId
                                                                    && x.MaterialInventoryId == loop.Key.MaterialInvId
                                                                    && x.ProductId == loop.Key.ProductId);
                                var assignWOById3 = assignWOById2.Where(x => x.MachineId == loop.Key.MachineId
                                                                    && x.MaterialInvId == loop.Key.MaterialInvId
                                                                    && x.ProductId == loop.Key.ProductId).ToList();
                                if (entity == null) {
                                    var routing = assignWOById3.FirstOrDefault();
                                    entity = MapMaterialAssignModel(new SmartProductionModel {
                                        UseDateString = date.ToString("dd/MM"),
                                        UseDateString2 = lastDateString,
                                    }, routing);
                                    var materialInvs = vfi.MaterialInventories.Where(pi => pi.MaterialId == entity.MaterialId && pi.TotalQty > 0);
                                    if (materialInvs.Any()) {
                                        entity.MaterialAllInvTotal = materialInvs.Sum(mi => mi.TotalQty);
                                    }

                                    var onShelvesById = onShelves.Where(x => x.ReferenceInvId == entity.MaterialInventoryId).ToList();
                                    if (onShelvesById.Any()) {
                                        entity.StoreCode = string.Join("+", onShelvesById.Select(x => x.DrawerCode).Distinct().OrderBy(x => x));
                                    }
                                    else {
                                        entity.StoreCode = "Ngoài kệ";
                                    }

                                    var allmaterialInvOnMachines =
                                        vfi.MaterialInvOnMachines.Where(mim => mim.MachineId == entity.MachineId
                                                                            && mim.MaterialInventory.MaterialId == entity.MaterialId)
                                                                 .Select(x => x.TotalQuantity).ToList();
                                    if (allmaterialInvOnMachines.Any()) {
                                        entity.MaterialInvOnMachine = allmaterialInvOnMachines.Sum(mim => mim);
                                    }
                                    var lastUseBy =
                                        lastUse.Where(
                                            mud =>
                                            mud.MachineId == entity.MachineId &&
                                            mud.MaterialId == entity.MaterialId);
                                    if (lastUseBy.Any()) {
                                        entity.DiffMaterial = lastUseBy.Sum(mud => mud.EditQuantity + mud.EditQuantity2);
                                    }
                                    model.Add(entity);
                                }

                                var serials = new List<string>();
                                foreach (var woRouting in assignWOById3) {
                                    entity.Require += woRouting.PlannedCost;
                                    serials.Add(woRouting.WorkOrder.SerialNumber);

                                    machineRunTime += (entity.MaterialInvOnMachine + entity.Require) * entity.Productivity * entity.ProductionRate;
                                    if (machineRunTime >= requireRunTime) break;
                                }
                                entity.Note = string.Join("-", serials);
                            }
                        }
                        #endregion
                    }
                }
                if (model.Any()) {
                    var first = model.FirstOrDefault();
                    first.TotalCames = model.Where(m => !m.MachineName.Contains("CNC") && m.DiffMaterial > 0).Count();
                    first.TotalCnc = model.Where(m => m.MachineName.Contains("CNC") && m.DiffMaterial > 0).Count();
                }
            }
            catch (Exception ex) {
                return PartialView(ex.Message);
            }
            return PartialView("PageWOAssignMaterial", model);
        }

        SmartProductionModel MapMaterialAssignModel(SmartProductionModel assignModel, WorkOrderRouting routing) {
            var info = JsonConvert.DeserializeObject<WorkOrderProductionInfo>(routing.MoreInfo);
            var entity = new SmartProductionModel {
                MachineName = routing.Machine.MachineName,
                MachineId = routing.MachineId.Value,
                ProductId = routing.ProductId,
                ProductCode = routing.Product.ProductCode,
                UseDateString = assignModel.UseDateString,
                UseDateString2 = assignModel.UseDateString2,
                Productivity = info.NS,
                ProductionRate = info.DM,
                KnifeCut = info.DC,
                WorkPiece = info.PD,

                MaterialId = routing.MaterialInventory.MaterialId,
                MaterialCode = routing.MaterialInventory.Material.MaterialCode,
                MaterialName = routing.MaterialInventory.Material.MaterialName,
                OutDiameter = routing.MaterialInventory.Material.OutDiameter,
                InDiameter = routing.MaterialInventory.Material.InDiameter,
                Shape = routing.MaterialInventory.Material.Shape,
                DiameterType = routing.MaterialInventory.Material.DiameterType,

                MaterialInventoryId = routing.MaterialInventory.MaterialInventoryId,
                MaterialInventoryCode = routing.MaterialInventory.Material.MaterialCode,
                MaterialInvTotal = routing.MaterialInventory.TotalQty,
                LotNumber = routing.MaterialInventory.LotNumber,
                Length = routing.MaterialInventory.Length / 1000,
                VendorCode = routing.MaterialInventory.Vendor.VendorCode,

                DiffProduction = 0,
                ProductAlert = 0,
                LimitColor = 1
            };
            entity.DiffProduction =
                    MyUtilities.Product.GetMaterialRateInFactoryFullShiftTime(entity.Productivity, entity.ProductionRate);
            entity.MaterialLimitQuantity = entity.DiffProduction;
            return entity;
        }

        [GridAction]
        public ActionResult SelectWorkOrderMaterialUse(string date, int machineId) {
            var model = new List<MaterialInvOnMachineModel>();
            try {
                model = GetWOMaterialUse(date, machineId);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderMaterialUse", ex.Message);
            }
            return View(new GridModel(model));
        }

        public ActionResult PrintWOMaterialUse(string date) {
            var model = new List<MaterialInvOnMachineModel>();
            try {
                model = GetWOMaterialUse(date,0);
            }
            catch (Exception ex) {
                return PartialView(ex.Message);
            }
            return PartialView("PageWOMaterialUse", model);
        }

        List<MaterialInvOnMachineModel> GetWOMaterialUse(string date, int machineId) {
            var model = new List<MaterialInvOnMachineModel>();
            if (string.IsNullOrWhiteSpace(date))
                return model;
            var reportDate = MyUtilities.Function.ParseDate(date);
            var fromDate = reportDate.AddHours(7);
            var shiftTime = fromDate.AddHours(12);
            var toDate = fromDate.AddDays(1);
            var lastDate = reportDate.AddDays(-1);
            using (var vfi = new tammaContext()) {
//                select * 
//from Factory.WorkOrderRouting wr, Factory.WorkOrderRouting nr
//where wr.Status = 4
//and wr.WarehouseId is null
//and wr.NextRouteId = nr.RoutingId
//and nr.Status != 9
//and (nr.ActualEndDate < '2022-10-31'
//or nr.ActualEndDate is null
//)
//and wr.ActualStartDate > '2022-10-30'
                var workOrderMaterials = (from x in vfi.WorkOrderRoutings
                                          where
                                          x.WarehouseId == null
                                          && x.Status == (byte)MyUtilities.WorkOrder.Status.Finish // assign and approved
                                          && x.WorkOrderRouting2.Status != (byte)MyUtilities.WorkOrder.Status.Cancel
                                          && (x.WorkOrderRouting2.ActualEndDate == null
                                          || ( x.WorkOrderRouting2.ActualEndDate >= fromDate
                                          && x.WorkOrderRouting2.ActualStartDate < toDate))
                                              //&& x.ActualStartDate < toDate
                                              //&& (x.ActualEndDate == null || x.ActualEndDate < toDate)
                                              //&& (x.WorkOrderRouting2.Status != (byte)MyUtilities.WorkOrder.Status.Finish
                                              // && x.WorkOrderRouting2.Status != (byte)MyUtilities.WorkOrder.Status.Cancel
                                              //|| (x.WorkOrderRouting2.Status == (byte)MyUtilities.WorkOrder.Status.Finish
                                              // && x.WorkOrderRouting2.ActualEndDate < toDate)
                                              //)

                                          && (machineId == 0 || x.MachineId == machineId)
                                          select new {
                                              MachineId = x.MachineId ?? 0,
                                              x.Machine.MachineName,
                                              x.MaterialInvId,
                                              x.MaterialInventory.MaterialId,
                                              x.MaterialInventory.Material.MaterialName,
                                              x.MaterialInventory.Material.Shape,
                                              x.MaterialInventory.Material.OutDiameter,
                                              x.MaterialInventory.Material.InDiameter,
                                              x.MaterialInventory.Material.DiameterType,
                                              x.MaterialInventory.Length,
                                              x.MaterialInventory.LotNumber,
                                              x.MaterialInventory.Vendor.VendorCode,

                                              x.ProductId,
                                              x.Product.ProductCode,

                                              x.WorkOrderRouting2,
                                              x.RoutingId,
                                              AssignMaterial = x.WorkOrderProcesses.Sum(y => y.GoodQuantity),
                                              x.NextRouteId,
                                              x.MoreInfo,
                                              x.WorkOrder.SerialNumber,
                                              RefIds = x.WorkOrderProcesses.Where(y => y.Status != (byte)MyUtilities.WorkOrder.Status.Cancel).Select(y => y.ReferenceDetailId),
                                          }).ToList();
                var processStatus = new List<byte> { 
                        (byte)MyUtilities.WorkOrder.Status.InProcess, 
                        (byte)MyUtilities.WorkOrder.Status.Finish 
                };
                var usedQuantity = workOrderMaterials.Where(x => processStatus.Contains(x.WorkOrderRouting2.Status))
                    .Select(x => new {
                        x.RoutingId,
                        UsingQuantity = x.WorkOrderRouting2.WorkOrderProcesses.Where(y => 
                            y.Status != (byte)MyUtilities.WorkOrder.Status.Cancel
                            && y.Date < fromDate).Sum(y => y.UsingQuantity)
                    }).ToList();

                //var anotherUsed = (from mud in vfi.MaterialUseDetails
                //                 where
                //                     mud.MaterialUseInShift.UsedDate >= lastDate &&
                //                     mud.MaterialUseInShift.UsedDate < fromDate &&
                //                     mud.MaterialUseInShift.Status == (byte)MyUtilities.Transaction.Status.Approved &&
                //                     (mud.IsDetroy || mud.MaterialUseInShift.Type == (byte)MyUtilities.Material.UseType.SendBack)
                //                 select new {
                //                     mud.DetailId,
                //                     mud.MachineId,
                //                     mud.MaterialInvId,
                //                     mud.IsDetroy,
                //                     mud.EditQuantity,
                //                     mud.EditQuantity2,
                //                     mud.MaterialUseInShift.Type
                //                 }).ToList();
                var exportMaterials = (from ed in vfi.ExportMaterialDetails
                                       where
                                           ed.ExportMaterial.ExportDate >= fromDate.Date &&
                                           ed.ExportMaterial.ExportDate < toDate &&
                                           ed.ExportMaterial.Transaction.Status ==
                                           (byte)MyUtilities.Transaction.Status.Approved &&
                                           ed.MachineId != null
                                       select new {
                                           ed.ExportDetailId,
                                           MachineId = ed.MachineId.Value,
                                           MaterialInvId = ed.MaterialInvId,
                                           Quantity = ed.Quantity,
                                       }).ToList();
                foreach (var workOrderMaterial in workOrderMaterials) {
                    var entity = new MaterialInvOnMachineModel {
                        Id = workOrderMaterial.RoutingId,
                        MachineId = workOrderMaterial.MachineId,
                        MachineName = workOrderMaterial.MachineName,
                        MaterialId = workOrderMaterial.MaterialId,
                        MaterialInvId = workOrderMaterial.MaterialInvId ?? 0,
                        ProductId = workOrderMaterial.ProductId,
                        ProductCode = workOrderMaterial.ProductCode,
                        //MaterialDesign = MyUtilities.Material.GetMaterialInvDesignNo(workOrderMaterial.MaterialInventory),
                        Length = workOrderMaterial.Length / 1000,
                        LotNumber = workOrderMaterial.LotNumber,
                        MaterialName = workOrderMaterial.MaterialName,
                        Shape = workOrderMaterial.Shape,
                        DiameterType = workOrderMaterial.DiameterType,
                        OutDiameter = workOrderMaterial.OutDiameter,
                        InDiameter = workOrderMaterial.InDiameter,
                        DateString = date,
                        VendorCode = workOrderMaterial.VendorCode,
                        EarlyQuantity = workOrderMaterial.AssignMaterial,
                        Note = workOrderMaterial.SerialNumber,
                    };
                    entity.MaterialDesign = MyUtilities.Material.GetMaterialInvDesignNo(
                        entity.MaterialName,
                        entity.OutDiameter,
                        entity.InDiameter,
                        entity.Length * 1000,
                        entity.DiameterType,
                        entity.Shape,
                        entity.VendorCode,
                        entity.LotNumber);
                    entity.AssignQuantity = exportMaterials.Where(ed => ed.MachineId == entity.MachineId
                                                                    && ed.MaterialInvId == entity.MaterialInvId
                                                                    && workOrderMaterial.RefIds.Contains(ed.ExportDetailId))
                                                           .ToList()
                                                           .Sum(ed => ed.Quantity);
                    var usingMaterial = usedQuantity.Where(x => x.RoutingId == workOrderMaterial.RoutingId)
                                                .ToList()
                                                .Sum(x => x.UsingQuantity);
                    entity.EarlyQuantity -= usingMaterial;
                    var info = JsonConvert.DeserializeObject<WorkOrderProductionInfo>(workOrderMaterial.MoreInfo);
                    entity.Productivity = info.DM;
                    entity.ProductionRate = info.NS;
                    var processed = workOrderMaterial.WorkOrderRouting2.WorkOrderProcesses.Where(x => processStatus.Contains(x.Status) 
                        && x.Date >= fromDate 
                        && x.Date < shiftTime).ToList();
                    entity.QuantityUse1 = processed.Sum(mud => mud.UsingQuantity);
                    processed = workOrderMaterial.WorkOrderRouting2.WorkOrderProcesses.Where(x => processStatus.Contains(x.Status)
                        && x.Date >= shiftTime
                        && x.Date < toDate).ToList();
                    entity.QuantityUse2 = processed.Sum(mud => mud.UsingQuantity);
                    entity.LastQuantity = entity.EarlyQuantity - entity.QuantityUse1 - entity.QuantityUse2;
                    //var useById = muInShifts.Where(
                    //        mud => mud.MachineId == entity.MachineId &&
                    //               mud.MaterialInvId == entity.MaterialInvId)
                    //                           .ToList();
                    //if (useById.Any()) {
                    //    var use = useById.Where(mud => mud.Type == (int)MyUtilities.Material.UseType.SendBack && mud.IsDetroy).ToList();
                    //    entity.Destroy = use.Sum(mud => mud.EditQuantity);
                    //    use = useById.Where(mud => mud.Type == (int)MyUtilities.Material.UseType.SendBack && !mud.IsDetroy).ToList();
                    //    entity.SendBack = use.Sum(mud => mud.EditQuantity);
                    //}
                    if (entity.Show) {
                        model.Add(entity);
                    }
                }
            }

            return model.OrderBy(x=> x.MachineName).ToList();
        }

        #endregion

        #region production 1

        [GridAction]
        public ActionResult SelectWorkOrderProductionManagement(string productCode, string fromDate, string toDate, byte status) {
            if (string.IsNullOrWhiteSpace(toDate)) { return View(new GridModel(new List<WorkOrderRoutingModel>())); }

            var model = new List<WorkOrderRoutingModel>();
            try {
                if (string.IsNullOrWhiteSpace(productCode) && string.IsNullOrWhiteSpace(fromDate) && status == 0) {
                    return View(new GridModel(model));
                }
                model = GetWorkOrderRoutingModel(
                    new RoutingConfiguration { IsProduction = true },
                    status, 0, 0, productCode, fromDate, toDate
                    );
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderProductionManagement", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult SelectWorkOrderProductionApprovement() {
            var model = new List<WorkOrderProcessModel>();
            try {
                model = GetWorkOrderProcessApprovement(
                    new RoutingConfiguration { IsProduction = true }, 
                    (byte)MyUtilities.WorkOrder.Status.InProcess
                    );
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderProductionApprovement", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult UpdateWorkOrderProductionProcess(WorkOrderProcessModel process) {
            var model = new List<WorkOrderProcessModel>();
            try {
                using (var vfi = new tammaContext()) {
                    var entity = vfi.WorkOrderProcesses.FirstOrDefault(x => x.ProcessId == process.ProcessId);
                    if (entity == null) {
                        throw new AggregateException("Lỗi! Không tìm thấy dữ liệu");
                    }
                    if (entity.Status != (byte)MyUtilities.WorkOrder.Status.InProcess) {
                        throw new AggregateException("Lỗi! Tình trạng không cho phép sửa đổi");
                    }
                    entity.GoodQuantity = process.GoodQuantity;
                    entity.NGQuantity = process.NGQuantity;
                    entity.DefectQuantity = process.DefectQuantity;
                    entity.ModifiedDate = DateTime.Now;
                    entity.ModifiedUser = HttpContext.User.Identity.Name;
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateWorkOrderProductionProcess", ex.Message);
            }
            return View(new GridModel(GetWorkOrderProcessApprovement(
                    new RoutingConfiguration { IsProduction = true },
                    (byte)MyUtilities.WorkOrder.Status.InProcess
                    )));
        }

        [GridAction]
        public ActionResult CancelWorkOrderProductionProcess(long processId) {
            var model = new List<WorkOrderProcessModel>();
            try {
                using (var vfi = new tammaContext()) {
                    var entity = vfi.WorkOrderProcesses.FirstOrDefault(x => x.ProcessId == processId);
                    if (entity == null) {
                        throw new AggregateException("Lỗi! Không tìm thấy dữ liệu");
                    }
                    if (entity.Status != (byte)MyUtilities.WorkOrder.Status.InProcess) {
                        throw new AggregateException("Lỗi! Tình trạng không cho phép sửa đổi");
                    }
                    entity.Status = (byte)MyUtilities.WorkOrder.Status.Cancel;
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("CancelWorkOrderProcess", ex.Message);
            }
            return View(new GridModel(GetWorkOrderProcessApprovement(
                    new RoutingConfiguration { IsProduction = true },
                    (byte)MyUtilities.WorkOrder.Status.InProcess
                    )));
        }

        public ActionResult ApproveWorkOrderProductionProcess(string ids) {
            var model = new List<WorkOrderProcessModel>();
            try {
                var saved = 0;
                var routingIds = new List<int>();
                var transactionIds = new List<long>();
                var messageError = "";
                using (var vfi = new tammaContext()) {
                    var checkedRecords = MyUtilities.Function.StringToBigIds(ids, ':');
                    var processes = vfi.WorkOrderProcesses.Where(x => checkedRecords.Contains(x.ProcessId) 
                        && x.Status == (byte) MyUtilities.WorkOrder.Status.InProcess);
                    if (!processes.Any()) {
                        throw new AggregateException("Lỗi! Danh sách chọn không tìm thấy! Vui lòng F5 để làm lại");
                    }
                    checkedRecords = processes.Select(x => x.ProcessId).ToList();
                    foreach (var process in processes) {
                        process.Status = (byte)MyUtilities.WorkOrder.Status.Finish;
                    }
                    routingIds = processes.Select(x => x.RoutingId).Distinct().ToList();
                    var materialUses = new List<MaterialUseInShift>();
                    var importSx1s = new List<ImportFormSX1>();
                    var transactions = new List<Transaction>();
                    var transactionSx1s = new List<Transaction>();
                    var shift1StartTime = MyUtilities.Product.StartShift1_HOUR;
                    var shift2StartTime = MyUtilities.Product.StartShift2_HOUR;
                    var startTime = processes.Min(x => x.Date);
                    var endTime = processes.Max(x => x.Date);
                    try {
                        #region material use case + material inv on machine
                        if (startTime.Hour >= shift1StartTime && startTime.Hour < shift2StartTime) {
                            startTime = startTime.Date.AddHours(shift1StartTime);
                        }
                        else {
                            startTime = startTime.Date.AddDays(-1).AddHours(shift2StartTime);
                        }
                        var endMaterialInvIds = new List<int>();
                        var startDate = new DateTime(startTime.Year, startTime.Month, startTime.Day);
                        var productionDates = (from x in vfi.ProductionLocks
                                               where x.LockDate >= startDate && x.LockDate <= endTime
                                               select new {
                                                   x.LockDate,
                                                   x.Shift1Name,
                                                   x.Shift2Name
                                               }).ToList();
                        var shift1Name = "A";
                        var shift2Name = "B";
                        while (startTime < endTime) {
                            var shift = startTime.Hour == shift1StartTime ? 1 : 2;
                            var productionDate = productionDates.FirstOrDefault(x => x.LockDate.Year == startTime.Year
                                                                        && x.LockDate.Month == startTime.Month
                                                                        && x.LockDate.Day == startTime.Day);
                            if (productionDate != null) {
                                shift1Name = productionDate.Shift1Name;
                                shift2Name = productionDate.Shift2Name;
                            }
                            var materialUse = new MaterialUseInShift() {
                                ModifiedDate = DateTime.Now,
                                ModifiedUser = HttpContext.User.Identity.Name,
                                Shift1 = (shift == 1 ? shift1Name : ""),
                                Shift2 = (shift == 2 ? shift2Name : ""),
                                Status = (byte)MyUtilities.Transaction.Status.Approved,
                                UsedDate = new DateTime(startTime.Year, startTime.Month, startTime.Day),
                                UsedCode = MyUtilities.AutoIncrease.GetParam((int)MyUtilities.AutoIncrease.IncreaseNum.MaterialUse, 1),
                                Type = (int)MyUtilities.Material.UseType.Using,
                            };
                            materialUses.Add(materialUse);

                            var periodTime = startTime.AddHours(12).AddSeconds(-1);
                            //var lot = MyUtilities.MySystem.LotNumber_Weekly(materialUse.UsedDate);
                            var processesByPeriod = processes.Where(x => x.Date >= startTime && x.Date <= periodTime);
                            foreach (var process in processesByPeriod) {
                                var materialUseDetail = new MaterialUseDetail {
                                    MachineId = process.WorkOrderRouting.MachineId.Value,
                                    MaterialInvId = process.WorkOrderRouting.MaterialInvId.Value,
                                    EditQuantity = (shift == 1 ? process.UsingQuantity : 0),
                                    EditQuantity2 = (shift == 2 ? process.UsingQuantity : 0),
                                    Note = process.ProcessId + "",
                                    Lot = process.WorkOrderRouting.WorkOrder.SerialNumber,
                                };
                                materialUseDetail.Quantity = materialUseDetail.EditQuantity;
                                materialUseDetail.Quantity2 = materialUseDetail.EditQuantity2;
                                materialUse.MaterialUseDetails.Add(materialUseDetail);
                                // material inventory machine using
                                var materialOnMachine =
                                    vfi.MaterialInvOnMachines.FirstOrDefault(
                                        mim =>
                                        mim.MachineId == materialUseDetail.MachineId &&
                                        mim.MaterialInvId == materialUseDetail.MaterialInvId);
                                var period = new MaterialInvOnMachinePeriod {
                                    EarlyQuantity = materialOnMachine.TotalQuantity,
                                    Quantity = materialUseDetail.EditQuantity + materialUseDetail.EditQuantity2,
                                    LastQuantity = 0,
                                    MachineId = materialOnMachine.MachineId,
                                    MaterialInvId = materialOnMachine.MaterialInvId,
                                    ModifiedDate = materialUse.ModifiedDate,
                                    ModifiedUser = materialUse.ModifiedUser,
                                    Note = materialUseDetail.Note,
                                    PeriodDate = materialUse.UsedDate,
                                };
                                period.LastQuantity = Math.Round(materialOnMachine.TotalQuantity - period.Quantity, 2);
                                materialOnMachine.TotalQuantity = period.LastQuantity;
                                vfi.MaterialInvOnMachinePeriods.Add(period);
                                if (materialOnMachine.MaterialInventory.FirstUseDate == null)
                                    materialOnMachine.MaterialInventory.FirstUseDate = materialUse.UsedDate;
                                if (Math.Round(materialOnMachine.TotalQuantity, 2) == 0) {
                                    materialOnMachine.TotalQuantity = 0;
                                    if (Math.Round(materialOnMachine.MaterialInventory.TotalQty, 2) == 0) {
                                        endMaterialInvIds.Add(materialOnMachine.MaterialInvId.Value);
                                    }
                                }

                            }
                            startTime = startTime.AddHours(12);

                        }
                        vfi.MaterialUseInShifts.AddRange(materialUses);
                        saved += vfi.SaveChanges();
                        if (endMaterialInvIds.Any()) {
                            endMaterialInvIds = endMaterialInvIds.Distinct().ToList();
                            foreach (var materialInvId in endMaterialInvIds) {
                                var existedOnMachine = vfi.MaterialInvOnMachines.Any(x => x.MaterialInvId == materialInvId && x.TotalQuantity > 0);
                                if (existedOnMachine) continue;
                                var materialInv = vfi.MaterialInventories.FirstOrDefault(x => x.MaterialInventoryId == materialInvId);
                                if (materialInv == null) continue;
                                materialInv.EndDate = DateTime.Now;
                            }
                            saved += vfi.SaveChanges();
                        }
                        #endregion
                    }
                    catch (Exception ex) { messageError += "material use case error: " + MyUtilities.MySystem.FetchExceptionMessage(ex); }

                    try {
                        #region import production 1 case

                        processes = vfi.WorkOrderProcesses.Where(x => checkedRecords.Contains(x.ProcessId));
                        foreach (var materialUse in materialUses) {
                            var import = new ImportFormSX1 {
                                ImportDate = DateTime.Today,
                                TransactionCode = MyUtilities.AutoIncrease.GetParam((int)MyUtilities.AutoIncrease.IncreaseNum.Production1, 1),
                                ModifiedDate = materialUse.ModifiedDate,
                                ModifiedUser = materialUse.ModifiedUser,
                                Shift1Name = materialUse.Shift1,
                                Shift2Name = materialUse.Shift2,
                                MaterialUseDate = materialUse.UsedDate,
                                Status = (byte)MyUtilities.Transaction.Status.Approved,
                            };
                            importSx1s.Add(import);
                            foreach (var useDetail in materialUse.MaterialUseDetails) {
                                var process = processes.FirstOrDefault(x => x.UsingQuantity == useDetail.EditQuantity + useDetail.EditQuantity2
                                    && x.WorkOrderRouting.MachineId == useDetail.MachineId
                                    && x.WorkOrderRouting.MaterialInvId == useDetail.MaterialInvId
                                    && useDetail.Note.Equals(x.ProcessId + ""));
                                var routing = process.WorkOrderRouting;
                                var info = JsonConvert.DeserializeObject<WorkOrderProductionInfo>(routing.MoreInfo);
                                var importDetail = new ImportFormSX1Detail {
                                    ImportFormSX1 = import,
                                    Machine = routing.Machine.MachineName,
                                    MachineId = routing.MachineId,
                                    ProductId = process.WorkOrderRouting.ProductId,
                                    Shift1 = materialUse.Shift1,
                                    Shift2 = materialUse.Shift2,
                                    MaterialInvId = routing.MaterialInvId,
                                    ProductWeight = process.WorkOrderRouting.Product.ProductionWeight ?? 0,
                                    ProductionRate = info.DM,
                                    UseDetailId = useDetail.DetailId,
                                    WarehouseExportId = routing.WorkOrderRouting2.WarehouseId,
                                    UnitMeasure = "pcs",
                                    LotNumber = routing.RoutingLot,
                                };
                                if (useDetail.EditQuantity > 0) {
                                    importDetail.MaterialUse1 = process.UsingQuantity;
                                    importDetail.Number1 = process.GoodQuantity;
                                    importDetail.Processing1 = process.NGQuantity;
                                    importDetail.DefectProduct1 = process.DefectQuantity;
                                }
                                else {
                                    importDetail.MaterialUse2 = process.UsingQuantity;
                                    importDetail.Number2 = process.GoodQuantity;
                                    importDetail.Processing2 = process.NGQuantity;
                                    importDetail.DefectProduct2 = process.DefectQuantity;
                                }
                                import.ImportFormSX1Detail.Add(importDetail);
                            }
                        }
                        vfi.ImportFormSX1.AddRange(importSx1s);
                        saved += vfi.SaveChanges();
                        #endregion
                    }
                    catch (Exception ex) { messageError += "import production case error" + MyUtilities.MySystem.FetchExceptionMessage(ex); }
                    try {
                        #region transaction case
                        var productionInvs = new List<ProductInventory>();
                        foreach (var importSx1 in importSx1s) {
                            var transactionSX1 = new Transaction {
                                TransactionCode = importSx1.TransactionCode,
                                CreatedUser = importSx1.ModifiedUser,
                                CreatedDate = importSx1.ImportDate,
                                WarehouseIssueId = null,
                                WarehouseReceiptId = MyUtilities.Warehouse.Production1,
                                ModifiedUser = importSx1.ModifiedUser,
                                ModifiedDate = importSx1.ModifiedDate,
                                Status = (byte)MyUtilities.Transaction.Status.Open,
                                Active = true,
                                EoI = "0",
                                MoP = false,
                                ReferenceId = importSx1.ImportId,
                            };
                            transactionSx1s.Add(transactionSX1);
                            transactions.Add(transactionSX1);
                            var transactionCXL = new Transaction {
                                TransactionCode = importSx1.TransactionCode,
                                CreatedUser = importSx1.ModifiedUser,
                                CreatedDate = importSx1.ImportDate,
                                WarehouseIssueId = transactionSX1.WarehouseReceiptId,
                                WarehouseReceiptId = MyUtilities.Warehouse.Processing,
                                ModifiedUser = importSx1.ModifiedUser,
                                ModifiedDate = importSx1.ModifiedDate,
                                Status = (byte)MyUtilities.Transaction.Status.Open,
                                Active = true,
                                EoI = "0",
                                MoP = false,
                                ReferenceId = importSx1.ImportId,
                            };
                            transactions.Add(transactionCXL);
                            var transactionPP = new Transaction {
                                TransactionCode = importSx1.TransactionCode,
                                CreatedUser = importSx1.ModifiedUser,
                                CreatedDate = importSx1.ImportDate,
                                WarehouseIssueId = null,
                                WarehouseReceiptId = MyUtilities.Warehouse.Defect,
                                ModifiedUser = importSx1.ModifiedUser,
                                ModifiedDate = importSx1.ModifiedDate,
                                Status = (byte)MyUtilities.Transaction.Status.Open,
                                Active = true,
                                EoI = "0",
                                MoP = false,
                                ReferenceId = importSx1.ImportId,
                            };
                            transactions.Add(transactionPP);
                            foreach (var detail in importSx1.ImportFormSX1Detail) {
                                var process = processes.FirstOrDefault(x => x.UsingQuantity == detail.MaterialUse1 + detail.MaterialUse2
                                    && x.WorkOrderRouting.MachineId == detail.MachineId
                                    && x.WorkOrderRouting.MaterialInvId == detail.MaterialInvId
                                    && x.WorkOrderRouting.ProductId == detail.ProductId
                                    && x.WorkOrderRouting.RoutingLot.Equals(detail.LotNumber)
                                    && x.GoodQuantity == detail.Number1 + detail.Number2
                                    && x.NGQuantity == detail.Processing1 + detail.Processing2
                                    && x.DefectQuantity == detail.DefectProduct1 + detail.DefectProduct2);
                                process.ReferenceDetailId = detail.DetailId;
                                var product = vfi.Products.FirstOrDefault(p => p.ProductId == detail.ProductId);
                                if (product.ProductionRate == null || product.ProductionRate == 0)
                                    product.ProductionRate = detail.ProductionRate;
                                if (detail.ProductWeight != 1 && product.ProductionWeight != detail.ProductWeight) {
                                    product.ProductionWeight = detail.ProductWeight;
                                }
                                if (product.QcWeight == null || product.QcWeight == 0 || product.QcWeight == 1)
                                    product.QcWeight = product.ProductionWeight;

                                if (detail.Number1 + detail.Processing1 + detail.Number2 + detail.Processing2 > 0) {
                                    var transactionDetailSX1 = new TransactionDetail {
                                        Transaction = transactionSX1,
                                        TransactionId = transactionSX1.TransactionId,
                                        ReferenceId = detail.ProductId,
                                        MoP = false,
                                        Quantity = detail.Number1 + detail.Processing1 + detail.Number2 + detail.Processing2,
                                        UnitMeasure = null,
                                        Active = true,
                                        ModifiedUser = importSx1.ModifiedUser,
                                        ModifiedDate = importSx1.ModifiedDate,
                                        QuantityKg = 0,
                                        Note = detail.LotNumber,
                                        LotNumber = detail.LotNumber,
                                        MachineId = detail.MachineId
                                    };
                                    transactionSX1.TransactionDetails.Add(transactionDetailSX1);
                                }
                                if (detail.DefectProduct1 + detail.DefectProduct2 > 0) {
                                    var transactionDetailPP = new TransactionDetail {
                                        Transaction = transactionPP,
                                        TransactionId = transactionPP.TransactionId,
                                        ReferenceId = detail.ProductId,
                                        MoP = false,
                                        Quantity = detail.DefectProduct1 + detail.DefectProduct2,
                                        UnitMeasure = null,
                                        Active = true,
                                        ModifiedUser = importSx1.ModifiedUser,
                                        ModifiedDate = importSx1.ModifiedDate,
                                        QuantityKg = 0,
                                        Note = detail.LotNumber,
                                        LotNumber = detail.LotNumber,
                                        MachineId = detail.MachineId
                                    };
                                    transactionPP.TransactionDetails.Add(transactionDetailPP);
                                }
                                if (detail.Processing1 + detail.Processing2 > 0) {
                                    var transactionDetailCXL = new TransactionDetail {
                                        Transaction = transactionCXL,
                                        TransactionId = transactionCXL.TransactionId,
                                        ReferenceId = detail.ProductId,
                                        MoP = false,
                                        Quantity = detail.Processing1 + detail.Processing2,
                                        UnitMeasure = null,
                                        Active = true,
                                        ModifiedUser = importSx1.ModifiedUser,
                                        ModifiedDate = importSx1.ModifiedDate,
                                        QuantityKg = 0,
                                        Note = detail.LotNumber,
                                        LotNumber = detail.LotNumber,
                                        MachineId = detail.MachineId
                                    };
                                    transactionCXL.TransactionDetails.Add(transactionDetailCXL);
                                    var productInv =
                                        vfi.ProductInventories.FirstOrDefault(
                                            pi =>
                                                pi.WarehouseId == (transactionCXL.WarehouseIssueId ?? 0) &&
                                                pi.ProductId == detail.ProductId &&
                                                pi.LotNumber.Equals(detail.LotNumber));
                                    if (productInv == null) {
                                        productInv = new ProductInventory {
                                            WarehouseId = transactionCXL.WarehouseIssueId.Value,
                                            ProductId = detail.ProductId,
                                            ImportDate = transactionSX1.CreatedDate,
                                            ModifiedUser = importSx1.ModifiedUser,
                                            ModifiedDate = importSx1.ModifiedDate,
                                            TotalQty = 0,
                                            LotNumber = detail.LotNumber,
                                            MachineId = detail.MachineId,
                                            MaterialInvId = detail.MaterialInvId,
                                        };
                                        vfi.ProductInventories.Add(productInv);
                                    }
                                    transactionDetailCXL.ProductInventory = productInv;
                                }
                            }
                        }
                        transactions = transactions.Where(x => x.TransactionDetails.Any(y => y.Quantity > 0)).ToList();
                        vfi.Transactions.AddRange(transactions);
                        saved += vfi.SaveChanges();
                        #endregion

                    }
                    catch (Exception ex) { messageError = "transaction case error: " + MyUtilities.MySystem.FetchExceptionMessage(ex); }

                    try {
                        #region workpiece case
                        foreach (var transactionSX1 in transactionSx1s) {
                            var importSx1 = importSx1s.FirstOrDefault(x => x.TransactionCode.Equals(transactionSX1.TransactionCode));

                            var importWorkpieceMaterial = new ImportWorkpieceMaterial {
                                ImportFormSX1 = importSx1,
                                ModifiedDate = importSx1.ModifiedDate,
                                ModifiedUser = importSx1.ModifiedUser,
                                Transaction = transactionSX1,
                                ImportDate = importSx1.MaterialUseDate,
                            };
                            vfi.ImportWorkpieceMaterials.Add(importWorkpieceMaterial);
                        }
                        saved += vfi.SaveChanges();
                        #endregion
                    }
                    catch (Exception) { messageError = "workpiece case error"; }

                    transactionIds = transactionSx1s.Select(x => x.TransactionId).Distinct().ToList();
                }
                try {
                    foreach (var transactionId in transactionIds) {
                        saved += transactionController.UpdateProductInvByTransaction(transactionId, HttpContext.User.Identity.Name);
                    }
                }
                catch (Exception ex) { messageError += "product inventory case error:" + MyUtilities.MySystem.FetchExceptionMessage(ex); }

                saved += UpdateStatusWorkOrderRoutingProduction(routingIds, false);

                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NoError, messageError, saved));
            }
            catch (Exception ex) {
                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.Exception, MyUtilities.MySystem.FetchExceptionMessage(ex), null));
            }
            //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NotImplement, "", null));
        }

        #endregion

        #region production 2

        [GridAction]
        public ActionResult SelectWorkOrderProduction2Management(string productCode, string fromDate, string toDate, byte status) {
            if (string.IsNullOrWhiteSpace(toDate)) { return View(new GridModel(new List<WorkOrderRoutingModel>())); }

            var model = new List<WorkOrderRoutingModel>();
            try {
                model = GetWorkOrderRoutingModel(
                    new RoutingConfiguration { IsProduction2 = true },
                    status, 0, 0, productCode, fromDate, toDate
                    );
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderProduction2Management", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult SelectWorkOrderProduction2Confirmation() {
            var model = new List<WorkOrderRoutingModel>();
            try {
                model = GetWorkOrderRoutingModel(new RoutingConfiguration { IsProduction2 = true },
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"", "", "");
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderProduction2Confirmation", ex.Message);
            }
            return View(new GridModel(model));
        }
        
        [GridAction]
        public ActionResult ConfirmWorkOrderProduction2(int routingId) {
            if (routingId == 0) {
                return View(new GridModel(GetWorkOrderRoutingModel(new RoutingConfiguration { IsProduction2 = true },
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"", "", "")));
                //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NotFound, "Không tìm thấy " + routingId, null));
            }
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    if (routing == null) { throw new AggregateException("Lỗi! Không tìm thấy công đoạn"); }
                    if (routing.Status != (byte)MyUtilities.WorkOrder.Status.Actived) { 
                        throw new AggregateException("Lỗi! Công đoạn đã xác nhận.F5 lại để làm mới danh sách");
                    }
                    routing.Status = (byte)MyUtilities.WorkOrder.Status.InProcess;
                    routing.ActualStartDate = DateTime.Now;
                    vfi.SaveChanges();
                }
                try {
                    RotatePreviousWorkOrderInventory(routingId);
                }
                catch (Exception ex) {
                    ModelState.AddModelError("RotatePreviousWorkOrderInventory", ex.Message);
                }

            }
            catch (Exception ex) {
                ModelState.AddModelError("ConfirmWorkOrderProduction2", ex.Message);
            }
            return View(new GridModel(GetWorkOrderRoutingModel(new RoutingConfiguration { IsProduction2 = true }, 
                (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","","")));
        }

        [GridAction]
        public ActionResult SelectWorkOrderProduction2Approvement() {
            var model = new List<WorkOrderProcessModel>();
            try {
                model = GetWorkOrderProcessApprovement(new RoutingConfiguration { IsProduction2 = true }, (byte)MyUtilities.WorkOrder.Status.InProcess);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderProduction2Approvement", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult UpdateWorkOrderProduction2Process(WorkOrderProcessModel process) {
            var model = new List<WorkOrderProcessModel>();
            try {
                using (var vfi = new tammaContext()) {
                    var entity = vfi.WorkOrderProcesses.FirstOrDefault(x => x.ProcessId == process.ProcessId);
                    if (entity == null) {
                        throw new AggregateException("Lỗi! Không tìm thấy dữ liệu");
                    }
                    if (entity.Status != (byte)MyUtilities.WorkOrder.Status.InProcess) {
                        throw new AggregateException("Lỗi! Tình trạng không cho phép sửa đổi");
                    }
                    entity.GoodQuantity = process.GoodQuantity;
                    entity.NGQuantity = process.NGQuantity;
                    entity.DefectQuantity = process.DefectQuantity;
                    entity.ModifiedDate = DateTime.Now;
                    entity.ModifiedUser = HttpContext.User.Identity.Name;
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateWorkOrderProductionProcess", ex.Message);
            }
            return View(new GridModel(GetWorkOrderProcessApprovement(
                    new RoutingConfiguration { IsProduction2 = true },
                    (byte)MyUtilities.WorkOrder.Status.InProcess
                    )));
        }

        [GridAction]
        public ActionResult CancelWorkOrderProduction2Process(long processId) {
            var model = new List<WorkOrderProcessModel>();
            try {
                using (var vfi = new tammaContext()) {
                    var entity = vfi.WorkOrderProcesses.FirstOrDefault(x => x.ProcessId == processId);
                    if (entity == null) {
                        throw new AggregateException("Lỗi! Không tìm thấy dữ liệu");
                    }
                    if (entity.Status != (byte)MyUtilities.WorkOrder.Status.InProcess) {
                        throw new AggregateException("Lỗi! Tình trạng không cho phép sửa đổi");
                    }
                    entity.Status = (byte)MyUtilities.WorkOrder.Status.Cancel;
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("CancelWorkOrderProcess", ex.Message);
            }
            return View(new GridModel(GetWorkOrderProcessApprovement(
                    new RoutingConfiguration { IsProduction2 = true },
                    (byte)MyUtilities.WorkOrder.Status.InProcess
                    )));
        }

        public ActionResult ApproveWorkOrderProduction2Process(string ids) {
            try {
                var saved = 0;
                var routingIds = new List<int>();
                using (var vfi = new tammaContext()) {
                    var checkedRecords = MyUtilities.Function.StringToBigIds(ids, ':');
                    var processes = vfi.WorkOrderProcesses.Where(x => checkedRecords.Contains(x.ProcessId));
                    routingIds = processes.Select(x => x.RoutingId).Distinct().ToList();
                    var transactions = new List<Transaction>();
                    foreach (var process in processes) {
                        process.Status = (byte)MyUtilities.WorkOrder.Status.Finish;
                        if (process.NGQuantity > 0) {
                            var transaction = transactions.FirstOrDefault(x => x.WarehouseIssueId == process.WorkOrderRouting.WarehouseId 
                                && x.WarehouseReceiptId == MyUtilities.Warehouse.Processing);
                            if (transaction == null) {
                                transaction = new Transaction {
                                    TransactionCode = MyUtilities.AutoIncrease.GetParam((int)MyUtilities.AutoIncrease.IncreaseNum.Product, 1),
                                    CreatedUser = HttpContext.User.Identity.Name,
                                    CreatedDate = DateTime.Now,
                                    WarehouseIssueId = process.WorkOrderRouting.WarehouseId,
                                    WarehouseReceiptId = MyUtilities.Warehouse.Processing,
                                    ModifiedUser = HttpContext.User.Identity.Name,
                                    ModifiedDate = DateTime.Now,
                                    Status = (byte)MyUtilities.Transaction.Status.Open,
                                    Active = true,
                                    EoI = "0",
                                    MoP = false,
                                };
                                transactions.Add(transaction);
                            }

                            var productInv =
                                vfi.ProductInventories.FirstOrDefault(
                                    pi =>
                                        pi.WarehouseId == (process.WorkOrderRouting.WarehouseId ?? 0) &&
                                        pi.ProductId == process.WorkOrderRouting.ProductId &&
                                        pi.LotNumber.Equals(process.WorkOrderRouting.RoutingLot));
                            var transactionDetail = new TransactionDetail {
                                Transaction = transaction,
                                TransactionId = transaction.TransactionId,
                                ReferenceId = process.WorkOrderRouting.ProductId,
                                MoP = false,
                                Quantity = process.NGQuantity,
                                UnitMeasure = null,
                                Active = true,
                                ModifiedUser = HttpContext.User.Identity.Name,
                                ModifiedDate = DateTime.Now,
                                QuantityKg = 0,
                                ProductInvId = productInv.ProductInventoryId,
                                LotNumber = process.WorkOrderRouting.RoutingLot,
                            };
                            transaction.TransactionDetails.Add(transactionDetail);
                        }
                        if (process.DefectQuantity > 0) {
                            var transaction = transactions.FirstOrDefault(x => x.WarehouseIssueId == process.WorkOrderRouting.WarehouseId
                                && x.WarehouseReceiptId == MyUtilities.Warehouse.Defect);
                            if (transaction == null) {
                                transaction = new Transaction {
                                    TransactionCode = MyUtilities.AutoIncrease.GetParam((int)MyUtilities.AutoIncrease.IncreaseNum.Product, 1),
                                    CreatedUser = HttpContext.User.Identity.Name,
                                    CreatedDate = DateTime.Now,
                                    WarehouseIssueId = process.WorkOrderRouting.WarehouseId,
                                    WarehouseReceiptId = MyUtilities.Warehouse.Defect,
                                    ModifiedUser = HttpContext.User.Identity.Name,
                                    ModifiedDate = DateTime.Now,
                                    Status = (byte)MyUtilities.Transaction.Status.Open,
                                    Active = true,
                                    EoI = "0",
                                    MoP = false,
                                };
                                transactions.Add(transaction);
                            }

                            var productInv =
                                vfi.ProductInventories.FirstOrDefault(
                                    pi =>
                                        pi.WarehouseId == (process.WorkOrderRouting.WarehouseId ?? 0) &&
                                        pi.ProductId == process.WorkOrderRouting.ProductId &&
                                        pi.LotNumber.Equals(process.WorkOrderRouting.RoutingLot));
                            var transactionDetail = new TransactionDetail {
                                Transaction = transaction,
                                TransactionId = transaction.TransactionId,
                                ReferenceId = process.WorkOrderRouting.ProductId,
                                MoP = false,
                                Quantity = process.DefectQuantity,
                                UnitMeasure = null,
                                Active = true,
                                ModifiedUser = HttpContext.User.Identity.Name,
                                ModifiedDate = DateTime.Now,
                                QuantityKg = 0,
                                ProductInvId = productInv.ProductInventoryId,
                                LotNumber = process.WorkOrderRouting.RoutingLot,
                            };
                            transaction.TransactionDetails.Add(transactionDetail);
                        }
                    }
                    if (transactions.Any()) {
                        vfi.Transactions.AddRange(transactions);
                    }
                    saved += vfi.SaveChanges();
                }

                saved += UpdateStatusWorkOrderRoutingProduction(routingIds, false);

                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NoError, "", saved));
            }
            catch (Exception ex) {
                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.Exception, ex.Message, null));
            }
            //return Json(0);
        }
        #endregion

        #region clean

        [GridAction]
        public ActionResult SelectWorkOrderCleanManagement(string productCode, string fromDate, string toDate, byte status) {
            if (string.IsNullOrWhiteSpace(toDate)) { return View(new GridModel(new List<WorkOrderRoutingModel>())); }

            var model = new List<WorkOrderRoutingModel>();
            try {
                model = GetWorkOrderRoutingModel(
                    new RoutingConfiguration { IsPolish = true },
                    status, 0, 0, productCode, fromDate, toDate
                    );
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderCleanManagement", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult SelectWorkOrderCleanConfirmation() {
            var model = new List<WorkOrderRoutingModel>();
            try {
                model = GetWorkOrderRoutingModel(new RoutingConfiguration { IsPolish = true },
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"", "", "");
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderCleanConfirmation", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult ConfirmWorkOrderClean(int routingId) {
            if (routingId == 0) {
                return View(new GridModel(GetWorkOrderRoutingModel(new RoutingConfiguration { IsPolish = true },
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"", "", "")));
                //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NotFound, "Không tìm thấy " + routingId, null));
            }
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    if (routing == null) { throw new AggregateException("Lỗi! Không tìm thấy routing"); }
                    if (routing.Status != (byte)MyUtilities.WorkOrder.Status.Actived) {
                        throw new AggregateException("Lỗi! Công đoạn đã xác nhận.F5 lại để làm mới danh sách");
                    }
                    routing.Status = (byte)MyUtilities.WorkOrder.Status.InProcess;
                    routing.ActualStartDate = DateTime.Now;
                    vfi.SaveChanges();
                }

                try {
                    RotatePreviousWorkOrderInventory(routingId);
                }
                catch (Exception ex) {
                    ModelState.AddModelError("RotatePreviousWorkOrderInventory", ex.Message);
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("ConfirmWorkOrderClean", ex.Message);
            }
            return View(new GridModel(GetWorkOrderRoutingModel(new RoutingConfiguration { IsPolish = true },
                (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0, "", "", "")));
        }

        [GridAction]
        public ActionResult SelectWorkOrderCleanApprovement() {
            var model = new List<WorkOrderProcessModel>();
            try {
                model = GetWorkOrderProcessApprovement(new RoutingConfiguration { IsPolish = true }, (byte)MyUtilities.WorkOrder.Status.InProcess);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderCleanApprovement", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult UpdateWorkOrderCleanProcess(WorkOrderProcessModel process) {
            var model = new List<WorkOrderProcessModel>();
            try {
                using (var vfi = new tammaContext()) {
                    var entity = vfi.WorkOrderProcesses.FirstOrDefault(x => x.ProcessId == process.ProcessId);
                    if (entity == null) {
                        throw new AggregateException("Lỗi! Không tìm thấy dữ liệu");
                    }
                    if (entity.Status != (byte)MyUtilities.WorkOrder.Status.InProcess) {
                        throw new AggregateException("Lỗi! Tình trạng không cho phép sửa đổi");
                    }
                    entity.GoodQuantity = process.GoodQuantity;
                    entity.NGQuantity = process.NGQuantity;
                    entity.DefectQuantity = process.DefectQuantity;
                    entity.ModifiedDate = DateTime.Now;
                    entity.ModifiedUser = HttpContext.User.Identity.Name;
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateWorkOrderCleanProcess", ex.Message);
            }
            return View(new GridModel(GetWorkOrderProcessApprovement(
                    new RoutingConfiguration { IsPolish = true },
                    (byte)MyUtilities.WorkOrder.Status.InProcess
                    )));
        }

        [GridAction]
        public ActionResult CancelWorkOrderCleanProcess(long processId) {
            var model = new List<WorkOrderProcessModel>();
            try {
                using (var vfi = new tammaContext()) {
                    var entity = vfi.WorkOrderProcesses.FirstOrDefault(x => x.ProcessId == processId);
                    if (entity == null) {
                        throw new AggregateException("Lỗi! Không tìm thấy dữ liệu");
                    }
                    if (entity.Status != (byte)MyUtilities.WorkOrder.Status.InProcess) {
                        throw new AggregateException("Lỗi! Tình trạng không cho phép sửa đổi");
                    }
                    entity.Status = (byte)MyUtilities.WorkOrder.Status.Cancel;
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("CancelWorkOrderProcess", ex.Message);
            }
            return View(new GridModel(GetWorkOrderProcessApprovement(
                    new RoutingConfiguration { IsPolish = true },
                    (byte)MyUtilities.WorkOrder.Status.InProcess
                    )));
        }

        public ActionResult ApproveWorkOrderCleanProcess(string ids) {
            try {
                var saved = 0;
                var routingIds = new List<int>();
                using (var vfi = new tammaContext()) {
                    var checkedRecords = MyUtilities.Function.StringToBigIds(ids, ':');
                    var processes = vfi.WorkOrderProcesses.Where(x => checkedRecords.Contains(x.ProcessId));
                    routingIds = processes.Select(x => x.RoutingId).Distinct().ToList();
                    var transactions = new List<Transaction>();
                    foreach (var process in processes) {
                        var productInv =
                            vfi.ProductInventories.FirstOrDefault(
                                pi =>
                                    pi.WarehouseId == (process.WorkOrderRouting.WarehouseId ?? 0) &&
                                    pi.ProductId == process.WorkOrderRouting.ProductId &&
                                    pi.LotNumber.Equals(process.WorkOrderRouting.RoutingLot));
                        if (productInv == null) {
                            productInv = new ProductInventory {
                                WarehouseId = process.WorkOrderRouting.WarehouseId.Value,
                                ProductId = process.WorkOrderRouting.ProductId,
                                ImportDate = DateTime.Now,
                                ModifiedUser = HttpContext.User.Identity.Name,
                                ModifiedDate = DateTime.Now,
                                TotalQty = 0,
                                LotNumber = process.WorkOrderRouting.RoutingLot,
                                MachineId = process.WorkOrderRouting.MachineId,
                                MaterialInvId = process.WorkOrderRouting.MaterialInvId,
                            };
                            vfi.ProductInventories.Add(productInv);
                            vfi.SaveChanges();
                        }
                        if (process.NGQuantity > 0) {
                            var transaction = transactions.FirstOrDefault(x => x.WarehouseIssueId == process.WorkOrderRouting.WarehouseId 
                                && x.WarehouseReceiptId == MyUtilities.Warehouse.Processing);
                            if (transaction == null) {
                                transaction = new Transaction {
                                    TransactionCode = MyUtilities.AutoIncrease.GetParam((int)MyUtilities.AutoIncrease.IncreaseNum.Product, 1),
                                    CreatedUser = HttpContext.User.Identity.Name,
                                    CreatedDate = DateTime.Now,
                                    WarehouseIssueId = process.WorkOrderRouting.WarehouseId,
                                    WarehouseReceiptId = MyUtilities.Warehouse.Processing,
                                    ModifiedUser = HttpContext.User.Identity.Name,
                                    ModifiedDate = DateTime.Now,
                                    Status = (byte)MyUtilities.Transaction.Status.Open,
                                    Active = true,
                                    EoI = "0",
                                    MoP = false,
                                };
                                transactions.Add(transaction);
                            }

                            var transactionDetail = new TransactionDetail {
                                Transaction = transaction,
                                TransactionId = transaction.TransactionId,
                                ReferenceId = process.WorkOrderRouting.ProductId,
                                MoP = false,
                                Quantity = process.NGQuantity,
                                UnitMeasure = null,
                                Active = true,
                                ModifiedUser = HttpContext.User.Identity.Name,
                                ModifiedDate = DateTime.Now,
                                QuantityKg = 0,
                                ProductInvId = productInv.ProductInventoryId,
                                LotNumber = process.WorkOrderRouting.RoutingLot,
                            };
                            transaction.TransactionDetails.Add(transactionDetail);
                        }
                        if (process.DefectQuantity > 0) {
                            var transaction = transactions.FirstOrDefault(x => x.WarehouseIssueId == process.WorkOrderRouting.WarehouseId
                                && x.WarehouseReceiptId == MyUtilities.Warehouse.Defect);
                            if (transaction == null) {
                                transaction = new Transaction {
                                    TransactionCode = MyUtilities.AutoIncrease.GetParam((int)MyUtilities.AutoIncrease.IncreaseNum.Product, 1),
                                    CreatedUser = HttpContext.User.Identity.Name,
                                    CreatedDate = DateTime.Now,
                                    WarehouseIssueId = process.WorkOrderRouting.WarehouseId,
                                    WarehouseReceiptId = MyUtilities.Warehouse.Defect,
                                    ModifiedUser = HttpContext.User.Identity.Name,
                                    ModifiedDate = DateTime.Now,
                                    Status = (byte)MyUtilities.Transaction.Status.Open,
                                    Active = true,
                                    EoI = "0",
                                    MoP = false,
                                };
                                transactions.Add(transaction);
                            }
                            var transactionDetail = new TransactionDetail {
                                Transaction = transaction,
                                TransactionId = transaction.TransactionId,
                                ReferenceId = process.WorkOrderRouting.ProductId,
                                MoP = false,
                                Quantity = process.DefectQuantity,
                                UnitMeasure = null,
                                Active = true,
                                ModifiedUser = HttpContext.User.Identity.Name,
                                ModifiedDate = DateTime.Now,
                                QuantityKg = 0,
                                ProductInvId = productInv.ProductInventoryId,
                                LotNumber = process.WorkOrderRouting.RoutingLot,
                            };
                            transaction.TransactionDetails.Add(transactionDetail);
                        }

                        process.Status = (byte)MyUtilities.WorkOrder.Status.Finish;
                    }
                    if (transactions.Any()) {
                        vfi.Transactions.AddRange(transactions);
                    }
                    saved += vfi.SaveChanges();
                }

                saved += UpdateStatusWorkOrderRoutingProduction(routingIds,false);

                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NoError, "", saved));
            }
            catch (Exception ex) {
                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.Exception, ex.Message, null));
            }
            //return Json(0);
        }

        #endregion

        #region qc/qa

        [GridAction]
        public ActionResult SelectWorkOrderQCManagement(string productCode, string fromDate, string toDate, byte status) {
            if (string.IsNullOrWhiteSpace(toDate)) { return View(new GridModel(new List<WorkOrderRoutingModel>())); }

            var model = new List<WorkOrderRoutingModel>();
            try {
                model = GetWorkOrderRoutingModel(
                    new RoutingConfiguration { IsQC = true },
                    status, 0, 0, productCode, fromDate, toDate
                    );
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderQCManagement", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult SelectWorkOrderQCConfirmation() {
            var model = new List<WorkOrderRoutingModel>();
            try {
                model = GetWorkOrderRoutingModel(new RoutingConfiguration { IsQC = true }, 
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","","");
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderQCConfirmation", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult ConfirmWorkOrderQC(int routingId) {
            if (routingId == 0) {
                return View(new GridModel(GetWorkOrderRoutingModel(new RoutingConfiguration { IsQC = true }, 
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","","")));
                //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NotFound, "Không tìm thấy " + routingId, null));
            }
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    if (routing == null) { throw new AggregateException("Lỗi! Không tìm thấy routing"); }
                    if (routing.Status != (byte)MyUtilities.WorkOrder.Status.Actived) {
                        throw new AggregateException("Lỗi! Công đoạn đã xác nhận.F5 lại để làm mới danh sách");
                    }
                    routing.Status = (byte)MyUtilities.WorkOrder.Status.InProcess;
                    routing.ActualStartDate = DateTime.Now;
                    vfi.SaveChanges();
                }

                try {
                    RotatePreviousWorkOrderInventory(routingId);
                }
                catch (Exception ex) {
                    ModelState.AddModelError("RotatePreviousWorkOrderInventory", ex.Message);
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("ConfirmWorkOrderQC", ex.Message);
            }
            return View(new GridModel(GetWorkOrderRoutingModel(new RoutingConfiguration { IsQC = true }, 
                (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","","")));
        }

        [GridAction]
        public ActionResult SelectWorkOrderQCApprovement() {
            var model = new List<WorkOrderProcessModel>();
            try {
                model = GetWorkOrderProcessApprovement(new RoutingConfiguration { IsQC = true }, (byte)MyUtilities.WorkOrder.Status.InProcess);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderQCApprovement", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult UpdateWorkOrderQCProcess(WorkOrderProcessModel process) {
            var model = new List<WorkOrderProcessModel>();
            try {
                using (var vfi = new tammaContext()) {
                    var entity = vfi.WorkOrderProcesses.FirstOrDefault(x => x.ProcessId == process.ProcessId);
                    if (entity == null) {
                        throw new AggregateException("Lỗi! Không tìm thấy dữ liệu");
                    }
                    if (entity.Status != (byte)MyUtilities.WorkOrder.Status.InProcess) {
                        throw new AggregateException("Lỗi! Tình trạng không cho phép sửa đổi");
                    }
                    entity.GoodQuantity = process.GoodQuantity;
                    entity.NGQuantity = process.NGQuantity;
                    entity.DefectQuantity = process.DefectQuantity;
                    entity.ModifiedDate = DateTime.Now;
                    entity.ModifiedUser = HttpContext.User.Identity.Name;
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateWorkOrderProductionProcess", ex.Message);
            }
            return View(new GridModel(GetWorkOrderProcessApprovement(
                    new RoutingConfiguration { IsQC = true },
                    (byte)MyUtilities.WorkOrder.Status.InProcess
                    )));
        }

        [GridAction]
        public ActionResult CancelWorkOrderQCProcess(long processId) {
            var model = new List<WorkOrderProcessModel>();
            try {
                using (var vfi = new tammaContext()) {
                    var entity = vfi.WorkOrderProcesses.FirstOrDefault(x => x.ProcessId == processId);
                    if (entity == null) {
                        throw new AggregateException("Lỗi! Không tìm thấy dữ liệu");
                    }
                    if (entity.Status != (byte)MyUtilities.WorkOrder.Status.InProcess) {
                        throw new AggregateException("Lỗi! Tình trạng không cho phép sửa đổi");
                    }
                    entity.Status = (byte)MyUtilities.WorkOrder.Status.Cancel;
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("CancelWorkOrderProcess", ex.Message);
            }
            return View(new GridModel(GetWorkOrderProcessApprovement(
                    new RoutingConfiguration { IsQC = true },
                    (byte)MyUtilities.WorkOrder.Status.InProcess
                    )));
        }

        public ActionResult ApproveWorkOrderQCProcess(string ids) {
            try {
                var saved = 0;
                var routingIds = new List<int>();
                using (var vfi = new tammaContext()) {
                    var checkedRecords = MyUtilities.Function.StringToBigIds(ids, ':');
                    var processes = vfi.WorkOrderProcesses.Where(x => checkedRecords.Contains(x.ProcessId));
                    routingIds = processes.Select(x => x.RoutingId).Distinct().ToList();
                    var transactions = new List<Transaction>();
                    foreach (var process in processes) {
                        process.Status = (byte)MyUtilities.WorkOrder.Status.Finish;
                        if (process.NGQuantity > 0) {
                            var transaction = transactions.FirstOrDefault(x => x.WarehouseIssueId == process.WorkOrderRouting.WarehouseId
                                && x.WarehouseReceiptId == MyUtilities.Warehouse.Processing);
                            if (transaction == null) {
                                transaction = new Transaction {
                                    TransactionCode = MyUtilities.AutoIncrease.GetParam((int)MyUtilities.AutoIncrease.IncreaseNum.Product, 1),
                                    CreatedUser = HttpContext.User.Identity.Name,
                                    CreatedDate = DateTime.Now,
                                    WarehouseIssueId = process.WorkOrderRouting.WarehouseId,
                                    WarehouseReceiptId = MyUtilities.Warehouse.Processing,
                                    ModifiedUser = HttpContext.User.Identity.Name,
                                    ModifiedDate = DateTime.Now,
                                    Status = (byte)MyUtilities.Transaction.Status.Open,
                                    Active = true,
                                    EoI = "0",
                                    MoP = false,
                                };
                                transactions.Add(transaction);
                            }

                            var productInv =
                                vfi.ProductInventories.FirstOrDefault(
                                    pi =>
                                        pi.WarehouseId == (process.WorkOrderRouting.WarehouseId ?? 0) &&
                                        pi.ProductId == process.WorkOrderRouting.ProductId &&
                                        pi.LotNumber.Equals(process.WorkOrderRouting.RoutingLot));
                            var transactionDetail = new TransactionDetail {
                                Transaction = transaction,
                                TransactionId = transaction.TransactionId,
                                ReferenceId = process.WorkOrderRouting.ProductId,
                                MoP = false,
                                Quantity = process.NGQuantity,
                                UnitMeasure = null,
                                Active = true,
                                ModifiedUser = HttpContext.User.Identity.Name,
                                ModifiedDate = DateTime.Now,
                                QuantityKg = 0,
                                ProductInvId = productInv.ProductInventoryId,
                                LotNumber = process.WorkOrderRouting.RoutingLot,
                            };
                            transaction.TransactionDetails.Add(transactionDetail);
                        }
                        if (process.DefectQuantity > 0) {
                            var transaction = transactions.FirstOrDefault(x => x.WarehouseIssueId == process.WorkOrderRouting.WarehouseId
                                && x.WarehouseReceiptId == MyUtilities.Warehouse.Defect);
                            if (transaction == null) {
                                transaction = new Transaction {
                                    TransactionCode = MyUtilities.AutoIncrease.GetParam((int)MyUtilities.AutoIncrease.IncreaseNum.Product, 1),
                                    CreatedUser = HttpContext.User.Identity.Name,
                                    CreatedDate = DateTime.Now,
                                    WarehouseIssueId = process.WorkOrderRouting.WarehouseId,
                                    WarehouseReceiptId = MyUtilities.Warehouse.Defect,
                                    ModifiedUser = HttpContext.User.Identity.Name,
                                    ModifiedDate = DateTime.Now,
                                    Status = (byte)MyUtilities.Transaction.Status.Open,
                                    Active = true,
                                    EoI = "0",
                                    MoP = false,
                                };
                                transactions.Add(transaction);
                            }

                            var productInv =
                                vfi.ProductInventories.FirstOrDefault(
                                    pi =>
                                        pi.WarehouseId == (process.WorkOrderRouting.WarehouseId ?? 0) &&
                                        pi.ProductId == process.WorkOrderRouting.ProductId &&
                                        pi.LotNumber.Equals(process.WorkOrderRouting.RoutingLot));
                            var transactionDetail = new TransactionDetail {
                                Transaction = transaction,
                                TransactionId = transaction.TransactionId,
                                ReferenceId = process.WorkOrderRouting.ProductId,
                                MoP = false,
                                Quantity = process.DefectQuantity,
                                UnitMeasure = null,
                                Active = true,
                                ModifiedUser = HttpContext.User.Identity.Name,
                                ModifiedDate = DateTime.Now,
                                QuantityKg = 0,
                                ProductInvId = productInv.ProductInventoryId,
                                LotNumber = process.WorkOrderRouting.RoutingLot,
                            };
                            transaction.TransactionDetails.Add(transactionDetail);
                        }
                    }
                    if (transactions.Any()) {
                        vfi.Transactions.AddRange(transactions);
                    }
                    saved += vfi.SaveChanges();
                }

                saved+=UpdateStatusWorkOrderRoutingProduction(routingIds,false);

                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NoError, "", saved));
            }
            catch (Exception ex) {
                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.Exception, ex.Message, null));
            }
            //return Json(0);
        }

        #endregion

        #region packing

        [GridAction]
        public ActionResult SelectWorkOrderPackingManagement(string productCode, string fromDate, string toDate, byte status) {
            if (string.IsNullOrWhiteSpace(toDate)) { return View(new GridModel(new List<WorkOrderRoutingModel>())); }

            var model = new List<WorkOrderRoutingModel>();
            try {
                model = GetWorkOrderRoutingModel(
                    new RoutingConfiguration { IsPacking = true },
                    status, 0, 0, productCode, fromDate, toDate
                    );
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderPackingManagement", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult SelectWorkOrderPackingProcess(int routingId, double productWeight, double packageWeight, double quantity) {
            if (routingId == 0) {
                return View(new GridModel(new List<WorkOrderRoutingModel>()));
            }
            var model = (List<WorkOrderRoutingModel>)Session["SessionPackingProcesses"];
            try {
                if (model == null || !model.Any()) {
                    model = new List<WorkOrderRoutingModel>();
                }
                else if (!model.Any(x => x.RoutingId == routingId)) {
                    model = new List<WorkOrderRoutingModel>(); // clean when change routing
                }
                using (var vfi = new tammaContext()) {
                    var routingModel = GetWorkOrderRoutingModel(null, 0, 0, routingId,"", "", "").FirstOrDefault();
                    var waitingQuantity = 0.0;
                    var waitingProcesses = vfi.WorkOrderProcesses.Where(x => x.RoutingId == routingId
                                                                    && x.Status != (byte)MyUtilities.WorkOrder.Status.Cancel
                                                                    && x.Status != (byte)MyUtilities.WorkOrder.Status.Finish).ToList();
                    if (waitingProcesses.Any()) {
                        waitingQuantity = waitingProcesses.Sum(x => x.UsingQuantity);
                    }
                    var entity = new WorkOrderRoutingModel {
                        RoutingId = routingId,
                        ProductWeight = productWeight,
                        GoodWeight = packageWeight,
                        GoodQuantity = quantity,
                        PreviousRouteQuantity = routingModel.PreviousRouteQuantity - waitingQuantity
                    };
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    var packingInfo = routing.Product.ProductionFuels.FirstOrDefault(x => x.Active);
                    if (packingInfo != null) {
                        entity.PlannedCost = packingInfo.Quota2;
                        entity.PlannedWeight = packingInfo.CrossWeight2;
                    }
                    if (entity.GoodQuantity == 0) {
                        entity.GoodQuantity = entity.GoodWeight / entity.ProductWeight;
                    }
                    else if (entity.GoodWeight == 0) {
                        entity.GoodWeight = entity.GoodQuantity * entity.ProductWeight;
                    }
                    else {
                        entity.GoodQuantity = entity.PlannedCost;
                        entity.GoodWeight = entity.PlannedWeight;
                    }
                    entity.UsingQuantity = quantity;
                    entity.UsingWeight = entity.UsingQuantity * entity.ProductWeight;

                    entity.RequireQuantity = entity.PreviousRouteQuantity - model.Sum(x => x.UsingQuantity);
                    //if (entity.RequireQuantity > entity.PlannedCost) { }
                    if (entity.RequireQuantity > 0) {
                        if (entity.UsingQuantity > entity.RequireQuantity) {
                            entity.GoodQuantity = entity.RequireQuantity;
                            entity.NGQuantity = entity.UsingQuantity - entity.RequireQuantity;
                        }
                    }
                    else {
                        entity.GoodQuantity = 0;
                        entity.NGQuantity = entity.UsingQuantity;
                    }
                    if (entity.UsingQuantity > 0)
                        model.Add(entity);
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderPackingProcess", ex.Message);
            }
            Session["SessionPackingProcesses"] = model;
            return View(new GridModel(model));
        }

        public ActionResult ImportWorkOrderPackingProcess(
            int routingId, int employeeId, double productWeight,
            double destroyQuantity
        ) {
            try {
                var saved = 0;
                var model = (List<WorkOrderRoutingModel>)Session["SessionPackingProcesses"];
                if (model == null || !model.Any()) {
                    return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NoThing, "Danh sách trống", saved));
                }
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    if (model.Any(x => x.NGQuantity > 0) && destroyQuantity != 0) {
                        throw new AggregateException("Lỗi! Cân hàng không thể vừa có nhập thêm vừa có xuất hủy");
                    }
                    var usingQuantity = model.Sum(x => x.GoodQuantity) + destroyQuantity;
                    if (usingQuantity != routing.PlannedCost) {
                        throw new AggregateException("Lỗi! Số lượng cân hàng không đúng với số lượng hàng đã nhận");
                    }

                    for (var i = 0; i < model.Count; i++) {
                        var import = model[i];
                        var process = new WorkOrderProcess {
                            RoutingId = routingId,
                            EmployeeId = employeeId,
                            //UsingQuantity = import.UsingQuantity + import.NGQuantity - import.DefectQuantity,
                            GoodQuantity = import.GoodQuantity,
                            NGQuantity = import.NGQuantity,
                            //DefectQuantity = import.DefectQuantity,
                            Date = DateTime.Now,
                            ModifiedDate = DateTime.Now,
                            ModifiedUser = HttpContext.User.Identity.Name,
                            Status = (byte)MyUtilities.WorkOrder.Status.InProcess,
                            UnitWeight = productWeight,
                        };
                        if (i == model.Count - 1) {
                            process.DefectQuantity = destroyQuantity * -1;
                        }
                        process.UsingQuantity = process.GoodQuantity + Math.Abs(process.DefectQuantity);
                        routing.WorkOrderProcesses.Add(process);
                    }

                    routing.Status = (byte)MyUtilities.WorkOrder.Status.InProcess;
                    saved += vfi.SaveChanges();
                    Session["SessionPackingProcesses"] = new List<WorkOrderRoutingModel>();
                    return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NoError, "", saved));
                }
            }
            catch (Exception ex) {
                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.Exception, ex.Message, null));
            }
        }

        [GridAction]
        public ActionResult SelectWorkOrderPackingConfirmation() {
            var model = new List<WorkOrderRoutingModel>();
            try {
                model = GetWorkOrderRoutingModel(new RoutingConfiguration { IsPacking = true }, 
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","","");
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderPackingConfirmation", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult ConfirmWorkOrderPacking(int routingId) {
            if (routingId == 0) {
                return View(new GridModel(GetWorkOrderRoutingModel(new RoutingConfiguration { IsPacking = true },
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0, "", "", "")));
                //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NotFound, "Không tìm thấy " + routingId, null));
            }
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    if (routing == null) { throw new AggregateException("Lỗi! Không tìm thấy routing"); }
                    if (routing.Status != (byte)MyUtilities.WorkOrder.Status.Actived) {
                        throw new AggregateException("Lỗi! Công đoạn đã xác nhận.F5 lại để làm mới danh sách");
                    }
                    routing.Status = (byte)MyUtilities.WorkOrder.Status.InProcess;
                    routing.ActualStartDate = DateTime.Now;
                    vfi.SaveChanges();
                }

                try {
                    RotatePreviousWorkOrderInventory(routingId);
                }
                catch (Exception ex) {
                    ModelState.AddModelError("RotatePreviousWorkOrderInventory", ex.Message);
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("ConfirmWorkOrderPacking", ex.Message);
            }
            return View(new GridModel(GetWorkOrderRoutingModel(new RoutingConfiguration { IsPacking = true },
                (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0, "", "", "")));
        }

        [GridAction]
        public ActionResult SelectWorkOrderPackingApprovement() {
            var model = new List<WorkOrderProcessModel>();
            try {
                model = GetWorkOrderProcessApprovement(new RoutingConfiguration { IsPacking = true }, 
                    (byte)MyUtilities.WorkOrder.Status.InProcess);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderPackingApprovement", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult UpdateWorkOrderPackingProcess(WorkOrderProcessModel process) {
            var model = new List<WorkOrderProcessModel>();
            try {
                using (var vfi = new tammaContext()) {
                    var entity = vfi.WorkOrderProcesses.FirstOrDefault(x => x.ProcessId == process.ProcessId);
                    if (entity == null) {
                        throw new AggregateException("Lỗi! Không tìm thấy dữ liệu");
                    }
                    if (entity.Status != (byte)MyUtilities.WorkOrder.Status.InProcess) {
                        throw new AggregateException("Lỗi! Tình trạng không cho phép sửa đổi");
                    }
                    entity.GoodQuantity = process.GoodQuantity;
                    entity.NGQuantity = process.NGQuantity;
                    entity.DefectQuantity = process.DefectQuantity;
                    entity.ModifiedDate = DateTime.Now;
                    entity.ModifiedUser = HttpContext.User.Identity.Name;
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("UpdateWorkOrderProductionProcess", ex.Message);
            }
            return View(new GridModel(GetWorkOrderProcessApprovement(
                    new RoutingConfiguration { IsPacking = true },
                    (byte)MyUtilities.WorkOrder.Status.InProcess
                    )));
        }
		
        [GridAction]
        public ActionResult CancelWorkOrderPackingProcess(long processId) {
            var model = new List<WorkOrderProcessModel>();
            try {
                using (var vfi = new tammaContext()) {
                    var entity = vfi.WorkOrderProcesses.FirstOrDefault(x => x.ProcessId == processId);
                    if (entity == null) {
                        throw new AggregateException("Lỗi! Không tìm thấy dữ liệu");
                    }
                    if (entity.Status != (byte)MyUtilities.WorkOrder.Status.InProcess) {
                        throw new AggregateException("Lỗi! Tình trạng không cho phép sửa đổi");
                    }
                    entity.Status = (byte)MyUtilities.WorkOrder.Status.Cancel;
                    vfi.SaveChanges();
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("CancelWorkOrderProcess", ex.Message);
            }
            return View(new GridModel(GetWorkOrderProcessApprovement(
                    new RoutingConfiguration { IsPacking = true },
                    (byte)MyUtilities.WorkOrder.Status.InProcess
                    )));
        }

        public ActionResult ApproveWorkOrderPackingProcess(string ids) {
            try {
                var saved = 0;
                var routingIds = new List<int>();
                using (var vfi = new tammaContext()) {
                    var checkedRecords = MyUtilities.Function.StringToBigIds(ids, ':');
                    var processes = vfi.WorkOrderProcesses.Where(x => checkedRecords.Contains(x.ProcessId));
                    routingIds = processes.Select(x => x.RoutingId).Distinct().ToList();
                    foreach (var process in processes) {
                        process.Status = (byte)MyUtilities.WorkOrder.Status.Finish;
                    }
                    saved = vfi.SaveChanges();
                }

                //saved +=this.transactionController.inventory

                saved += UpdateStatusWorkOrderRoutingProduction(routingIds, false);

                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NoError, "", saved));

            }
            catch (Exception ex) {
                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.Exception, ex.Message, null));
            }
            //return Json(0);
        }
        #endregion
        
        #region finish

        [GridAction]
        public ActionResult SelectWorkOrderFinishConfirmation() {
            var model = new List<WorkOrderRoutingModel>();
            try {
                model = GetWorkOrderRoutingModel(new RoutingConfiguration { IsFinish = true }, 
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","","");
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderFinishConfirmation", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult ConfirmWorkOrderFinish(int routingId) {
            if (routingId == 0) {
                return View(new GridModel(GetWorkOrderRoutingModel(new RoutingConfiguration { IsFinish = true }, 
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","","")));
                //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NotFound, "Không tìm thấy " + routingId, null));
            }
            var workOrderId = 0;
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    if (routing == null) { throw new AggregateException("Lỗi! Không tìm thấy routing"); }
                    if (routing.Status != (byte)MyUtilities.WorkOrder.Status.Actived) {
                        throw new AggregateException("Lỗi! Công đoạn đã xác nhận.F5 lại để làm mới danh sách");
                    }
                    routing.Status = (byte)MyUtilities.WorkOrder.Status.Finish;
                    routing.ActualCost = routing.PlannedCost;
                    routing.ActualStartDate = DateTime.Now;
                    routing.ActualEndDate = DateTime.Now;
                    workOrderId = routing.WorkOrderId;
                    vfi.SaveChanges();
                }
                try{ 
                    RotateFinishWorkOrderInventory(routingId);
                }
                catch (Exception ex) {
                    ModelState.AddModelError("RotateFinishWorkOrderInventory", ex.Message);
                }
                try {
                    FinishWorkOrder(workOrderId);
                }
                catch (Exception ex) {
                    ModelState.AddModelError("FinishWorkOrder", ex.Message);
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("ConfirmWorkOrderFinish", ex.Message);
            }
            return View(new GridModel(GetWorkOrderRoutingModel(new RoutingConfiguration { IsFinish = true }, 
                (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","","")));
        }

        public int RotateFinishWorkOrderInventory(int routingId) {
            var saved = 0;
            try {
                var transactions = new List<Transaction>();
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    var previousRoute = routing.WorkOrderRouting1.FirstOrDefault();
                    if (previousRoute == null || previousRoute.ActualCost == 0) return saved;
                    // case VFDN không có kho đóng gói
                    // 1. nhập thêm
                    var productInv = vfi.ProductInventories.FirstOrDefault(
                                    pi =>
                                        pi.WarehouseId == (previousRoute.WarehouseId ?? 0) &&
                                        pi.ProductId == routing.ProductId &&
                                        pi.LotNumber.Equals(routing.RoutingLot));
                    if (previousRoute.Warehouse.IsPacking) {
                        var importQuantity = previousRoute.WorkOrderProcesses
                            .Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.Finish && x.NGQuantity > 0)
                            .Sum(x => x.NGQuantity);
                        if (importQuantity > 0) {
                            var transaction = new Transaction {
                                TransactionCode = MyUtilities.AutoIncrease.GetParam((int)MyUtilities.AutoIncrease.IncreaseNum.Product, 1),
                                CreatedUser = HttpContext.User.Identity.Name,
                                CreatedDate = DateTime.Now,
                                WarehouseIssueId = null,
                                WarehouseReceiptId = previousRoute.WarehouseId,
                                ModifiedUser = HttpContext.User.Identity.Name,
                                ModifiedDate = DateTime.Now,
                                Status = (byte)MyUtilities.Transaction.Status.Open,
                                Active = true,
                                EoI = "0",
                                MoP = false,
                                ReferenceId = routing.RoutingId,
                                Description = routing.WorkOrder.SerialNumber + "-" + routing.RoutingName,
                            };
                            var detail = new TransactionDetail {
                                ReferenceId = routing.ProductId,
                                MoP = false,
                                Quantity = importQuantity,
                                UnitMeasure = null,
                                Active = true,
                                ModifiedUser = HttpContext.User.Identity.Name,
                                ModifiedDate = DateTime.Now,
                                QuantityKg = 0,
                                Note = transaction.Description,
                                LotNumber = routing.RoutingLot,
                                MachineId = previousRoute.MachineId
                            };
                            transaction.TransactionDetails.Add(detail);
                            transactions.Add(transaction);
                        }
                        if (productInv == null) {
                            productInv = new ProductInventory {
                                WarehouseId = previousRoute.WarehouseId.Value,
                                ProductId = routing.ProductId,
                                ImportDate = DateTime.Now,
                                ModifiedUser = HttpContext.User.Identity.Name,
                                ModifiedDate = DateTime.Now,
                                TotalQty = 0,
                                LotNumber = routing.RoutingLot,
                                MachineId = routing.MachineId,
                                MaterialInvId = routing.MaterialInvId,
                            };
                            vfi.ProductInventories.Add(productInv);
                        }

                        // 2. xuất hủy
                        var destroyQuantity = previousRoute.WorkOrderProcesses.Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.Finish
                             && x.DefectQuantity != 0)
                             .Sum(x => x.DefectQuantity);
                        if (destroyQuantity != 0) {
                            destroyQuantity = Math.Abs(destroyQuantity);
                            var transaction = new Transaction {
                                TransactionCode = MyUtilities.AutoIncrease.GetParam((int)MyUtilities.AutoIncrease.IncreaseNum.Product, 1),
                                CreatedUser = HttpContext.User.Identity.Name,
                                CreatedDate = DateTime.Now,
                                WarehouseIssueId = previousRoute.WarehouseId,
                                WarehouseReceiptId = MyUtilities.Warehouse.Destroy,
                                ModifiedUser = HttpContext.User.Identity.Name,
                                ModifiedDate = DateTime.Now,
                                Status = (byte)MyUtilities.Transaction.Status.Open,
                                Active = true,
                                EoI = "0",
                                MoP = false,
                                ReferenceId = routing.RoutingId,
                                Description = routing.WorkOrder.SerialNumber + "-" + routing.RoutingName,
                            };
                            var detail = new TransactionDetail {
                                ReferenceId = routing.ProductId,
                                MoP = false,
                                Quantity = destroyQuantity,
                                UnitMeasure = null,
                                Active = true,
                                ModifiedUser = HttpContext.User.Identity.Name,
                                ModifiedDate = DateTime.Now,
                                QuantityKg = 0,
                                Note = transaction.Description,
                                LotNumber = routing.RoutingLot,
                                MachineId = previousRoute.MachineId,
                                ProductInventory = productInv
                            };
                            transaction.TransactionDetails.Add(detail);
                            transactions.Add(transaction);
                        }
                    }
                    // 3. chuyển tồn kho
                    {
                        var transaction = new Transaction {
                            TransactionCode = MyUtilities.AutoIncrease.GetParam((int)MyUtilities.AutoIncrease.IncreaseNum.Product, 1),
                            CreatedUser = HttpContext.User.Identity.Name,
                            CreatedDate = DateTime.Now,
                            WarehouseIssueId = previousRoute.WarehouseId,
                            WarehouseReceiptId = routing.WarehouseId,
                            ModifiedUser = HttpContext.User.Identity.Name,
                            ModifiedDate = DateTime.Now,
                            Status = (byte)MyUtilities.Transaction.Status.Open,
                            Active = true,
                            EoI = "0",
                            MoP = false,
                            ReferenceId = routing.RoutingId,
                            Description = routing.WorkOrder.SerialNumber + "-" + routing.RoutingName,
                        };
                        var detail = new TransactionDetail {
                            ReferenceId = routing.ProductId,
                            MoP = false,
                            Quantity = routing.PlannedCost,
                            UnitMeasure = null,
                            Active = true,
                            ModifiedUser = HttpContext.User.Identity.Name,
                            ModifiedDate = DateTime.Now,
                            QuantityKg = 0,
                            Note = transaction.Description,
                            LotNumber = routing.RoutingLot,
                            MachineId = previousRoute.MachineId,
                            ProductInventory = productInv
                        };
                        transaction.TransactionDetails.Add(detail);
                        transactions.Add(transaction);
                    }
                    vfi.Transactions.AddRange(transactions);
                    saved += vfi.SaveChanges();
                }
                try {
                    foreach (var transaction in transactions) {
                        saved += transactionController.UpdateProductInvByTransaction(transaction.TransactionId, HttpContext.User.Identity.Name);
                    }
                }
                catch (Exception ex) { ModelState.AddModelError("transaction inventory errror", ex.Message); }
            }
            catch (Exception ex) { ModelState.AddModelError("transaction rotate finish errror", ex.Message); }
            return saved;
        }

        public void FinishWorkOrder(int workOrderId) {
            using (var vfi = new tammaContext()) {
                var workOrder = vfi.WorkOrders.FirstOrDefault(x => x.WorkOrderId == workOrderId);
                workOrder.Status = (byte)MyUtilities.WorkOrder.Status.Finish;
                workOrder.EndDate = DateTime.Now;
                vfi.SaveChanges();
            }
        }
        #endregion
        
        #region combobox

        public ActionResult SelectComboBoxWorkOrderActiveStatus() {
            return new JsonResult {
                Data = new SelectList(MyUtilities.WorkOrder.ActivatedStatusModel, "Value", "Text")
            };
        }

        public ActionResult SelectComboBoxWorkOrderStatus() {
            var val = from MyUtilities.WorkOrder.Status stt in Enum.GetValues(typeof(MyUtilities.WorkOrder.Status))
                      select new {
                          Value = (int)Enum.Parse(typeof(MyUtilities.WorkOrder.Status), stt.ToString()),
                          Text = MyUtilities.WorkOrder.GetText((int)Enum.Parse(typeof(MyUtilities.WorkOrder.Status), stt.ToString()))
                      };

            return new JsonResult {
                Data = new SelectList(val, "Value", "Text")
            };
        }

        public ActionResult SelectComboBoxWorkOrderRoute(int workOrderId) {
            var model = new List<WorkOrderRoutingModel>();
            using (var vfi = new tammaContext()) {
                var workOrder = vfi.WorkOrders.FirstOrDefault(x => x.WorkOrderId == workOrderId);
                if (workOrder == null) return new JsonResult { };
                var productProcesses = (from x in vfi.ProductionProcesses
                                        where x.ProductId == workOrder.ProductId && x.IsAlert && x.IsNecessary
                                        && !x.Warehouse.IsProduction && !x.Warehouse.IsFinish
                                        orderby x.ProcessIndex
                                        select new { 
                                            x.ProcessIndex, 
                                            x.WarehouseId,
                                            x.Warehouse.IsProduction2,
                                            x.Warehouse.WarehouseName,
                                            x.Warehouse.ShortName,
                                        }).ToList();
                var productionSections = vfi.ProductionSections.Where(x => x.Active && x.ProductId == workOrder.ProductId)
                    .OrderBy(x => x.SectionIndex)
                    .Select(x => new { x.ProductionSectionId, x.Section.SectionName })
                    .ToList();
                foreach (var process in productProcesses) {
                    if (process.IsProduction2) {
                        foreach (var section in productionSections) {
                            model.Add(new WorkOrderRoutingModel {
                                WarehouseName = process.WarehouseId + "|" + section.ProductionSectionId,
                                RoutingName = process.ShortName + ": " + section.SectionName
                            });
                        }
                    }
                    else {
                        model.Add(new WorkOrderRoutingModel {
                            WarehouseName = process.WarehouseId + "",
                            RoutingName = process.WarehouseName,
                        });
                    }
                }
            }
            return new JsonResult {
                Data = new SelectList(model, "WarehouseName", "RoutingName")
            };
        }


        public List<WorkOrderRoutingModel> GetComboBoxWorkOrderRoutingModel(RoutingConfiguration config) {
            var model = new List<WorkOrderRoutingModel>();
            try {
                using (var vfi = new tammaContext()) {
                    model = (from x in vfi.WorkOrderRoutings
                             where (config.IsProduction == null || (x.WarehouseId != null && x.Warehouse.IsProduction))
                             && (config.IsProduction2 == null || (x.WarehouseId != null && x.Warehouse.IsProduction2))
                             && (config.IsQC == null || (x.WarehouseId != null && x.Warehouse.IsQC))
                             && (config.IsPacking == null || (x.WarehouseId != null && x.Warehouse.IsPacking))
                             && (config.IsPolish == null || (x.WarehouseId != null && x.Warehouse.IsPolish))
                             && (config.IsFinish == null || (x.WarehouseId != null && x.Warehouse.IsFinish))
                             select new WorkOrderRoutingModel {
                                 RoutingId = x.RoutingId,
                                 Status = x.Status,
                                 RoutingName = x.RoutingName,
                                 SerialNumber = x.WorkOrder.SerialNumber,
                                 ProductCode = x.Product.ProductCode,
                                 //PlannedCost = x.PlannedCost,
                                 //UsingQuantity = x.WorkOrderProcesses.Where(y => y.Status != (byte)MyUtilities.WorkOrder.Status.Cancel)
                                 //               .ToList()
                                 //               .Sum(y => y.UsingQuantity)
                             }).ToList();
                    //model = model.Where(x => x.UsingQuantity < x.PlannedCost).ToList();
                }
            }
            catch (Exception ex) { ModelState.AddModelError("GetComboBoxWorkOrderRoutingModel", ex.Message); }
            return model;
        }

        public ActionResult SelectComboBoxWorkOrderRouting() {
            using (var vfi = new vfiContext()) {
                return new JsonResult {
                    Data = new SelectList(GetComboBoxWorkOrderRoutingModel(
                        new RoutingConfiguration { Status = (byte)MyUtilities.WorkOrder.Status.InProcess }),
                        "RoutingId", "RoutingFullName")
                };
            }
        }

        public ActionResult SelectComboBoxWorkOrderProduction1Routing() {
            using (var vfi = new vfiContext()) {
                var model = GetComboBoxWorkOrderRoutingModel(
                        new RoutingConfiguration {
                            IsProduction = true
                        });
                model = model.Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.Actived
                    || x.Status == (byte)MyUtilities.WorkOrder.Status.InProcess).ToList();

                return new JsonResult { Data = new SelectList(model, "RoutingId", "RoutingFullName") };
            }
        }

        public ActionResult SelectComboBoxWorkOrderProduction2Routing() {
            using (var vfi = new vfiContext()) {
                var model = GetComboBoxWorkOrderRoutingModel(
                        new RoutingConfiguration {
                            IsProduction2 = true
                        });
                model = model.Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.InProcess).ToList();

                return new JsonResult { Data = new SelectList(model, "RoutingId", "RoutingFullName") };
            }
        }

        public ActionResult SelectComboBoxWorkOrderCleanRouting() {
            using (var vfi = new vfiContext()) {
                var model = GetComboBoxWorkOrderRoutingModel(
                        new RoutingConfiguration {
                            IsPolish = true
                        });
                model = model.Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.InProcess).ToList();

                return new JsonResult { Data = new SelectList(model, "RoutingId", "RoutingFullName") };
            }
        }

        public ActionResult SelectComboBoxWorkOrderQCRouting() {
            using (var vfi = new vfiContext()) {
                var model = GetComboBoxWorkOrderRoutingModel(
                        new RoutingConfiguration {
                            IsQC = true
                        });
                model = model.Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.InProcess).ToList();

                return new JsonResult { Data = new SelectList(model, "RoutingId", "RoutingFullName") };
            }
        }

        public ActionResult SelectComboBoxWorkOrderPackingRouting() {
            using (var vfi = new vfiContext()) {
                var model = GetComboBoxWorkOrderRoutingModel(
                        new RoutingConfiguration {
                            IsPacking = true
                        });
                model = model.Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.InProcess).ToList();

                return new JsonResult { Data = new SelectList(model, "RoutingId", "RoutingFullName") };
            }
        }

        public ActionResult CheckWorkOrderRoutingInfo(int routingId) {
            if (routingId == 0) {
                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.ReferenceError, "Lỗi! Chọn lại work order", null));
            }
            var entity = new WorkOrderRoutingModel { };
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    if (routing == null) {
                        return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NotFound, "Không tìm thấy " + routingId, routingId));
                    }
                    var model = GetWorkOrderRoutingModel(null, 0, 0, routingId,"", "", "");
                    if (model.Any()) {
                        entity = model.FirstOrDefault();
                    }
                    if (routing.Warehouse.IsPacking && routing.Product.ProductionFuels.Any(x => x.Active)) {
                        entity.PackingInfo = (from x in vfi.ProductionFuels
                                              where x.ProductId == routing.ProductId
                                              && x.Active
                                              orderby x.Priority
                                              select new ProductionFuelModel {
                                                  FuelFullCode = x.Fuel1.FuelFullCode,
                                                  Quota = x.Quota2,
                                                  CrossWeight = x.Quota2 * (x.Product.QcWeight ?? 0)
                                              }).FirstOrDefault();
                    }
                    return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NoError, "", entity));
                }
            }
            catch (Exception ex) {
                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.Exception, ex.Message, entity));
            }
            //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NotImplement, "", entity));
        }

        #endregion

    }
}
