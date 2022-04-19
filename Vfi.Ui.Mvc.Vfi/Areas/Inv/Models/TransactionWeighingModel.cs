using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class TransactionWeighingModel : ICloneable {
        public int WeighingId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string CustomerCode { get; set; }
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public double UnitWeight { get; set; }
        public double PackageWeight { get; set; }
        public double Weight { get; set; }
        public double Quantity { get; set; }
        public long TransactionId { get; set; }
        public string TransactionCode { get; set; }
        public byte Status { get; set; }
        public string StatusName { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }

        public bool CanCreate { get; set; }
        public int ProductInvId { get; set; }
        public string LotNumber { get; set; }
        public double InvQuantity { get; set; }
        public double InvWeight { get { return InvQuantity * UnitWeight / 1000; } }
        //public string GroupHeader { get { return ProductCode + "_" + Quantity + "_" + WeighingId; } }
        public string IdentityWeighing { get { return MyUtilities.Function.StringsJoin(new List<string>() { WeighingId + "", ProductInvId + "", Convert.ToInt32(InvQuantity) + "" }); } }
        public object Clone() {
            return this.MemberwiseClone();
        }
    }
}