namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public int     Age { get; set; }



        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

    }
}
