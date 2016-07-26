using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SetupAnularjsApp.Startup))]
namespace SetupAnularjsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
