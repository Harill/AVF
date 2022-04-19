using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public class ProductImgModel
    {
        public int ImgId { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        [DataType("_UploadProductImgTemplate")]
        public string ImgUrl { get; set; }
        [DataType("Int")]
        public int Step { get; set; }
        public string Description { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }

        public bool CanModify { get; set; }
        public string UploadDate { get { return ModifiedDate.ToString("yyyyMMddhhmmss"); } }

        public int WarehouseId { get; set; }
        [DataType("_WarehouseEditTemplate")]
        public string WarehouseName { get; set; }
    }
}