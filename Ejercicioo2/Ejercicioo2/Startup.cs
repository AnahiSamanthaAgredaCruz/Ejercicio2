using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ejercicioo2.Startup))]
namespace Ejercicioo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
