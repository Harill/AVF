namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports {
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
    using Vfi.Areas.Factory.Models;

    /// <summary>
    /// Summary description for Report2.
    /// </summary>
    public partial class RptWorkOrder : Telerik.Reporting.Report {
        public RptWorkOrder() {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.Name = "WorkOrder";
        }

        public void BindDataOwner(object models) {
            DataSource = models;
            var data = (WorkOrderModel)models;
            this.Name = "WorkOrder_" + data.SerialNumber;
        }
    }
}