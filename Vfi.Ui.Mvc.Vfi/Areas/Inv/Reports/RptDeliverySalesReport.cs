using System;
using System.Collections.Generic;
using System.Globalization;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptDeliverySalesReport : Telerik.Reporting.Report
    {
        public RptDeliverySalesReport()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            this.Name = "DeliverySalesReport_" + DateTime.Today.ToString("dd_MM_yyyy");
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
        }

        void Status_ItemDataBinding(object sender, EventArgs e, string statusColor) {
            var entity = (Telerik.Reporting.TextBox)sender;

            //CultureInfo cultureInfo = null;
            //if (string.Compare(cultureID, "zh-CHT", true, CultureInfo.InvariantCulture) == 0) {
            //    cultureInfo = new CultureInfo("zh-TW", false);
            //}
            //else {
            //    cultureInfo = new CultureInfo(cultureID);
            //}

            //this.Culture = cultureInfo;
        }
    }
}