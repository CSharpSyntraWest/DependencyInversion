using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public interface IEmployeeDAL
    {
        List<Employee> SelectAllEmployees();
    }
    public class EmployeeDAL: IEmployeeDAL
    {
        public List<Employee> SelectAllEmployees()
        {
            List<Employee> ListEmployees = new List<Employee>();
            //Get the Employees from the Database
            //for now we are hard coded the employees
            ListEmployees.Add(new Employee() { ID = 1, Name = "Jos", Department = "IT" });
            ListEmployees.Add(new Employee() { ID = 2, Name = "Jan", Department = "HR" });
            ListEmployees.Add(new Employee() { ID = 3, Name = "Piet", Department = "Boekhouding" });
            return ListEmployees;
        }
    }
}
