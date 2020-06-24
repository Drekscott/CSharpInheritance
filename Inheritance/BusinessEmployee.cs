using System;
namespace Inheritance
{
    public class BusinessEmployee : Employee
    {
        public BusinessEmployee(string name) : base(name, 50000)
        {
        }
        public override string employeeStatus()
        {
            Random random = new Random();
            return $"{this.getEmployeeID()}: {this._name} has a budge of {random.Next(1, 22500)}";
        }
    }
}
