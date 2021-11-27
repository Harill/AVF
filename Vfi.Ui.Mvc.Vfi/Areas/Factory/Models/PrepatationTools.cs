using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class PreparationToolModel {
        public PreparationToolModel() {
            Details = new List<PreparationToolDetail>();
            SameMachines = new List<SamePreparation>();
            Productivity = 0;
        }
        public int Index { get; set; }
        public int TrackId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public double Quantity { get; set; }
        public string DeliveryEmployee { get; set; }
        public string ReceiveEmployee { get; set; }


        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public double Productivity { get; set; }
        public double ProductivityInDay {
            get {
                return MyUtilities.Product.GetProductionRateInFactoryDayTime(Productivity);
            }
        }
        public double ProductionDay {
            get {
                return Productivity > 0 ? MyUtilities.Function.RoundUp(Quantity / ProductivityInDay) : 0;
            }
        }
        public double ProductionRate { get; set; }

        public int MaterialId { get; set; }
        public string MaterialTypeName { get; set; }
        public string MaterialCode { get; set; }
        public double MaterialUseInDay {
            get {
                return MyUtilities.Product.GetMaterialRateInFactoryDayTime(Productivity, ProductionRate);
            }
        }
        public double ProductionMaterial {
            get { return ProductionRate > 0 ? MyUtilities.Function.RoundUp(Quantity / ProductionRate) : 0; }
        }
        public double MaterialInv { get; set; }

        public int MachineId { get; set; }
        public string MachineName { get; set; }

        public int ToolTypeId { get; set; }
        public string ToolTypeName { get; set; }

        public int ExportQuantity {
            get { return Details.Sum(d => d.ExportQuantity); }
        }
        public int PrepareQuantity {
            get { return Details.Sum(d => d.PrepareQuantity); }
        }

        public List<PreparationToolDetail> Details { get; set; }
        public int SameMachineCount {
            get {
                return SameMachines.Count;
            }
        }
        public string SameMachine {
            get {
                return SameMachines.Any() ?
                            SameMachines.Count <= 10 ?
                                SameMachines.Select(i => i.MachineName).Aggregate((i, j) => i + ", " + j)
                                : "Tổng máy chạy: " + SameMachines.Count
                        : "";
            }
        }
        public List<SamePreparation> SameMachines { get; set; }
    }
    public class PreparationToolDetail {
        public PreparationToolDetail() {
            SameMachines = new List<SamePreparation>();
        }

        public int ToolId { get; set; }
        public string ToolName { get; set; }
        public string ToolUse { get; set; }
        public int ToolIndex { get; set; }

        public int TypeId { get; set; }
        public string TypeName { get; set; }

        public int ExportQuantity { get; set; }
        public int PrepareQuantity { get; set; }
        public double TotalInv { get; set; }

        public string Note { get; set; }

        public List<SamePreparation> SameMachines { get; set; }
        public int SameMachineCount {
            get {
                return SameMachines.Count;
            }
        }
        public string SameMachine {
            get {
                return SameMachines.Any() ?
                            SameMachines.Count <= 10 ?
                                SameMachines.Select(i => i.MachineName).Aggregate((i, j) => i + ", " + j)
                                : "Tổng máy chạy: " + SameMachines.Count
                        : "";
            }
        }
    }

    public class SamePreparation {
        public int MachineId { get; set; }
        public string MachineName { get; set; }
    }
}