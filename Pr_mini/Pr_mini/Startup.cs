using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Pr_mini.Startup))]
namespace Pr_mini
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
