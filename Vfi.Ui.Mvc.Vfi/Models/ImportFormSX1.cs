using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ImportFormSX1
    {
        public ImportFormSX1()
        {
            this.ImportFormSX1Detail = new List<ImportFormSX1Detail>();
            this.ImportWorkpieceMaterials = new List<ImportWorkpieceMaterial>();
        }

        public int ImportId { get; set; }
        public System.DateTime ImportDate { get; set; }
        public string ModifiedUser { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string TransactionCode { get; set; }
        public string Shift1Name { get; set; }
        public string Shift2Name { get; set; }
        public System.DateTime MaterialUseDate { get; set; }
        public Nullable<bool> AddWorkpieceMaterial { get; set; }
        public byte Status { get; set; }
        public virtual ICollection<ImportFormSX1Detail> ImportFormSX1Detail { get; set; }
        public virtual ICollection<ImportWorkpieceMaterial> ImportWorkpieceMaterials { get; set; }
    }
}
