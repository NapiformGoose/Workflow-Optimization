using Config;
using Autofac;
using Autofac.Core;
using Autofac.Integration.Mvc;

namespace WebView
{
    public class MvcApplication
    {
        protected void Application_Start()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly).PropertiesAutowired();

            AutofacConfig.ConfigureContainer(builder);
        }
    }
}
