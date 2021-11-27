using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class Production2PlanModel
    {
        public Production2PlanModel()
        {
            StartDateString = new string[40];
            for (int i = 0; i < 40; i++)
            {
                StartDateString[i] = StartDate.AddDays(i).ToString("dd/MM");
            }
        }

        public int Index { get; set;}
        public string CustomerCode { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double Production2Weight { get; set; }
        public List<Production2PlanDetailModel> Details { get; set; }
        public string[] StartDateString { get; set; }
        public DateTime StartDate { get; set; }
        public double ExportInMonth { get; set; }
    }

    public class Production2PlanDetailModel
    {
        public Production2PlanDetailModel()
        {
            Quantity = new double[]
                {
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0
                }
                ;
            Time = new double[]
                {
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0,
                    0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0
                }
                ;
        }
        public int SectionId { get; set; }
        public string SectionName { get; set;}
        public double SectionProductivity { get; set; }
        public double SectionProductivityInDay { get; set; }
        public double SectionProductivityInDayKg { get; set; }

        public double OrderQuantity { get; set; }
        public string CreateDate { get; set; }
        public int CreateDateStatus { get; set; }
        public string DueDate { get; set; }
        public int DueDateStatus { get; set; }
        public int PrepareDay { get; set; }
        public string FinishDateString { get; set; }
        public double ForecastNextMonth { get; set; }
        
        public double Production2Inv { get; set; }
        public double AfterProduction2Inv { get; set; }

        public double RequirementQuantity { get; set; }
        public double RequirementQuantityKg { get; set; }
        public double RequirementDay { get; set; }
        public int BorderLast { get; set; }
        public double ExportInMonth { get; set; }

        public double[] Quantity { get; set; }
        public double[] Time { get; set; } 

    }

}