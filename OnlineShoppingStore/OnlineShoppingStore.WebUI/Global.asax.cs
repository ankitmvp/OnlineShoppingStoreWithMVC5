using OnlineShoppingStore.Domain.Entities;
using OnlineShoppingStore.WebUI.Binders;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineShoppingStore.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ModelBinders.Binders.Add(typeof(Cart), new CartModelBinder());
        }
    }
}
