using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FinalProject2020.Startup))]
namespace FinalProject2020
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
