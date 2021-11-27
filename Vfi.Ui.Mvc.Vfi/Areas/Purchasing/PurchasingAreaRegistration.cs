using System.Web.Mvc;

namespace Vfi.Ui.Mvc.Vfi.Areas.Purchasing
{
    public class PurchasingAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Purchasing";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Purchasing_default",
                "Purchasing/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
