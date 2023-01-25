using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class ARController : Controller
    {
        public IActionResult M3()
        {
            return View();
        }
        public IActionResult ReturnSpecifiedView()
        {
            return View("M Three");
        }
        public ActionResult ControllerPassDataToView(int id,string name)
        {
            ViewData["StuID"] = id;//store data in ViewData
            ViewData["StuName"]=name;

            ViewBag.StuID = id;//store data in Viewbag
            ViewBag.StuName = name;
            return View("Data");
        }
    }
}
