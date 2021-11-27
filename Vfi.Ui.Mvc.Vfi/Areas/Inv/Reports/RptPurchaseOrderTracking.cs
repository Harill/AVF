using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using Telerik.Reporting;
using Telerik.Reporting.Drawing;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for Report1.
    /// </summary>
    [Description("Product Catalog Report. (Multilingual)")]
    public partial class RptPurchaseOrderTracking : Report
    {
        public RptPurchaseOrderTracking()
        {
           
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            //this.ItemDataBinding += new EventHandler(ProductCatalog_ItemDataBinding);
            this.Name = "TheoDoiMuaHang";
        }

        public void BindDataOwner(object models)
        {
            DataSource = models;
            //if (models != null)
            //{
            //    var model = (List<PrintGroupMaterial>) models;
            //    var rows = model[0].CountRow;
            //    if (rows >= 30 && rows <= 37)
            //    {
            //        PageSettings.Margins.Bottom = new Unit(1, UnitType.Inch);
            //    }
            //}
        }
        void ProductCatalog_ItemDataBinding(object sender, EventArgs e)
        {
            string cultureID = (string)this.ReportParameters["CultureID"].Value;

            CultureInfo cultureInfo = null;
            if (string.Compare(cultureID, "zh-CHT", true, CultureInfo.InvariantCulture) == 0)
            {
                cultureInfo = new CultureInfo("zh-TW", false);
            }
            else
            {
                cultureInfo = new CultureInfo(cultureID);
            }

            this.Culture = cultureInfo;
        }
        public static object FormatAmount(double value)
        {
            if (value == 0) return "-";
            return value;
        }
    }
}