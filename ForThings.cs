using System;

namespace csharp_craziness
{
    class ForThings
    {
        private int InitialValue()
        {
            return 0;
        }

        private int Condition()
        {
            return 1;
        }

        private int Increment(int i)
        {
            return i++;
        }

        private int RecursiveFactorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * RecursiveFactorial(n-1);
        }

        public void Run()
        {
            for(int i = InitialValue();i<1;i++)
            {
                Console.WriteLine("initial value from another function");
            }

            for(int i = 0;i<Condition();i++)
            {
                Console.WriteLine("condition from another function");
            }

            for(;;)
            {
                Console.WriteLine("no initial, no condition, no increment." +
                    "same thing as while. runs forever");
                break;
            }

            // Some different styles of doing things
            Console.WriteLine("(with elses block) {");
            for(int i = 1;i<10;i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"{i} is multiple of 2");
                } else if(i % 3 == 0)
                {
                    Console.WriteLine($"{i} is multiple of 3");
                }
            }
            Console.WriteLine("}");

            // Some different styles of doing things. From go lang, avoid using else:
            // I like this one
            Console.WriteLine("(no elses block) {");
            for(int i = 1;i<10;i++)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"{i} is multiple of 2");
                    continue;
                }

                if(i % 3 == 0)
                {
                    Console.WriteLine($"{i} is multiple of 3");
                    continue;
                }
            }
            Console.WriteLine("}");

            // example of recursive function instead of using for
            int factorialOfTen = RecursiveFactorial(10);
            Console.WriteLine($"Factorial of 10 = {factorialOfTen}");
        }
    }
}