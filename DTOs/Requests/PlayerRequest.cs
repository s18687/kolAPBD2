using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace kolAPBD2.DTOs.Requests
{
    public interface PlayerRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int NumOnShirt { get; set; }
        public string? comment { get; set; }
        public int IdTeam { get; set; }
        
    }
}
