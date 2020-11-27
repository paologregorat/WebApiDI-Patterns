using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Security.Authentication;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestEFPostgres.Entities.BridgePattern;
using WebAPITest.Commands.Abstract;
using WebAPITest.Commands.Concrete;
using WebAPITest.Patterns.AdapterPattern;
using WebAPITest.Patterns.FactoryPattern;
using WebAPITest.Patterns.Prototype;

namespace WebAPITest.Controllers
{
    [ApiController, Route("api/test")]
    public class CommandsController : ControllerBase
    {
        private readonly IMyDependency _myDependency;
        private IActionResult InternalError => Problem(type: $"{HttpStatusCode.InternalServerError}");
        
        public CommandsController(IMyDependency myDependency)
        {
            _myDependency = myDependency;
        }
        
        [HttpPost("DependencyInjection-WriteLog")]
        public async Task<IActionResult> WriteLog()
        {
            _myDependency.WriteLog();
            return Ok();
           
        }

        [HttpPost("PrototypePattern-Clone")]
        public async Task<IActionResult> SetColor()
        {
            var colormanager = new WebAPITest.Patterns.Prototype.ColorManager();
            colormanager["red"] = new Color(255, 0, 0);
            
            var color1 = colormanager["red"].Clone() as WebAPITest.Patterns.Prototype.ColorPrototype;
            return Ok();
        }
        
        [HttpPost("BridgePattern-Client")]
        public async Task<IActionResult> Client()
        {
            var client = new Client();
            Abstraction abstraction;
            abstraction = new Abstraction(new ConcreteImplementationA());
            client.ClientCode(abstraction);
            Console.WriteLine();
            abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            client.ClientCode(abstraction);
            return Ok();
        }
        
        [HttpPost("FactoryPattern-CreatePages")]
        public async Task<IActionResult> Createpages()
        {
            var doc = new Resume();
            doc.CreatePages();
            return Ok();
        }

    }
}