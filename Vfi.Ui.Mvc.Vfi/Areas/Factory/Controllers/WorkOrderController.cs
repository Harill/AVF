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
                var workOrders = vfi.WorkOrders.Where(x => checkedRecords.Contains(x.WorkOrderId));
                if (workOrders.Any()) {
                    var workOrder = workOrders.FirstOrDefault();
                    entity = new EditWorkOrderModel {
                        WorkOrderIds = checkedRecords,
                        Ids = ids,
                        ProductId = workOrder.ProductId,
                        ProductCode = workOrder.Product.ProductCode,
                        MaterialId = workOrder.Product.MaterialId ?? 0,
                        OrderNumber = workOrder.OrderDetail.Order.OrderNumber,
                        DueDate = workOrder.OrderDetail.Order.DueDate.Value,
                        CustomerCode = workOrder.OrderDetail.Order.Customer.CustomerCode,
                        List = workOrders.Select(x => new EditWorkOrderDetail {
                            WorkOrderId = x.WorkOrderId,
                            SerialNumber = x.SerialNumber,
                            Quantity = x.OrderQty
                        }).ToList(),
                        SerialNumber = string.Join("+", workOrders.Select(x => x.SerialNumber)),
                        Quantity = workOrders.Sum(x => x.OrderQty),
                        Info = new WorkOrderProductionInfo {
                            NS = workOrder.Product.Productivity ?? 0,
                            DM = workOrder.Product.ProductionRate ?? 0,
                            DC = workOrder.Product.KnifeCut ?? 0,
                            CDSP = workOrder.Product.Length ?? 0,
                            PD = 300
                        },
                    };
                }
            }
            return View(entity);
        }

        public ActionResult WorkOrderMaterialAssignment() {
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
            return View();
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
        #endregion

        #region Work Order Management
        public List<WorkOrderModel> CalculateWorkOrderFromOrder(int orderId, long orderDetailId) {
            var model = new List<WorkOrderModel>();
            using (var vfi = new tammaContext()) {
                var orderDetails = vfi.OrderDetails.Where(x => x.OrderId == orderId || x.OrderDetailId == orderDetailId);
                var productIds = orderDetails.Select(x => x.ProductId).Distinct().ToList();
                var products = vfi.Products.Where(x => productIds.Contains(x.ProductId)).ToList();
                var workOrderTolerance = MyUtilities.Monitor.GetParameterValue(MyUtilities.Monitor.WorkOrderTolerance);
                foreach (var orderDetail in orderDetails) {
                    var maxOrderQuantity = MyUtilities.Function.RoundUp(orderDetail.OrderQty.Value * (1 + workOrderTolerance / 100));
                    var product = products.FirstOrDefault(x => x.ProductId == orderDetail.ProductId);
                    if ((product.ProductionRate ?? 0) == 0) { continue; } // bỏ qua data lỗi
                    var maxTray = 1;
                    if (product.MaxQuantityInTray > 0) {
                        maxTray = MyUtilities.Function.RoundUp((double)maxOrderQuantity / product.MaxQuantityInTray);
                    }
                    var maxMaterial = MyUtilities.Function.RoundDown(product.MaxQuantityInTray / (product.ProductionRate ?? 1));
                    if (maxMaterial <= 0) maxMaterial = 1;
                    // tray index 1 -> n-1
                    //var index = 0;
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

                var scheduleDate = order.OrderDate.AddDays(1);
                foreach (var entity in list) {
                    var lastWorkOrder = vfi.WorkOrders.Where(x => x.Status !=(byte) MyUtilities.WorkOrder.Status.Cancel 
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
        public ActionResult SelectActivateWorkOrder() {
            var model = new List<ActivateWorkOrderModel>();
            try {
                model = GetActivateWorkOrderByOrder();
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectActivateWorkOrder", ex.Message);
            }

            return View(new GridModel(model));
        }

        public List<ActivateWorkOrderModel> GetActivateWorkOrderByOrder() {
            var model = new List<ActivateWorkOrderModel>();

            using (var vfi = new tammaContext()) {
                var orderDetails = (from x in vfi.OrderDetails
                                    where x.WorkOrders.Any(y => y.Status == (byte)MyUtilities.WorkOrder.Status.Pending
                                        || y.Status == (byte)MyUtilities.WorkOrder.Status.InProcess)
                                    select x).ToList();
                //var workOrders = vfi.WorkOrders.Where(x => orderDetailIds.Contains(x.OrderDetailId)).ToList();
                foreach (var orderDetail in orderDetails) {
                    var runningWorkOrders = orderDetail.WorkOrders.ToList();
                    var entity = new ActivateWorkOrderModel {
                        OrderDetailId = orderDetail.OrderDetailId,
                        ProductCode = orderDetail.Product.ProductCode,
                        DueDate = orderDetail.Order.DueDate.Value,
                        OrderNumber = orderDetail.Order.OrderNumber,
                        OrderQuantity = orderDetail.OrderQty ?? 0,
                        WorkOrderQuantity = runningWorkOrders.Sum(x => x.OrderQty),
                        WorkOrderCount = runningWorkOrders.Count,
                    };
                    model.Add(entity);
                }
            }

            return model;
        }



        [GridAction]
        public ActionResult SelectWorkOrders(long orderDetailId) {
            var model = new List<WorkOrderModel>();
            try {
                model = GetWorkOrders(orderDetailId);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrder", ex.Message);
            }

            return View(new GridModel(model));
        }

        List<WorkOrderModel> GetWorkOrders(long orderDetailId) {
            var model = new List<WorkOrderModel>();

            using (var vfi = new tammaContext()) {
                var workOrders = from x in vfi.WorkOrders
                                 where x.OrderDetailId == orderDetailId
                                 orderby x.Status
                                 select x;
                foreach (var workOrder in workOrders) {
                    var entity = new WorkOrderModel {
                        WorkOrderId = workOrder.WorkOrderId,
                        SerialNumber = workOrder.SerialNumber,

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
                    entity.CanCancel = entity.Status <= (byte)MyUtilities.WorkOrder.Status.Actived;
                    if (workOrder.WorkOrderRoutings.Any()) {
                        var finishRoutes = workOrder.WorkOrderRoutings
                            .Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.Finish);
                        if (finishRoutes.Any()) {
                            entity.GoodQuantity = finishRoutes.OrderByDescending(x => x.RoutingIndex).FirstOrDefault().ActualCost;
                            entity.NGQuantity = finishRoutes.Sum(x =>
                                x.WorkOrderProcesses.Where(y => y.Status == (byte)MyUtilities.WorkOrder.Status.Finish)
                                .Sum(y => y.NGQuantity));
                            entity.DefectQuantity = finishRoutes.Sum(x =>
                                x.WorkOrderProcesses.Where(y => y.Status == (byte)MyUtilities.WorkOrder.Status.Finish)
                                .Sum(y => y.DefectQuantity));
                        }
                        if (workOrder.Status == (byte)MyUtilities.WorkOrder.Status.Actived) {
                            var lastProcesRoute = workOrder.WorkOrderRoutings
                                .Where(x => x.Status != (byte)MyUtilities.WorkOrder.Status.Finish
                                        && x.Status != (byte)MyUtilities.WorkOrder.Status.Pending
                                        && x.Status != (byte)MyUtilities.WorkOrder.Status.Cancel)
                                .OrderBy(x=> x.RoutingIndex)
                                .FirstOrDefault();
                            if (lastProcesRoute != null) {
                                entity.RoutingName = lastProcesRoute.RoutingName;
                            }

                        }
                    }
                    model.Add(entity);
                }
            }

            return model;
        }


        [GridAction]
        public ActionResult DeleteWorkOrder(int workOrderId) {
            var model = new List<WorkOrderModel>();
            try {
                long orderDetailId = 0;
                using (var vfi = new tammaContext()) {
                    var workOrder = vfi.WorkOrders.FirstOrDefault(x => x.WorkOrderId == workOrderId);
                    if (workOrder == null) {
                        throw new AggregateException("Lỗi! Không tìm thấy data");
                    }
                    if (workOrder.Status > (byte)MyUtilities.WorkOrder.Status.Actived) {
                        throw new AggregateException("Lỗi! Tình trạng Work order không thể hủy");
                    }
                    workOrder.Status = (byte)MyUtilities.WorkOrder.Status.Cancel;
                    vfi.SaveChanges();
                    orderDetailId = workOrder.OrderDetailId;
                }
                model = GetWorkOrders(orderDetailId);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrder", ex.Message);
            }

            return View(new GridModel(model));
        }
        
        [GridAction]
        public ActionResult SelectWorkOrderRouting(string ids) {
            var model = new List<WorkOrderRoutingModel>();
            try {
                var checkedRecords = MyUtilities.Function.StringToIds(ids, ':');
                using (var vfi = new tammaContext()) {

                    var workOrder = vfi.WorkOrders.FirstOrDefault(x => checkedRecords.Contains(x.WorkOrderId));
                    model = workOrder.WorkOrderRoutings.Select(x => new WorkOrderRoutingModel {
                        RoutingName = x.RoutingName,
                        WarehouseId = x.WarehouseId ?? 0,
                        PlannedCost = x.PlannedCost,
                        MoreInfo = x.MoreInfo,
                        RoutingIndex = x.RoutingIndex,
                        ActualResourceHrs = x.ActualResourceHrs,
                    }).ToList();
                }
                model = model.OrderBy(x => x.RoutingIndex).ToList();
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderRouting", ex.Message);
            }
            return View(new GridModel(model));
        }

        public ActionResult SaveEditWorkOrders(
            string ids, int materialInvId, int machineId,
            double productivity, int productionRate, double knifeCut, int workPiece,
            bool isActive) {

            //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NoError, ids, 0));
            var saved = 0;
            try {
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
                    if (materialInv == null) { }
                    track.MaterialId = materialInv.MaterialId;
                    var workOrders = vfi.WorkOrders.Where(x => checkedRecords.Contains(x.WorkOrderId));
                    foreach (var workOrder in workOrders) {
                        if (isActive) workOrder.Status = (byte)MyUtilities.WorkOrder.Status.Actived;
                        workOrder.ModifiedDate = DateTime.Now;
                        workOrder.ModifiedUser = HttpContext.User.Identity.Name;
                        if (track.ProductId == 0) {
                            track.ProductId = workOrder.ProductId;
                            track.StartDate = workOrder.StartDate;
                            track.DeliveryDate = workOrder.StartDate;
                        }
                        track.Quantity += workOrder.OrderQty;
                        foreach (var routing in workOrder.WorkOrderRoutings) {
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

                                routing.PlannedCost = MyUtilities.Function.RoundUp(workOrder.OrderQty / productionRate);
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
            string fromDate, string toDate) {
            var model = new List<WorkOrderRoutingModel>();
            using (var vfi = new tammaContext()) {
                //var routings = vfi.WorkOrderRoutings.Where(x => x.WarehouseId == warehouseId).ToList();
                //var routings4 = vfi.WorkOrderRoutings.Where(x => (x.WarehouseId ?? 0) == 0).ToList();
                //var routings3 = vfi.WorkOrderRoutings.Where(x => x.WarehouseId == null).ToList();
                //var routings5 = vfi.WorkOrderRoutings.Where(x => x.Warehouse == null).ToList();

                var routings = vfi.WorkOrderRoutings.Where(x => (status == 0 || x.Status == status)
                                                                && (workOrderId == 0 || x.WorkOrderId == workOrderId)
                                                                && (routingId == 0 || x.RoutingId == routingId))
                                                    .ToList();
                if (config != null) {
                    if (config.IsMainProcess == true) {
                        routings = routings.Where(x => x.WarehouseId == null).ToList(); // work
                    }
                    else {
                        routings = routings.Where(x => x.WarehouseId != null &&
                            (config.IsProduction == null || x.Warehouse.IsProduction == config.IsProduction) &&
                            (config.IsProduction2 == null || x.Warehouse.IsProduction2 == config.IsProduction2) &&
                            (config.IsQC == null || x.Warehouse.IsQC == config.IsQC)).ToList();
                    }
                }
                if (!string.IsNullOrWhiteSpace(toDate)) {
                    var fDate = MyUtilities.Function.ParseDate(fromDate);
                    var tDate = MyUtilities.Function.ParseDate(toDate);
                    routings = routings.Where(x => x.ModifiedDate >= fDate && x.ModifiedDate <= tDate).ToList();
                }
                foreach (var routing in routings) {
                    var entity  = new WorkOrderRoutingModel {
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
                        MoreInfoObject = JsonConvert.DeserializeObject<WorkOrderProductionInfo>(routing.MoreInfo),
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
                    if (routing.WorkOrderRouting1.Any()) {
                        entity.ActualResources = routing.WorkOrderRouting1.FirstOrDefault().ActualCost;
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
                    }
                    entity.PreviousRouteQuantity = entity.PlannedCost - entity.UsingQuantity;
                    entity.PlannedWeight = entity.PlannedCost * entity.ProductWeight;
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
        public ActionResult SelectWorkOrderProcess(int routingId, double productWeight) {
            if (routingId == 0) {
                return View(new GridModel(new List<WorkOrderRoutingModel>()));
            }
            var model = new List<WorkOrderRoutingModel>();
            try {
                using (var vfi = new tammaContext()) {
                    model = GetWorkOrderRoutingModel(null, 0, 0, routingId, "", "");
                    model.ForEach(x => {
                        x.ProductWeight = productWeight;
                        x.UsingQuantity = 0;
                        x.GoodQuantity = 0;
                        x.GoodWeight = 0;
                        x.NGQuantity = 0;
                        x.NGWeight = 0;
                        x.DefectQuantity = 0;
                        x.DefectWeight = 0;
                    });
                }
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderProcess", ex.Message);
            }
            return View(new GridModel(model));
        }

        [GridAction]
        public ActionResult ImportWorkOrderProcess(
            [Bind(Prefix = "inserted")] IEnumerable<WorkOrderRoutingModel> inserteds,
            [Bind(Prefix = "updated")] IEnumerable<WorkOrderRoutingModel> updateds,
            [Bind(Prefix = "deleted")] IEnumerable<WorkOrderRoutingModel> deleteds,
            int routingId, int employeeId, int machineId, double productWeight
        ) {
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    var import = updateds.FirstOrDefault();
                    if (routing.WorkOrderRouting1.Any() && routing.WorkOrderProcesses.Any()) {
                        var usingQuantity = routing.WorkOrderRouting1.Sum(x => x.ActualCost);
                        var usedQuantity = routing.WorkOrderProcesses.Where(x => x.Status != (byte)MyUtilities.WorkOrder.Status.Cancel)
                                                                    .Sum(x => x.UsingQuantity);
                        if (usedQuantity + import.UsingQuantity > usingQuantity) {
                            throw new AggregateException("Lỗi! Đã sử dụng quá số lượng cho phép");
                        }
                    }
                    var process = new WorkOrderProcess {
                        RoutingId = routingId,
                        EmployeeId = employeeId,
                        UsingQuantity = import.UsingQuantity,
                        GoodQuantity = import.GoodQuantity,
                        NGQuantity = import.NGQuantity,
                        DefectQuantity = import.DefectQuantity,
                        Date = DateTime.Now,
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

        List<WorkOrderProcessModel> GetWorkOrderProcessApprovement(RoutingConfiguration config, byte status) {
            var model = new List<WorkOrderProcessModel>();
            var shift1StartTime = MyUtilities.Product.StartShift1_HOUR;
            var shift2StartTime = MyUtilities.Product.StartShift2_HOUR;
            using (var vfi = new tammaContext()) {
                model = (from x in vfi.WorkOrderProcesses
                         where (status == 0 || x.Status == status)
                                 && x.WorkOrderRouting.WarehouseId != null
                                 && (config.IsProduction == null || x.WorkOrderRouting.Warehouse.IsProduction == true)
                                 && (config.IsProduction2 == null || x.WorkOrderRouting.Warehouse.IsProduction2 == true)
                                 && (config.IsQC == null || x.WorkOrderRouting.Warehouse.IsQC == true)
                         select new WorkOrderProcessModel {
                             ProcessId = x.ProcessId,
                             Status = x.Status,
                             RoutingId = x.RoutingId,
                             UnitWeight = x.UnitWeight,
                             UsingQuantity = x.UsingQuantity,
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
                         }).ToList();
                //if (!processes.Any()) return model;

            }
            return model;
        }

        public int UpdateStatusWorkOrderRoutingProduction(List<int> routingIds) {
            var saved = 0;
            try {
                using (var vfi = new tammaContext()) {
                    var routings = vfi.WorkOrderRoutings.Where(x => routingIds.Contains(x.RoutingId));
                    foreach (var routing in routings) {
                        var finishProcesses = routing.WorkOrderProcesses.Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.Finish);
                        if (finishProcesses.Any()) {
                            var previousRouteQuantity = routing.WorkOrderRouting1.Any() ? routing.WorkOrderRouting1.Sum(x => x.ActualCost) : 0;
                            if (finishProcesses.Sum(x => x.UsingQuantity) >= previousRouteQuantity) {
                                routing.Status = (byte)MyUtilities.WorkOrder.Status.Finish;
                                routing.ActualCost = finishProcesses.Sum(x => x.GoodQuantity);
                                routing.WorkOrderRouting2.PlannedCost = routing.ActualCost;
                                routing.ActualEndDate = DateTime.Now;
                                routing.WorkOrderRouting2.Status = (byte)MyUtilities.WorkOrder.Status.Actived;
                                routing.WorkOrderRouting2.ScheduledStartDate = DateTime.Now;
                                routing.WorkOrderRouting2.ScheduledEndDate = routing.WorkOrderRouting2.ScheduledStartDate.AddHours(routing.WorkOrderRouting2.ActualResourceHrs);
                            }
                        }
                        else {
                            routing.Status = (byte)MyUtilities.WorkOrder.Status.InProcess;
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
                        RunTime = workOrder.RunTime,
                        StartDate = workOrder.StartDate,
                        EndDate = workOrder.EndDate,
                        Routings =  new List<WorkOrderRoutingModel>()
                    };

                    foreach (var routing in workOrder.WorkOrderRoutings.OrderBy(x=> x.RoutingIndex)) {
                        if (routing.WarehouseId == null) {
                            if (routing.MaterialInvId != null) {
                                entity.MaterialName = routing.MaterialInventory.Material.MaterialCode;
                                entity.MaterialLot = "x" + (routing.MaterialInventory.Length / 1000) + "-" + routing.MaterialInventory.LotNumber;
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
            catch (Exception ex) { }
            return PartialView("PageWorkOrder", entity);
        }

        #endregion

        #region Assign Material
        [GridAction]
        public ActionResult SelectWorkOrderMaterialAssignment() {
            var model = new List<WorkOrderRoutingModel>();
            try {
                model = GetWorkOrderRoutingModel(new RoutingConfiguration { IsMainProcess = true },
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0, "", "");
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderMaterialAssignment", ex.Message);
            }
            return View(new GridModel(model));
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
                            Active = true,
                            ModifiedUser = HttpContext.User.Identity.Name,
                            ModifiedDate = DateTime.Now,
                            Note = routing.WorkOrder.SerialNumber + "-" + routing.Machine.MachineName,
                            LotNumber = materialInv.LotNumber,
                            VendorId = routing.RoutingId,
                        };
                        transactionMaterialDetail.QuantityKg = transactionMaterialDetail.Quantity * materialInv.UnitWeight;
                        transactionMaterial.TransactionDetails.Add(transactionMaterialDetail);
                        var exportDetail = new ExportMaterialDetail {
                            MachineId = routing.MachineId.Value,
                            ExportId = exportMaterial.ExportId,
                            ExportMaterial = exportMaterial,
                            MaterialInvId = routing.MaterialInvId.Value,
                            MaterialId = materialInv.MaterialId,
                            Quantity = transactionMaterialDetail.Quantity,
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
                                UnitWeight = transactionDetail.QuantityKg.Value / transactionDetail.Quantity
                            };
                            routing.WorkOrderProcesses.Add(routingProcess);
                            routing.Status = (byte)MyUtilities.WorkOrder.Status.InProcess;
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

        public ActionResult PrintWOAssignMaterial(string printDate,                        bool isAll,                        bool haveInventory,                        bool haveWorkOrder) {
            var model = new List<SmartProductionModel>();
            try {
                using (var vfi = new tammaContext()) {
                    var date = MyUtilities.Function.ParseDate(printDate);

                    var machines = (from m in vfi.Machines
                                    where m.Active && m.MachineName.Contains("C")
                                    orderby m.MachineName
                                    select new {
                                        m.MachineId,
                                        m.MachineName
                                    }).ToList();
                    var assignWorkOrders = vfi.WorkOrderRoutings.Where(x => x.WarehouseId == null 
                        && x.Status == (byte)MyUtilities.WorkOrder.Status.Actived);

                    var lastDate = new DateTime();
                    var lastUse = (from mud in vfi.MaterialUseDetails
                                   where mud.MaterialUseInShift.Status != (byte)MyUtilities.Transaction.Status.Cancel &&
                                         mud.MaterialUseInShift.UsedDate < date &&
                                         mud.MaterialUseInShift.Type == (byte) MyUtilities.Material.UseType.Using
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
                                machineRunTime = entity.MaterialInvOnMachine * entity.Productivity * entity.ProductionRate;

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
                                var assignWOById3 = assignWOById2.Where(x=> x.MachineId == loop.Key.MachineId
                                                                    && x.MaterialInvId == loop.Key.MaterialInvId
                                                                    && x.ProductId == loop.Key.ProductId).ToList();
                                if (entity == null) { 
                                    var routing  = assignWOById3.FirstOrDefault();
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
        #endregion

        #region production 1

        [GridAction]
        public ActionResult SelectWorkOrderProductionManagement(string fromDate, string toDate, byte status) {
            if (string.IsNullOrWhiteSpace(toDate)) { return View(new GridModel(new List<WorkOrderRoutingModel>())); }

            var model = new List<WorkOrderRoutingModel>();
            try {
                model = GetWorkOrderRoutingModel(new RoutingConfiguration { IsProduction = true },
                    status, 0, 0, fromDate, toDate);
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
                model = GetWorkOrderProcessApprovement(new RoutingConfiguration { IsProduction = true }, (byte)MyUtilities.WorkOrder.Status.InProcess);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderProductionApprovement", ex.Message);
            }
            return View(new GridModel(model));
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
                    var processes = vfi.WorkOrderProcesses.Where(x => checkedRecords.Contains(x.ProcessId));
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
                        while (startTime < endTime) {
                            var periodTime = startTime.AddHours(12).AddSeconds(-1);
                            var shift = startTime.Hour == shift1StartTime ? 1 : 2;
                            var materialUse = new MaterialUseInShift() {
                                ModifiedDate = DateTime.Now,
                                ModifiedUser = HttpContext.User.Identity.Name,
                                Shift1 = (shift == 1 ? (shift + "") : ""),
                                Shift2 = (shift == 2 ? (shift + "") : ""),
                                Status = (byte)MyUtilities.Transaction.Status.Approved,
                                UsedDate = startTime,
                                UsedCode = MyUtilities.AutoIncrease.GetParam((int)MyUtilities.AutoIncrease.IncreaseNum.MaterialUse, 1),
                                Type = (int)MyUtilities.Material.UseType.Using,
                            };
                            materialUses.Add(materialUse);

                            //var lot = MyUtilities.MySystem.LotNumber_Weekly(materialUse.UsedDate);
                            var processesByPeriod = processes.Where(x => x.Date >= startTime && x.Date <= periodTime);
                            foreach (var process in processesByPeriod) {
                                var materialUseDetail = new MaterialUseDetail {
                                    MachineId = process.WorkOrderRouting.MachineId.Value,
                                    MaterialInvId = process.WorkOrderRouting.MaterialInvId.Value,
                                    EditQuantity = (shift == 1 ? process.UsingQuantity : 0),
                                    EditQuantity2 = (shift == 2 ? process.UsingQuantity : 0),
                                    Note = process.WorkOrderRouting.WorkOrder.SerialNumber,
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
                    catch (Exception) { messageError = "material use case error"; }
                    try {
                        #region import production 1 case
                        foreach (var materialUse in materialUses) {
                            var import = new ImportFormSX1 {
                                ImportDate = startTime,
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
                                    && x.WorkOrderRouting.MaterialInvId == useDetail.MaterialInvId);
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
                    catch (Exception) { messageError = "import production case error"; }
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
                                    && x.WorkOrderRouting.ProductId == detail.ProductId);
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
                        vfi.Transactions.AddRange(transactions);
                        saved += vfi.SaveChanges();
                        #endregion
                    }
                    catch (Exception) { messageError = "transaction case error"; }

                    transactionIds = transactionSx1s.Select(x => x.TransactionId).Distinct().ToList();
                }
                try {
                    foreach (var transactionId in transactionIds) {
                        saved += transactionController.UpdateProductInvByTransaction(transactionId, HttpContext.User.Identity.Name);
                    }
                }
                catch (Exception) { messageError = "product inventory case error"; }

                saved += UpdateStatusWorkOrderRoutingProduction(routingIds);

                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NoError, messageError, saved));
            }
            catch (Exception ex) {
                return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.Exception, ex.Message, null));
            }
            //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NotImplement, "", null));
        }

        #endregion

        #region production 2

        [GridAction]
        public ActionResult SelectWorkOrderProduction2Confirmation() {
            var model = new List<WorkOrderRoutingModel>();
            try {
                model = GetWorkOrderRoutingModel(new RoutingConfiguration { IsProduction2 = true },
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0, "", "");
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
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0, "", "")));
                //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NotFound, "Không tìm thấy " + routingId, null));
            }
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    if (routing == null) { throw new AggregateException("Lỗi! Khôg tìm thấy routing"); }
                    routing.Status = (byte)MyUtilities.WorkOrder.Status.InProcess;
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
                (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","")));
        }

        [GridAction]
        public ActionResult SelectWorkOrderProduction2Approvement() {
            var model = new List<WorkOrderProcessModel>();
            try {
                model = GetWorkOrderProcessApprovement(new RoutingConfiguration { IsProduction2 = true }, (byte)MyUtilities.WorkOrder.Status.InProcess);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderProductionApprovement", ex.Message);
            }
            return View(new GridModel(model));
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
                    }
                    saved += vfi.SaveChanges();
                }

                saved += UpdateStatusWorkOrderRoutingProduction(routingIds);

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
        public ActionResult SelectWorkOrderQCConfirmation() {
            var model = new List<WorkOrderRoutingModel>();
            try {
                model = GetWorkOrderRoutingModel(new RoutingConfiguration { IsQC = true }, 
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","");
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
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","")));
                //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NotFound, "Không tìm thấy " + routingId, null));
            }
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    if (routing == null) { throw new AggregateException("Lỗi! Không tìm thấy routing"); }
                    routing.Status = (byte)MyUtilities.WorkOrder.Status.InProcess;

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
                (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","")));
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
                    }
                   saved= vfi.SaveChanges();
                }

                saved+=UpdateStatusWorkOrderRoutingProduction(routingIds);

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
                    var routingModel = GetWorkOrderRoutingModel(null, 0, 0, routingId, "", "").FirstOrDefault();
                    var waitingProcess = vfi.WorkOrderProcesses.Where(x => x.RoutingId == routingId
                                                                    && x.Status != (byte)MyUtilities.WorkOrder.Status.Cancel
                                                                    && x.Status != (byte)MyUtilities.WorkOrder.Status.Finish)
                                                                .Sum(x => x.UsingQuantity);
                    var entity = new WorkOrderRoutingModel {
                        RoutingId = routingId,
                        ProductWeight = productWeight,
                        GoodWeight = packageWeight,
                        GoodQuantity = quantity,
                        PreviousRouteQuantity = routingModel.PreviousRouteQuantity - waitingProcess
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
                    entity.UsingQuantity = entity.GoodQuantity;
                    entity.UsingWeight = entity.UsingQuantity * entity.ProductWeight;

                    entity.PreviousRouteQuantity -= model.Sum(x => x.UsingQuantity);
                    if (entity.PreviousRouteQuantity > entity.PlannedCost) { }
                    else if (entity.PreviousRouteQuantity > 0 && entity.PreviousRouteQuantity < entity.PlannedCost) {
                        entity.GoodQuantity = entity.PreviousRouteQuantity;
                        entity.NGQuantity = entity.UsingQuantity - entity.PreviousRouteQuantity;
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
                    if (routing.WorkOrderRouting1.Any() && routing.WorkOrderProcesses.Any()) {
                        var planQuantity = routing.WorkOrderRouting1.Sum(x => x.ActualCost);
                        var usedQuantity = routing.WorkOrderProcesses.Where(x => x.Status != (byte)MyUtilities.WorkOrder.Status.Cancel)
                                                                    .Sum(x => x.UsingQuantity);
                        var usingQuantity = model.Sum(x => x.UsingQuantity);
                        if (usedQuantity + usingQuantity > planQuantity) {
                            throw new AggregateException("Lỗi! Đã sử dụng quá số lượng cho phép");
                        }
                    }
                    for (var i = 0; i < model.Count; i++) {
                        var import = model[i];
                        var process = new WorkOrderProcess {
                            RoutingId = routingId,
                            EmployeeId = employeeId,
                            UsingQuantity = import.UsingQuantity,
                            GoodQuantity = import.GoodQuantity,
                            NGQuantity = import.NGQuantity,
                            DefectQuantity = import.DefectQuantity,
                            Date = DateTime.Now,
                            ModifiedDate = DateTime.Now,
                            ModifiedUser = HttpContext.User.Identity.Name,
                            Status = (byte)MyUtilities.WorkOrder.Status.InProcess,
                            UnitWeight = productWeight,
                        };
                        if (i == model.Count - 1) {
                            import.DefectQuantity = destroyQuantity * -1;
                        }
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
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","");
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
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","")));
                //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NotFound, "Không tìm thấy " + routingId, null));
            }
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    if (routing == null) { throw new AggregateException("Lỗi! Không tìm thấy routing"); }
                    routing.Status = (byte)MyUtilities.WorkOrder.Status.InProcess;
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
                (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","")));
        }

        [GridAction]
        public ActionResult SelectWorkOrderPackingApprovement() {
            var model = new List<WorkOrderProcessModel>();
            try {
                model = GetWorkOrderProcessApprovement(new RoutingConfiguration { IsPacking = true }, (byte)MyUtilities.WorkOrder.Status.InProcess);
            }
            catch (Exception ex) {
                ModelState.AddModelError("SelectWorkOrderPackingApprovement", ex.Message);
            }
            return View(new GridModel(model));
        }

        public ActionResult ApproveWorkOrderPackingProcess(string ids) {
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
                    }
                    saved = vfi.SaveChanges();
                }

                saved += UpdateStatusWorkOrderRoutingProduction(routingIds);

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
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","");
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
                    (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","")));
                //return Json(new MyUtilities.Monitor.MyJsonResult((int)MyUtilities.Monitor.ErrorCode.NotFound, "Không tìm thấy " + routingId, null));
            }
            var workOrderId = 0;
            try {
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    if (routing == null) { throw new AggregateException("Lỗi! Không tìm thấy routing"); }
                    routing.Status = (byte)MyUtilities.WorkOrder.Status.Finish;
                    routing.ActualCost = routing.PlannedCost;
                    workOrderId = routing.WorkOrderId;
                    vfi.SaveChanges();
                }
                try {
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
                (byte)MyUtilities.WorkOrder.Status.Actived, 0, 0,"","")));
        }

        public int RotateFinishWorkOrderInventory(int routingId) {
            var saved = 0;
            try {
                var transactions = new List<Transaction>();
                using (var vfi = new tammaContext()) {
                    var routing = vfi.WorkOrderRoutings.FirstOrDefault(x => x.RoutingId == routingId);
                    var previousRoute = routing.WorkOrderRouting1.FirstOrDefault();
                    if (previousRoute == null || previousRoute.ActualCost == 0) return saved;

                    var importQuantity = previousRoute.WorkOrderProcesses.Where(x => x.Status == (byte)MyUtilities.WorkOrder.Status.Finish
                        && x.NGQuantity > 0)
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
                    var productInv = vfi.ProductInventories.FirstOrDefault(
                                    pi =>
                                        pi.WarehouseId == (previousRoute.WarehouseId ?? 0) &&
                                        pi.ProductId == routing.ProductId &&
                                        pi.LotNumber.Equals(routing.RoutingLot));
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
                            Quantity = previousRoute.ActualCost,
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

        public List<WorkOrderRoutingModel> GetComboBoxWorkOrderRoutingModel(RoutingConfiguration config) {
            var model = new List<WorkOrderRoutingModel>();
            try {
                using (var vfi = new tammaContext()) {
                    model = (from x in vfi.WorkOrderRoutings
                             where (config.IsProduction == null || (x.WarehouseId != null && x.Warehouse.IsProduction))
                             && (config.IsProduction2 == null || (x.WarehouseId != null && x.Warehouse.IsProduction2))
                             && (config.IsQC == null || (x.WarehouseId != null && x.Warehouse.IsQC))
                             && (config.IsPacking == null || (x.WarehouseId != null && x.Warehouse.IsPacking))
                             && (config.IsFinish == null || (x.WarehouseId != null && x.Warehouse.IsFinish))
                             select new WorkOrderRoutingModel {
                                 RoutingId = x.RoutingId,
                                 Status = x.Status,
                                 RoutingName = x.RoutingName,
                                 SerialNumber = x.WorkOrder.SerialNumber
                             }).ToList();
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
                    var model = GetWorkOrderRoutingModel(null, 0, 0, routingId, "", "");
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
