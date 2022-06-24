using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using entity_cutproj.Models;

namespace entity_cutproj.ViewModel
{
    public class custViewModel
    {
      public customer customerobj { get; set; }
        public List<customer> customers { get;set; }
    }
}