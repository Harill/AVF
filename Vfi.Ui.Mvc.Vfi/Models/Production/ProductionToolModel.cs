using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Models.Production
{
    public class ProductionToolModel
    {
        public int RealToolId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double ProductOrder { get; set; }
        public int ToolId { get; set; }
        public string ToolCode { get; set; }
        public string ToolName { get; set; }
        [UIHint("_ToolEditTemplate")]
        public string ToolFullCode { get; set; }
        public string ToolDesign { get; set; }
        public string ToolMaterial { get; set; }
        [DataType("Int")]
        public int UseNumber { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public bool ToolActive { get; set; }
        [DataType("Number0")]
        public double Quota { get; set; }
        public int PrepareQuantity { get; set; }
        public double ToolInv { get; set; }
        public int ToolIndex { get; set; }
        public string ToolLocation { get; set; }
        public string Description { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string ToolProduction { get; set; }
        public string MachineName { get; set; }
        public string ToolTypeName { get; set; }

        public int NamingToolId { get; set; }
        [UIHint("_ToolNameSelectTemplate")]
        public string NamingToolName { get; set; }

        public int? ProcessWarehouseId { get; set; }
        [UIHint("_WarehouseEditTemplate")]
        public string ProcessWarehouseName { get; set; }
    }
}