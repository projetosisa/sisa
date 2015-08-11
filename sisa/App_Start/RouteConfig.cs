using System;
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
                name: "Login",
                url: "Login",
                defaults: new { controller = "Usuario", action = "Index" }
            );
            routes.MapRoute(
                name: "Principal",
                url: "Principal",
                defaults: new { controller = "Home", action = "Index" }
            );
            routes.MapRoute(
                name: "TesteRota",
                url: "PesquisaPessoa",
                defaults: new { controller = "Pessoa", action = "Index" }
            );

            routes.MapRoute(
                name: "Retornar Contrato",
                url: "TesteContrato/{codcli}/{banco}",
                defaults: new { controller = "Pessoa", action = "Index" }
            );
            
            routes.MapRoute(
                name: "PessoaContratos",
                url: "Pessoa/Index/{codcli}/{banco}",
                defaults: new { controller = "Pessoa", action = "Index", codcli = UrlParameter.Optional, banco = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "EditarProcesso",
               url: "Processo/Editar/{id}",
               defaults: new { controller = "Processo", action = "Editar" }
           );

            routes.MapRoute(
               name: "PessoaProcesso",
               url: "Pessoa/ListaProcessos/{codcli}/{banco}",
               defaults: new { controller = "Pessoa", action = "ListaProcessos", codcli = UrlParameter.Optional, banco = UrlParameter.Optional, contrato = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
