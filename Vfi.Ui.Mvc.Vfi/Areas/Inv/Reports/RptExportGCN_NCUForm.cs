using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptExportGCN_NCUForm : Telerik.Reporting.Report
    {
        public RptExportGCN_NCUForm()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            this.Name = "XuatGCN";
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
            var list = (List<PrintExportGCN_NCUModel>)models;
            var data = list.FirstOrDefault();
            if (data != null) {
                this.picLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch;
                this.picLogo.Value = data.Info.Logo;
                this.Name = "Plating_Export_" + data.ExportDateString;
            }
        }
    }
}