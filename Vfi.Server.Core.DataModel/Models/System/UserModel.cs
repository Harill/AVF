
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Server.Core.DataModel.Models.System
{
    public class LogInUserModel
    {
        [Required(ErrorMessage = " * ")]
        [DisplayName("Tên tài khoản")]
        public string Username { get; set; }

        [Required(ErrorMessage = " * ")]
        [DisplayName("Mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }

        public string PersonalName { get; set; }

        public string Hello {
            get {
                string a = "Xin chào ";
                string now = DateTime.Now.ToString("t");
                string morning = DateTime.Parse("5:30 AM").ToString("t");
                string noon = DateTime.Parse("10:00 AM").ToString("t");
                string evening = DateTime.Parse("3:00 PM").ToString("t");
                string night = DateTime.Parse("5:00 PM").ToString("t");
                if (DateTime.Parse(now) >= DateTime.Parse(morning) && DateTime.Parse(now) < DateTime.Parse(noon))
                    a += "buổi sáng: ";
                else if (DateTime.Parse(now) >= DateTime.Parse(noon) && DateTime.Parse(now) < DateTime.Parse(evening))
                    a += "buổi trưa: ";
                else if (DateTime.Parse(now) >= DateTime.Parse(evening) && DateTime.Parse(now) < DateTime.Parse(night))
                    a += "buổi chiều: ";
                else
                    a += "buổi tối: ";
                a += PersonalName;
                return a;
            }
        }
    }
    
    /*
    [UserValidation.PropertiesMustMatchAttribute("Password", "ConfirmPassword")]
    public class ChangePasswordUserModel
    {
        [HiddenInput]
        public virtual long UserId { get; private set; }

        [HiddenInput]
        public string UserName { get; set; }

        [HiddenInput]
        public virtual string UserCode { get; set; }

        [Required(ErrorMessage = " * ")]
        [DataType(DataType.Password)]
        [DisplayName("Mật khẩu hiện tại")]
        [UserValidation.ValidatePasswordLengthAttribute]
        [UserValidation.ValidateCurrentPassword]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = " * ")]
        [DataType(DataType.Password)]
        [DisplayName("Mật khẩu mới")]
        [UserValidation.ValidatePasswordLengthAttribute]
        public string Password { get; set; }

        [Required(ErrorMessage = " * ")]
        [DataType(DataType.Password)]
        [DisplayName("Xác nhận mật khẩu mới")]
        [UserValidation.ValidatePasswordLengthAttribute]
        public string ConfirmPassword { get; set; }

        public virtual string Email { get; set; }

        public virtual int Active { get; set; }
    }
    */

    public class LookupUserModel
    {
        [DisplayName("User name")]
        public string UserName { get; set; }

        public string Password { get; set; }
    }

    public class UserModel
    {
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

        public IList<PermissionModel> Permissions { get; set; }
        public PermissionModel PermissionModel { get; set; }

        public IList<UserWorkGroupModel> UserWorkGroups { get; set; }
        public List<string> FunctionCodes { get; set; }
    }
    #region ChangePasswordModel
    public class ChangePasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        //[Display(Name = "Current password")]
        [Display(Name = "Mật khẫu hiện tại")]
        public string OldPassword { get; set; }

        [Required]
        [RegularExpression(@"^.{3,16}$", ErrorMessage = "The Password length must be between 3 and 16 characters ")]
        [DataType(DataType.Password)]
        [Display(Name = "Mật khẫu mới")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Xác nhận lại mật khẩu")]
        [Compare("NewPassword", ErrorMessage = "The new password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    #endregion

    //[UserValidation.ValidateDuplicateUpdateUserAccount("UserID", "UserCode", "UserName", "Email")]
    public class UserAccountEditModel
    {

        [Required(ErrorMessage = " * ")]
        public string Username { get; set; }

        [DataType(DataType.Password)]
        //[UserValidation.ValidateUpdatePasswordLengthAttribute(ErrorMessage = " * ")]
        public string Password { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public bool Active { get; set; }

        public string CurrentPassword { get; set; }

        public virtual string PreUserAccountName { get; set; }

        //public virtual PermissionModel PermissionModel { get; set; }
    }
}
