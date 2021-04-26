using System;

namespace Sample1
{
    class Program
    {
        void sum(double a, double b)
        {
            Console.WriteLine("The sum of the entered integers is :" + (a + b));
        }
        void sum(int a, int b)
        {
            Console.WriteLine("The sum of the entered integers is :" + (a + b));
        }
        static void Main(string[] args)
        {
            Program class1 = new Program();
            class1.sum(2.3, 3.5);
            class1.sum(2, 5);
            Console.ReadLine();
        }
    }
}
