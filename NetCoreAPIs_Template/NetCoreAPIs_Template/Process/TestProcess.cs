using Microsoft.Extensions.Logging;
using NetCoreAPIs_Template.Base;
using NetCoreAPIs_Template.MappingErrors;
using NetCoreAPIs_Template.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Process
{
    public class TestProcess
    {
        private readonly ILogger _logger;
        private StringBuilder sb;
        public TestProcess(ILogger logger)
        {
            _logger = logger;
            sb = new StringBuilder();
        }

        public TestResponse testss(TestRequest req)
        {
            //sb.AppendLine($"Request data : {ii}");
            TestResponse resp = new TestResponse();
            try
            {
                resp.OperationStatus = new OperationStatus()
                {
                    Code = "201",
                    Description = "DESCccccc",
                    IsSuccess = true,
                    OrderRef = "asdfg13456",
                    StatusCode = System.Net.HttpStatusCode.Created
                };
                resp.dict = new Dictionary<string, int>();
                resp.dict.Add("a", 1);
                resp.dict.Add("b", 2);
                resp.dict.Add("c", 3);
                sb.AppendLine("Do something...");
                sb.AppendLine($"Response data : {JsonConvert.SerializeObject(resp)}");

                string[] ii = new string[3];
                ii[0] = "ser";
                ii[4] = "error";
            }
            catch (Exception ex)
            {
                //_logger.LogError(LoggingEvents.GetItem, ex, sb.ToString());
                _logger.LogError(LoggingEvents.GetItem, ex, LoggingMessages.getFormat, req, resp);
            }
            finally
            {
                //_logger.LogInformation(LoggingEvents.GetItem, sb.ToString());
                _logger.LogInformation(LoggingEvents.GetItem, LoggingMessages.getFormat, req, resp);
            }
            return resp;
        }
    }
}
