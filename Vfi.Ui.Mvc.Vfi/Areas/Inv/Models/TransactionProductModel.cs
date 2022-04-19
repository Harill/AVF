
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using Vfi.Ui.Mvc.Vfi.Utilities;

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
        public string CustomerCode { get; set; }
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
        public string StatusName { get { return MyUtilities.Transaction.CastText.GetTextStatus(Status); } }
        public double TransactionProductQuantity { get; set; }

        public string WarehouseIssueName { get; set; }
        public string WarehouseReceiptName { get; set; }
        public DateTime PeriodDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }

        public List<TransactionDetailModel> Details { get; set; }
    }
}