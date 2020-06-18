using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolAPBD2.DTOs.Responses
{
    public class TeamResponse
    {
        public int MyProperty { get; set; }
        public int IdTeam { get; set; }
        public string TeamName { get; set; }
        public int MaxAge { get; set; }
        public float Score { get; set; }
    }
}
