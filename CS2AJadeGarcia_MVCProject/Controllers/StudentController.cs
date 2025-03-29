using CS2AJadeGarcia_MVCProject.BusLogic.Model;
using CS2AJadeGarcia_MVCProject.BusLogic.Service;
using Microsoft.AspNetCore.Mvc;

namespace CS2AJadeGarcia_MVCProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentService _studentService = new StudentService();
        public IActionResult Index()
        {
            var students = _studentService.GetAll();
            return View(students);
        }

        public IActionResult AddNewStudent()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddStudent(TblStudent student)
        {
            try
            {
                bool result = _studentService.Add(student);
                return Json(new { success = result, message = result ? "Student added successfully" : "Failed to add student" });
            }
            catch
            {
                return Json(new { success = false, message = "An error occured"});
            }
        }
    }
}
