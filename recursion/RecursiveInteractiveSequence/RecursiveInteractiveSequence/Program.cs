namespace MyApp
{
    public static class Program
    {
        static void Main()
        {
            // прочитаме число от потребителя за броя на числата в редицата
            double n = double.Parse(Console.ReadLine());

            // interactive
            // начално инициализиране на стойностите
            double n1 = 1 / 3d;
            double n2 = 3;
            double n3 = 4;
            double n4 = 5;

            double result = 0;

            // по задание n > 4 затова цикъла започва от 5 и приключва до <=n
            for (int i = 5; i <= n; i++)
            {
                // формулата за формиране на интеративен вариант
                result = n4 + 2 * n2 - 3 * n1;

                // запазва стойностите с една назад, първата най- задната не ни е нужна защото не участеа във формулата
                n1 = n2;
                n2 = n3;
                n3 = n4;
                n4 = result;
            }

            // принтираме интеративния резултат на конзолата
            Console.WriteLine(result);

            // recursive
            // рекурсивния вариант е реализиран чрез функцията RecursiveVariant
            double result2 = RecursiveVariant(n);
            Console.WriteLine(result2);
        }

        // функцията на рекурсивният вариант
        public static double RecursiveVariant(double n)
        {
            // базови стойности при навлизане най- дълбоко в рекурсията (константни)
            if (n == 1) return 1 / 3d;
            else if (n == 2) return 3;
            else if (n == 3) return 4;
            else if (n == 4) return 5;

            // рекурсията се осъществява на три етапа в зависимост от подадената стойност n. Ако примерно е подадено n=5 
            // първия етап е RecursiveVariant(4) кое връща стойност 5, втори етап RecursiveVariant(2) което връща стойност 3, трети етап  RecursiveVariant(1) което връща стойност 0.33333333. В този случай поподаме на константните стойности зададени по условие. Ако подаденото число n=6 е в първия вариант ще имаме RecursiveVariant(5) което не е константна стойност и ще се разгледа примера по горе за формиране на стойността, другите два етапа са константни. С нарастването на n ще се престмятам стойностите като не навлиза в рекурсията.
            return RecursiveVariant(n - 1) + 2 * RecursiveVariant(n - 3) - 3 * RecursiveVariant(n - 4);
        }
    }
}