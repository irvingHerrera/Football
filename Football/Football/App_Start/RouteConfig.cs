using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace Football
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //var settings = new FriendlyUrlSettings();
            //settings.AutoRedirectMode = RedirectMode.Permanent;
            //routes.EnableFriendlyUrls(settings);

            #region Route Team
            routes.MapPageRoute("",
            "Equipo",
            "~/ViewFootball/Team/Index.aspx");

            routes.MapPageRoute("",
            "Equipo/Nuevo",
            "~/ViewFootball/Team/Create.aspx");

            routes.MapPageRoute("",
            "Equipo/Editar",
            "~/ViewFootball/Team/Edit.aspx");

            routes.MapPageRoute("",
            "Equipo/Ver",
            "~/ViewFootball/Team/Details.aspx");

            routes.MapPageRoute("",
            "Equipo/Eliminar",
            "~/ViewFootball/Team/Delete.aspx");

            #endregion

            #region Route Player

            routes.MapPageRoute("",
             "Jugador",
             "~/ViewFootball/Player/Index.aspx");

            routes.MapPageRoute("",
            "Jugador/Nuevo",
            "~/ViewFootball/Player/Create.aspx");

            routes.MapPageRoute("",
            "Jugador/Editar",
            "~/ViewFootball/Player/Index.aspx");

            routes.MapPageRoute("",
            "Jugador/Ver",
            "~/ViewFootball/Player/Details.aspx");

            routes.MapPageRoute("",
            "Jugador/Eliminar",
            "~/ViewFootball/Player/Delete.aspx");

            #endregion

            #region Route Game

            routes.MapPageRoute("",
             "Partido",
             "~/ViewFootball/Game/Index.aspx");

            routes.MapPageRoute("",
            "Partido/Nuevo",
            "~/ViewFootball/Game/Create.aspx");

            routes.MapPageRoute("",
            "Partido/Game",
            "~/ViewFootball/Game/Index.aspx");

            routes.MapPageRoute("",
            "Partido/Game",
            "~/ViewFootball/Game/Details.aspx");

            routes.MapPageRoute("",
            "Partido/Game",
            "~/ViewFootball/Game/Delete.aspx");

            #endregion
        }
    }
}
