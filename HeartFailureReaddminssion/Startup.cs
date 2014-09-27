using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HeartFailureReaddminssion.Startup))]
namespace HeartFailureReaddminssion
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
