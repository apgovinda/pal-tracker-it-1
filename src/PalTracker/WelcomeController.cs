
 
using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController : ControllerBase
    {
        [HttpGet]
        public string SayHello()
        {
           //HttpRequest request =   HttpContext.Request;
           //return "the url you had hit is : " + request.Host.Value ;

           return "hello";
        }
    }
}
