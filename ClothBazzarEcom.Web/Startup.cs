using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClothBazzarEcom.Web.Startup))]
namespace ClothBazzarEcom.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
