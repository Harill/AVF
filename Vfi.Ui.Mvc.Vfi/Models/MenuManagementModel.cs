using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public class MenuManagementModel
    {
        public int MenuId { get; set; }
        public string MenuCode { get; set; }
        //tên menu
        public string MenuName { get; set; }
        //menu cha
        public int? ParentId { get; set; }
        //tên menu cha
        [DataType("_MenuParentTemplate")]
        public string ParentName { get; set; }
        // cap độ
        public byte MenuLevel { get; set; }
        public string ProjectName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Area { get; set; }
        public string Description { get; set; }
        public byte Index { get; set; }
        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int FunctionId { get; set; }

        public int ChildrenCount { get; set; }
    }
}