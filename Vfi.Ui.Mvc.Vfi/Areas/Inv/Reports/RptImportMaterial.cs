using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptImportMaterial : Telerik.Reporting.Report
    {
        public RptImportMaterial()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            //this.Name = "NhapKhoNguyenLieu";
            //this.pictureBox1.Value = Properties.Resources.ql_muahang;
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
            var list = (List<PrintTransactionMaterialModel>)models;
            var data = list.FirstOrDefault();
            this.picLogo.Sizing = Telerik.Reporting.Drawing.ImageSizeMode.Stretch;
            this.picLogo.Value = data.Info.Logo;
            this.Name = "Import_Material_" + data.CreatedDate.ToString("yy_MM_dd");
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
    }
}