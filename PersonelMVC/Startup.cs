using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PersonelMVC.Startup))]
namespace PersonelMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
