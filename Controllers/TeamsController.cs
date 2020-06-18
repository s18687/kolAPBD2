using kolAPBD2.DTOs.Requests;
using kolAPBD2.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kolAPBD2.Controllers
{
    [Route("api/teams")]
    [ApiController]
    public class TeamsController : ControllerBase
    {
        private readonly ITeamDbService dbService;

        public TeamsController(ITeamDbService dbService)
        {
            this.dbService = dbService;
        }

        [HttpGet("{id:int}/players")]
        public IActionResult AddPlayer(int id, PlayerRequest req)
        {
           
        }
    }
}
