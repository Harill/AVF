using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv.Models {
    public class MachineSetupPlanModel {
        public MachineSetupPlanModel() {
            OrderNumber = 0;
            ForecastNumber = 0;
            MachineSetupHistoryList = new List<MachineSetupHistory>();
        }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string CustomerCode { get; set; }
        public double TotalInv { get; set; }

        public int MaterialId { get; set; }
        public string MaterialCode { get; set; }
        public double MaterialInv { get; set; }
        public double MaterialInvKg { get; set; }

        public int Function { get; set; }

        public double OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }

        public double ForecastNumber { get; set; }
        public DateTime? ForecastDate { get; set; }

        public double RequireNumber { get { return OrderNumber > ForecastNumber ? OrderNumber - TotalInv : ForecastNumber - TotalInv; } }
        public DateTime? RequireDate { get { return OrderNumber > ForecastNumber ? OrderDate : ForecastDate; } }

        public DateTime SetupDate { get; set; }
        public string State { get { return OrderNumber > ForecastNumber ? "PO" : "DB"; } }
        public List<MachineSetupHistory> MachineSetupHistoryList { get; set; }
        public string ProductionHistory {
            get {
                var str = "";
                foreach (var machine in MachineSetupHistoryList) {
                    str += machine.MachineName + "-" + machine.MachineType + "(" + machine.Function + "), ";
                }
                return str;
            }
        }

        public string AvailableMachine {
            get {
                var str = "";
                foreach (var machine in MachineSetupHistoryList) {
                    if (machine.State == MyUtilities.Machine.State.Done && machine.Function >= Function)
                        str += machine.MachineName + "(" + machine.Function + "), ";
                }
                return str;
            }
        }
        //public string AvailableMatchMachine { get; set; }
        public string PickUpMachine { get; set; }
        public string Note { get; set; }
    }

    public class MachineSetupHistory {
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public string MachineType { get; set; }
        public int Function { get; set; }
        public int State { get; set; }
    }
}