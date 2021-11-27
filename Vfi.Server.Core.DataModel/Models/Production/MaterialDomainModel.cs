using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Production
{
    public class MaterialDomainModel: Material
    {
        public new int MaterialId { get; set; }
        public virtual new int MaterialTypeId { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Tên loại nguyên liệu")]
        [UIHint("_MaterialTypeEditTemplate")]
        public virtual  string MaterialTypeName { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Mã nguyên liệu VF")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public new virtual string MaterialCode { get; set; }

        [DisplayName("Mã nguyên liệu")]
        public new virtual string MaterialCodeName { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Tên nguyên liệu")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public new virtual string MaterialName { get; set; }

        [DisplayName("Nguyên liệu")]
        public virtual string MaterialCodeName2 { get { return MaterialCode + " -- " + MaterialName; } }

        [Required(ErrorMessage = "*")]
        [DisplayName("Đường kính/mm")]
        //[DataType("Number")]
        //[Range(0.01, double.MaxValue, ErrorMessage = "0.01 < * < decimal.MaxValue")]
        public new virtual string Diameter { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Dung sai")]
        public new virtual string DiameterType { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Chiều dài/mm")]
        [DataType("Number")]
        [Range(0.01, double.MaxValue, ErrorMessage = "0.01 < * < decimal.MaxValue")]
        public new virtual double? Length { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Đơn giá/kg")]
        [DataType("Number")]
        [Range(0.01, double.MaxValue, ErrorMessage = "0.01 < * < decimal.MaxValue")]
        public new virtual double? UnitPrice { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Trọng lượng/kg")]
        [DataType("Number")]
        [Range(0.01, double.MaxValue, ErrorMessage = "0.01 < * < decimal.MaxValue")]
        public new virtual double? Weight { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
