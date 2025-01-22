using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BesTAsControllerQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHello : ControllerBase
    {
        [HttpGet]
        [Route("name")]
        public string SayHi(string name){
            if (string.IsNullOrEmpty(name)){
                return "Please provide a name and not a number";
            }

            return $"Hallo, {name}!";
        }
    }
}