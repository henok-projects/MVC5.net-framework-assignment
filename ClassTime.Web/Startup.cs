using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClassTime.Web.Startup))]
namespace ClassTime.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
