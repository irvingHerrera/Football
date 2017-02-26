using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football.Entities;
using Football.Data;
using Football.Data.Repositories;

namespace Football.Bussines
{
    public class TeamBussines : IBussines
    {
        private IConnectionFactory connectionFactory;

        public IList<Team> GetAllTeam()
        {
            connectionFactory = ConnectionHelper.GetConnection();
            var context = new DbContext(connectionFactory);
            var teamRep = new TeamRepository(context);
            var lstTeam = teamRep.GetUsers();

            context.Dispose();

            return lstTeam;
        }
    }
}
