using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeesController : Controller
    {

        private readonly EmployeeRepository _repository;

        public EmployeesController(EmployeeRepository repository) {

            _repository = repository;


        }

        public IActionResult Index()
        {
           //
           //Depriacted code 
           //EmployeeRepository repository = new EmployeeRepository();


            Employee employee = _repository.GetEmployee();

            return View(employee);
        }


    }
}


/*
 
 This code that was depreciated after the resposiory took over the process of creating and assigning 
the Employee object:

 Employee employee = new Employee();

            employee.FirstName = "Tom";
            employee.LastName = "Welling";

            string FullName = employee.GetFullName();

            return View(employee);

            // return Content(FullName);
 
 */