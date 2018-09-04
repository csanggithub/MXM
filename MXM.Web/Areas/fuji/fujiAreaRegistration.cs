using System.Web.Mvc;

namespace MXM.Web.Areas.fuji
{
    public class fujiAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "fuji";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name:"fuji_default",
                url:"fuji/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "MXM.Web.Areas.fuji.*" }
            );
        }
    }
}