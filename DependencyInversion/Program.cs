using System;
using System.Collections.Generic;

namespace DependencyInversion
{
    class InjectorClass
    {
        static void Main(string[] args)
        {
            IEmployeeDAL empDal = Factory.GetObjectOfEmployeeDAL();
            EmployeeBL employeeBL = new EmployeeBL(empDal);
            List<Employee> ListEmployee = employeeBL.GetAllEmployees();
            foreach (Employee emp in ListEmployee)
            {
                Console.WriteLine("ID = {0}, Naam = {1}, Afdeling = {2}", emp.ID, emp.Name, emp.Department);
            }
            Console.ReadKey();
        }
    }
}
