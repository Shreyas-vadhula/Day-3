using System;

namespace Sample7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            String s = Console.ReadLine();
            char[] arr;
            arr = s.ToCharArray();
            for(int i=0; i<arr.Length;i++)
            {
                if (Char.IsLower(arr[i]))
                {
                    Console.Write(Char.ToUpper(arr[i]));
                }
                else
                {
                    Console.Write(Char.ToLower(arr[i]));
                }                               
            }
            Console.ReadLine();
        }
    }
}
