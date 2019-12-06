using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalProject_JasonHuber.Startup))]
namespace FinalProject_JasonHuber
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
