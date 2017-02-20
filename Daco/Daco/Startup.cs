using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Daco.Startup))]
namespace Daco
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
