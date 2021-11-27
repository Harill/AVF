using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Vfi.Server.Core.DataModel.Models.System
{
    public class WorkGroupModel
    {
        [ScaffoldColumn(false)]
        public int WorkGroupId { get; set; }

        [Required(ErrorMessage = " Bạn Phải Nhập Giá Trị WorkGroupCode ")]
        //[UserValidation.ValidateDuplicateGroupCode(ErrorMessage = " * ")]
        public string WorkGroupCode { get; set; }

        [Required(ErrorMessage = " Bạn Phải Nhập Giá Trị WorkGroupName ")]
        public string WorkGroupName { get; set; }

        public string Description { get; set; }

        //[HiddenInput]
        public bool Active { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedDate { get; set; }

        //public bool IsActive { get; set; }

        //public virtual bool IsSelected { get; set; }

        public virtual PermissionModel PermissionModel { get; set; }
        public IList<PermissionModel> Permissions { get; set; }
    }
}
