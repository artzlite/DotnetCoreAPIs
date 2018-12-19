using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.MappingErrors
{
    public class HttpActionResult : IActionResult
    {

        private readonly int _statuscode;
        private readonly object _data;

        public HttpActionResult(int statuscode, object data)
        {
            _statuscode = statuscode;
            _data = data;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var objectResult = new ObjectResult(_data)
            {
                StatusCode = _statuscode
            };

            await objectResult.ExecuteResultAsync(context);
        }
    }
}
