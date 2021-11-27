using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public class DbSystemMonitorModel
    {
        public DbSystemMonitorModel()
        {
            Type = 0;
        }
        public int Type { get; set; }

        public string TypeName
        {
            get { return MyUtilities.Monitor.GetText(Type); }
        }
        public string WaresouseName
        {
            get { return GetWaresouseName(); }
        }
        public string GetWaresouseName()
        {
            using (var vfi = new vfiContext())
            {
                var warehouse = vfi.Warehouses.FirstOrDefault(w => w.WarehouseId == Type);
                if (warehouse != null)
                    return warehouse.WarehouseName;
                return "";
            }
        }

        public int Count { get; set; }
    }
    public class MonitorDetailModel
    {
        public string Type { get; set; }
        public int Id { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
    }
}