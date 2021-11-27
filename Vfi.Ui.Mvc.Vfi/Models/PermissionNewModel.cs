using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public class PermissionNewModel
    {
        public int PermissionId { get; set; }
        public int UserId { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string Description { get; set; }
        public int FunctionId { get; set; }
        public string FunctionName { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}