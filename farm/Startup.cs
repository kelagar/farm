using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(farm.Startup))]
namespace farm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
