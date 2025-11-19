using System;
using System.Collections.Generic;
using System.Globalization;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptWorkOrderFinishCard : Telerik.Reporting.Report
    {
        public RptWorkOrderFinishCard()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            this.Name = "ItemCard";
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
        }
    }
}