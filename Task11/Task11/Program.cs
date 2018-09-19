using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] triangles = new int[n];
            for (int i = 0; i < n; i++)
            {
                triangles[i] = int.Parse(Console.ReadLine());
            }
            double[] perimeters = new double[n];
            for (int i=1; i<n-1; i++)
            {
                perimeters[i-1] = (triangles[i] + triangles[i + 1] + triangles[i - 1]) / 2;
            }
            double[] all_areas = new double[n];
            for(int i=1; i<n-1; i++)
            {
                all_areas[i-1] = Math.Sqrt(perimeters[i-1]*(perimeters[i-1]-triangles[i])*(perimeters[i-1]-triangles[i-1])*(perimeters[i-1]-triangles[i+1]));
            }
            double[] areas = new double[n/3];
            areas[0] = all_areas[0];
            for (int i=1; i<n; i++)
            {
                for(int j=1; j<n; j++)
                {
                    if (i/j==3)
                    {
                        areas[j] = all_areas[i];
                    }
                }
            }
            double max = areas.Max();
            int max_index = areas.ToList().IndexOf(max)+1;
            Console.WriteLine("Triangle# with max area : "+max_index);
            Console.ReadKey();
        }
    }
}
