using Microsoft.Owin;
using Owin;
using System.Web.Services.Description;

[assembly: OwinStartupAttribute(typeof(IsotechThermometer.Startup))]
namespace IsotechThermometer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            // check if serial link connected
            // clear any commands ongoing
            // clear data buffers
        }


        
        public void ConfigureServices(ServiceCollection services)
        {
           // add services consumed by application

        }
    }
}
