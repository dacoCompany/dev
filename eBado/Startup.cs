using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eBado.Startup))]
namespace eBado
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
