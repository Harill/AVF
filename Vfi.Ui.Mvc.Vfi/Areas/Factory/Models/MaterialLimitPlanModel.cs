using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class MaterialLimitPlanModel {

        public int LimitId { get; set; }

        [UIHint("_DateTemplateNullable")]
        public DateTime? ApplyDate { get; set; }

        public string ExpiredDateStr {
            get {
                return ApplyDate == null ? "" : ApplyDate.Value.AddDays(ExpiredDay).ToString("dd/MM/yyyy");
            }
        }
        [DataType("NumberAsInt")]
        public int ExpiredDay { get; set; }

        public bool IsLock { get; set; }

        public int MaterialId { get; set; }
        [UIHint("_MaterialEditTemplate")]
        public string MaterialCode { get; set; }
        public string MaterialType { get; set; }

        public int ProductId { get; set; }
        [UIHint("_ProductEditTemplate")]
        public string ProductCode { get; set; }
        public double RawProductionWeight { get; set; }

        [DataType("NumberAsInt")]
        public int WorkpieceLossPercent { get; set; }
        [DataType("NumberAsInt")]
        public int EstimateLossPercent { get; set; }

        [DataType("Number0")]
        public double ProductLimitQuantity { get; set; }

        public double MaterialLimitQuantity {
            get {
                return (ProductLimitQuantity * RawProductionWeight / 1000) * LossPercent / 100;
            }
        }

        public double LossPercent {
            get {
               return WorkpieceLossPercent + EstimateLossPercent + 100;
            }
        }

        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
    }
}