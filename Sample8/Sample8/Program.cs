using System;

namespace Sample8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence");
            String s = Console.ReadLine();
            char[] arr = s.ToCharArray();
            String p = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if ((!p.Contains(arr[i])) || (Char.IsWhiteSpace(s[i])))
                {                
                        p += s[i];
                }                                  
                
            }           
            Console.WriteLine(p);
            Console.ReadLine();
        }
    }
}
