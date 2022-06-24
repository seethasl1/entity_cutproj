using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace entity_cutproj.Models
{
    public class customer
    {
        [Required]
        [Key]
        public string custcode { get; set; }
        public string custname { get; set; }
    }
}