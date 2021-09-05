using System;
using System.Collections.Generic;

#nullable disable

namespace Core_NewSolutions.Models
{
    public partial class UploadProject
    {
        public int Id { get; set; }
        public string SmallTitle { get; set; }
        public string BigTitle { get; set; }
        public string Category { get; set; }
        public string ImageUrl { get; set; }
        public string details { get; set; }
        public DateTime date { get; set; }
    }
}
