using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WuQiang.WebSevice.Web.Startup))]
namespace WuQiang.WebSevice.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
