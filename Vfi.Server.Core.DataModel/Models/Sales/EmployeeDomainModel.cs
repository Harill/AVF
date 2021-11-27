using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.Sales
{
    public class EmployeeDomainModel : Employee
    {
        public virtual new int EmployeeId { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Mã nhân viên")]
        [StringLength(50, ErrorMessage = "* < 50 ký tự")]
        public virtual new string EmployeeCode { get; set; }

        [Required(ErrorMessage = "*")]
        [DisplayName("Tên nhân viên")]
        [StringLength(255, ErrorMessage = "* < 255 ký tự")]
        public virtual new string EmployeeName { get; set; }

        [DisplayName("Nhân viên")]
        public virtual string EmployeeCodeName { get { return EmployeeCode + " -- " + EmployeeName; } set { EmployeeCode = value; } }

        [DisplayName("Kích hoạt")]
        public new bool Active { get; set; }
        [DisplayName("Người thay đổi")]
        public new string ModifiedUser { get; set; }
        [DisplayName("Ngày thay đổi")]
        public new DateTime? ModifiedDate { get; set; }
    }
}
