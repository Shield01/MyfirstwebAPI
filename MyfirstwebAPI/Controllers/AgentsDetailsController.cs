using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyfirstwebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyfirstwebAPI.Controllers
{
    [Route("api/[controller]")]
    public class AgentsDetailsController : Controller
    {
        public AgentsDetailsController()
            {

            }
        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            List<AgentsDetails> agentsDetails = new List<AgentsDetails>();

            agentsDetails.Add(new AgentsDetails
            {
                Id = 1, Username = "King",
                Age = 19,
                EmailAddress = "husseintijsni2017@gmsil.com",
                FullName = "Tijani Hussein",
                Gender = 'M',
                PhoneNumber = 08034567876
            });

            return Ok (agentsDetails);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
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
