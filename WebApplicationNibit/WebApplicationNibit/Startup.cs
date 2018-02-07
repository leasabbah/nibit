using Microsoft.Owin;
using Owin;
using SimpleInjector;
using SimpleInjector.Lifestyles;
using SimpleInjector.Integration;
[assembly: OwinStartupAttribute(typeof(WebApplicationNibit.Startup))]
namespace WebApplicationNibit
{
    public partial class Startup
    {
        private Container container = new Container();

        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            
        }
        
    }
}
