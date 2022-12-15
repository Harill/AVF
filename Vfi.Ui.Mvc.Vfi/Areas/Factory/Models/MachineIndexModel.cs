using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vfi.Ui.Mvc.Vfi.Models;
using Vfi.Ui.Mvc.Vfi.Utilities;

namespace Vfi.Ui.Mvc.Vfi.Areas.Factory.Models
{
    public class MachineIndexModel
    {
        public int MachineId { get; set; }
        public string MachineName { get; set; }
        public int MachineDiagram { get; set; }
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
        public string MachineIndex
        {
            get { return GetMachineIndex(); }
        }

        public string GetMachineIndex()
        {
            string a = "";
            a = MachineName + ": " + MyUtilities.Machine.GetDiagramText(MachineDiagram) + "-" + ColumnIndex + "-" + RowIndex;
            return a;
        }
    }
    public static class GetMachineIndexModel
    {

        public static string GetFullMachineIndex(Machine machine)
        {
            string a = "";
            a = machine.MachineName + ": " + MyUtilities.Machine.GetDiagramText(machine.DiagramType ?? 0) + "-"
                + (machine.ColumnIndex ?? 0) + "-" + (machine.RowIndex ?? 0);
            return a;
        }


        public static string GetMachineIndex(Machine machine)
        {
            string a = "";
            a = MyUtilities.Machine.GetDiagramText(machine.DiagramType ?? 0) + "-"
                + (machine.ColumnIndex ?? 0) + "-" + (machine.RowIndex ?? 0);
            return a;
        }
    }
}