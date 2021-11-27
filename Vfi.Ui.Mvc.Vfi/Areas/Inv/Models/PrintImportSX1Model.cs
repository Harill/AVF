using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class PrintImportSX1Model
    {

        public DateTime ImportDate { get; set; }
        public string ImportDateString { get; set; }
        public string Machine { get; set; }
        public string ProductCode { get; set; }
        public string TransactionCode { get; set; }

        public string Shift1Name { get; set; }
        public double Number1 { get; set; }
        public double DefectProduct1 { get; set; }
        public double MaterialUse1 { get; set; }
        public double Processing1 { get; set; }

        public string Shift2Name { get; set; }
        public double Number2 { get; set; }
        public double DefectProduct2 { get; set; }
        public double MaterialUse2 { get; set; }
        public double Processing2 { get; set; }

        public double TotalNumber { get; set; }
        public double TotalDefect { get; set; }

        public string StatusName { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedDateString { get; set; }
    }
}