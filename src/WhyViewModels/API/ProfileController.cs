using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WhyViewModels.Data;
using WhyViewModels.ViewModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WhyViewModels.API
{
    [Route("api/[controller]")]
    public class ProfileController : Controller
    {
        private ApplicationDbContext _db;
        public ProfileController(ApplicationDbContext db)
        {
            _db = db;
        }


        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var profile = _db.Profiles.Where(p => p.Id == id).Select(p => new ProfileViewModel {
                Id = p.Id,
                FirstName = p.FirstName,
                LastName = p.LastName
            }).FirstOrDefault();

            return Ok(profile);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]CreateMovieBookViewModel data)
        {
            _db.Movies.Add(data.Movie);
            _db.Books.Add(data.Book);
            _db.SaveChanges();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
