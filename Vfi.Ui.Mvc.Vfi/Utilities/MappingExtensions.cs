using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vfi.Ui.Mvc.Vfi.Areas.Sales.Models;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Utilities
{
    public static class MappingExtensions
    {
        // order
        public static OrderModel ToModel(this Order entity)
        {
            return Mapper.Map<Order, OrderModel>(entity);
        }

        public static Order ToEntity(this OrderModel model)
        {
            return Mapper.Map<OrderModel, Order>(model);
        }

        public static Order ToEntity(this OrderModel model, Order destination)
        {
            return Mapper.Map(model, destination);
        }

        // order detail
        public static OrderDetailModel ToModel(this OrderDetail entity)
        {
            return Mapper.Map<OrderDetail, OrderDetailModel>(entity);
        }

        public static OrderDetail ToEntity(this OrderDetailModel model)
        {
            return Mapper.Map<OrderDetailModel, OrderDetail>(model);
        }

        public static OrderDetail ToEntity(this OrderDetailModel model, OrderDetail destination)
        {
            return Mapper.Map(model, destination);
        }
    }
}