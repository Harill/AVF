namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class PrintProductTransactionModel
    {


        public virtual string WarehouseIssueName { get; set; }
        public virtual string WarehouseReceiptName { get; set; }

        public virtual string TransactionCode { get; set; }

        public virtual string EoI { get; set; }
        public virtual string EoIName { get; set; }

        public virtual string CreatedUser { get; set; }

        public virtual string CreatedDate { get; set; }

        public virtual string StatusName { get; set; }

        public virtual bool IsApprove { get; set; }

        public virtual string Description { get; set; }

        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public string ModifiedDate { get; set; }

        public double TotalQuality { get; set; }

        public string ProductCode { get; set; }
        public string CustomerCode { get; set; }
        public double Number { get; set; }


    }
}