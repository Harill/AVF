namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for Report2.
    /// </summary>
    public partial class RptProductionSX1 : Telerik.Reporting.Report
    {
        public RptProductionSX1()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public void BindDataOwner(object models)
        {
            DataSource = models;
        }
    }
}