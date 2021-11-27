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
    public partial class RptExpectedSales : Report
    {
        public RptExpectedSales()
        {
           
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            //this.ItemDataBinding += new EventHandler(ProductCatalog_ItemDataBinding);
            this.Name = "DuKienBanHang";
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
        public static string FormatDateValue(DateTime? value)
        {
            string formatted = "";
            if (value!=null)
            {
                //formatted = value.ToString("{0:N0}");
                formatted = String.Format("{0:dd/MM/yyyy}", value);
            }
            return formatted;
        }
        public static string FormatValue(double value)
        {
            string formatted = "-";
            if (value >0)
            {
                //formatted = value.ToString("{0:N0}");
                formatted = String.Format("{0:N0}", value);
            }
            return formatted;
        }
        public static string FormatAmount(double value, string currency)
        {
            string formatted = "";
            if (currency.Equals("VND"))
            {
                //formatted = value.ToString("{0:N0}");
                formatted = String.Format("{0:N0}", value);// +" " + currency;
            }
            else
            {
                //formatted = value.ToString("{0:N4}");
                formatted = String.Format("{0:N2}", value);// +" " + currency;
            }
            return formatted;
        }
    }
}