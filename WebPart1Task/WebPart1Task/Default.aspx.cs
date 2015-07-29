using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebPart1Task
{
    public partial class Default : System.Web.UI.Page
    {

        // Get all methods and display info
        //protected override void OnInit(EventArgs e)
        //{
        //    var all = this.GetType().GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        //    foreach (var method in all)
        //    {
        //        Response.Write(string.Format("Method{0}\t{1}<br/>", method.Name, DateTime.Now.ToUniversalTime()));
        //    }
        //}

        #region Page events
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Response.Write(string.Format("Page_PreInit {0}<br/>", DateTime.Now.ToUniversalTime()));
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            Response.Write(string.Format("Page_Init {0}<br/>", DateTime.Now.ToUniversalTime()));
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Response.Write(string.Format("Page_InitComplete {0}<br/>", DateTime.Now.ToUniversalTime()));
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            Response.Write(string.Format("Page_PreLoad {0}<br/>", DateTime.Now.ToUniversalTime()));
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(string.Format("Page_Load {0}<br/>", DateTime.Now.ToUniversalTime()));
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Response.Write(string.Format("Page_LoadComplete {0}<br/>", DateTime.Now.ToUniversalTime()));
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            Response.Write(string.Format("Page_PreRender {0}<br/>", DateTime.Now.ToUniversalTime()));
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            Response.Write(string.Format("Page_PreRenderComplete {0}<br/>", DateTime.Now.ToUniversalTime()));
        }
        protected void Page_SaveStateComplete(object sender, EventArgs e)
        {
            Response.Write(string.Format("Page_SaveStateComplete {0}<br/>", DateTime.Now.ToUniversalTime()));
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            // Will never be shown cause HTML markup was generated before this(Page.Response.Write() can`t write cause markup was generated before)
            Label1.Text += "Page_Unload text will never be visible";
        }
        #endregion

        #region Methods
        //Page.Response.Write() can`t write from this method cause Response page property aren`t set until UICulture
        protected override void Construct()
        {
            base.Construct();
        }
        //Page.Response.Write() can`t write from this method cause Response page property aren`t set until UICulture
        public override void ProcessRequest(HttpContext context)
        {
            base.ProcessRequest(context);
        }
        // Will never be shown cause HTML markup was generated before this(Page.Response.Write() can`t write cause markup was generated before)
        protected override void OnUnload(EventArgs e)
        {
            Label1.Text += "OnUnload text will never be visible";
            base.OnUnload(e);
        }
        // Will never be shown cause HTML markup was generated before this(Page.Response.Write() can`t write cause markup was generated before)
        public override void Dispose()
        {
            Label1.Text += "Dispose text will never be visible";
            base.Dispose();
        }

        protected override void InitializeCulture()
        {
            Response.Write(string.Format("InitializeCulture {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.InitializeCulture();
        }
        protected override NameValueCollection DeterminePostBackMode()
        {
            Response.Write(string.Format("DeterminePostBackMode {0}<br/>", DateTime.Now.ToUniversalTime()));
            return base.DeterminePostBackMode();
        }
        protected override void OnPreInit(EventArgs e)
        {
            Response.Write(string.Format("OnPreInit {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.OnPreInit(e);
        }

        protected override void OnInit(EventArgs e)
        {
            Response.Write(string.Format("OnInit {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.OnInit(e);
        }

        protected override void TrackViewState()
        {
            Response.Write(string.Format("TrackViewState {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.TrackViewState();
        }

        protected override void OnInitComplete(EventArgs e)
        {
            Response.Write(string.Format("OnInitComplete {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.OnInitComplete(e);
        }

        protected override object LoadPageStateFromPersistenceMedium()
        {
            Response.Write(string.Format("LoadPageStateFromPersistenceMedium {0}<br/>", DateTime.Now.ToUniversalTime()));
            return base.LoadPageStateFromPersistenceMedium();
        }

        protected override void LoadViewState(object savedState)
        {
            Response.Write(string.Format("LoadViewState {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.LoadViewState(savedState);
        }

        protected override void OnPreLoad(EventArgs e)
        {
            Response.Write(string.Format("OnPreLoad {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.OnPreLoad(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            Response.Write(string.Format("OnLoad {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.OnLoad(e);
        }

        protected override void RaisePostBackEvent(IPostBackEventHandler sourceControl, string eventArgument)
        {
            Response.Write(string.Format("RaisePostBackEvent {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.RaisePostBackEvent(sourceControl, eventArgument);
        }

        public override void Validate()
        {
            Response.Write(string.Format("Validate {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.Validate();
        }

        protected override void OnLoadComplete(EventArgs e)
        {
            Response.Write(string.Format("OnLoadComplete {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.OnLoadComplete(e);
        }

        protected override void OnPreRender(EventArgs e)
        {
            Response.Write(string.Format("OnPreRender {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.OnPreRender(e);
        }

        protected override void OnPreRenderComplete(EventArgs e)
        {
            Response.Write(string.Format("OnPreRenderComplete {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.OnPreRenderComplete(e);
        }

        protected override object SaveViewState()
        {
            Response.Write(string.Format("SaveViewState {0}<br/>", DateTime.Now.ToUniversalTime()));
            return base.SaveViewState();
        }

        protected override void SavePageStateToPersistenceMedium(object state)
        {
            Response.Write(string.Format("SavePageStateToPersistenceMedium {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.SavePageStateToPersistenceMedium(state);
        }

        protected override void OnSaveStateComplete(EventArgs e)
        {
            Response.Write(string.Format("OnSaveStateComplete {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.OnSaveStateComplete(e);
        }

        public override void RenderControl(HtmlTextWriter writer)
        {
            Response.Write(string.Format("RenderControl {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.RenderControl(writer);
        }

        protected override void Render(HtmlTextWriter writer)
        {
            Response.Write(string.Format("Render {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.Render(writer);
        }

        protected override void RenderChildren(HtmlTextWriter writer)
        {
            Response.Write(string.Format("RenderChildren {0}<br/>", DateTime.Now.ToUniversalTime()));
            base.RenderChildren(writer);
        }

        #endregion

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Request form property includes the pairs(name,key) for each control in form. Stores info at at NameValueCollection

            //Each click with post back includes different values of ViewState and EventValidation properties cause in each request they includes new information and encode it. 
            //They save and recover state of controls in each request.
            int numcells = 1;
            for (int i = 0; i < Request.Form.Count; i++)
            {
                TableRow r = new TableRow();
                for (int j = 0; j < numcells; j++)
                {
                    TableCell c = new TableCell();
                    TableCell b = new TableCell();
                    c.Controls.Add(new LiteralControl(Request.Form.GetKey(i)));
                    b.Controls.Add(new LiteralControl(Request.Form[i]));
                    r.Cells.Add(c);
                    r.Cells.Add(b);
                }
                Table1.Rows.Add(r);
            }
        }
    }
}