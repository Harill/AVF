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
    public partial class RptTransactionFormGroup : Telerik.Reporting.Report
    {
        public RptTransactionFormGroup()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            //this.Name = "PhieuLuanChuyenKho";
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;

            var list = (List<TransactionProductModel>)models;
            var data = list.FirstOrDefault();
            this.picLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch;
            this.picLogo.Value = data.Info.Logo;
            this.Name = "Rorate_Product_" + data.PeriodDate.ToString("yy_MM_dd");
        }
    }
}