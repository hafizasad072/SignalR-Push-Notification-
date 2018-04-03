using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Toaster_Notification_Signar_R.Startup))]
namespace Toaster_Notification_Signar_R
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
