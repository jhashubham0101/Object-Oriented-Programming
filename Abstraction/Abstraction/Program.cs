// See https://aka.ms/new-console-template for more information
using System;
namespace Abstraction
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay; 
        double TaxDeduction = 0.1;
        double netSalary;

        public Employee(int Eid, string Ename, double Egrosspay)
        {
            this.EmpId = Eid;
            this.EmpName = Ename;
            this.GrossPay = Egrosspay;
        }

        void CalculateSalary()
        {
            if (GrossPay >= 30000)
            {
                netSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("Your Salary is: {0}", netSalary);
            }
            else
            {
                Console.WriteLine("Your Salary is: {0}", GrossPay);
            }
        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee Id is: {0}", this.EmpId);
            Console.WriteLine("Employee Name is: {0}", this.EmpName);
            this.CalculateSalary();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee a= new Employee(101, " Shubham Kumar Jha", 25000);
            a.ShowEmployeeDetails();
            Console.ReadLine();
        }
    }
}