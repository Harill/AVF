using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vfi.Ui.Mvc.Vfi.Models.Production {
    public class WorkGroupModel {
        public int WorkGroupId { get; set; }

        public string WorkGroupCode { get; set; }

        public string WorkGroupName { get; set; }

        [DataType("_TelerikThemeEditTemplate")]
        public string Theme { get; set; }
        public string ThemeCss { get { return "telerik." + Theme + ".min.css"; } }
        public string Description { get; set; }
        public string BackgroundImage { get; set; }
        public string LogoImage { get; set; }
        public string ImagePath { get; set; }
        public string PageTitleColor { get; set; }
        public bool Active { get; set; }

        public DateTime ModifiedDate { get; set; }
    }

    public class PageConfigModel {
        public PageConfigModel() {
            PageTheme = "office2007";
            BackgroundImage = "bg_body.jpg";
            ImagePath = "/vfi/Content/Images";
            PageTitleColor = "white";
        }

        public string PageTheme { get; set; }
        public string PageName { get; set; }
        public string BackgroundImage { get; set; }
        public string LogoImage { get; set; }
        public string ImagePath { get; set; }
        public string PageTitleColor { get; set; }

        public string UserLoginFullName { get; set; }
    }
    public class WorkGroupInfo {
        public string Logo { get; set; }
        public string CompanyName { get; set; }
        public string CompanyFullName { get; set; }
        public string CompanyShortName { get; set; }
        public string Address { get; set; }
        public string TelNumber { get; set; }
        public string FaxNumber { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }
}