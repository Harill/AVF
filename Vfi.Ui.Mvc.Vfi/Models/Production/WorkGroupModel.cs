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
        public bool Active { get; set; }

        public DateTime ModifiedDate { get; set; }
    }

    public class PageConfigModel {
        public string PageTheme { get; set; }
        public string PageName { get; set; }
        public string BackgroundImage { get; set; }
        public string LogoImage { get; set; }
        public string ImagePath { get; set; }
    }
}