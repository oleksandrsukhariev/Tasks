using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        private MembershipUserCollection _MyUsers;
        protected void Page_Load(object sender, EventArgs e)
        {
            _MyUsers = Membership.GetAllUsers();
            GridView1.DataSource = _MyUsers;

            if (!IsPostBack)
            {
                GridView1.DataBind();
            }

            CountLabel.Text = string.Format("There are: {0} users in your base!", _MyUsers.Count);
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex >= 0)
            {
                var Current = _MyUsers[(string)GridView1.SelectedValue];

                UsernameLabel.Text = Current.UserName;
                PasswordText.Text = Current.GetPassword();
                EmailText.Text = Current.Email;
            }
        }

        protected void update_btn_Click(object sender, EventArgs e)
        {
            if (GridView1.SelectedIndex >= 0)
            {
                MembershipUser Current = _MyUsers[(string)GridView1.SelectedValue];

                Current.ChangePassword(Current.GetPassword(), PasswordText.Text);
                Current.Email = string.Empty;
                Current.Email = EmailText.Text;

                Membership.UpdateUser(Current);

                GridView1.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Membership.DeleteUser(GridView1.Rows[e.RowIndex].Cells[0].Text);
            GridView1.DataBind();
            Response.Redirect(Request.Url.ToString());
        }
    }
}
