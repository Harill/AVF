using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MaterialUseInShiftForm
    {
        public MaterialUseInShiftForm()
        {
            this.MaterialUseFormDetails = new List<MaterialUseFormDetail>();
        }

        public int FormId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<byte> ShiftType { get; set; }
        public string ShiftName { get; set; }
        public Nullable<byte> Status { get; set; }
        public string FormCode { get; set; }
        public Nullable<int> Type { get; set; }
        public virtual ICollection<MaterialUseFormDetail> MaterialUseFormDetails { get; set; }
    }
}
