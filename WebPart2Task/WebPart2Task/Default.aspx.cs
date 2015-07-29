using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPart2Task
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var usersCount = Convert.ToInt16(Application["DefaultPageRequestCount"]);
            Application["DefaultPageRequestCount"] = (usersCount + 1).ToString();
        }
    }
}