using System;
using System.Collections.Generic;

namespace Vfi.Server.Core.DrivenModel.Models
{
    public partial class Material
    {
        public Material()
        {
            MaterialInventories = new List<MaterialInventory>();
            MaterialInventoryPeriods = new List<MaterialInventoryPeriod>();
            StockOrderDetails = new List<StockOrderDetail>();
            TransactionDetails = new List<TransactionDetail>();
            PriceListMaterials = new List<PriceListMaterial>();
            Products = new List<Product>();
            PurchaseOrderDetails = new List<PurchaseOrderDetail>();
        }

        public int MaterialId { get; set; }
        public int MaterialTypeId { get; set; }
        public string MaterialCode { get; set; }
        public string MaterialName { get; set; }
        public string Diameter { get; set; }
        public string DiameterType { get; set; }
        public Nullable<double> Length { get; set; }
        public Nullable<double> Weight { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public virtual ICollection<MaterialInventory> MaterialInventories { get; set; }
        public virtual ICollection<MaterialInventoryPeriod> MaterialInventoryPeriods { get; set; }
        public virtual ICollection<StockOrderDetail> StockOrderDetails { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
        public virtual MaterialType MaterialType { get; set; }
        public virtual ICollection<PriceListMaterial> PriceListMaterials { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
    }
}
