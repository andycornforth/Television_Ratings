using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RatingsMVC.Startup))]
namespace RatingsMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
