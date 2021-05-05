using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScottPhotography.UI.MVC.Startup))]
namespace ScottPhotography.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
