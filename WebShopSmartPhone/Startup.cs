using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebShopSmartPhone.Startup))]
namespace WebShopSmartPhone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
