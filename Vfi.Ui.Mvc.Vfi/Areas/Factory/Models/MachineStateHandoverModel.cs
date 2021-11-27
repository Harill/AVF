using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models {
    public class MachineStateHandoverModel {
        public MachineStateHandoverModel() {
        }
        public int FormId { get; set; }
        public int MachineId { get; set; }
        public DateTime ReportDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime StartState { get; set; }
        public DateTime? FinishState { get; set; }
        public string MachineName { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int StateId { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public double RunningTime { get; set; }
        public double ErrorTime { get; set; }
        public int CountErrorState { get; set; }
        public double ProductionMaterialPlan { get; set; }
        public double ProductionProductPlan { get; set; }
        public string Note { get; set; }
        public double RealProductivity { get; set; }
        public double RealRate { get; set; }
        public int EstimateTime { get; set; }
        public bool BetweenTime {
            get {
                return EstimateTime > 30 && EstimateTime < 120 ? true : false;
            }
        }


        // print technical handover
        public int Normal {
            get {
                return StateId == MyUtilities.Machine.State.Normal ? 1 : 0;
            }
        }
        public int Setup {
            get {
                return StateId == MyUtilities.Machine.State.Setup ? 1 : 0;
            }
        }
        public int Done {
            get {
                return StateId == MyUtilities.Machine.State.Done ? 1 : 0;
            }
        }
        public int OutOfMaterial {
            get {
                return StateId == MyUtilities.Machine.State.OutOfMaterial ? 1 : 0;
            }
        }
        public int OutOfTool {
            get {
                return StateId == MyUtilities.Machine.State.OutOfTool ? 1 : 0;
            }
        }
        public int Error {
            get {
                return StateId == MyUtilities.Machine.State.Error ? 1 : 0;
            }
        }
        public int Repairing {
            get {
                return StateId == MyUtilities.Machine.State.Repairing ? 1 : 0;
            }
        }
        public int EstimateTimeBelow30 {
            get {
                return EstimateTime > 0 && EstimateTime <= 30 ? 1 : 0;
            }
        }
        public int EstimateTime30_120 {
            get {
                return BetweenTime ? 1 : 0;
            }
        }
        public int EstimateTimeOver120 {
            get {
                return EstimateTime >= 120 ? 1 : 0;
            }
        }
    }

    public class GroupMachineStateHandoverModel {
        public GroupMachineStateHandoverModel() {
            Details = new List<MachineStateHandoverModel>();
        }
        public int MachineId { get; set; }
        public DateTime ReportDate { get; set; }
        public string MachineName { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int TotalState {
            get { return Details.Count(); }
        }
        public int TotalRunning {
            get { return Details.Where(d => d.RunningTime > 0).ToList().Count(); }
        }
        public int NormalState {
            get { return Details.Count(d => d.StateId == MyUtilities.Machine.State.Normal); }
        }
        public int SetupState {
            get { return Details.Count(d => d.StateId == MyUtilities.Machine.State.Setup); }
        }
        public int DoneState {
            get { return Details.Count(d => d.StateId == MyUtilities.Machine.State.Done); }
        }
        public int OutMaterialState {
            get { return Details.Count(d => d.StateId == MyUtilities.Machine.State.OutOfMaterial); }
        }
        public int OutToolState {
            get { return Details.Count(d => d.StateId == MyUtilities.Machine.State.OutOfTool); }
        }
        public int ErrorState { get; set; }
        public int RepairState {
            get { return Details.Count(d => d.StateId == MyUtilities.Machine.State.Repairing); }
        }
        public double RunningTime {
            get { return Details.Sum(d => d.RunningTime); }
        }
        public double ErrorTime {
            get { return Details.Sum(d => d.ErrorTime); }
        }
        public int CountErrorState {
            get { return Details.Sum(d => d.CountErrorState); }
        }
        public double ProductionMaterialPlan {
            get { return Details.Sum(d => d.ProductionMaterialPlan); }
        }
        public double ProductionProductPlan {
            get { return Details.Sum(d => d.ProductionProductPlan); }
        }
        public List<MachineStateHandoverModel> Details { get; set; }
    }

}