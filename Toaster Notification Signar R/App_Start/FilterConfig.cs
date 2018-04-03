using System.Web;
using System.Web.Mvc;

namespace Toaster_Notification_Signar_R
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
