using Core_NewSolutions.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_NewSolutions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Contacts : ControllerBase
    {

        private readonly NewSolutionsContext db;

        public Contacts(NewSolutionsContext db)
        {
            this.db = db;
        }

        [HttpGet("ContactsSection1")]
        public ActionResult GetSection1()
        {
            return Ok(db.ContactsSection1s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("ContactsSection1")]
        public ActionResult Post([FromBody] ContactsSection1 value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            db.ContactsSection1s.Add(value);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet("SocialMedia")]
        public ActionResult SocialMedia()
        {
            return Ok(db.ContactsSocialMedia.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("SocialMedia")]
        public ActionResult Post([FromBody] ContactsSocialMedium value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            db.ContactsSocialMedia.Add(value);
            db.SaveChanges();
            return Ok();
        }

    }
}
