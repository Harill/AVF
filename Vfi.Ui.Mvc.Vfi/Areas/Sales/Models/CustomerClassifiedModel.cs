using System;
namespace Vfi.Ui.Mvc.Vfi.Areas.Sales.Models
{
    public class CustomerClassifiedModel
    {
        public int ClassifiedId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}