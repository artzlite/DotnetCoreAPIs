using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreAPIs_Template.AppSettings;
using NetCoreAPIs_Template.AppSettings.Mapping;
using NetCoreAPIs_Template.Entities;
using NetCoreAPIs_Template.Utilities.MongoDB;
using Newtonsoft.Json;

namespace NetCoreAPIs_Template.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //// GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    string json = JsonConvert.SerializeObject(Settings.MongoDB);
        //    return Settings.MongoDB;
        //    //return new string[] { "value1", "value2" };
        //}

        // GET api/values
        [HttpGet]
        public ActionResult<MongoDBMapping> Get()
        {
            //MongoDBUtil._Things.Add();
            string json = JsonConvert.SerializeObject(SettingsHelper.MongoDB);

            things t = MongoDBUtil._Things.FindOne(new MongoDB.Bson.ObjectId("34545fc3fb4d09423a4ae899"));

            return SettingsHelper.MongoDB;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
