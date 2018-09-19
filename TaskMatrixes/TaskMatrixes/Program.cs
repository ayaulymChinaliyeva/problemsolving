using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TaskMatrixes
{
    class Program
    {
        static void Main(string[] args)
        {
            int row1 = int.Parse(Console.ReadLine());
            int column1 = int.Parse(Console.ReadLine());
            int row2 = int.Parse(Console.ReadLine());
            int column2 = int.Parse(Console.ReadLine());
            int[,] matrix1 = new int[row1, column1];
            int[,] matrix2 = new int[row2, column2];
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < column1; j++)
                {
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < row2; i++)
            {
                for (int j = 0; j < column2; j++)
                {
                    matrix2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            if (column1 == row2)
            {
                int[,] matrix3 = new int[row2, column1];
                for (int i = 0; i < row2; i++)
                {
                    for (int j = 0; j < column1; j++)
                    {
                        matrix3[i,j] = 0;
                        for(int k=0; k<column1; k++)
                        {
                            matrix3[i, j] = matrix3[i, j] + matrix1[i, k] * matrix2[k, j];
                            Console.WriteLine(matrix3[i, j]);
                        }
                    }
                }
                int[,] transposedMatrix = new int[column1, row2];
                Console.WriteLine("Transpose matrix elements:");
                for (int i = 0; i < column1; i++)
                {
                    for (int j = 0; j < row2; j++)
                    {
                        transposedMatrix[i, j] = matrix3[j, i];
                    }
                }
                for(int d=0; d<column1; d++)
                {
                    for(int h=0; h<row2; h++)
                    {
                        Console.WriteLine(transposedMatrix[d, h]);
                    }
                }
                int[,] frequencies = new int[row2, column1];
                for(int c=0; c<row2; c++)
                {
                    for(int b=0; b<column1; b++)
                    {
                        frequencies[c, b] = 0;
                    }
                }
                foreach(int s in matrix3)
                {
                    for(int i=0; i<row2; i++)
                    {
                        for(int j=0; j<column1; j++)
                        {
                            if(s==matrix3[i, j])
                            {
                                frequencies[i, j] += 1;
                            }
                        }
                    }
                }
                Console.WriteLine("Frequencies of the elements (appear in accordance with indiecies)");
                for(int k=0; k<row2; k++)
                {
                    for(int g=0; g<column1; g++)
                    {
                        Console.WriteLine(frequencies[k, g]);
                    }
                }
            }
            else
            {
                Console.WriteLine("Matrixes cannot be multiplied");
            }
            Console.ReadKey();
        }
    }
}
