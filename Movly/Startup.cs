using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Movly.Startup))]
namespace Movly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
