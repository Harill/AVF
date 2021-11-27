using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class MaterialType
    {
        public MaterialType()
        {
            this.Tools = new List<Tool>();
            this.Materials = new List<Material>();
        }

        public int MaterialTypeId { get; set; }
        public int MaterialClassifiedId { get; set; }
        public string MaterialTypeName { get; set; }
        public bool Active { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string IdentityCode { get; set; }
        public virtual ICollection<Tool> Tools { get; set; }
        public virtual ICollection<Material> Materials { get; set; }
        public virtual MaterialClassified MaterialClassified { get; set; }
    }
}
