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
    public partial class RptExportMaterial : Telerik.Reporting.Report
    {
        public RptExportMaterial()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
            var list = (List<PrintTransactionMaterialModel>)models;
            var data = list.FirstOrDefault();
            this.picLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch;
            this.picLogo.Value = data.Info.Logo;
            this.Name = "Export_Material_" + data.CreatedDate.ToString("yy_MM_dd");
        }
    }
}