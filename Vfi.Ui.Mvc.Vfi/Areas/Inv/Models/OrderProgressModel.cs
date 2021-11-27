using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Areas.Factory.Models;
using Vfi.Ui.Mvc.Vfi.Areas.Sales.Models;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class OrderProgressModel {
        public int ProgressId { get; set; }
        public int ProgressIndex { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }

        public int WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public double InvQuantity { get; set; }
        public double AfterInvQuantity { get; set; }

        [DataType("_DateTemplate")]
        public DateTime? StartDate { get; set; }
        public DateTime? FinishDate { get; set; }

        [DataType("Int")]
        public int ExpectedDay { get; set; }

        [DataType("Int")]
        public int PendingProcessDay { get; set; }

        [DataType("Number1")]
        public double ExpectedFactor { get; set; }

        public int ProductId { get; set; }
        public string ProductCode { get; set; }

        public bool IsProductionManager { get; set; }
        public bool IsProduction { get; set; }
        public double DesignProductivityInDay { get; set; }
        public double RequiredProductivityInDay { get; set; }

        public double NumberProcess { get; set; }
        public bool Active { get; set; }
        public string Note { get; set; }
        public long OrderDetailId { get; set; }

        public string ProgressNote { get; set; }
    }

    public static class OrderProgressNote {
        public static string GetProductionNote() {
            var note = "";
            return note;
        }
        public static string GetTrackUpProductionNote(List<TrackUpMachineModel> list) {
            var note = "";
            foreach (var item in list) {
                note += item.MachineName + ":" + item.RealProductivity + "s| ";
            }
            return note;
        }
        public static string GetTrackUpCNCNote(List<TrackUpMachineModel> list) {
            var note = "";
            foreach (var item in list) {
                note += item.MachineName + ":" + item.RealProductivity + "s| ";
            }
            return note;
        }
        public static string GetProduction2Note(List<ProductionSection> list) {
            var note = "";
            foreach (var item in list) {
                note += item.SectionIndex + "." + item.Section.SectionName + ": " + item.Productivity + "s| ";
            }
            return note;
        }
        public static string GetHeatTreatmentNote(ProductionHeatTreatment item) {
            return item.Name + ":" + string.Format("{0:n0}", item.Rate) + "pcs/" + string.Format("{0:n0}", item.Timing) + "s-" + item.Temperature + "ºC";
        }
        public static string GetPolishNote(ProductionPolish item) {
            return item.Name + ":" + string.Format("{0:n0}", item.Rate) + "pcs/" + string.Format("{0:n0}", item.Timing) + "s-" + item.Using + "-" + item.Rock;
        }
        public static string GetPlatingNote(List<ProductionPlating> list) {
            var note = "";
            foreach (var item in list) {
                note += item.PlatingName + ": " + item.PlatingDay + "d| ";
            }
            return note;
        }
        public static string GetQCNote() {
            var note = "";
            return note;
        }
    }
}