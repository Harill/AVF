using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductionPlating
    {
        public int PlatingId { get; set; }
        public string PlatingName { get; set; }
        public string Description { get; set; }
        public double PlatingCost { get; set; }
        public bool Active { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int ProductId { get; set; }
        public System.DateTime InsertDate { get; set; }
        public string InserUser { get; set; }
        public int PlatingIndex { get; set; }
        public int PlatingDay { get; set; }
        public string Thickness { get; set; }
        public string SaltSprayTime { get; set; }
        public bool IsMainProcess { get; set; }
        public virtual Product Product { get; set; }
    }
}
