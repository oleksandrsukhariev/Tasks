using System;
using System.IO;
using System.Linq;
using System.Web.Configuration;
using System.Web.Services.Description;
using System.Web.UI;
using System.Windows.Forms;

namespace WebPart2Task
{
    public partial class Stat : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            #region For concrete page if in file

            try
            {
                var pages =  LoadPagesFromFile();

            if (pages.Contains("About.aspx"))
            {
                Label1.Text = "Requests for About page: " + Application["AboutPageRequestCount"];
            }
            else
            {
                Label1.Text = String.Empty;
            }

            if (pages.Contains("Contact.aspx"))
            {
                Label2.Text = "Requests for Contact page:" + Application["ContactPageRequestCount"];
            }
            else
            {
                Label2.Text = String.Empty;
            }

            if (pages.Contains("Default.aspx"))
            {
                Label3.Text = "Requests for Default page:" + Application["DefaultPageRequestCount"];
            }
            else
            {
                Label3.Text = String.Empty;
            }
            }
            catch(FileNotFoundException ex)
            {
                //Uncomment this for show messagebox
                //MessageBox.Show("Place Pages.txt file to D:\\project\\Pages.txt",ex.Message);

                Label1.Text = "Requests for About page: " + Application["AboutPageRequestCount"];
                Label2.Text = "Requests for Contact page:" + Application["ContactPageRequestCount"];
                Label3.Text = "Requests for Default page:" + Application["DefaultPageRequestCount"];
            }

            #endregion

            Label4.Text = "Count of all users:" + Application["AllUsersCount"];
            Label5.Text = "Count of unique users:" + Application["UniqueUsersCount"];
            Label6.Text = "Count of all requests:" + Global.AllRequestsCount;

            Label7.Text = "Count of TODAY users:"+Application["TodayUsersCount"];
            Label8.Text = "Count of TODAY requests:" + Application["TodayRequestCount"]; ;
        }

        /// <summary>
        /// Get pages list from file
        /// </summary>
        /// <returns></returns>
        private string[] LoadPagesFromFile()
        {
            using (StreamReader sr = new StreamReader(WebConfigurationManager.AppSettings["fileLocation"]))
            {
                var line = sr.ReadToEnd();
                var words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return words;
            }
        }
    }
}