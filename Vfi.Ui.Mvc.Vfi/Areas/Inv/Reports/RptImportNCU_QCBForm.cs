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
    public partial class RptImportNCU_QCBForm : Telerik.Reporting.Report
    {
        public RptImportNCU_QCBForm()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            this.Name = "NhapGiaCongNgoai";
            this.pictureBox1.Value = Properties.Resources.ql_muahang;
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
            var list = (List<PrintImportNCU_QCBModel>)models;
            var data = list.FirstOrDefault();
            if (data != null) {
                this.picLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch;
                this.picLogo.Value = data.Info.Logo;
                this.Name = "Plating_Import_" + data.ImportDateString;
            }
        }
    }
}