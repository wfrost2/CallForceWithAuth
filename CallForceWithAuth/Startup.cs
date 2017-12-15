using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CallForceWithAuth.Startup))]
namespace CallForceWithAuth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
