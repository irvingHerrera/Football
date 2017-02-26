using Football.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Data.Repositories
{
    public class TeamRepository : Repository<Team>
    {
        private DbContext context;

        public TeamRepository(DbContext context) : base(context)
        {
            this.context = context;
        }

        public IList<Team> GetUsers()
        {
            using (var command = context.CreateCommand())
            {
                command.CommandText = "exec [dbo].[GetAllTeam]";

                return this.ToList(command).ToList();
            }
        }
    }
}
