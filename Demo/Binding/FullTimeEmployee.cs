﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public FullTimeEmployee(int id, string name, int age, decimal salary):base(id, name, age)
        {
            Salary = salary;
        }

        public new void GetEmployeeType()
        {
            Console.WriteLine("Full Time Employee");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"Id = {Id}, Name = {Name}, Age = {Age}, Salary = {Salary:C}");
        }

    }
}
