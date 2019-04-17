using System;

namespace generating_01_vector
{
    class Program
    {
        static void Main(string[] args)
        {
            //not finished!!!!!!!!!!!!
            int index = int.Parse(Console.ReadLine());
            int[] vector = new int[index];
            GenerateVector(0,vector);
        }
        static void GenerateVector(int index,int[] vector)
        {
            if (index >= vector.Length)
                Console.WriteLine(string.Join("",vector));
            else
            {
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    GenerateVector(index + 1, vector);
                }
            }
        }
    }
}
