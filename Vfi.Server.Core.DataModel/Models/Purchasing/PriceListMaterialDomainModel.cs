using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Purchasing
{
    public class PriceListMaterialDomainModel: PriceListMaterial
    {
        public virtual new long PriceListMaterialId { get; set; }

        public virtual new int MaterialId { get; set; }
        [DisplayName("Nguyên liệu")]
        public virtual string MaterialName { get; set; }

        [DisplayName("Giá góc")]
        [DataType("Number")]
        public virtual new double? NetPrice { get; set; }

        [DisplayName("Tiền tệ")]
        public virtual new string Currency { get; set; }
        [DisplayName("Tiền tệ")]
        public virtual string CurrencyCode { get; set; }
        
        [DisplayName("Tỉ giá")]
        [DataType("Number")]
        public virtual new double? Exchange { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
