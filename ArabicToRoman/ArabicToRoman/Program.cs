namespace ArabicToRoman
{
    using System;

    class Program
    {
        static void Main()
        {
            var num = uint.Parse(Console.ReadLine());
            string romanNumber = string.Empty;

            try
            {
                romanNumber = Converter.ArabicToRoman(num);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(romanNumber);
        }
    }
}
