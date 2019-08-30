using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Football4.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Football4
{
    [Route("api/[controller]")]
    public class TeamsController : BaseController
    {
        // passthrough to base
        public TeamsController(MyDbContext _db) : base(_db) { }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Team> Get()
        {
            return base.DB.Teams.ToList();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Team Get(string id)
        {
            return base.DB.Teams.Find(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]Team value)
        {
            ;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
