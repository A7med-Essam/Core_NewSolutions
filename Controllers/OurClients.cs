using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core_NewSolutions.Models;
using Core_NewSolutions.Interfaces;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace Core_NewSolutions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OurClients : ControllerBase
    {
        private readonly IphotoServices _photoService;
        private readonly NewSolutionsContext db;

        public OurClients(IphotoServices photoService, NewSolutionsContext db)
        {
            _photoService = photoService;
            this.db = db;
        }

        [HttpGet("ClientsSection1")]
        public ActionResult GetSection1()
        {
            return Ok(db.ClientsSection1s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("ClientsSection1")]
        public ActionResult Post([FromBody] ClientsSection1 value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            db.ClientsSection1s.Add(value);
            db.SaveChanges();
            return Ok();
        }


        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("AddClientsImg")]
        public async Task<ActionResult> AddClientsImg([FromForm] IFormFile File)
        {
            var result = await _photoService.AddPhotoAsync(File);

            if (result.Error != null)
            {
                return BadRequest(result.Error.Message);
            }

            var img = new ClientImgUrl()
            {
                Url = result.SecureUrl.AbsoluteUri
            };

            db.ClientImgUrls.Add(img);
            db.SaveChanges();
            return Ok();
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("AddClientsInfo")]
        public ActionResult AddClientsInfo([FromBody] Client model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            db.Clients.Add(model);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet("getClientsInfo")]
        public ActionResult getClientsInfo()
        {
            var clients = db.Clients.ToList();
            return Ok(clients);
        }

        [HttpGet("getClientsImg")]
        public ActionResult getClientsImg()
        {
            var clients_img = db.ClientImgUrls.ToList();
            return Ok(clients_img);
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpDelete("deleteClientsInfo")]
        public ActionResult deleteClientsInfo(int id)
        {
            db.Clients.Remove(db.Clients.Find(id));
            db.SaveChanges();
            return Ok();
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpDelete("deleteClientsImg")]
        public ActionResult deleteClientsImg(int id)
        {
            db.ClientImgUrls.Remove(db.ClientImgUrls.Find(id));
            db.SaveChanges();
            return Ok();
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPut("updateClientsInfo")]
        public ActionResult updateClientsInfo(Client model)
        {
            var c = db.Clients.Find(model.Id);
            c.FacebookUrl = model.FacebookUrl;
            c.InstegramUrl = model.InstegramUrl;
            c.TwitterUrl = model.TwitterUrl;
            c.LinkedInUrl = model.LinkedInUrl;
            c.JobTitle = model.JobTitle;
            c.Name = model.Name;
            c.ImageUrl = model.ImageUrl;
            db.SaveChanges();
            return Ok();
        }


    }
}
