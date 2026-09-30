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

        //This the get request that allows the user to enter info*
        public IActionResult Create() { 
            
            return View();
        
        }

        [HttpPost]
        public IActionResult Create(Employee employee) 
        {
            if (!ModelState.IsValid) 
            { 
                return View(employee); 
            }


            // This code can me used to display the post values on screen
            return Content($"Name: {employee.FirstName} {employee.LastName}, Age: {employee.Age}");
           
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