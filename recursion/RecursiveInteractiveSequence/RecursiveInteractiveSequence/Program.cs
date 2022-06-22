namespace MyApp
{
    public static class Program
    {
        static void Main()
        {
            double n = int.Parse(Console.ReadLine());

            // interactive
            double n1 = 1 / 3d;
            double n2 = 3;
            double n3 = 4;
            double n4 = 5;

            double result = 0;

            for (int i = 5; i <= n; i++)
            {
                result = n4 + 2 * n2 - 3 * n1;
                n1 = n2;
                n2 = n3;
                n3 = n4;

                n4 = result;
            }

            Console.WriteLine(result);

            // recursive
            double result2 = RecursiveVariant(n);
            Console.WriteLine(result2);
        }

        public static double RecursiveVariant(double n)
        {
            if (n == 1) return 1 / 3d;
            else if (n == 2) return 3;
            else if (n == 3) return 4;
            else if (n == 4) return 5;

            return RecursiveVariant(n - 1) + 2 * RecursiveVariant(n - 3) - 3 * RecursiveVariant(n - 4);
        }
    }
}