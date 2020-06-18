using System;
using System.Collections.Generic;

namespace kolAPBD2.Models
{
    public partial class Player
    {
        public Player()
        {
            PlayerTeam = new HashSet<PlayerTeam>();
        }

        public int IdPlayer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<PlayerTeam> PlayerTeam { get; set; }
    }
}
