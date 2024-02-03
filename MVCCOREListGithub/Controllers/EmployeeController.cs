using Microsoft.AspNetCore.Mvc;
using MVCCOREListGithub.Models;

namespace MVCCOREListGithub.Controllers
{
    public class EmployeeController : Controller
    {
        //[ActionName("Tarun")]
        public IActionResult GetEmployeeDetails()
        {
            List<Employee> employees = new List<Employee>()
            {
            new Employee()
            {
                Id = 1,
                Name = "Tarun",
                Email = "tarunkumar@gmail.com"
            },
            new Employee()
            {
                Id = 2,
                Name = "Satish",
                Email = "satish109@gmail.com"
            }, new Employee()
            {
                Id = 3,
                Name = "Sathwik",
                Email = "sathwik@gmail.com"
            },
            new Employee()
            {
                Id = 4,
                Name = "Sivakumar",
                Email = "sivakumar@gmail.com"
            }
            };
            return View(employees);
        }
    }
}
