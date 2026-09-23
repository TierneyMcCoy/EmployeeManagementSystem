using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Cache;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeRepository
    {
        public Employee GetEmployee() {

            Employee employee = new Employee
            {

                FirstName = "Test",
                LastName = "Test",
                Age = 31

        };

            return employee;


        }

    }
}


/*
 * This is depraciated code used to create an Employee object it was replaced with code that
 * uses object ijnitalizer
 
 * employee = new Employee();

   employee.FirstName = "Test Name";
   employee.LastName = "Test Last";
   employee.Age = 30;


return employee;
*/