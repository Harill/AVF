using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class CustomerAccessPermissionModel
    {
        public int RoleId { get; set; }
        public int CustomerId { get; set; }
        public int UserId { get; set; }
        [DataType("_UserEditTemplate")]
        public string UserName { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}