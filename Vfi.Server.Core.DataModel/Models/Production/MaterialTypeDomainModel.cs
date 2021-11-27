using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Production
{
    public class MaterialTypeDomainModel: MaterialType
    {
        public new int MaterialTypeId { get; set; }

        [DisplayName("Mã phân loại")]
        public new int MaterialClassifiedId { get; set; }

        [DisplayName("Tên phân loại")]
        [Required(ErrorMessage = "*")]
        [UIHint("_MaterialClassifiedEditTemplate")]
        public string MaterialClassifiedName { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Tên loại nguyên liệu")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public new string MaterialTypeName { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Mã nhận dạng")]
        [StringLength(1, ErrorMessage = "Chỉ được 1 ký tự")]
        public string IdentityCode { get; set; }
    }
}
