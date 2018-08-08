using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Freyja.Startup))]
namespace Freyja
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
