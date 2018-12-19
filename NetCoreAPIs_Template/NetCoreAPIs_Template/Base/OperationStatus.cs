using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace NetCoreAPIs_Template.Base
{
    public class OperationStatus
    {
        public OperationStatus()
        {
            IsSuccess = false;
            OrderRef = Description = "";
        }
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public bool IsSuccess { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string OrderRef { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Code { get; set; }

        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Include)]
        public string Description { get; set; }

        [IgnoreDataMember]
        public HttpStatusCode StatusCode { get; set; }
        [IgnoreDataMember]
        public String ExceptionMessage { get; set; }
    }
}
