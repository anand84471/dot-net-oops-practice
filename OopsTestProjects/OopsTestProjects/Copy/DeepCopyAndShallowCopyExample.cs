using System;
using System.Collections.Generic;
using System.Text;

namespace OopsTestProjects.Copy
{
    public class DeepCopyAndShallowCopyExample
    {
        //Test
        //static void Main(string[] args)
        //{
        //    EmployeDetails e1 = new EmployeDetails();
        //    e1.Salary = 100;
        //    e1.employee = new Employee();
        //    e1.employee.Name = "Anand";
        //    EmployeDetails e2 = (EmployeDetails)e1.DeepCopy(); //deep copy
        //    EmployeDetails e3 = (EmployeDetails)e1.Shallowcopy(); ///shallow copy
        //    e1.employee.Name = "Ajay";
        //    Console.WriteLine(e2.employee.Name); //Anand
        //    Console.WriteLine(e3.employee.Name); //Ajay
        //    e3.employee.Name = "Vivek";
        //    Console.WriteLine(e1.employee.Name); //Vivek
        //}
    }
    public class EmployeDetails
    {
        public double Salary;
        public Employee employee;
        // method for cloning object
        public object Shallowcopy()
        {
            return this.MemberwiseClone();
        }

        // method for cloning object
        public EmployeDetails DeepCopy()
        {
            EmployeDetails deepcopyCompany = new EmployeDetails();
            deepcopyCompany.Salary = this.Salary;
            deepcopyCompany.employee = new Employee();
            deepcopyCompany.employee.Name = this.employee.Name;
            return deepcopyCompany;
        }
    }
    public class Employee
    {
        public string Name { get; set; }
    }
}
