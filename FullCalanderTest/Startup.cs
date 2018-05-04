using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullCalanderTest.Startup))]
namespace FullCalanderTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
