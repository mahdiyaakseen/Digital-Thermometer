using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IsotechThermometer.Startup))]
namespace IsotechThermometer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
