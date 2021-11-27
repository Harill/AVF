using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class MethodEnumType
    {





    }
    public static class MethodEnumTypeId
    {
        /// <summary>
        /// 1	Phương thức thanh toán ByCash - Transport
        /// </summary>
        public static int PaymentMethod = 1;
        /// <summary>
        /// 2	Hình thức vận chuyển FOB - DDU
        /// </summary>
        public static int DeliveryTerm = 2;
        /// <summary>
        /// 3	Phương thức giao hàng AtFactory
        /// </summary>
        public static int DeliveryMethod = 3;
        /// <summary>
        /// 4	Phương thức đóng gói InPackage
        /// </summary>
        public static int PackageMethod = 4;
        /// <summary>
        /// 5	Phương tiện vận chuyển ByTruck-ByShip-ByPlane
        /// </summary>
        public static int DeliveryBy = 5;
        /// <summary>
        /// 6	Thời hạn giao hàng 30-45-60
        /// </summary>
        public static int DeliveryPeriod = 6;
        /// <summary>
        /// 7   Điều kiện giao hàng thanh toan 50%, du khi nhan hang
        /// </summary>
        public static int PaymentCondition = 7;
    }
}