using NetCoreAPIs_Template.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Models
{
    public class TestRequest : RequestBase
    {
        [Required]
        [MinLength(10)]
        public string Test { get; set; }
        [Required]
        public string name { get; set; }
        public nested nes { get; set; }
    }

    public class nested
    {
        public int nesA { get; set; }
        public string nesB { get; set; }
    }
}
