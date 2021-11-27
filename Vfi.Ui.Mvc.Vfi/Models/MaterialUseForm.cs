using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MaterialUseForm
    {
        public int UseId { get; set; }
        public Nullable<System.DateTime> UseDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<byte> ShiftType { get; set; }
        public string ShiftName { get; set; }
        public Nullable<byte> Status { get; set; }
    }
}
