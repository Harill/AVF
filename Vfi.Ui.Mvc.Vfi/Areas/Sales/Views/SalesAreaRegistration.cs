using System.Web.Mvc;

namespace Vfi.Ui.Mvc.Vfi.Areas.Sales
{
    public class SalesAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Sales";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Sales_default",
                "Sales/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );

            //roi vay ta

            context.MapRoute(
                "Sales_ForecastOrderProgress",
                "Sales/{controller}/{action}/{month}/{year}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
