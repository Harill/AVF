
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.Models.Inv;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class StockOrderModel: StockOrderDomainModel
    {
        [Required(ErrorMessage = @"*")]
        [UIHint("_warehouseIssueEditTemplate")]
        public override string WarehouseIssueName
        {
            get
            {
                return base.WarehouseIssueName;
            }
            set
            {
                base.WarehouseIssueName = value;
            }
        }


        [Required(ErrorMessage = @"*")]
        [UIHint("_warehouseReceiptEditTemplate")]
        public override string WarehouseReceiptName
        {
            get
            {
                return base.WarehouseReceiptName;
            }
            set
            {
                base.WarehouseReceiptName = value;
            }
        }
    }
}