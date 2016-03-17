using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_0314.Startup))]
namespace _0314
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
