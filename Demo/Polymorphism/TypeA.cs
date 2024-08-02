using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism
{
    public class TypeA
    {
        public int A { get; set; }
        // automatic property 
        // compiler will generate hidden private field called backing field

        public TypeA (int a)
        {
            A = a;
        }

        public void MyFun01()
        {
            Console.WriteLine("i am base class [parent]");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"TypeA : A = {A}");
        }
    }
}
