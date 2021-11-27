using System;
using System.Collections.Generic;
using System.Globalization;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptProductionForm : Telerik.Reporting.Report
    {
        public RptProductionForm()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            this.Name = "ThongTinSP";
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
        }
    }
}