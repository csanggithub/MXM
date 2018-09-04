using System.Web.Mvc;

namespace MXM.Web.Areas.kc
{
    public class kcAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "kc";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name:"kc_default",
                url:"kc/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "MXM.Web.Areas.kc.*" }
            );
        }
    }
}