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
    public partial class RptExpectedProduction2Plan : Telerik.Reporting.Report
    {
        public RptExpectedProduction2Plan()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            this.Name = "KHSX2";
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
        }
    }
}