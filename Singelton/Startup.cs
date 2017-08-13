using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Singelton.Startup))]
namespace Singelton
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
