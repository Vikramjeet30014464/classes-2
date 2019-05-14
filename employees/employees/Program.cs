using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employees
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******task2********");
            Console.WriteLine("Enter your details below...");
            Console.Write("First Name: ");
            string fname = Console.ReadLine();
            Console.Write("Last Name: ");
            string lname = Console.ReadLine();
            Console.Write("Tax Rate: ");
            double tax = double.Parse(Console.ReadLine());
            Console.Write("Gross Income: ");
            double gross = double.Parse(Console.ReadLine());

            Employee E1 = new Employee(fname, lname, gross, tax);
            Console.WriteLine($"Net Salary: ${Math.Round(E1.NetSalary(), 2)}");
            Console.ReadLine();
        }
        class Employee
        {//attributes
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Gross { get; set; }
            public double Tax { get; set; } = 0.15;

            //method
            public double NetSalary()
            {
                return Gross * (1 - Tax);
            }

            //Constructor
            public Employee(string fname, string lname, double _gross, double _tax)
            {
                FirstName = fname;
                LastName = lname;
                Gross = _gross;
                Tax = _tax;
            }

            public Employee()
            {

            }

        }
    }
}
