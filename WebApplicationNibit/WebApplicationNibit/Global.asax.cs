using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using WebApplicationNibit.Controllers.Sevices;

namespace WebApplicationNibit
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            // 1. Create a new Simple Injector container
            var container = new Container();

            // 2. Configure the container (register)
          //  container.Register<IBroadcastsRepository>(() => new BroadcastsService());
                container.Register<IBroadcastsRepository, BroadcastsService>(Lifestyle.Transient);

            //   container.Register<ILogger, MailLogger>(Lifestyle.Singleton);

            // 3. Optionally verify the container's configuration.
            container.Verify();

            // 4. Register the container as MVC3 IDependencyResolver.
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}

