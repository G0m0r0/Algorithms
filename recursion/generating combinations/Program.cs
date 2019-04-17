using System;
using System.Linq;

namespace generating_combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] set = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int border = int.Parse(Console.ReadLine());
            int[] vector = new int[border];
            GenComb(set, vector, 0, 0);
        }
        static void GenComb(int[] set,int[] vector,int index,int border)
        {
            if(index>=vector.Length)
                Console.WriteLine(string.Join(" ",vector));
            else
                for (int i = border+1; i < set.Length; i++)
                {
                    vector[index] = set[i];
                    GenComb(set, vector, index + 1, i);
                }
        }
    }
}
