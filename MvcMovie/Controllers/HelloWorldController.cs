using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "This is my default action....";
        }


        public string Welcome()
        {
            return "This is the welcome action method.....";
        }
        public string Introduction (int ID,string Name)
        {
            return "I'm Mr. " + Name + " .My ID is " + ID;
        }
        /*
         * https://localhost:7100/helloworld/introduction?id=99&name=veng
        */
    }
}
