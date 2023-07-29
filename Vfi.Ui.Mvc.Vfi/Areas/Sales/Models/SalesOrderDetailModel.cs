using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Server.Core.DataModel.Models.Sales;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class SalesOrderDetailModel : OrderDetailDomainModel
    {
        [UIHint("_ProductEditTemplate")]
        public override string ProductCode
        {
            get
            {
                return base.ProductCode;
            }
            set
            {
                base.ProductCode = value;
            }
        }
        public string OrderNote { get; set; }
    }
}