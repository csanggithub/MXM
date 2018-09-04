using System.Web.Mvc;

namespace MXM.Web.Areas.fjwap
{
    public class fjwapAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "fjwap";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name:"fjwap_default",
                url:"fjwap/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "MXM.Web.Areas.fjwap.*" }
            );
        }
    }
}