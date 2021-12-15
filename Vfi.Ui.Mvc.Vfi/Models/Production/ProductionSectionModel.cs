using System;
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Models.Production
{
    public class ProductionSectionModel
    {
        public int SectionId { get; set; }
        [UIHint("_SectionTemplate")]
        public string SectionName { get; set; }
        [DataType("Number")]
        public double SectionCost { get; set; }
        [DataType("Number3Digit")]
        public double Weight { get; set; }
        public double SectionCostKg { get; set; }
        public string Description { get; set; }
        public DateTime InsertDate { get; set; }
        public string InsertUser { get; set; }
        public DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public bool Active { get; set; }
        public int ProductId { get; set; }
        [DataType("Number2Digit")]
        public double Productivity { get; set; }
        public int IsProductionManagement { get; set; }
        public int IsSaleManagement { get; set; }
        [DataType("Int")]
        public int SectionIndex { get; set; }
        public int ProductionSectionId { get; set; }
        public int WarehouseId { get; set; }
        public bool IsMainProcess { get; set; }

        public int MachineId { get; set; }
        [UIHint("_MachineProduction2Template")]
        public string MachineName { get; set; }
    }
}