using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(purchase_products.Startup))]
namespace purchase_products
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
