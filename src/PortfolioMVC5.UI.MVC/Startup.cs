using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PortfolioMVC5.UI.MVC.Startup))]
namespace PortfolioMVC5.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
