using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class SelectDiagram1
    {
        public int MachineId { get; set; }
        public Nullable<System.DateTime> MaxDate { get; set; }
        public string MachineName { get; set; }
        public Nullable<int> DiagramType { get; set; }
        public Nullable<int> ColumnIndex { get; set; }
        public Nullable<int> RowIndex { get; set; }
        public Nullable<int> ProcessingTypeId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string WarrningColor { get; set; }
        public string MaterialCode { get; set; }
        public int TrackId { get; set; }
        public Nullable<System.DateTime> DeliveryDate { get; set; }
        public int Expr1 { get; set; }
        public int Expr2 { get; set; }
        public string Phase { get; set; }
        public int RoundPerMinute { get; set; }
        public double RealProductivity { get; set; }
        public int RealRate { get; set; }
        public double WorkPiece { get; set; }
        public double KnifeCut { get; set; }
        public string DeliveryEmployee { get; set; }
        public string ReceiveEmployee { get; set; }
        public string Note { get; set; }
        public byte Status { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<int> MaterialId { get; set; }
        public int Quantity { get; set; }
        public System.DateTime EndDate { get; set; }
        public int ForecastDay { get; set; }
        public System.DateTime ForecastDate { get; set; }
    }
}
