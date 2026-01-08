using System;
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class ProcessingTypeModel
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        [DataType("Number4Digit")]
        public double ProcessingFactor { get; set; }
        [DataType("Number4Digit")]
        public double ProcessingSaleFactor { get; set; }

        public int IsProductionManagement { get; set; }
        public int IsSaleManagement { get; set; }

        public int ForWarehouseId { get; set; }
        public int ForIdx { get; set; }

        [DataType("_WarehouseMainProcessTemplate")]
        public string WarehouseName { get; set; }

    }
}