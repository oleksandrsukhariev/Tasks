using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Timers;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Timer = System.Timers.Timer;

namespace WebPart2Task
{
    public class Global : System.Web.HttpApplication
    {
        public static int AllRequestsCount = 0;
        private Timer timer = new Timer(86400000D);
        

        protected void Application_Start(object sender, EventArgs e)
        {
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Elapsed += new ElapsedEventHandler(timer_Elapsed);

            Application["AllUsersCount"] = 0;
            Application["DefaultPageRequestCount"] = 0;
            Application["AboutPageRequestCount"] = 0;
            Application["ContactPageRequestCount"] = 0;
            Application["UniqueUsersCount"] = 0;
            Application["TodayUsersCount"] = 0;
            Application["TodayRequestCount"] = 0;   

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            var usersCount = Convert.ToInt16(Application["AllUsersCount"]);
            Application["AllUsersCount"] = (usersCount + 1).ToString();

            var todayUsersCount = Convert.ToInt16(Application["TodayUsersCount"]);
            Application["TodayUsersCount"] = (todayUsersCount + 1).ToString();
            
            if (Request.Cookies["username"] == null)
            {
                var userIdentity = "notUniqueUser";

                var cookie = new HttpCookie("username", userIdentity) {Expires = DateTime.MaxValue};
                Response.Cookies.Add(cookie);
            }
            else
            {
                var uniqueUsersCount = Convert.ToInt16(Application["UniqueUsersCount"]);
                Application["UniqueUsersCount"] = (uniqueUsersCount + 1).ToString();
            }

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            var requestPerDayCount = Convert.ToInt16(Application["TodayRequestCount"]);
            Application["TodayRequestCount"] = (requestPerDayCount + 1).ToString();

            var userIdentity = "notUniqueUser";

            var cookie = new HttpCookie("username", userIdentity) {Expires = DateTime.MaxValue};
            Response.Cookies.Add(cookie);
        }

        public void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Application["TodayUsersCount"] = 0;
            Application["TodayRequestCount"] = 0;
        }
    }
}