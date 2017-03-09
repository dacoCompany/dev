using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Web.eBado.Startup))]
namespace Web.eBado
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
