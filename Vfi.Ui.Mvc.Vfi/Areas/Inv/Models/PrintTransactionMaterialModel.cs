using System;
using Vfi.Ui.Mvc.Vfi.Models.Production;
namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class PrintTransactionMaterialModel
    {
        public string Note { get; set; }
        public string LotNumber { get; set; }
        public string PONumber { get; set; }
        public string StatusName { get; set; }
        public string TransactionCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Currency { get; set; }
        public virtual double UnitPrice { get; set; }
        public virtual double UnitWeight { get; set; }
        public virtual string VendorCode { get; set; }

        public virtual string VendorName { get; set; }

        public virtual string VendorCodeName
        {
            get { return VendorCode + " -- " + VendorName; }
            set { VendorCode = value; }
        }

        public virtual string MaterialCode { get; set; }

        public virtual string MaterialName { get; set; }

        public virtual string MaterialCodeName
        {
            get { return MaterialCode + " -- " + MaterialName; }
            set { MaterialCode = value; }
        }

        public string MaterialDesignNo { get; set; }
        public virtual double? Quantity { get; set; }

        public virtual double? QuantityKg { get; set; }
        public double Price { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string StoreCode { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public byte PurchasingSignature { get; set; }
        public double ExchangeRate { get; set; }
        public double TotalInv{get;set;}
        public WorkGroupInfo Info { get; set; }
    }
}