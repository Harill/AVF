using System;
using System.ComponentModel.DataAnnotations;
using Vfi.Ui.Mvc.Vfi.Models.Production;

namespace Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models
{
    public class PlatingDetailModel
    {
        public PlatingDetailModel()
        {
            UnitPrice = 0;
        }
        public int Index { get; set; }
        public int FormId { get; set; }
        public string FormNumber { get; set; }
        public string TransactionCode { get; set; }
        [DataType("DateNonNullable")]
        public DateTime ExportDate { get; set; }
        [DataType("_DateTemplate")]
        public DateTime? ExportDateRequirement { get; set; }
        [DataType("DateNonNullable")]
        public DateTime ImportDate { get; set; }
        [DataType("_DateTemplate")]
        public DateTime? ImportDateRequirement { get; set; }
        public string ImportDateRequirementStr {
            get {
                return ImportDateRequirement != null
                    ? ImportDateRequirement.Value.ToString("dd/MM/yyyy")
                    : "";
            }
        }
        public int DetailId { get; set; }
        public int ProductId { get; set; }
        [DataType("_ProductCodePlatingTemplate2")]
        public string ProductCode { get; set; }
        public int PlatingId { get; set; }
        [DataType("_PlatingTemplate")]
        public string PlatingCode { get; set; }
        public string Thickness { get; set; }
        public string SaltSprayTime { get; set; }
        public string SpecialRequest { get; set; }
        public string Sample { get; set; }
        public string TestingEquipment { get; set; }
        [DataType("_PlatingUnitTemplate")]
        public string Unit { get; set; }
        [UIHint("Number")]
        public double QuantityRequirement { get; set; }
        [UIHint("Number")]
        public double UnitPrice { get; set; }
        public string UnitPriceString { get; set; }
        public double TotalPrice { get; set; }
        public string Note { get; set; }
        public double Export { get; set; }
        public string ExportString { get; set; }
        public double Import { get; set; }
        public string ImportString { get; set; }
        public string Package { get; set; }
        public  int PlatingDetailId { get; set; }
        public string VendorCode { get; set; }
        public string VendorName { get; set; }
        public string VendorAddress { get; set; }
        public string VendorContact { get; set;}
        public string VendorPhone { get; set; }
        public string VendorFax { get; set; }

        public string AutoNumber { get; set; }
        public double Number { get; set; }
        public double NumberKg { get; set; }

        public int PackageInt
        {
            get
            {
                try
                {
                    return Convert.ToInt32(Package);
                }
                catch (Exception)
                {
                    // ignored
                }
                return 0;
            }
        }
        public  bool PurchaseManager { get; set; }

        public WorkGroupInfo Info { get; set; }
    }
}