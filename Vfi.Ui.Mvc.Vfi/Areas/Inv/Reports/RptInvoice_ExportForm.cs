using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptInvoice_ExportForm : Telerik.Reporting.Report
    {
        public RptInvoice_ExportForm()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.pictureBox1.Value = Properties.Resources.LOGO_ISO;
            this.picLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch;
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
            var invoices = (List<PrintInvoiceModel>)models;
            var invoice = invoices.FirstOrDefault();
            this.picLogo.Value = invoice.Info.Logo;
            this.Name = "PackingList_" + invoice.CustomerCode + "_" + invoice.ShiftmentDateString;
        }
    }
}