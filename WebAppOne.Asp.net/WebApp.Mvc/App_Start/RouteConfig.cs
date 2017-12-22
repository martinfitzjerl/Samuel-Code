using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApp.Mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");//there are some files that will get generated based on resources, axd will have info of our routing information
            //for every file we create we are serving content, mvc has to generate indexing, axd will check indexing, no direct access to server
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",//placeholder, requests start with controller, similar to string interpolation, actions/methods- when someone outside is requesting something it is called an action, ID is any information you want to pass
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }//our template//if you don't give me a piece then I will fill with default
                //when you make a request it will find resource and then internally find file that gives resource
                //Controller suffix is there automatically, differientiates classes that are controllers, 
            );
        }
    }
}
