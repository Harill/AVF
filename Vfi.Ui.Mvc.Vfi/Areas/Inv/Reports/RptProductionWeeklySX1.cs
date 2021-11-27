using System;
using System.Collections.Generic;
using System.Globalization;
using Telerik.Reporting.Drawing;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptProductionWeeklySX1 : Telerik.Reporting.Report
    {
        public RptProductionWeeklySX1()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.Name = "BaoCaoTongHop";
            //var styleSheet = new ExternalStyleSheet("bcth1");
            //this.ExternalStyleSheets.Add(styleSheet);
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
        }
        public static double? GetItemValue(List<double?> values, int index)
        {
            return values[index];
        }

        public static string KhoSX1(DateTime date)
        {
            return "Kho SX1\n" + (date.Day - 1) + "/" + date.Month;
        }

       // public static string 

        public static string FormatQuality(double? value)
        {
            return String.Format("{0:n0,0}", value.Value) ?? "0";
            
        }
        public static string FormatNumber(double? value)
        {
            string formatted = "";
            if (value == 0 || value == null) return "";
                formatted = String.Format("{0:N0}", value);
            return formatted;
        }
    }
}