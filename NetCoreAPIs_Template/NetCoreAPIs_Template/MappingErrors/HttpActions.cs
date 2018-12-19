using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.MappingErrors
{
    public static class HttpActions
    {
        public static IActionResult CustomResult(HttpStatusCode statuscode, object data)
        {
            return new HttpActionResult((int)statuscode, data);
        }
    }
}
