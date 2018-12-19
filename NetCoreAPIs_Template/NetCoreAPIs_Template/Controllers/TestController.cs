using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreAPIs_Template.MappingErrors;
using NetCoreAPIs_Template.Models;

namespace NetCoreAPIs_Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            TestResponse resp = new TestResponse()
            {
                OperationStatus = new Base.OperationStatus()
                {
                    Code = "201",
                    Description = "DESCccccc",
                    IsSuccess = true,
                    OrderRef = "asdfg13456",
                    StatusCode = System.Net.HttpStatusCode.Created
                }
            };
            resp.dict = new Dictionary<string, int>();
            resp.dict.Add("a", 1);
            resp.dict.Add("b", 2);
            resp.dict.Add("c", 3);

            return HttpActions.CustomResult(resp.OperationStatus.StatusCode, resp);
        }
    }
}