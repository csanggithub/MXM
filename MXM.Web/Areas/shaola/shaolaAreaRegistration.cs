using System.Web.Mvc;

namespace MXM.Web.Areas.shaola
{
    public class shaolaAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "shaola";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                name:"shaola_default",
                url:"shaola/{controller}/{action}/{id}",
                defaults:new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "MXM.Web.Areas.shaola.*" }
            );
        }
    }
}