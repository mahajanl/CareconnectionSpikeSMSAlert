using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CareConnection2.Startup))]
namespace CareConnection2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
