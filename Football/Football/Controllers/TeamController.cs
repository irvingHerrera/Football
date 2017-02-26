using Football.Bussines;
using Football.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Football.Controllers
{
    public class TeamController : ApiController
    {
        private TeamBussines tb;

        public TeamController()
        {
            tb = new TeamBussines();
        }

        // GET: api/Team
        public IEnumerable<Team> Get()
        {
            var lst = tb.GetAllTeam();

            return lst.ToList();
        }

        // GET: api/Team/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Team
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Team/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Team/5
        public void Delete(int id)
        {
        }
    }
}
