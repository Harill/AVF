using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using Telerik.Reporting;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for Report1.
    /// </summary>
    [Description("Product Catalog Report. (Multilingual)")]
    public partial class RptMachineProductionOnTest : Report
    {
        public RptMachineProductionOnTest()
        {
           
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            //this.ItemDataBinding += new EventHandler(ProductCatalog_ItemDataBinding);
            this.Name = "Testing";
        }

        public void BindDataOwner(object models)
        {
            DataSource = models;
        }

        public static string FormatAmount(double value)
        {
            string formatted = "";
            if (value == 0) return "";
            //formatted = String.Format("{0:N1}", value);
            
            return formatted;
        }
        // 254, 67, 67
        public static string GetHeader(List<ProductionTestingReportDetailModel> data, int index) {
            return data[index].Hour + ":00";
        }
        public static int GetColor(List<ProductionTestingReportDetailModel> data, int index) {
            return data[index].Valid;
        }
        public static string GetData(List<ProductionTestingReportDetailModel> data, int index) {
            string formatted = "";
            if (string.IsNullOrWhiteSpace(data[index].EmployeeCode)) {
                if (data[index].Number == 0) return "";
                formatted = data[index].Number.ToString();
            }
            else { formatted = data[index].EmployeeCode; }
            return formatted;
        }
    }
}