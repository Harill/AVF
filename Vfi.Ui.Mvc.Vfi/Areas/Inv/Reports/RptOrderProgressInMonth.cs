using System;
using System.Collections.Generic;
using System.Globalization;
using Telerik.Reporting.Drawing;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptOrderProgressInMonth : Telerik.Reporting.Report
    {
        public RptOrderProgressInMonth()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.Name = "BaoCaoTinhTrangSpTrongThang";
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
    }
}