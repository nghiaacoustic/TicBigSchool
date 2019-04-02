using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tic_BigSchool.Startup))]
namespace Tic_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
