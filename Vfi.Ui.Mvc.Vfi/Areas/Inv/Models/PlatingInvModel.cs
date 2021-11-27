using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class PlatingInvModel
    {
        public PlatingInvModel()
        {
            EarlyInventory = 0;
            Weight = 0;
            LastInventory = 0;
        } 
        public int GlobalIndex { get; set; }    
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }

        public double Weight { get; set; }

        public double EarlyInventory { get; set; }

        public double EarlyInventoryKg
        {
            get { return EarlyInventory*Weight; }
        }

        public double ImportWaiting { get; set; }

        public double ExportQcB { get; set; }

        public double LastInventory { get; set; }
        public double LastInventoryKg
        {
            get { return LastInventory * Weight; }
        }
    }
}