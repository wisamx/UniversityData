using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UniversityData.Startup))]
namespace UniversityData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
