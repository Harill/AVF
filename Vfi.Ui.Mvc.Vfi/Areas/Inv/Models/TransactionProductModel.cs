
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class TransactionProductModel
    {
        public long TransactionProductId { get; set; }
        public long TransactionId { get; set; }
        public string TransactionCode { get; set; }
        public string Note { get; set; }
        [DataType("Number0")]
        public double Quantity { get; set; }
        [DataType("Number2")]
        public double QuantityKg { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int ProductInvId { get; set; }
        public string ProductInvLot { get; set; }
        public double ProductWeight { get; set; }
        public double ProductInvQuantity { get; set; }
        public double ProductInvAvailable { get; set; }
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public int Status { get; set; }
        public double TransactionProductQuantity { get; set; }
    }
}