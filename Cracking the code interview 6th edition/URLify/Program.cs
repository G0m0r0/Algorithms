using System;

namespace URLify
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "Mr John Smith ";
            var url = str.TrimEnd().Replace(" ", "%20");

            Console.WriteLine(url);
        }
    }
}
