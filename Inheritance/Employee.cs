using System;
namespace Inheritance
{
    public class Employee
    {
        private double      _baseSalary     = 0;
        public string      _name           = "";
        private int         _employeeID;
        private static int  counter;


        public Employee(string name, double baseSalary)
        {
            this._name          = name;
            this._baseSalary    = baseSalary;
            this._employeeID    = ++counter;
        }

        public Double getBaseSalary()
        {
            return this._baseSalary;
        }

        public String getName()
        {
            return this._name;
        }

        public Int32 getEmployeeID()
        {
            return this._employeeID;
        }

        public String toString()
        {
            return $"{this._employeeID}: {this._name}";
        }

        public virtual String employeeStatus()
        {
            return $"{this._employeeID}: {this._name} is in the company's system";
        }
    }
}
