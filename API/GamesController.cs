using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Football4.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Football4
{
    [Route("api/[controller]")]
    public class GamesController : BaseController
    {
        public GamesController(MyDbContext _db): base(_db) { }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return DB.Games.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Game GetById(int id)
        {
            return DB.Games.Find(id);
        }

        // GET: api/<controller>/week/5
        [HttpGet("week/{week}")]
        public IEnumerable<Game> GetByWeek(int week)
        {
            return DB.Games.Where(g => g.Week == week).ToList();
        }

        // GET api/<controller>/team/NYG
        [HttpGet("team/{teamId}")]
        public IEnumerable<Game> GetByTeam(string teamId)
        {
            teamId = teamId.ToUpper();

            return DB.Games
                .Include("HomeTeam")
                .Include("AwayTeam")
                //.Include("Favorite.TeamId")
                .Where(g => g.HomeTeam.TeamId == teamId || g.AwayTeam.TeamId == teamId)
                .ToList();
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
