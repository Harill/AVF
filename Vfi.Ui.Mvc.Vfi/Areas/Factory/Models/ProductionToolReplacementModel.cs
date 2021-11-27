using System;
using System.ComponentModel.DataAnnotations;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class ProductionToolReplacementModel
    {
        public int ReplaceId { get; set; }
        public int TrackId { get; set; }
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string ReplaceImg { get; set; }
        public int ReplaceToolId { get; set; }
        [DataType("_ToolEditTemplate")]
        public string ReplaceToolFullCode { get; set; }
        public int ProductionToolId { get; set; }
        [DataType("_ProductionToolEditTemplate")]
        public string ProductionToolFullCode { get; set; }

        [DataType("NumberAsInt")]
        public int PrepareQuantity { get; set; }
        public double TotalInv { get; set; }
        public double RequireInventory { get; set; }
        public double AutoPrepareQuantity { get; set; }
        public string Note { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }

        public string ToolImg { get; set; }
        public string UploadDate { get; set; }
    }
}