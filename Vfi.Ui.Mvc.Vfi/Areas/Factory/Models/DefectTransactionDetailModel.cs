using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class DefectTransactionDetailModel
    {
        public DefectTransactionDetailModel() {
            QuantityDefect = 0;
            UnitWeight = 0;
        }
        public long DetailId { get; set; }
        public long TransactionId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double UnitWeight { get; set; }
        public int DefectId { get; set; }
        public string DefectName { get; set; }
        public string DefectExpand { get; set; }
        public string Note { get; set; }
        public Nullable<int> MachineId { get; set; }
        public string MachineName { get; set; }
        [DataType("Number")]
        public double QuantityDefect { get; set; }
        [DataType("Number")]
        public double QuantityDefectKg { get; set; }
        [DataType("Number")]
        public double RequireQuantityDefect { get; set; }
        [DataType("Number")]
        public double RequireQuantityDefectKg { get; set; }
        public bool Destroy { get; set; }
        public bool Recheck { get; set; }
        public bool Reprocess { get; set; }
        public bool IsRotateAll { get; set; }
        public int Shift { get; set; }

        public long? ReferenceDetailId { get; set; }
        public Nullable<int> NextWarehouseProcessId { get; set; }
        [DataType("_WarehouseNextEditTemplate")]
        public string NextWarehouseProcessName { get; set; }
        public Nullable<int> RemedyId { get; set; }
        [DataType("_ProductionDefectRemedyTemplate")]
        public string RemedyCode { get; set; }
        public string StoreCode { get; set; }
        // autocomplete
        public int DefaultRemedyId { get; set; }
        public string RemedyName { get; set; }
        public int ProcessWarehouseId { get; set; }
        public string ProcessWarehouseName { get; set; }

    }
}