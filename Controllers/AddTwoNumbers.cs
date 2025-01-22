using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BesTAsControllerQuiz.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AddTwoNumbers : ControllerBase
    {
        [HttpGet]
        [Route("add/{num1}/{num2}")]
        public double Add(double num1, double num2){
            return num1 + num2;
        }
    }
}