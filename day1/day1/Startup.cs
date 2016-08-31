using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(day1.Startup))]
namespace day1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
