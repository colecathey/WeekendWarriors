using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeekendWarriors.Startup))]
namespace WeekendWarriors
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
