using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Vfi.Ui.Mvc.Vfi.Models.Production
{
    public class MaterialModel
    {
        public int MaterialId { get; set; }
        public virtual int MaterialTypeId { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Tên loại nguyên liệu")]
        [UIHint("_MaterialTypeEditTemplate")]
        public virtual string MaterialTypeName { get; set; }

        [DisplayName("Material Code VF")]                                          //Mã nguyên liệu VF
        public virtual string MaterialCode { get; set; }
        
        [Required(ErrorMessage = "*")]
        [DisplayName("Tên nguyên liệu")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public virtual string MaterialName { get; set; }

        //[DisplayName("Mã nguyên liệu")]
        //public virtual string MaterialCodeName { get { return MaterialCode; } }

        [Required(ErrorMessage = "*")]
        [DisplayName("Đường kính trong(mm)")]
        public virtual double OutDiameter { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Dung sai")]
        public  virtual string DiameterType { get; set; }
        
        [DisplayName("Đơn giá/kg")]
        [DataType("Number")]
        [Range(0.00, double.MaxValue, ErrorMessage = "0.00 < * < decimal.MaxValue")]
        public  virtual double UnitPrice { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Trọng lượng/kg")]
        [DataType("Number")]
        [Range(0.01, double.MaxValue, ErrorMessage = "0.01 < * < decimal.MaxValue")]
        public  virtual double Weight { get; set; }

        [DisplayName("Kích hoạt")]
        public  bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public  string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public  DateTime ModifiedDate { get; set; }
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorCode { get; set; }
        public string IdentityCode { get; set; }
        //[Required(ErrorMessage = "*")]
        [UIHint("_VendorEditTemplate")]
        [DisplayName("Nhà cung cấp")]
        public string VendorCodeName
        {
            get { return (VendorCode + " -- " + VendorName); }
            set { VendorCode = value; }
        }

        [DisplayName("Đường kính ngoài(mm)")]
        public double InDiameter { get; set; }
        [Required(ErrorMessage = "*")]
        [DisplayName("Hình dạng")]
        public string Shape { get; set; }
        public bool IsExpensive { get; set; }
    }
}