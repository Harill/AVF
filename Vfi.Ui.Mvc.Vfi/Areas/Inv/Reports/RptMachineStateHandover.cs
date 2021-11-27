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
    public partial class RptMachineStateHandover : Report
    {
        public RptMachineStateHandover()
        {
           
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            //this.ItemDataBinding += new EventHandler(ProductCatalog_ItemDataBinding);
            this.Name = "Ban giao ca";
        }

        public void BindDataOwner(object models)
        {
            DataSource = models;
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
        public static string FormatAmount(double value)
        {
            string formatted = "";
            if (value == 0) return "-";
                //formatted = value.ToString("{0:N4}");
            formatted = String.Format("{0:N1}", value);
            
            return formatted;
        }
        public static string FormatPrice(double value)
        {
            string formatted = "";
            if (value == 0) return "-";
            //formatted = value.ToString("{0:N4}");
            formatted = String.Format("{0:N0}", value);

            return formatted;
        }
    }
}