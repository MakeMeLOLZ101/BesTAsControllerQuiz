using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BesTAsControllerQuiz.Models;

namespace BesTAsControllerQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloTwo : ControllerBase
    {
        [HttpGet]
        [Route("GetName")]
        public string SayHelloAgain(string idName)
        {
            return $"Heylo, {idName}";
        }
    }
}