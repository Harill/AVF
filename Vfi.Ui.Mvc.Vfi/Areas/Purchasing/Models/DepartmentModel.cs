using System;
namespace Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models
{
    public class DepartmentModel 
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}