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
    public partial class RptProductionMonthlyDate : Telerik.Reporting.Report
    {
        public RptProductionMonthlyDate()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            this.Name = "SX";
        }
        
        public void BindDataOwner(object models)
        {
            DataSource = models;
        }
        public static double? GetNumberOfDay(double[] values, int index)
        {
            return values[index-1];
        }

        public static double GetValue(List<Shift> list, int index, int valueGet)
        {
            try
            {
                switch (valueGet)
                {
                    case 0:
                        return list[index].MaterialUse;
                    case 1:
                        return list[index].Quantity;
                    case 2:
                        return list[index].ProcessingQuantity;
                    case 3:
                        return list[index].DefectQuantity;
                    case 4:
                        return list[index].DifferenceRate;
                }
            }
            catch (Exception)
            {
                return 0;
            }
            return 0;
        }
        public static double GetValueTotal(List<Shift> list, int valueGet)
        {
            try
            {
                switch (valueGet)
                {
                    case 0:
                        return list.Sum(l=> l.MaterialUse);
                    case 1:
                        return list.Sum(l => l.Quantity);
                    case 2:
                        return list.Sum(l => l.ProcessingQuantity);
                    case 3:
                        return list.Sum(l => l.DefectQuantity);
                    case 4:
                        return list.Sum(l => l.DifferenceRate); ;
                }
            }
            catch (Exception)
            {
                return 0;
            }
            return 0;
        }
        public static string GetValueDate(List<Shift> list, int index)
        {
            try
            {

                return list[index].UseDate.ToString("dd/MM");
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}