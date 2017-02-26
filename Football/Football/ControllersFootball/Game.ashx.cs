using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Football.ControllersFootball
{
    /// <summary>
    /// Descripción breve de Game
    /// </summary>
    public class Game : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "texto/normal";
            context.Response.Write("Hola a todos");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}