using System;
using System.Linq;

namespace Sample6
{
    class Program
    { 

      public static void Main(string[] args)
      {
        string s = "It is a bad color";    
        if (s.Contains("is a"))
            {
                Console.WriteLine("Yes its there in string");
            }
            else
            {
                Console.WriteLine("No its not there in string");
            }
            Console.ReadLine();
      }
    }
}
