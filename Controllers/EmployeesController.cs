
using EmployeeManagementSystem.Models;
using EmployeeManagementSystem.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly EmployeeRepository _repository;

        public EmployeesController(EmployeeRepository repository)
        {
            _repository = repository;
        }

        // READ: Display employees from the database
        public async Task<IActionResult> Index()
        {
            var employees = await _repository.GetAllEmployeesAsync();
            return View(employees);
        }

        // GET: Display the empty form
        public IActionResult Create()
        {
            return View();
        }

        // POST: Save the submitted employee
        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return View(employee);
            }

            await _repository.AddEmployeeAsync(employee);

            return RedirectToAction(nameof(Index));
        }


        // GET: Display the Edit form
        public async Task<IActionResult> Edit(int id)
        {
            var employee = await _repository.GetEmployeeByIdAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Save the edited employee
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(employee);
            }

            await _repository.UpdateEmployeeAsync(employee);

            return RedirectToAction(nameof(Index));
        }


        // GET: Show the employee before deleting
        public async Task<IActionResult> Delete(int id)
        {
            var employee = await _repository.GetEmployeeByIdAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Confirm and perform deletion
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _repository.DeleteEmployeeAsync(id);

            return RedirectToAction(nameof(Index));
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