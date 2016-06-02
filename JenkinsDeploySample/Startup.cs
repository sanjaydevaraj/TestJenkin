using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JenkinsDeploySample.Startup))]
namespace JenkinsDeploySample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
