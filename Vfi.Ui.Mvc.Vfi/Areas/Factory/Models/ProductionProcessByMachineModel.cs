
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class ProductionProcessByMachineModel
    {
        public int DetailId { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        [DataType("_WarehouseEditTemplate")]
        public string WarehouseName { get; set; }
        public string ProductCode { get; set; }
        public int ProcessIndex { get; set; }
        public double UnitWeight { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string Note { get; set; }
    }
}