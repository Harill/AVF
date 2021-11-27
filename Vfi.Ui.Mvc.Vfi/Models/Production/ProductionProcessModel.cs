using System;
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Models.Production
{
    public class ProductionProcessModel
    {
        public int ProcessId { get; set; }
        public int WarehouseId { get; set; }
        [UIHint("_WarehouseEditTemplate")]
        public string WarehouseName { get; set; }
        public int ProductId { get; set; }
        public bool IsAlert { get; set; }
        public bool IsNecessary { get; set; }
        [DataType("Int")]
        public int ProcessIndex { get; set; }
        public string Note { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}