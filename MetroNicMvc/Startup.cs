using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MetroNicMvc.Startup))]
namespace MetroNicMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
