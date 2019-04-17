using System;

namespace factoriel_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(FactorielRecursion(num));
        }
        static long FactorielRecursion(int n)
        {
            if (n == 0) //n=1 without multipling 1
            {
                return 1;
            }
           // Console.WriteLine($"Before recursion {n}");

            long recursion= n * FactorielRecursion(n - 1);

           // Console.WriteLine($"After recursion {n}");

            return recursion;
        }
    }
}
