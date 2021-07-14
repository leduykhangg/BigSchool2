using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BigSchool2.Startup))]
namespace BigSchool2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
