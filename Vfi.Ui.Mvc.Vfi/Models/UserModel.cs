using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models {

    public class UserModel {
        //[ScaffoldColumn(false)]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Required")]
        //[UserValidation.ValidateDuplicateUserName(ErrorMessage = " * ")]
        public virtual string Username { get; set; }

        //[Required(ErrorMessage = "Required")]
        //[ReadOnly(true)]
        //[ScaffoldColumn(false)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^.{3,24}$", ErrorMessage = "The Password length must be between 3 and 24 characters ")]
        public string Password { get; set; }

        public string FullName { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Must be a valid Email Address")]
        public string Email { get; set; }

        public bool Active { get; set; }

        //[DataType(DataType.DateTime)]
        //[ReadOnly(true)]
        //[UIHint("UserEditTemplate")]
        //public DateTime? ModifiedDate { get; set; }

        //public bool IsActive { get; set; }

        //public virtual bool IsSelected { get; set; }

        public User User { get; set; }

        public IList<PermissionNewModel> Permissions { get; set; }
        public PermissionNewModel PermissionModel { get; set; }

        public List<string> FunctionCodes { get; set; }
    }
}