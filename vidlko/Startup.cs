using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vidlko.Startup))]
namespace vidlko
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
