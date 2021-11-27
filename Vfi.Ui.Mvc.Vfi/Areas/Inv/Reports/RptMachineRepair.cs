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
    public partial class RptMachineRepair : Report
    {
        public RptMachineRepair()
        {
           
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            //this.ItemDataBinding += new EventHandler(ProductCatalog_ItemDataBinding);
            this.Name = "TinhTrangMay";
        }

        public void BindDataOwner(object models)
        {
            DataSource = models;
        }
        public static Telerik.Reporting.Drawing.Unit GetHeight(int count)
        {
            return Telerik.Reporting.Drawing.Unit.Inch(0.34*count);
        }

        public static string FormatUnitPrice(double value, string currency)
        {
            string formatted = "";
            if (currency.Equals("VND"))
            {
                //formatted = value.ToString("{0:N0}");
                formatted = String.Format("{0:N0}", value);
            }
            else
            {
               // formatted = value.ToString("{0:N4}");
                formatted = String.Format("{0:N4}", value);
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