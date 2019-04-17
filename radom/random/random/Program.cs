using System;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public static void Shuffle<T>(T[] source)
        {
            Random rnd = new Random();

            for (int i = 0; i < source.Length; i++)
            {
                int r = i + rnd.Next(0, source.Length - i);

                T temp = source[i];
                source[i] = source[r];
                source[r] = temp;
            }
        }
    }
}
