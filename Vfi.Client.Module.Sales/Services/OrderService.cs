using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Vfi.Client.Module.Sales.Interfaces;
using Vfi.Server.Core.DataModel.BaseEntities;
using Vfi.Server.Core.DataModel.Models.Sales;
using Vfi.Server.Core.Repository.Sales;

namespace Vfi.Client.Module.Sales.Services
{
    public class OrderService: IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IOrderDetailRepository _orderDetailRepository;
        [InjectionConstructor]
        public OrderService(IOrderRepository orderRepository,
                                    IOrderDetailRepository orderDetailRepository)
        {
            if (orderRepository == null) throw new ArgumentNullException("orderRepository");
            if (orderDetailRepository == null) throw new ArgumentNullException("orderDetailRepository");

            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
        }

        #region Order

        public IEnumerable<Order> GetAllOrders()
        {
            try
            {
                return _orderRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<OrderDomainModel> GetAllOrderDomainModels()
        {
            try
            {
                return GetAllOrders().Select(
                    entity => new OrderDomainModel
                                  {
                                      OrderId = entity.OrderId,
                                      CustomerId = entity.CustomerId,
                                      SalesPersonId = entity.SalesPersonId,
                                      ShipMethodId = entity.ShipMethodId,

                                      OrderDate = entity.OrderDate,
                                      DueDate = entity.DueDate,
                                      ShipDate = entity.ShippedDate,
                                      Status = entity.Status,
                                      PurchaseOrderNumber = entity.PoNumber,
                                      OrderNumber = entity.OrderNumber,
                                      BillToAddress = entity.BillToAddress,
                                      ShipToAddress = entity.ShipToAddress,

                                      Active = entity.Active,
                                      ModifiedUser = entity.ModifiedUser,
                                      ModifiedDate = entity.ModifiedDate
                                  });
            }
            catch
            {
                return null;
            }
        }
        public Order GetOrderById(long orderId)
        {
            try
            {
                return _orderRepository.FindAsNoTracking(f => f.OrderId == orderId).FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<Order> GetOrderByCustomerId(int customerId)
        {
            try
            {
                return _orderRepository.FindAsNoTracking(f=>f.CustomerId == customerId);
            }
            catch
            {
                return null;
            }
        }
        public Order GetOrderByOrderNumber(string orderNumber)
        {
            try
            {
                return
                    _orderRepository.FindAsNoTracking(
                        f => f.OrderNumber.Equals(orderNumber, StringComparison.OrdinalIgnoreCase))
                        .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public Order GetOrderByPurchaseOrderNumber(string purchaseOrderNumber)
        {
            try
            {
                return
                    _orderRepository.FindAsNoTracking(
                        f => f.PoNumber.Equals(purchaseOrderNumber, StringComparison.OrdinalIgnoreCase))
                        .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<Order> GetOrderByStatus(byte status)
        {
            try
            {
                return _orderRepository.FindAsNoTracking(f => f.Status == status);
            }
            catch
            {
                return null;
            }
        }

        public string CreateOrder(Order order)
        {
            try
            {
                var targetCreate = GetOrderByOrderNumber(order.OrderNumber);
                if(targetCreate == null)
                {
                    _orderRepository.Add(order);

                    return "1";
                }
                return "0";
            }
            catch(Exception exception)
            {
                return exception.Message;
            }
        }
        public string UpdateOrder(Order order)
        {
            try
            {
                var targetUpdate =
                    _orderRepository.Find(f => f.OrderId == order.OrderId).FirstOrDefault();
                if (targetUpdate != null)
                {
                    

                    //return "1";
                }
                return "0";
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        #endregion

        #region Order Detail

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            try
            {
                return _orderDetailRepository.GetAllAsNoTracking();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<OrderDetailDomainModel> GetAllOrderDetailDomainModels()
        {
            try
            {
                return GetAllOrderDetails().Select(
                    entity => new OrderDetailDomainModel
                                  {
                                      OrderDetailId = entity.OrderDetailId,
                                      OrderId = entity.OrderId,
                                      
                                      ProductId = entity.ProductId,
                                      ProductCode = entity.Product != null ? entity.Product.ProductCode : "",
                                      ProductName = entity.Product != null ? entity.Product.ProductName : "",

                                      CarrierTrackingNumber = entity.CarrierTrackingNumber,
                                      OrderQty = entity.OrderQty,
                                      UnitPrice = entity.UnitPrice,
                                      UnitPriceDiscount = entity.UnitPriceDiscount,
                                      LineTotal = entity.LineTotal,
                                      
                                      Active = entity.Active,
                                      ModifiedUser = entity.ModifiedUser,
                                      ModifiedDate = entity.ModifiedDate
                                  });
            }
            catch
            {
                return null;
            }
        }
        public OrderDetail GetOrderDetailById(long orderDetailId)
        {
            try
            {
                return
                    _orderDetailRepository.FindAsNoTracking(f => f.OrderDetailId == orderDetailId)
                        .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<OrderDetail> GetOrderDetailByOrderId(long orderId)
        {
            try
            {
                return _orderDetailRepository.FindAsNoTracking(f => f.OrderId == orderId);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<OrderDetail> GetOrderDetailByProductId(long productId)
        {
            try
            {
                return _orderDetailRepository.FindAsNoTracking(f => f.ProductId == productId);
            }
            catch
            {
                return null;
            }
        }

        #endregion
    }
}
