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
    public class OurEmployees : ControllerBase
    {
        private readonly IphotoServices _photoService;
        private readonly NewSolutionsContext db;

        public OurEmployees(IphotoServices photoService, NewSolutionsContext db)
        {
            _photoService = photoService;
            this.db = db;
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("AddEmployeesImg")]
        public async Task<ActionResult> AddEmployeesImg([FromForm] IFormFile File)
        {
            var result = await _photoService.AddPhotoAsync(File);

            if (result.Error != null)
            {
                return BadRequest(result.Error.Message);
            }

            var img = new EmployeeImgUrl()
            {
                Url = result.SecureUrl.AbsoluteUri
            };

            db.EmployeeImgUrls.Add(img);
            db.SaveChanges();
            return Ok();
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPost("AddEmployeesInfo")]
        public ActionResult AddEmployeesInfo([FromBody] Employee model)
        {
            if (model == null)
            {
                return BadRequest();
            }
            db.Employees.Add(model);
            db.SaveChanges();
            return Ok();
        }

        [HttpGet("getEmployeesInfo")]
        public ActionResult getEmployeesInfo()
        {
            var Employee = db.Employees.ToList();
            return Ok(Employee);
        }

        [HttpGet("getEmployeesImg")]
        public ActionResult getEmployeesImg()
        {
            var Employees_img = db.EmployeeImgUrls.ToList();
            return Ok(Employees_img);
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpDelete("deleteEmployeesInfo")]
        public ActionResult deleteEmployeesInfo(int id)
        {
            db.Employees.Remove(db.Employees.Find(id));
            db.SaveChanges();
            return Ok();
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpDelete("deleteEmployeesImg")]
        public ActionResult deleteEmployeesImg(int id)
        {
            db.EmployeeImgUrls.Remove(db.EmployeeImgUrls.Find(id));
            db.SaveChanges();
            return Ok();
        }

        [Authorize(Roles = "Admin,SuperAdmin")]
        [HttpPut("updateEmployeesInfo")]
        public ActionResult updateEmployeesInfo(Employee model)
        {
            var e = db.Employees.Find(model.Id);
            e.FacebookUrl = model.FacebookUrl;
            e.InstegramUrl = model.InstegramUrl;
            e.TwitterUrl = model.TwitterUrl;
            e.LinkedInUrl = model.LinkedInUrl;
            e.JobTitle = model.JobTitle;
            e.Name = model.Name;
            e.ImageUrl = model.ImageUrl;
            db.SaveChanges();
            return Ok();
        }
    }
}
