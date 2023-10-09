using Microsoft.AspNetCore.Mvc;

namespace OOPTask3007Web.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View("NewStudents");
        }

        public IActionResult SaveData()
        {
            // code save in Db

            return View("NewStudents");
        }
    }
}
