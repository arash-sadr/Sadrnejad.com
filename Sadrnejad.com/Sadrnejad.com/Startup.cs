using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sadrnejad.com.Startup))]
namespace Sadrnejad.com
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
