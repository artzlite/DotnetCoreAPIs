using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreAPIs_Template.MappingErrors;
using NetCoreAPIs_Template.Models;
using NetCoreAPIs_Template.Process;
using Newtonsoft.Json;
using NLog;

namespace NetCoreAPIs_Template.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;
        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// TestController Get()
        /// </summary>
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(200, Type = typeof(TestResponse))]
        [ProducesResponseType(400, Type = typeof(TestResponse))]
        public IActionResult Get(string id)
        {
            #region mock
            TestRequest req = new TestRequest()
            {
                orderreftest = "orderref",
                id = 99,
                name = "nametset",
                nes = new nested()
                {
                    nesA = 55,
                    nesB = "nesTT"
                }

            };
            #endregion

            TestProcess t = new TestProcess(_logger);
            TestResponse resp = t.testss(req);
            return HttpActions.CustomResult(resp.OperationStatus.StatusCode, resp);
        }
    }
}