using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BoardGamePlaylist_MVC.Startup))]
namespace BoardGamePlaylist_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
