using System;
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class ToolInvRequirementModel {

        public int RequirementId { get; set; }
        public int ToolTypeId { get; set; }
        public string ToolTypeName { get; set; }

        public int ToolId { get; set; }
        [DataType("_ToolEditTemplate")]
        public string ToolFullCode { get; set; }
        public DateTime StartDate { get; set; }
        [DataType("Number0")]
        public double RequireQuantity { get; set; }
        public string Note { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}