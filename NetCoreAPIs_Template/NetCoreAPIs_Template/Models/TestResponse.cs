using NetCoreAPIs_Template.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Models
{
    public class TestResponse : ResponseBase
    {
        public Dictionary<string,int> dict { get; set; }
    }
}
