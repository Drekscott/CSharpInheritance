using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TechnicalEmployee techy = new TechnicalEmployee("Dreyton");
            Console.WriteLine(techy.employeeStatus());
            BusinessEmployee business = new BusinessEmployee("Sheila");
            Console.WriteLine(business.employeeStatus());
        }
    }
}
