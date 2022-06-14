
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.Models.Inv;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models
{
    public class WarehouseModel: WarehouseDomainModel
    {
        public string ShortName { get; set; }
        public bool CanInternal { get; set; }
        public bool CanPurchase { get; set; }
        public bool IsHeatTreatment { get; set; }
        public bool IsPolish { get; set; }
        public bool IsReprocessing { get; set; }
        public bool IsProduction2 { get; set; }
        public bool IsProduction2Process { get; set; }
        public bool IsMainProcess { get; set; }
        public bool IsQC { get; set; }
        public bool IsPlating { get; set; }
        public bool CanStock { get; set; }
        public bool IsOutOfProcess { get; set; }
        public bool IsProduction { get; set; }
        public bool IsCncMilling { get; set; }
        public bool CanWeighing { get; set; }
        public bool IsPacking { get; set; }
        public bool IsFinish { get; set; }
    }

    public class WarehouseCboModel {
        public int Idx { get; set; }
        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
    }

    public class WarehouseConfiguration {
        public WarehouseConfiguration() {
            Ids = new List<int>();
        }
        public List<int> Ids { get; set; }
        public bool? CanInternal { get; set; }
        public bool? CanPurchase { get; set; }
        public bool? IsHeatTreatment { get; set; }
        public bool? IsPolish { get; set; }
        public bool? IsReprocessing { get; set; }
        public bool? IsProduction { get; set; }
        public bool? IsProduction2 { get; set; }
        public bool? IsProduction2Process { get; set; }
        public bool? IsMainProcess { get; set; }
        public bool? IsQC { get; set; }
        public bool? IsPlating { get; set; }
        public bool? IsPacking { get; set; }
        public bool? IsFinish { get; set; }
        public bool? CanStock { get; set; }
        public bool? IsOutOfProcess { get; set; }
        public bool? IsCncMilling { get; set; }
        public bool? CanWeighing { get; set; }

        public bool? AddFirstAll { get; set; }
    }
}