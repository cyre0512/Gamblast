using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gamblast.Startup))]
namespace Gamblast
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
