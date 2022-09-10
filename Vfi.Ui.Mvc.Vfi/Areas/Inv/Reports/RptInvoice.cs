using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptInvoice : Telerik.Reporting.Report
    {
        public RptInvoice()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.pictureBox1.Value = Properties.Resources.LOGO_ISO;
            //this.picLogo.Value = "/vfi/Content/Images/Logo/Logo-VF.png";
            this.picLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch;
            //this.txtLogo.Style.BackgroundImage. = "/vfi/Content/Images/Logo/Logo-VF.png";
            //this.pictureBox1.Value = "/vfi/Content/Images/Logo/Logo-VF.png";
            //this.Name = "Invoice_PackingList";
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
            var invoices = (List<PrintInvoiceModel>)models;
            var invoice = invoices.FirstOrDefault();
            this.picLogo.Value = invoice.Info.Logo;
            this.Name = "Invoice_" + invoice.CustomerCode + "_" + invoice.ShiftmentDateString;
        }
        
        public static string FormatPrice(double value, string currency)
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
                formatted = String.Format("{0:N2}", value);
            }
            return formatted;
        }
    }
}