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
    public partial class RptPlatingPrice : Telerik.Reporting.Report
    {
        public RptPlatingPrice()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            this.Name = "GiaCongNgoai";
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
            var list = (List<PlatingDetailModel>)models;
            var data = list.FirstOrDefault();
            if (data != null) {
                this.picLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch;
                this.picLogo.Value = data.Info.Logo;
                this.Name = "Plating_Report_" + DateTime.Today.ToString("yy_MM_dd");
            }
        }
    }
}