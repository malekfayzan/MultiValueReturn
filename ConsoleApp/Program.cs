using System;

namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter The Number....");
            int a = Convert.ToInt32(Console.ReadLine()),
                b = Convert.ToInt32(Console.ReadLine()),
                addition = 0, 
                multiplication = 0;


            //Reference Method
            ArithmaticRef(a, b, ref addition, ref multiplication);

            Console.WriteLine("This Is Value Of Arethmetic for addition: {0},and for multiplication: {1} Reference Value ", addition, multiplication);



            //Out Method

            ArithmaticOut(a, b, out addition, out multiplication);
            Console.WriteLine("This Is Value Of Arethmetic for addition : {0},and for multiplication: {1} Out Value ", addition, multiplication);
           
            //Tuple Method
            Console.WriteLine("Tuple Value Is Here....");

           Console.WriteLine(ArithmeticTuple(a , b));

            Console.WriteLine("Your Program Has Been SuccessFullly Updated......");
            Console.ReadLine();
        }
        public static void ArithmaticRef(int a, int b, ref int addition, ref int multiplication)
        {
            addition = a + b;
            multiplication = a * b;

        }
        public static void ArithmaticOut(int a, int b, out int addition,out int multiplication)
        {
            addition = a + b;
            multiplication =  a * b;
        }
        public static Tuple<int,int> ArithmeticTuple(int a, int b)
        {

            return Tuple.Create(a + b, a * b);
        }
    }
}

