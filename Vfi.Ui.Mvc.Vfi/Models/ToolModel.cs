using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public class ToolModel
    {
        public ToolModel() {

        }
        public int ToolId { get; set; }
        public string ToolName { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ToolCode { get; set; }
        public string ToolFullCode { get; set; }
        public string ToolFullDesign { get { return GetFullToolDesign(); } }
        public string ToolDesignNo { get; set; }
        public string ToolMaterial { get; set; }
        public double UnitPrice { get; set; }
        public string GetFullToolCode() {
            var str = ToolCode + "(" + ToolDesignNo + ")";
            if (!string.IsNullOrWhiteSpace(ToolMaterial))
                str += ("-" + ToolMaterial);
            if (!string.IsNullOrWhiteSpace(ToolProduction))
                str += ("-" + ToolProduction);
            return str;
        }
        public string GetFullToolDesign() {
            var str = ToolDesignNo;
            if (!string.IsNullOrWhiteSpace(ToolMaterial))
                str += ("-" + ToolMaterial);
            if (!string.IsNullOrWhiteSpace(ToolProduction))
                str += ("-" + ToolProduction);
            return str;
        }

        public int MaterialTypeId { get; set; }
        [UIHint("_MaterialToolTypeEditTemplate")]
        public string MaterialTypeName { get; set; }

        public int ToolType { get; set; }
        [UIHint("_ToolTypeEditTemplate")]
        public string ToolTypeName { get; set; }
        [UIHint("_UploadTemplate")]
        public string Img { get; set; }
        public string UploadDate { get; set; }
        public string ToolProduction { get; set; }

        public bool IsDeleted { get; set; }
    }
}