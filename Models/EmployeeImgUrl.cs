using System;
using System.Collections.Generic;

#nullable disable

namespace Core_NewSolutions.Models
{
    public partial class EmployeeImgUrl
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int? IdNavigation { get; set; }
    }
}
