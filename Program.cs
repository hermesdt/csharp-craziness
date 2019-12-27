using System;

namespace csharp_craziness
{
    class Program
    {
        static int Func1() {
            return 1;
        }

        static void Main(string[] args)
        {
           ForThings things = new ForThings();
           things.Run();
        }
    }
}
