using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace WebAppOne.Asp.net
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
        }

        protected void Application_Error()
        {

        }

        protected void Application_Stop()
        {

        }
    }
}

//no main method, application start is the thing that starts ever Active Server Application X, thing that starts everything