[assembly: WebActivator.PostApplicationStartMethod(typeof(WebApplicationNibit.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace WebApplicationNibit.App_Start
{
    using System.Reflection;
    using System.Web.Mvc;

    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    using Controllers.Sevices;

    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {

            // 1. Create a new Simple Injector container
            var container = new Container();

            // 2. Configure the container (register)
            container.Register<IBroadcastsRepository>( () => new BroadcastsService());
        //    container.Register<IBroadcastsRepository, BroadcastsService>(Lifestyle.Transient);

         //   container.Register<ILogger, MailLogger>(Lifestyle.Singleton);

            // 3. Optionally verify the container's configuration.
            container.Verify();

            // 4. Register the container as MVC3 IDependencyResolver.
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));


           // container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            
            //InitializeContainer(container);

            //container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            
            //container.Verify();
            
            //DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
     
        private static void InitializeContainer(Container container)
        {
//#error Register your services here (remove this line).

            // For instance:
            // container.Register<IUserRepository, SqlUserRepository>(Lifestyle.Scoped);
        }
    }
}