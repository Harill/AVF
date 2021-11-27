
using Vfi.Server.Core.DataModel.Models.Sales;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class EmployeeModel: EmployeeDomainModel
    {
        public bool Production2 { get; set; }
        public bool Production2B { get; set; }
        public bool Repair { get; set; }
        public bool QcLine { get; set; }
        public string GroupName { get; set; }
    }
}