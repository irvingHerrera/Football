using Football.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Bussines
{
    public interface IBussines
    {
        IList<Team> GetAllTeam();
    }
}
