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
        // static binding [early binding]
        // myFunction01() is static bounded method 
        // it is bounded at compile time
        // Compiler will bind function call based on reference type
        public new void MyFun01() // new version 
        {
            Console.WriteLine("i am derived class [child]");
        }
    
        // apply function overriding using override keyword
        // dynamic binding [Late binding]
        // myFunction02() is dynamic bounded method
        // it is bounded at runtime
        // CLR will bind function call based on object type
        // 
        public override void MyFun02() // override version
        {
            Console.WriteLine($"TypeB : A = {A}, B = {B}");
        }
    }
}
