using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PointCollegeSensorControl.Startup))]
namespace PointCollegeSensorControl
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
