using System;
using System.Collections.Generic;
using System.Globalization;
using Telerik.Reporting.Drawing;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptProductionDefectDaily : Telerik.Reporting.Report
    {
        public RptProductionDefectDaily()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.Name = "BaoCaoThongKeHangLoi";
            //var styleSheet = new ExternalStyleSheet("bcth1");
            //this.ExternalStyleSheets.Add(styleSheet);
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

       // public static string 

        public static string FormatQuality(double? value)
        {
            return String.Format("{0:n0,0}", value.Value) ?? "0";
        }
        public static string FormatNumber(double value)
        {
            string formatted = "-";
            if (value != 0)
                formatted = String.Format("{0:N0}", value);
            return formatted;
        }
       
        public static double GetValue(List<Shift> list,int index , int valueGet)
        {
            switch (valueGet)
            {
                case 0:
                    return list[index].Quantity;
                case 1:
                    return list[index].MaterialUse;
                case 2:
                    return list[index].DefectQuantity;
                case 3:
                    return list[index].DifferenceRate;
                case 4:
                    return list[index].ProcessingQuantity;
            }
            return 0;
        }
        public static string GetValueFormat(List<Shift> list, int index, int valueGet)
        {
            string formatted = "-";
            switch (valueGet)
            {
                case 0:
                    if (list[index].Quantity != 0)
                        formatted = String.Format("{0:N0}", list[index].Quantity);
                    break;
                case 1:
                    if (list[index].MaterialUse != 0)
                        formatted = String.Format("{0:N2}", list[index].MaterialUse);
                    break;
                case 2:
                    if (list[index].DefectQuantity != 0)
                        formatted = String.Format("{0:N0}", list[index].DefectQuantity);
                    break;
                case 3:
                    if (list[index].DifferenceRate != 0)
                        formatted = String.Format("{0:N0}", list[index].DifferenceRate);
                    break;
                case 4:
                    if (list[index].ProcessingQuantity != 0)
                        formatted = String.Format("{0:N0}", list[index].ProcessingQuantity);
                    break;
            }
            return formatted;
        }
        public static string GetShiftName(List<Shift> list, int shiftType)
        {
            
            return "Ca";
        }
    }
}