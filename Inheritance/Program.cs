using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee employee1 = new Employee("Dreyton", 100000);
            Console.WriteLine(employee1.employeeStatus());
            Employee employee2 = new Employee("Other", 100000);
            Console.WriteLine(employee2.employeeStatus());
            Console.WriteLine(employee1.getBaseSalary());
            TechnicalEmployee techy = new TechnicalEmployee("Dreyton");
            Console.WriteLine(techy.employeeStatus());
            BusinessEmployee business = new BusinessEmployee("Sheila");
            Console.WriteLine(business.employeeStatus());
        }
    }
}
