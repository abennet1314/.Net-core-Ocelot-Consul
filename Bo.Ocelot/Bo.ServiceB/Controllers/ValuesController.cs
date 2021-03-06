﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Bo.ServiceB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        public IConfiguration Configuration { get; }

        public ValuesController(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        [HttpGet]
        public string Get()
        {
            return HttpContext.Request.Host.Port + " " + Configuration["AppName"] + " " + DateTime.Now.ToString();
        }
        [HttpGet("/health")]
        public IActionResult Heathle()
        {
            return Ok();
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
