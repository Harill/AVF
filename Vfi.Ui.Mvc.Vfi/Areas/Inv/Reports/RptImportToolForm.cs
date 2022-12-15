using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Vfi.Ui.Mvc.Vfi.Areas.Purchasing.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptImportToolForm : Telerik.Reporting.Report
    {
        public RptImportToolForm()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            this.Name = "NhapCC";
            //this.pictureBox1.Value = Properties.Resources.ql_muahang;
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
            var list = (List<TransactionFptDetailModel>)models;
            var data = list.FirstOrDefault();
            if (data != null) {
                this.picLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch;
                this.picLogo.Value = data.Info.Logo;
                this.Name = "Rotate_Product_" + data.TransactionDate.ToString("yy_MM_dd");
            }
        }
    }
}