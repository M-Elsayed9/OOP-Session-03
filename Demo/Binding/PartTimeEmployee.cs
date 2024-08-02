using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Binding
{
    internal class PartTimeEmployee : Employee
    {
        public int CountOfHours { get; set; }
        public decimal HourRate { get; set; }

        public new void GetEmployeeType()
        {
            Console.WriteLine("Part Time Employee");
        }

        public override void GetEmployeeData()
        {
            Console.WriteLine($"Id = {Id}, Name = {Name}, Age = {Age}, Count of Hours = {CountOfHours}, Hour Rate = {HourRate:C}");
        }

        
    }
}
