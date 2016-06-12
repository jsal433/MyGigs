using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyGigs.Startup))]
namespace MyGigs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
