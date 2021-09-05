using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_NewSolutions.Models;
using Microsoft.AspNetCore.Authorization;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Core_NewSolutions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class About : ControllerBase
    {

        private readonly NewSolutionsContext db;

        public About(NewSolutionsContext db)
        {
            this.db = db;
        }

        // GET: api/<AboutController>
        [HttpGet("AboutSection1")]
        public ActionResult GetSection1()
        {
            return Ok(db.AboutSection1s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        // POST api/<AboutController>
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("AboutSection1")]
        public ActionResult Post([FromBody] AboutSection1 value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            db.AboutSection1s.Add(value);
            db.SaveChanges();
            return Ok();
        }

        // GET: api/<AboutController>
        [HttpGet("AboutSection2")]
        public ActionResult GetSection2()
        {
            return Ok(db.AboutSection2s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        // POST api/<AboutController>
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("AboutSection2")]
        public ActionResult Post([FromBody] AboutSection2 value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            db.AboutSection2s.Add(value);
            db.SaveChanges();
            return Ok();
        }

        // GET: api/<AboutController>
        [HttpGet("AboutSection3")]
        public ActionResult GetSection3()
        {
            return Ok(db.AboutSection3s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        // POST api/<AboutController>
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("AboutSection3")]
        public ActionResult Post([FromBody] AboutSection3 value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            db.AboutSection3s.Add(value);
            db.SaveChanges();
            return Ok();
        }

    }
}
