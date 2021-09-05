using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Core_NewSolutions.Models
{
    public partial class Blogs
    {
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Comment { get; set; }
        [Required]
        public int BlogId { get; set; }
        public DateTime date { get; set; }
    }
}
