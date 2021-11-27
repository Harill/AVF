using System;
using System.Collections.Generic;
using System.Globalization;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptExportInMonth : Telerik.Reporting.Report
    {
        public RptExportInMonth()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            this.Name = "GiaoHang";
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
        }
        public static double? GetNumberOfDay(double[] values, int index)
        {
            return values[index-1];
        }

    }
}