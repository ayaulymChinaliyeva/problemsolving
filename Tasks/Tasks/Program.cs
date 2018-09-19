using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for(int i=0; i<n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int temp = 0;
            for(int i=0; i<n-1; i++)
            {
                for(int j=0; j<n-i-1; j++) { 
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            for(int i=0; i<n; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();*/
            /*!---Task 1 here---!
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
            Console.ReadKey();*/

            /*!---Task 2 is here---!
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int index1 = 0;
            int index2 = 0;
            for(int i=1; i<n-1; i++)
            {
                if (array[i] + array[i - 1] > array[i] + array[i + 1])
                {
                    index1 = i;
                    index2 = i - 1;
                }
                else
                {
                    index1 = i;
                    index2 = i + 1;
                }
            }
            Console.WriteLine("Index 1 is: "+index1+" "+"Index 2 is: "+index2);
            Console.ReadKey();*/

            /*!---Third task is here---!
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            List<int> list = new List<int>();
            for (int i=0; i<n-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    list.Add(i);
                }
            }
            int temp = 0;
            for(int i=0; i< list.Count - 1; i++)
            {
                for (int j=0; j< list.Count - 1-i; j++)
                {
                    if (list[j] > list[j+1])
                    {
                        temp = list[j];
                        list[j] = list[j+1];
                        list[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("Indiecies are");
            list.ForEach(Console.WriteLine);
            Console.ReadKey();*/

            /*!---Fourth task is here---!
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for(int i=1; i<n-1; i++)
            {
                if(array[i]<array[i+1] && array[i] < array[i - 1])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadKey();*/

            /*!---Fifth task is here---!
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = n-2; i>=1; i--)
            {
                if (array[i] >array[i + 1] && array[i] > array[i - 1])
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadKey();*/

            /*!---Sixth task is here---!
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int temp = 0;
            for(int i=0; i<n-1;i++)
            {
                for(int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine(array[n - 2]);
            Console.ReadKey();*/
        }
    }
}
