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
    public class Projects : ControllerBase
    {
        private readonly IphotoServices _photoService;
        private readonly NewSolutionsContext db;

        public Projects(IphotoServices photoService, NewSolutionsContext db)
        {
            _photoService = photoService;
            this.db = db;
        }

        [HttpGet("ProjectsSection1")]
        public ActionResult GetSection1()
        {
            return Ok(db.ProjectsSection1s.ToList().OrderByDescending(m => m.Id).Take(1));
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("ProjectsSection1")]
        public ActionResult Post([FromBody] ProjectsSection1 value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            db.ProjectsSection1s.Add(value);
            db.SaveChanges();
            return Ok();
        }


        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("AddProjectImg")]
        public async Task<ActionResult> AddProjectImg([FromForm] IFormFile File)
        {
            var result = await _photoService.AddPhotoAsync(File);

            if (result.Error != null)
            {
                return BadRequest(result.Error.Message);
            }

            var img = new ProjectImgUrl()
            {
                Url = result.SecureUrl.AbsoluteUri
            };

            db.ProjectImgUrls.Add(img);
            db.SaveChanges();
            return Ok();
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("AddProjectInfo")]
        public ActionResult AddProjectInfo([FromBody] UploadProject model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            db.UploadProjects.Add(model);
            model.date = DateTime.Now;
            db.SaveChanges();
            return Ok();
        }

        [HttpGet("getProjectsInfo")]
        public ActionResult getProjectsInfo()
        {
            var project = db.UploadProjects.ToList();
            return Ok(project);
        }

        [HttpGet("getProjectsInfoById")]
        public ActionResult getProjectsInfoById([FromQuery] int id)
        {
            var project = db.UploadProjects.Find(id);
            return Ok(project);
        }

        [HttpGet("getProjectsImg")]
        public ActionResult getProjectsImg()
        {
            var project_img = db.ProjectImgUrls.ToList();
            return Ok(project_img);
        }

        [HttpGet("getProjectsImgById")]
        public ActionResult getProjectsImgById(int id)
        {
            var project_img = db.ProjectImgUrls.Find(id);
            return Ok(project_img);
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpDelete("deleteProjectInfo")]
        public ActionResult deleteProjectInfo(int id)
        {
            db.UploadProjects.Remove(db.UploadProjects.Find(id));
            db.SaveChanges();
            return Ok();
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpDelete("deleteProjectImg")]
        public ActionResult deleteProjectImg(int id)
        {
            db.ProjectImgUrls.Remove(db.ProjectImgUrls.Find(id));
            db.SaveChanges();
            return Ok();
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPut("updateProjectInfo")]
        public ActionResult updateProjectInfo(UploadProject model)
        {
            var project = db.UploadProjects.Find(model.Id);
            project.SmallTitle = model.SmallTitle;
            project.BigTitle = model.BigTitle;
            project.Category = model.Category;
            project.ImageUrl = model.ImageUrl;
            project.details = model.details;
            db.SaveChanges();
            return Ok();
        }

    }
}
