
using System.Collections.Generic;
using Vfi.Server.Core.DataModel.BaseEntities;

namespace Vfi.Ui.Mvc.Vfi.Models
{
    public class MenuModel
    {
        public MenuModel() {
            Children = new List<MenuModel>();
        }
        public Menu Menu { get; set; }

        public List<MenuModel> Children { get; set; }

        public MenuModel Parent { get; set; }

        public bool IsOkie { get; set; }

        public bool HasPermissionExecute { get; set; }

        //public bool IsShow {
        //    get {
        //        return Menu.MenuName.Contains("----") ||
        //            (Menu.Active == true && Children != null && Children.Count > 0 && Children.FindAll(c => !c.Menu.MenuName.Contains("-----")).Count > 0);
        //    }
        //}
        public bool IsShow {
            get {
                return Menu.MenuName.Contains("----") ||
                    (Menu.Active == true 
                    && Children.Count > 0 
                    && Children.FindAll(c => !c.Menu.MenuName.Contains("-----")).Count > 0);
            }
        }
    }
}
