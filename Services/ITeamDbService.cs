using kolAPBD2.DTOs.Requests;
using kolAPBD2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolAPBD2.Services
{
    public interface ITeamDbService
    {
        public IEnumerable<Team> GetTeams(int IdTeam);

        public void AddPlayer(PlayerRequest playerRequest);
    }
}
