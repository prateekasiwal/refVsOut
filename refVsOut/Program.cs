using refVsOut;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---------- Ref and Out Example -----------------
            //int add = 0;
            //int multi = 0;

            //MyMethodRef(10, 20, ref add, ref multi);
            //Console.WriteLine($"Ref Add : {add}");
            //Console.WriteLine($"Ref Multi : {multi}");

            //MyMethodOut(10, 20, out int add, out int multi);
            //Console.WriteLine($"Out Add : {add}");
            //Console.WriteLine($"Out Multi : {multi}");

            //---------- Dependency Injection Example -----------------
            //MainService mainService = new(new MyService());
            // mainService.Run("Parteek");


            //---------- Polymorphism OverRidding : Virtual and Override Example -----------------
            ParentClass parentClass = new ParentClass();
            parentClass.Add(10, 20);
            BaseClass baseClass = new BaseClass();
            baseClass.Add(10, 20);

            BaseClass baseClass1 = new ParentClass();
            baseClass1.Add(10, 20); //Parent class with virtual and override

            //---------- Polymorphism Overloading ------------------
            int var1 = dosomething(1, 2);
            Console.WriteLine($"With two  parmater {var1}");
            int var2 = dosomething(1, 2, 3);
            Console.WriteLine($"With three  parmater {var2}");
        }

        public static void MyMethodRef(int num1, int num2, ref int add, ref int multi)
        {
            add = num1 + num2;
            multi = num1 * num2;
        }

        public static void MyMethodOut(int num1, int num2, out int add, out int multi)
        {
            add = num1 + num2;
            multi = num1 * num2;
        }

        public static int dosomething(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int dosomething(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }


    }
}