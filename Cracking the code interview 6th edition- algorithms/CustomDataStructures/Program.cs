namespace CustomDataStructures
{
    using System.Collections.Generic;
    using System;
    using System.Text;

    class Program
    {
        static void Main()
        {
            //try to implement list
            var list = new List<int>();
            list.Remove(1); //returns bool
            list.Add(1);
            list.Clear();
            list.AddRange(new int[] { 1, 2, 3, 4 });
            list.Contains(3); //returns bool
            // int count = list.Count;  //returns int

            //check initial array of list
            var initSize = list.Capacity.ToString();
            Console.WriteLine(initSize);

            //check initial value
            var arr = new int[5];
            Console.WriteLine(arr[1]);


            //my list
            var myList = new MyList<int>();
            myList.Add(5);
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);

            Console.WriteLine(myList.Remove(5));
            Console.WriteLine(myList.Remove(10));

            myList.Add(10);
            myList.Clear();

            myList.AddRange(new int[] { 1, 2, 3, 4, 5 });

            Console.WriteLine(myList.Contains(1));
            Console.WriteLine(myList.Contains(10));

            foreach (var item in myList)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[4]);


            MyList<string> mylist2 = new MyList<string>() { "pesho", "ivan", "petar","gosho" };

            Console.WriteLine(string.Join(" ",mylist2));

            Console.WriteLine(mylist2.Count());

            //MyList implimented


            //try to impliment StringBuilder
            var sb = new StringBuilder();
            sb.Append("text");
            sb.AppendLine("text");
            Console.WriteLine(sb.ToString());
            sb.AppendJoin(" ", 1,2,3,4);
            sb.Remove(1, 2);
            sb.Replace("e", "E");
            Console.WriteLine(sb.ToString());
            sb.Clear();
            Console.WriteLine(sb);
        }
    }
}
