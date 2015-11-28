using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QaStories.Web.Startup))]
namespace QaStories.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
