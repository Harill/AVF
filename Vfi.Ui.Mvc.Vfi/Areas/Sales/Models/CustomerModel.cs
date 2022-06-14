
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.Models.Sales;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class CustomerModel : CustomerDomainModel
    {
        public string PrintCustomerList { get; set; }
        public bool IsMonitor { get; set; }

        public int State { get; set; }
        [DisplayName(@"Tình trạng")]
        [UIHint("_StateEditTemplate")]
        public string StateName { get; set; }

        public bool IsNotRequireApproveOrder { get; set; }
        public bool IsWorkOrder { get; set; }
    }
}