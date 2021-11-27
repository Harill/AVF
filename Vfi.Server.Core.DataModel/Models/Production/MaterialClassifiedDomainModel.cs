using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Production
{
    [Serializable]
    public class MaterialClassifiedDomainModel: MaterialClassified
    {
        public new int MaterialClassifiedId { get; set; }
        
        [DisplayName("Tên phân loại")]
        [Required(ErrorMessage = "*")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public new string MaterialClassifiedName { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
