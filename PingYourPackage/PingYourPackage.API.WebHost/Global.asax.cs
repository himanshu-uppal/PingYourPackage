using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using System.Net.Http;




namespace PingYourPackage.API.WebHost
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            EFConfig.Initialize();

            //var config = GlobalConfiguration.Configuration;
            //RouteConfig.RegisterRoutes(config);
            //WebAPIConfig.Configure(config);
            //AutofacWebAPI.Initialize(config);
        }
    }
}
