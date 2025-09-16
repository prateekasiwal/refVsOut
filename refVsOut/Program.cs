using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int add= 0;
            ////int multi= 0;

            //MyMethodRef(10, 20, ref  add, ref  multi);
            //Console.WriteLine($"Ref Add : {add}");
            //Console.WriteLine($"Ref Multi : {multi}");

            MyMethodOut(10, 20, out int add, out int multi);
            Console.WriteLine($"Out Add : {add}");
            Console.WriteLine($"Out Multi : {multi}");
        }

        public static void MyMethodRef(int num1, int num2, ref int add, ref int multi)
        {
            add = num1 + num2;
            //multi = num1 * num2;
        }

        public static void MyMethodOut(int num1, int num2, out int add, out int multi)
        {
            add = num1 + num2;
            //multi = num1 * num2;
        }

    }
}