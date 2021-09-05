using Core_NewSolutions.Models;
using Core_NewSolutions.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core_NewSolutions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Blog : ControllerBase
    {
        private readonly NewSolutionsContext db;

        public Blog (NewSolutionsContext db)
        {
            this.db = db;
        }

        [HttpGet("getReviews")]
        public ActionResult getReviews([FromQuery] PagingParameter_VM pagingparametermodel)
        {
            var reviews = db.Blogs.Where(x => x.BlogId == pagingparametermodel.id).ToList();
            int count = reviews.Count();
            int CurrentPage = pagingparametermodel.pageNumber;
            int PageSize = pagingparametermodel.pageSize;
            int TotalCount = count;
            int TotalPages = (int)Math.Ceiling(count / (double)PageSize);
            var items = reviews.Skip((CurrentPage - 1) * PageSize).Take(PageSize).ToList();
            var previousPage = CurrentPage > 1 ? "Yes" : "No";
            var nextPage = CurrentPage < TotalPages ? "Yes" : "No";
            var paginationMetadata = new
            {
                data = items,
                totalCount = TotalCount,
                pageSize = PageSize,
                currentPage = CurrentPage,
                totalPages = TotalPages,
                previousPage,
                nextPage
            };
            //HttpContext.Response.Headers.Add("Paging-Headers", JsonConvert.SerializeObject(paginationMetadata));

            return Ok(paginationMetadata);
        }

        [HttpPost("AddReview")]
        public ActionResult AddReview([FromBody] Blogs value)
        {
            if (value == null)
            {
                return BadRequest();
            }

            value.date = DateTime.Now;
            db.Blogs.Add(value);
            db.SaveChanges();
            return Ok();
        }
    }
}
