using Demo.Polymorphism;
using System.Security.Cryptography.X509Certificates;

namespace Demo
{
    internal class Program
    {
        #region Polymorhism (Overloading)
        // Method Overloading

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static double Sum(double a, double b)
        {
            return (a + b);
        }

        public static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        public static double Sum(double a, double b, double c)
        {
            return a + b + c;
        }

        public static double Sum(double a, int b)
        {
            return a + b;
        }

        public static double Sum(int a, double b)
        {
            return a + b;
        }

        //public static double Sum(int b, double a) invalid because the signature already exists
        //            {
        //    return a + b;
        //}


        #endregion

        static void Main(string[] args)
        {
            #region Polymorhism (Overloading)

            int result1 = Sum(10, 20);
            Console.WriteLine(result1);
            int result2 = Sum(10, 20, 30);




            #endregion

            #region Polymorhism (Overriding)
            // supported within classes only
            // function overriding must be with relationship inheritance
            // function overriding must be with virtual keyword in the base class
            // function overriding must be with override keyword in the derived class

            TypeA typeA = new TypeA(10);
            typeA.A = 100;
            typeA.MyFun01();
            typeA.MyFun02();

            TypeB typeB = new TypeB(10, 20);
            typeB.A = 100;
            typeB.B = 200;
            typeB.MyFun01();
            typeB.MyFun02();
            #endregion


        }
    }
}
