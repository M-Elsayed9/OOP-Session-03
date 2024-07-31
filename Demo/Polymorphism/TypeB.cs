using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Polymorphism
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int a, int b)
            : base(a)
        {
            B = b;
        }

        // overriding
        // 1. using new keyword
        // 2. using override keyword

        //apply function overriding using new keyword

        public new void MyFun01() // new version 
        {
            Console.WriteLine("i am derived class [child]");
        }
    
        // apply function overriding using override keyword

        public override void MyFun02() // override version
        {
            Console.WriteLine($"TypeB : A = {A}, B = {B}");
        }
    }
}
