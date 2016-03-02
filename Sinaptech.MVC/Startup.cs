using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sinaptech.MVC.Startup))]
namespace Sinaptech.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
