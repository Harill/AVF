using System;
using System.Collections.Generic;
using System.Globalization;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptMaterialLotCard : Telerik.Reporting.Report
    {
        public RptMaterialLotCard()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            this.Name = "NhanNguyenLieu";
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
        }
    }
}