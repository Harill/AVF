using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MaterialUseInShift
    {
        public MaterialUseInShift()
        {
            this.MaterialUseDetails = new List<MaterialUseDetail>();
        }

        public int UseId { get; set; }
        public System.DateTime UsedDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string Shift2 { get; set; }
        public string Shift1 { get; set; }
        public byte Status { get; set; }
        public string UsedCode { get; set; }
        public int Type { get; set; }
        public virtual ICollection<MaterialUseDetail> MaterialUseDetails { get; set; }
    }
}
