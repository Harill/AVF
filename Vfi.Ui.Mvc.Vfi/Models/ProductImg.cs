using System;
using System.Collections.Generic;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public partial class ProductImg
    {
        public int ImgId { get; set; }
        public int ProductId { get; set; }
        public string ImgUrl { get; set; }
        public string Description { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public Nullable<int> Step { get; set; }
        public virtual Product Product { get; set; }
    }
}
