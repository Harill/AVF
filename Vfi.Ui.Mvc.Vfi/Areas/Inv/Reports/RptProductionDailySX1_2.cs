using System;
using System.Collections.Generic;
using System.Globalization;
using Telerik.Reporting.Drawing;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;
using Vfi.Ui.Mvc.Vfi.Models.Production;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Reports
{
    /// <summary>
    /// Summary description for RptMaterialInvManagement.
    /// </summary>
    public partial class RptProductionDailySX1_2 : Telerik.Reporting.Report
    {
        public RptProductionDailySX1_2()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.Name = "BaoCaoSanXuatHangNgay";
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
        public static string FormatNumber(double? value)
        {
            string formatted = "-";
            if (value == 0 || value == null) return "";
                formatted = String.Format("{0:N0}", value);
            return formatted;
        }


        public static int GetMachineRun(string shift1Name, string shift2Name,string shiftName, int shift1Run,int shift2Run)
        {
            if (shift1Name.Contains(shiftName))
                return shift1Run;
            if (shift2Name.Contains(shiftName))
                return shift2Run;
            return 0;
        }

        public static double GetValueByShift(List<Shift> list, string shiftName, int valueGet)
        {
            try
            {
                var shift = new Shift();
                foreach (var shift1 in list)
                {
                    if (string.IsNullOrWhiteSpace(shift1.ShiftName))
                        return 0;
                    if (shift1.ShiftName.Contains(shiftName))
                    {
                        shift = shift1;
                        break;
                    }
                }
                switch (valueGet)
                {
                    case 0:
                        return shift.Quantity;
                    case 1:
                        return shift.MaterialUse;
                    case 2:
                        return shift.DefectQuantity;
                    case 3:
                        return shift.DifferenceRate;
                    case 4:
                        return shift.ProcessingQuantity;
                    case 5:
                        return shift.ProductionPrice;
                    case 6:
                        return Math.Round(shift.ProductCost / 1000000, MyUtilities.Product.ProductionDecimalPoint);
                        return shift.ProductCost;
                    case 7:
                        return shift.ProductCostInMonth;
                }
            }
            catch (Exception ex)
            {

            }
            return 0;
        }
        public static double FormatNumber(double value)
        {
            return Math.Round(value / 1000000, 0, MidpointRounding.AwayFromZero);
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
                case 5:
                    return list[index].ProductionPrice;
                case 6:
                    return Math.Round(list[index].ProductCost / 1000000, MyUtilities.Product.ProductionDecimalPoint);
                case 7:
                    return list[index].ProductCostInMonth;
            }
            return 0;
        }

        public static object GetValueFormat(List<Shift> list, int index, int valueGet)
        {
            switch (valueGet)
            {
                case 0:
                    if (list[index].Quantity == 0) return "-";
                    return list[index].Quantity;
                case 1:
                    if (list[index].MaterialUse == 0) return "-";
                    return list[index].MaterialUse;
                case 2:
                    if (list[index].DefectQuantity == 0) return "-";
                    return list[index].DefectQuantity;
                case 3:
                    if (list[index].DifferenceRate == 0) return "-";
                    return list[index].DifferenceRate;
                case 4:
                    if (list[index].ProcessingQuantity == 0) return "-";
                    return list[index].ProcessingQuantity;
            } 
            return "-";
        }
        public static string GetShiftName(List<Shift> list, int shiftType)
        {
            return "Ca";
        }
    }
}