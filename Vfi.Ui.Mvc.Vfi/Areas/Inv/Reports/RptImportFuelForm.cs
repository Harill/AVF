using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Reflection;
using Telerik.ReportViewer.WebForms;
using Telerik.Reporting;
using Telerik.Reporting.Processing;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptImportFuelForm : Telerik.Reporting.Report
    {
        public RptImportFuelForm()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            this.Name = "NhapBB_HC_NL";
            this.pictureBox1.Value = Properties.Resources.ql_muahang;
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

        public static string FormatQuality(double? value)
        {
            return String.Format("{0:n0,0}", value.Value) ?? "0";
        }
    }
}