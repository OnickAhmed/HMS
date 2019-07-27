using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HMS_MVC.Startup))]
namespace HMS_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
