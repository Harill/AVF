using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class Tool
    {
        public Tool()
        {
            this.ProductionTools = new List<ProductionTool>();
            this.ProductionTools1 = new List<ProductionTool>();
            this.ProductionToolReplacements = new List<ProductionToolReplacement>();
            this.ToolDetails = new List<ToolDetail>();
            this.ToolInventories = new List<ToolInventory>();
            this.ToolInventoryPeriods = new List<ToolInventoryPeriod>();
            this.ToolInventoryRequirements = new List<ToolInventoryRequirement>();
            this.ToolPeriods = new List<ToolPeriod>();
        }

        public int ToolId { get; set; }
        public string ToolName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ToolCode { get; set; }
        public string ToolFullCode { get; set; }
        public string ToolDesignNo { get; set; }
        public double UnitPrice { get; set; }
        public string ToolMaterial { get; set; }
        public int MaterialTypeId { get; set; }
        public int ToolTypeId { get; set; }
        public string Img { get; set; }
        public string ToolProduction { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public virtual ICollection<ProductionTool> ProductionTools { get; set; }
        public virtual ICollection<ProductionTool> ProductionTools1 { get; set; }
        public virtual ICollection<ProductionToolReplacement> ProductionToolReplacements { get; set; }
        public virtual MaterialType MaterialType { get; set; }
        public virtual ICollection<ToolDetail> ToolDetails { get; set; }
        public virtual ICollection<ToolInventory> ToolInventories { get; set; }
        public virtual ICollection<ToolInventoryPeriod> ToolInventoryPeriods { get; set; }
        public virtual ICollection<ToolInventoryRequirement> ToolInventoryRequirements { get; set; }
        public virtual ICollection<ToolPeriod> ToolPeriods { get; set; }
    }
}
