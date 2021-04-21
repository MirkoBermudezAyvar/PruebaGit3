using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaGit3.Startup))]
namespace PruebaGit3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
