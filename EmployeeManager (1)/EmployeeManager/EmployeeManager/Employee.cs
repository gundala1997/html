using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using EmployeeManager;

namespace EmployeeManager
{
    [TestFixture]
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double Salary { get; set; }
        public DateTime DOJ { get; set; }
    }
    [TestFixture]
    public class EmployeeManager
    {
        private static readonly List<Employee> employees;

        static EmployeeManager()
        {
            employees = new List<Employee>
            {
                new Employee { EmpId=100, EmpName="John",DOJ=DateTime.Now.AddYears(-5),Salary=30000},
                new Employee { EmpId=101, EmpName="Mary",DOJ=DateTime.Now.AddYears(-2),Salary=10000},
                new Employee { EmpId=102, EmpName="Steve",DOJ=DateTime.Now.AddYears(-2),Salary=10000},
                new Employee { EmpId=103, EmpName="Allen",DOJ=DateTime.Now.AddYears(-7),Salary=50000},
            };
        }
        [Test]
        [TestCaseSource(nameof(employees))]
        public void employee()
        {
            List<Employee> em = GetEmployees(employees);
            List<Employee> es = GetEmployeesWhoJoinedInPreviousYears();
            Assert.Equals(em, es);
        }
        [Test]
        public List<Employee> GetEmployees(List<Employee> employees)
        {
            Assert.IsNotNull(employees);
            Assert.That(employees, Is.Unique);
            return employees;
        }
        public List<Employee> GetEmployeesWhoJoinedInPreviousYears()
        {
            return employees.FindAll(x => x.DOJ< DateTime.Now);
        }
    }
}







