using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Deals.Startup))]
namespace Deals
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
