using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringToIntMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variables 
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            //declare matrix size rols,cols
            int[,] matrix = new int[rows, cols];
            //fill matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string colsLine = Console.ReadLine();
                string[] cells = colsLine.Split(' ');
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = int.Parse(cells[col]);
                }
            }
            //write matrix to console
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0}", matrix[row, col]);
                    if (col != matrix.GetLongLength(1) - 1)
                    {
                        Console.Write(", ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}