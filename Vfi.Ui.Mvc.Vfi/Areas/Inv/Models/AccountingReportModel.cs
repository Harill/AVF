using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class AccountingReportModel
    {
        public AccountingReportModel()
        {
            ProductInv = 0;
            ProductionQuantity = 0;
            ImportQuantity = 0;
            DefectQuantity = 0;
            DestroyQuantity = 0;
            ImportFinish = 0;
            ExportSales = 0;
            TaxInvoiceQuantity = 0;
            Details = new List<AccountingReportDetail>();
        }
        public int CustomerId { get; set; }
        public string CustomerCode { get;set; }
        public int ProductId { get; set; }
        public string ProductCustomerCode { get; set; }
        public string ProductCode { get; set; }
        public double ProductInv { get; set; }
        public double ProductionQuantity { get; set; }
        public double MaterialUseQuantity { get; set; }
        public double MaterialUseWeight { get; set; }
        public double ImportQuantity { get; set; }
        public double DefectQuantity { get; set; }
        public double DestroyQuantity { get; set; }
        public double ImportFinish { get; set; }
        public double ExportSales { get; set; }
        public List<AccountingReportDetail> Details { get; set; }

        public string MaterialCode
        {
            get
            {
                var code = "";
                foreach (var detail in Details)
                {
                    if(detail.MaterialId == 0) continue;
                    code += detail.MaterialProductionCode + " | ";
                }
                return code;
            }
        }
        public double MaterialCost
        {
            get { return Details.Count > 0 ? Math.Round(Details.Average(d => d.MaterialCost), 0) : 0; }
        }

        public double TaxInvoiceQuantity { get; set; }
    }

    public class AccountingReportDetail
    {
        public AccountingReportDetail()
        {
            MaterialCost = 0;
        }
        public int MaterialId { get; set; }
        public int MaterialInvId { get; set; }
        public string MaterialProductionCode { get; set; }
        public double MaterialCost { get; set; }
        
    }
}