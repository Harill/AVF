using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Sales
{
    public class CustomerDomainModel: Customer
    {
        public virtual new int CustomerId { get; set; }
        public virtual new int? CustomerTypeId { get; set; }

        [DisplayName("Loại khách hàng")]
        [UIHint("_CustomerTypeEditTemplate")]
        public virtual string CustomerTypeName { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Mã khách hàng")]
        public virtual new string CustomerCode { get; set; }

        //[Required(ErrorMessage = "*")]
        [DisplayName("Tên khách hàng")]
        public virtual new string CustomerName { get; set; }

        [DisplayName("Khách hàng")]
        public virtual string CustomerCodeName { get { return CustomerCode + " -- " + CustomerName; } set { CustomerCode = value; } }

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
        //[UIHint("_TextAreaTemplate")]
        public new virtual string Address { get; set; }

        [DisplayName("Địa chỉ giao hàng")]
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

        [DisplayName("Khu vực")]
        [UIHint("_CustomerAreaEditTemplate")]
        public new virtual string AreaName { get; set; }

        [DisplayName("Hình thức thanh toán")]
        [UIHint("_CustomerPayTypeEditTemplate")]
        public new virtual string PayType { get; set; }

        public new int AreaId { get; set; }
        [DisplayName("Dùng dự báo ?")]
        public bool UseForecast { get; set; }

        public virtual int EmployeeId { get; set; }
        [DisplayName("Nhân viên")]
        [UIHint("_EmployeeEditTemplate")]
        public virtual string EmloyeeName { get; set; }

        public virtual int ClassifiedId { get; set; }
        [DisplayName("Phân loại")]
        [UIHint("_CustomerClassifiedTemplate")]
        public virtual string ClassifiedName { get; set; }
        public string Info1 { get; set; }
        public string Info2 { get; set; }
        [UIHint("_DateTemplate")]
        public DateTime StartDate { get; set; }
    }
}
