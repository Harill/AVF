using System.Web.Mvc;

namespace Vfi.Ui.Mvc.Vfi.Areas.Inv
{
    public class InvAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Inv";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Inv_default",
                "Inv/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
