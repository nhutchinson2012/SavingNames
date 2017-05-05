using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaveTest.Startup))]
namespace SaveTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
