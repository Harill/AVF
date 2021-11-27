using System;
using System.Collections.Generic;
using System.Globalization;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptProduction2Period : Telerik.Reporting.Report
    {
        public RptProduction2Period()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            this.Name = "San xuat 2";
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
        }
        public static double? GetItemValue(List<double?> values, int index)
        {
            return values[index];
        }
        public static string Formatnumber(double value)
        {
            if (value == 0) return "-";
            return string.Format("{0:n0}", value);
        }

        public static string KhoSX1(DateTime date)
        {
            return "Kho SX1\n" + (date.Day - 1) + "/" + date.Month;
        }

        public static string FormatQuality(double? value)
        {
            return String.Format("{0:n0,0}", value.Value) ?? "0";
            
        }
    }
}