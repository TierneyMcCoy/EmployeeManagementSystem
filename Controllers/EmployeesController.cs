using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            Employee employee = new Employee();

            employee.FirstName = "Tom";
            employee.LastName = "Welling";

            string FullName = employee.GetFullName();

            return View(employee);

            // return Content(FullName);

        }


    }
}
