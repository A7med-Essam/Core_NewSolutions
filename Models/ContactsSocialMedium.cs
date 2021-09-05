using System;
using System.Collections.Generic;

#nullable disable

namespace Core_NewSolutions.Models
{
    public partial class ContactsSocialMedium
    {
        public int Id { get; set; }
        public string TwitterUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string InstegramUrl { get; set; }
    }
}
