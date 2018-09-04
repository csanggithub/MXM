using System.Web.Mvc;

namespace MXM.Web.Areas.fjpc
{
    public class fipcAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "fjpc";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name:"fjpc_default",
                url:"fjpc/{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "MXM.Web.Areas.fjpc.*" }
            );
        }
    }
}