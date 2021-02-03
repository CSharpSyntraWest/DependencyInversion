using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class EmployeeBL
    {

        public IEmployeeDAL employeeDAL;
        public EmployeeBL(IEmployeeDAL employeeDAL)
        {
            this.employeeDAL = employeeDAL;
        }
        public List<Employee> GetAllEmployees()
        {
            return employeeDAL.SelectAllEmployees();
        }

    }
}
