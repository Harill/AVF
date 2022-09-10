using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptPlatingForm : Telerik.Reporting.Report
    {
        public RptPlatingForm()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            this.Name = "NhapBB_HC_NL";
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
            var list = (List<PlatingDetailModel>)models;
            var data = list.FirstOrDefault();
            this.picLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch;
            this.picLogo.Value = data.Info.Logo;
            this.Name = "Plating_Export_" + data.ExportDate.ToString("yy_MM_dd");
        }
    }
}