using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TinyMCE_MVC_Sample.Startup))]
namespace TinyMCE_MVC_Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
