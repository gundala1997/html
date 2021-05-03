using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDEMPLOYEESMOQ
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    public class EmployoeeManger
    {
        private readonly List<Employee> employees;
        public int HeadCount { get; set; }



        public EmployoeeManger()
        {
            employees = new List<Employee>();
            HeadCount = employees.Count();
        }
        public void AddEmployee(Employee empObj)
        {
            employees.Add(empObj);
            HeadCount++;
        }
    }
}
    

