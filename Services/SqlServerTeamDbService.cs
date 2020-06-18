using kolAPBD2.DTOs.Requests;
using kolAPBD2.Exceptions;
using kolAPBD2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolAPBD2.Services
{
    public class SqlServerTeamDbService : ITeamDbService
    {
        private readonly s18687Context context;

        public SqlServerTeamDbService(s18687Context context)
        {
            this.context = context;
        }

        
        public IEnumerable<Team> GetTeams(int IdTeam)
        {
            //wyciagnac liste druzyn
            throw new NotImplementedException();
        }

        public void AddPlayer(PlayerRequest playerRequest)
        {

            Player newPlayer = context.Player.Where(p => p.FirstName == playerRequest.FirstName).
                Where(p => p.LastName == playerRequest.LastName).
                Where(p => p.DateOfBirth == playerRequest.DateOfBirth).SingleOrDefault();
            if (playerRequest == null)
            {
                throw new Exc("This player does not exist.");
            }

            Team newTeam = context.Team.Where(t => t.IdTeam == playerRequest.IdTeam).SingleOrDefault();

            var today = DateTime.Today;
            var age = today - playerRequest.DateOfBirth;

            //sprawdzic czy nalezy do druzyny, jesli nie to dodac do kontekstu i zapisac zmiany
           
            context.SaveChanges();

            //if (age.ToString > newTeam.MaxAge)
            //{
            //    throw new ExcAge("Player to old");
            //}
        }

    }
}
