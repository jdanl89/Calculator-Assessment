using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public IActionResult Add(double a, double b)
        {
            //This header is only added so that the api can be called from the simple ui
            //It is not secure, and the api works without it
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Ok(Math.Round((a + b), 8));
        }

        [HttpGet("subtract")]
        public IActionResult Subtract(double a, double b)
        {
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Ok(Math.Round((a - b), 8));
        }

        [HttpGet("multiply")]
        public IActionResult Multiply(double a, double b)
        {
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Ok(Math.Round((a * b), 8));
        }

        [HttpGet("divide")]
        public IActionResult Divide(double a, double b)
        {
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            if (b == 0)
            {
                
                return BadRequest("Cannot divide by zero");
            }
            return Ok(Math.Round((a / b), 8));
        }
    }
}
