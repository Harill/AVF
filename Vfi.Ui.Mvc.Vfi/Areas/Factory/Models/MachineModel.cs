using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Vfi.Ui.Mvc.Vfi.Areas.Inv.Models;
using Vfi.Ui.Mvc.Vfi.Models;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class MachineModel
    {
        public MachineModel()
        {
            Tracks = new List<TrackUpMachineModel>();
        }
        public List<TrackUpMachineModel> Tracks { get; set; }

        public TrackUpMachineModel ActiveTrack { get; set; }
        public int MachineId { get; set; }
        public string MachineCode { get; set; }
        [UIHint("_MachineEditTemplate")]
        public string MachineName { get; set; }
        public string MachineIdName { get; set; }
        public string MachineFullName { get { return MachineName + " -- " + ProcessingTypeName; } }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int StateId { get; set; }
        public int ProductActive { get; set; }
        public double Number { get; set; }
        public int DayRate { get; set; }
        public DateTime StartProductionDate { get; set; }
        public string Note { get; set; }
        [UIHint("_MachineStateTemplate")]
        public string StateName { get; set; }
        public string StateColor { get; set; }
        public int MachineFunction{get;set;}
        public string GetMachineStateLog()
        {
            string a = "";
            //a +="Máy: "+ MachineName +" - Tình trạng: "+ StateName;
            //if (!string.IsNullOrWhiteSpace(Note))
            //    a += " - " + Note;
            return a;
        }

        public List<int> Days { get; set; } 
        public int DiagramType { get; set; }
        [DataType("_MachineDiagramTypeEditTemplate")]
        public string DiagramTypeName { get; set; }
        [DataType("NumberAsInt")]
        public int ColumnIndex { get; set; }
        [DataType("NumberAsInt")]
        public int RowIndex { get; set; }

        public string ErrorCause { get; set; }
        public string HowToFix { get; set; }
        public DateTime ModifiedState { get; set; }
        public DateTime ModifiedFix { get; set; }
        public int ProcessingTypeId { get; set; }
        [DataType("_ProcessingTypeTemplate")]
        public string ProcessingTypeName { get; set; }

        public bool Production2 { get; set; }

        public string GetUpdateStateLog()
        {
            string a = "";
            a = "Lỗi: " + CastMachineStateEnum.GetText(StateId);
            if (!string.IsNullOrWhiteSpace(ErrorCause))
                a += " Nguyên nhân: " + ErrorCause;
            if (!string.IsNullOrWhiteSpace(HowToFix))
                if (ModifiedState == ModifiedFix)
                {
                    a += " Khắc phục: " + HowToFix;
                    var fixTime = ModifiedFix - ModifiedState;
                    a += " Thời gian sửa: " + fixTime.ToString();
                }
            return a;
        }
        public string GetUpdateStateLog(Machine machine)
        {
            string a = "";
            a = "Lỗi: " + CastMachineStateEnum.GetText(machine.StateId??0);
            if (!string.IsNullOrWhiteSpace(machine.ErrorCause))
                a += " Nguyên nhân: " + machine.ErrorCause;
            if (!string.IsNullOrWhiteSpace(machine.HowToFix))
                if (machine.ModifiedState == machine.ModifiedFix)
                {
                    a += " Khắc phục: " + machine.HowToFix;
                    var fixTime = machine.ModifiedFix - machine.ModifiedState;
                    a += " Thời gian sửa: " + fixTime.ToString();
                }
            return a;
        }
    }

    public class MachineConfiguration : WarehouseConfiguration {
        public MachineConfiguration() {
            TypeIds = new List<int>();
        }
        public List<int> TypeIds { get; set; }
    }
}