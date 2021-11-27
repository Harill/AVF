using System;
using System.ComponentModel;
using System.Globalization;
using Telerik.Reporting;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for Report1.
    /// </summary>
    [Description("Product Catalog Report. (Multilingual)")]
    public partial class RptMaterialDailyReport : Report
    {
        public RptMaterialDailyReport()
        {

            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            //this.ItemDataBinding += new EventHandler(ProductCatalog_ItemDataBinding);
            this.Name = "NLSD_HangNgay";
        }

        public void BindDataOwner(object models)
        {
            DataSource = models;
        }

        private void ProductCatalog_ItemDataBinding(object sender, EventArgs e)
        {
            string cultureID = (string) this.ReportParameters["CultureID"].Value;

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

        public static object Format(double value, int digit)
        {
            //string formatted = "";
            //if (value == 0) return "-";
            ////formatted = value.ToString("{0:N4}");
            //if (digit == 2)
            //    formatted = String.Format("{0:N2}", value);
            //else if (digit == 0)
            //    formatted = String.Format("{0:N0}", value);

            //return formatted;
            if (value == 0) return "-";
            return Math.Round(value, digit);
        }
    }
}