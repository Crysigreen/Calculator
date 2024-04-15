using Microsoft.AspNetCore.Mvc;
using Сalculator.Services;

namespace Сalculator.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class calculator : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public calculator(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }
        
        [HttpGet("addition")]
        public IActionResult Addition(double x, double y)
        {
            return Ok(_calculatorService.Addition(x,y));
        }

        [HttpGet("subtraction")]
        public IActionResult Subtraction(double x, double y)
        {
            return Ok(_calculatorService.Subtraction(x,y));
        }

        [HttpGet("multiplication")]
        public IActionResult Multiplication(double x, double y)
        {
            return Ok(_calculatorService.Multiplication(x,y));
        }

        [HttpGet("divide")]
        public IActionResult Divide(double x, double y)
        {
            try
            {
                return Ok(_calculatorService.Divide(x,y));
            }
            catch (DivideByZeroException)
            {
                return BadRequest("Division by zero is not allowed");
            }
        }
    }
}
