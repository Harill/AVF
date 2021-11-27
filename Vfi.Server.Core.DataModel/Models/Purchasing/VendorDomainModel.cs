using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Purchasing
{
    public class VendorDomainModel: Vendor
    {
        public new int VendorId { get; set; }

        [DisplayName("Mã nhà cung cấp")]
        [Required(ErrorMessage = "*")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public new virtual string VendorCode { get; set; }

        [DisplayName("Tên nhà cung cấp")]
        [Required(ErrorMessage = "*")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public new string VendorName { get; set; }

        [Required(ErrorMessage = "*")]
        [UIHint("_MaterialClassifiedEditTemplate")]
        [DisplayName("Loại hình cung cấp")]
        public new string MaterialClassifiedName { get; set; }

        public new int MaterialClassifiedId { get; set; }

        public virtual string VendorCodeName { get { return VendorCode + " -- " + VendorName; } set { VendorCode = value; } }

        [DisplayName("Tên viết tắt")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public new virtual string ShortName { get; set; }

        [DisplayName("Tên công ty")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public new virtual string CompanyName { get; set; }
        
        [DisplayName("Tên liên hệ")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public new virtual string ContactName { get; set; }

        [DisplayName("Địa chỉ")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public new virtual string Address { get; set; }

        [DisplayName("Địa chỉ trên mạng")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        public new virtual string Eaddress { get; set; }

        [DisplayName("Số đt")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public new virtual string Phone { get; set; }

        [DisplayName("Số fax")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public new virtual string Fax { get; set; }

        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public new virtual string Email { get; set; }

        [DisplayName("Mã số thuế")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public new virtual string TaxCode { get; set; }

        [DisplayName("Tài khoản ngân hàng")]
        [StringLength(50, ErrorMessage = "* <= 50 ký tự.")]
        public new virtual string BankAccount { get; set; }

        public new virtual double? MaxCredit { get; set; }

        [DisplayName("Thông tin đặc biệt")]
        [StringLength(255, ErrorMessage = "* <= 255 ký tự.")]
        [DataType(DataType.MultilineText)]
        public new virtual string SpecialInfo { get; set; }

        [DisplayName("Ghi chú")]
        [StringLength(500, ErrorMessage = "* <= 500 ký tự.")]
        [DataType(DataType.MultilineText)]
        public new virtual string Note { get; set; }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
