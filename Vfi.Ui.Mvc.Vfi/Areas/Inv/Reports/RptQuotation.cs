using System;
using System.Collections.Generic;
using System.Globalization;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptQuotation : Telerik.Reporting.Report
    {
        public RptQuotation()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            //this.pictureBox1.Value = Properties.Resources.LOGO_ISO;
            this.Name = "Quotation";
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
        }
        public static double? GetItemValue(List<double?> values, int index)
        {
            return values[index];
        }

        public static string KhoSX1(DateTime date)
        {
            return "Kho SX1\n" + (date.Day - 1) + "/" + date.Month;
        }

        public static string FormatQuality(double? value)
        {
            return String.Format("{0:n0,0}", value.Value) ?? "0";
            
        }

        public static double FormatPrice(double value, string currency)
        {
            if (currency == "USD")
                value = Math.Round(value, 4);
            else
                value = Math.Round(value, 0);
            return value;
        }

        public static string FormatAmount(double value, string currency)
        {
            string formatted = "";
            if (value == 0) return "-";
            if (currency.Equals("VND"))
            {
                //formatted = value.ToString("{0:N0}");
                formatted = String.Format("{0:N0}", value);
            }
            else
            {
                //formatted = value.ToString("{0:N4}");
                formatted = String.Format("{0:N4}", value);
            }
            return formatted;
        }
    }
}