using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AppLayer.Controllers
{
    [Controller]
    [Route("home")]
    public class HomeController : Controller
    {
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            Console.WriteLine(id);
            return "value";
        }
        // index/1/2
        [HttpGet("index/{a}/{b}")]
        public string Get(int a, int b)
        {
            Console.WriteLine("here: "+ a + " " + b);
            int res = (a + b);
            return res.ToString();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string data)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put( int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

