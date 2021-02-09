using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion
{
    public class Factory
    {
        public static IEmployeeDAL GetObjectOfEmployeeDAL()
        {
            return new EmployeeDAL();
        }
    }
}
