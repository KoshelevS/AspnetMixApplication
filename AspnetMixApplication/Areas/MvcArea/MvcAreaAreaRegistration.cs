using System.Web.Mvc;

namespace AspnetMixApplication.Areas.MvcArea
{
    public class MvcAreaAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "MvcArea";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "MvcArea_default",
                "MvcArea/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}