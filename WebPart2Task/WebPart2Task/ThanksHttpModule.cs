using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebPart2Task
{
    public delegate void ThanksEventHandler(Object s, EventArgs e);	

    public class ThanksHttpModule : IHttpModule
    {
        private ThanksEventHandler _eventHandler = null;

        public event ThanksEventHandler MyEvent
        {
            add { _eventHandler += value; }
            remove { _eventHandler -= value; }
        }

        public void Dispose()
        { }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += new EventHandler(OnBeginRequest);
        }

        public void OnBeginRequest(Object s, EventArgs e)
        {
            HttpApplication app = s as HttpApplication;
            app.Context.Response.Write("Thanks for visit our site!.<br>");
            if (_eventHandler != null)
                _eventHandler(this, null);
            Global.AllRequestsCount += 1;
        }
    }
}