using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Entities
{
    public class Team
    {
        public int IdTeam { get; set; }
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }
        public string Image { get; set; }
    }
}
