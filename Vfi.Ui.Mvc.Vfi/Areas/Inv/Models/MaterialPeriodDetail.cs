namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class MaterialPeriodDetail
    {
        public int MaterialId { get; set; }
        public int MaterialInvId { get; set; }
        public string MaterialLotNumber { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }

        public int ProductId { get; set; }
        public string ProductCode { get; set; }

        public double ProductQuantity { get; set; }
        public double ProductWeight { get; set; }
        public double MaterialExportQuantity { get; set; }
        public double TotalProductQuantity { get; set; }
        public double ProductForecastsQuality { get; set; }
        public double ProductionRate { get; set; }
        public string Note { get; set; }
        public byte Status { get; set; }

        public int VendorId { get; set; }
        public string VendorCode { get; set; }
        public string VendorName { get; set; }

        public double MaterialRequired { get; set; }
    }
}