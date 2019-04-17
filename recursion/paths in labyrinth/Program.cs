using System;
using System.Collections.Generic;
using System.Linq;

namespace paths_in_labyrinth
{
    class Program
    {
        static char[,] labyrinth;

        static List<char> listDirections = new List<char>();
        static void ReadInput()
        {
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            labyrinth = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                string currentLine = Console.ReadLine();
                for (int j = 0; j < cols; j++)
                {
                    labyrinth[i, j] = currentLine[j];
                }
            }
        }
        static void Solve(int row, int col, char direction)
        {
            if (OutSideOfLabyrinth(row, col))
            {
                return;
            }

            listDirections.Add(direction);

            if (IsExit(row, col))
            {
                PrintSolution();
            }
            else if (IsPassible(row, col))
            {
                labyrinth[row, col] = 'x';

                Solve(row + 1, col, 'D'); //down
                Solve(row - 1, col, 'U'); //up
                Solve(row, col + 1, 'R'); //right
                Solve(row, col - 1, 'L'); //left

                labyrinth[row, col] = '-';
            }
            listDirections.RemoveAt(listDirections.Count - 1);
        }

        private static bool IsPassible(int row, int col)
        {
            //already visited
            if (labyrinth[row, col] == 'x')
            {
                return false;
            }

            //wall
            if (labyrinth[row, col] == '*')
            {
                return false;
            }
            return true;
        }

        private static bool IsExit(int row, int col)
        {
            return labyrinth[row, col] == 'e';
        }

        private static void PrintSolution()
        {
            Console.WriteLine(string.Join(string.Empty,listDirections.Skip(1)));
        }

        private static bool OutSideOfLabyrinth(int row, int col)
        {
            if (row < 0 || row >= labyrinth.GetLength(0))
            {
                return true;
            }

            if (col < 0 || col >= labyrinth.GetLength(1))
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            ReadInput();
            Solve(0, 0,'S');
        }
    }
}
