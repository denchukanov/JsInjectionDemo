﻿using System.Web;
using System.Web.Http;

namespace JsInjectionDemo
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
