using NetCoreAPIs_Template.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Models.Auth
{
    public class SignInResponse : ResponseBase
    {
        public string username { get; set; }
        public string name { get; set; }
        public string token { get; set; }
    }
}
