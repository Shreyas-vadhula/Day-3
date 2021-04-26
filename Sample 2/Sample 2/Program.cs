using System;

namespace Sample_2
{
    class Program
    {
        int a;
        int b;
        Program(int _a, int _b)
        {
            a = _a;
            b = _b;
        }

        public static Program operator*(Program _obj1, Program _obj2)
        {
            Program _obj3 = new Program(0, 0);
            _obj3.a = _obj1.a * _obj2.a;
            _obj3.b = _obj1.b * _obj2.b;
            return _obj3;
        }
        public static void show(Program _obj)
        {
            Console.WriteLine("a=" + _obj.a);
            Console.WriteLine("b=" + _obj.b);
        }
        static void Main(string[] args)
        {
            Program Obj1 = new Program(2,5);
            Program Obj2 = new Program(3,6);
            Program Obj3 = new Program(0,0);
            Obj3 = Obj1 * Obj2;
            Program.show(Obj3);
            Console.ReadLine();
        }
    }
}
