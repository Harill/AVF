using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class CncFormDetailModel
    {
        public int DetailId { get; set; }
        public int ImportId { get; set; }

        public int MachineId { get; set; }

        public string MachineName { get; set; }

        public int ProductId { get; set; }
        [UIHint("_ProductEditTemplate")]
        public string ProductCode { get; set; }

        public int ProductInvId { get; set; }
        [UIHint("_ProductCodeInvEditTemplate")]
        public string ProductInvCode { get; set; }

        [DataType("Number0")]
        public double Number1 { get; set; }
        [DataType("Number0")]
        public double Processing1 { get; set; }
        [DataType("Number0")]
        public double DefectProduct1 { get; set; }

        [DataType("Number0")]
        public double Number2 { get; set; }
        [DataType("Number0")]
        public double Processing2 { get; set; }
        [DataType("Number0")]
        public double DefectProduct2 { get; set; }

        public double Rate { get; set; }
        public double Productivity { get; set; }

        [DataType("Number3")]
        public double ProductWeight { get; set; }


        public int WarehouseExportId { get; set; }

        [UIHint("_WarehouseRotateEditTemplate")]
        public string WarehouseExportName { get; set; }

        public double InvQuantity { get; set; }
        public int ProcessByMachineId { get; set; }


        public double Number { get; set; }
        public double Processing { get; set; }
        public double DefectProduct { get; set; }
        public string Shift1Name { get; set; }
        public string Shift2Name { get; set; }
        public string MachineType { get; set; }

        public DateTime Date { get; set; }
        public string TransactionCode { get; set; }
    }
}