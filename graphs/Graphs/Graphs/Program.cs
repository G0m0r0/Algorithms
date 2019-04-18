using System;
using System.Collections.Generic;

namespace Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize
            var graph = new List<int>[]
            {
                new List<int>{3,6}, //zero is connected with 3 and 6
                new List<int>{2,3,4,5,6}, //first is connected with 2,3,4..
                new List<int>{1,4,5},
                new List<int>{0,1,5},
                new List<int>{1,2,6},
                new List<int>{1,2,3},
                new List<int>{0,1,4} //sixth is connected with the rest
            };
        }
    }
}
