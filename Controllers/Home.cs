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
    public class Home : ControllerBase
    {
        private readonly NewSolutionsContext db;

        public Home(NewSolutionsContext db)
        {
            this.db = db;
        }

        // GET: api/<HomeSection1>
        [HttpGet("HomeSection1")]
        public ActionResult GetSection1()
        {
            return Ok(db.HomeSection1s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        // POST api/<HomeSection1>
        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("HomeSection1")]
        public ActionResult Post([FromBody] HomeSection1 value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            db.HomeSection1s.Add(value);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet("HomeSection2")]
        public ActionResult GetSection2()
        {
            return Ok(db.HomeSection2s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("HomeSection2")]
        public ActionResult Post([FromBody] HomeSection2 value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            db.HomeSection2s.Add(value);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet("HomeSection3")]
        public ActionResult GetSection3()
        {
            return Ok(db.HomeSection3s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("HomeSection3")]
        public ActionResult Post([FromBody] HomeSection3 value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            db.HomeSection3s.Add(value);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet("HomeSection4")]
        public ActionResult GetSection4()
        {
            return Ok(db.HomeSection4s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("HomeSection4")]
        public ActionResult Post([FromBody] HomeSection4 value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            db.HomeSection4s.Add(value);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet("HomeSection4-card1")]
        public ActionResult GetSection4Card1()
        {
            return Ok(db.HomeSection4Card1s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("HomeSection4-card1")]
        public ActionResult Post([FromBody] HomeSection4Card1 value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            db.HomeSection4Card1s.Add(value);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet("HomeSection4-card2")]
        public ActionResult GetSection4Card2()
        {
            return Ok(db.HomeSection4Card2s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("HomeSection4-card2")]
        public ActionResult Post([FromBody] HomeSection4Card2 value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            db.HomeSection4Card2s.Add(value);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet("HomeSection4-card3")]
        public ActionResult GetSection4Card3()
        {
            return Ok(db.HomeSection4Card3s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("HomeSection4-card3")]
        public ActionResult Post([FromBody] HomeSection4Card3 value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            db.HomeSection4Card3s.Add(value);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet("HomeSection5")]
        public ActionResult GetSection5()
        {
            return Ok(db.HomeSection5s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("HomeSection5")]
        public ActionResult Post([FromBody] HomeSection5 value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            db.HomeSection5s.Add(value);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet("HomeSection6")]
        public ActionResult GetSection6()
        {
            return Ok(db.HomeSection6s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("HomeSection6")]
        public ActionResult Post([FromBody] HomeSection6 value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            db.HomeSection6s.Add(value);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet("HomeSection7")]
        public ActionResult GetSection7()
        {
            return Ok(db.HomeSection7s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("HomeSection7")]
        public ActionResult Post([FromBody] HomeSection7 value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            db.HomeSection7s.Add(value);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet("HomeSection7-Slider1")]
        public ActionResult GetSection7Slider1()
        {
            return Ok(db.HomeSection7Slider1s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("HomeSection7-Slider1")]
        public ActionResult Post([FromBody] HomeSection7Slider1 value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            db.HomeSection7Slider1s.Add(value);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet("HomeSection7-Slider2")]
        public ActionResult GetSection7Slider2()
        {
            return Ok(db.HomeSection7Slider2s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("HomeSection7-Slider2")]
        public ActionResult Post([FromBody] HomeSection7Slider2 value)
        {
            if (value == null)
            {
                return BadRequest();
            }
            db.HomeSection7Slider2s.Add(value);
            db.SaveChanges();
            return Ok();
        }

    }
}
