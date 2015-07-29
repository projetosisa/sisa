﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace sisa
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "TesteRota",
                url: "TesteRota",
                defaults: new { controller = "Home", action = "Index" }
            );
            
            routes.MapRoute(
                name: "PessoaContratos",
                url: "Pessoa/Index/{codcli}/{banco}",
                defaults: new { controller = "Pessoa", action = "Index", codcli = UrlParameter.Optional, banco = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
