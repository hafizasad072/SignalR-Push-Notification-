using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.Entity.Infrastructure;
using Microsoft.AspNet.SignalR.Hubs;
using Toaster_Notification_Signar_R.DB;
using Microsoft.AspNet.Identity;

namespace Toaster_Notification_Signar_R
{
    [HubName("myhub")]
    public class MyHub : Hub
    {
        public static void Show()
        {
            IHubContext context = GlobalHost.ConnectionManager.GetHubContext<MyHub>();
            context.Clients.All.displayStatus();
        }
        public void getlatestmessage()
        {
            Extention.GetData();
        }

    }
    public class Extention
    {
        public static void GetData()
        {
            string con = ConfigurationManager.ConnectionStrings["DataBase"].ConnectionString;
            using (var connection = new SqlConnection(con))
            {
                connection.Open();
                SignalREntities db = new SignalREntities();
                string uid = HttpContext.Current.User.Identity.GetUserId();
                var query = db.Heartbeats as DbQuery<Heartbeat>;
                using (SqlCommand command = new SqlCommand(@"SELECT [NotificationId]
                                                              ,[UserName]
                                                              ,[UserId]
                                                              ,[NotificationText]
                                                              ,[NotificationDate]
                                                          FROM [dbo].[Notification]"/*@"SELECT  [ProductID],[Name],[UnitPrice],[Quantity] FROM [SignalRDemo].[dbo].[Products]"*/, connection))
                {
                    // Make sure the command object does not already have
                    // a notification object associated with it.
                    command.Notification = null;
                    SqlDependency.Start(con);
                    SqlDependency dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    using (var reader = command.ExecuteReader())
                    { }
                    //return reader.Cast<IDataRecord>()
                    //    .Select(x => new Notification()
                    //    {
                    //        NotificationId = x.GetInt64(0),
                    //        UserName = x.GetString(1),
                    //        NotificationDate = x.GetDateTime(4),
                    //        Notification1 = x.GetString(3),
                    //        UserId = x.GetString(2),
                    //    }).Where(x => x.UserId == uid).ToList();



                }
            }
        }
        private static void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            //if(e.Type == SqlNotifica)
            MyHub.Show();
        }

    }
}
