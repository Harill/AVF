using System;
using System.Collections.Generic;
using System.Globalization;
using Telerik.Reporting.Drawing;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptSalesYearly : Telerik.Reporting.Report
    {
        public RptSalesYearly()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.Name = "BaoCaoMuaBan";
            //var styleSheet = new ExternalStyleSheet("bcth1");
            //this.ExternalStyleSheets.Add(styleSheet);
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
        }

       // public static string 

        public static string FormatNumber(double value)
        {
            string formatted = "-";
            if (value != 0)
                formatted = String.Format("{0:N0}", value);
            return formatted;
        }

        public static double GetValueFormat(List<SalesReport> list, int index, int valueGet)
        {
            return GetValue(list, index, valueGet);
            //switch (valueGet)
            //{
            //    case 0:
            //        if (list[index].OrderQuantity == 0) return "-";
            //        return string.Format("{0:n0}", list[index].OrderQuantity);
            //    case 1:
            //        if (list[index].ExportQuantity == 0) return "-";
            //        return string.Format("{0:n0}", list[index].ExportQuantity);
            //    case 2:
            //        if (list[index].ProductionQuantity == 0) return "-";
            //        return string.Format("{0:n0}", list[index].ProductionQuantity);
            //    case 3:
            //        if (list[index].ForecastQuantity == 0) return "-";
            //        return string.Format("{0:n0}", list[index].ForecastQuantity);
            //}
            //return "-";
        }

        public static double GetValue(List<SalesReport> list, int index, int valueGet)
        {
            switch (valueGet)
            {
                case 0:
                    return list[index].OrderQuantity;
                case 1:
                    return list[index].ExportQuantity;
                case 2:
                    return list[index].ProductionQuantity;
                case 3:
                    return list[index].ForecastQuantity;
            }
            return 0;
        }
    }
}