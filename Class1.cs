using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArray
{
    public static class DoubleArrayDouble
    {
        public static int FindTheMinimumElementOfAnArray(int [,] result)
        {
            
            int minValue = result[0,0];
            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {
                    if (result[i, j] < minValue)
                    {
                        minValue = result[i, j];
                    }
                }
            }
            return minValue;
        }
        public static int FindTheMaximumElementOfAnArray(int[,] result)
        {
            
            int maxValue = result[0,0];

            for (int i = 0; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < result.GetLength(1); j++)
                {

                    if (result[i, j] > maxValue)
                    {
                        maxValue = result[i, j];
                    }
                }
            }
            return maxValue;
        }
        public static int FindTheIndexOfTheMinimumElementOfAnArray(int[,] array)
        {
          
            int minValue = array[0,0];
            int index = 0;

            for (int i = 0; i < array.GetLength(0); i++)

            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < minValue)
                    {
                        array[i, j] = minValue;
                        index = i;
                    }
                }
            }
            return index;
        }
        public static int FindIndexOfMaximumArrayElement(int[,] array)
        {           
            int maxValue = array[0,0];
            int result = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    if (array[i,j] > maxValue)
                {
                    maxValue = array[i,j];
                    result = i;
                }
            }
            return result;
        }
        public static int FindOfElements(int[,] array)
        {
            int count = 0;

            for (int i=0; i<array.GetLength(0); i++)
            {
                for (int j=0; j<array.GetLength(1); j++)
                {
                    if (
                        (i == 0 || array[i, j] > array[i - 1,j])
                        &&(i== array.GetLength(0)-1 || array[i, j] > array[i + 1, j])
                        &&(j == 0 || array[i, j] > array[i, j-1])
                        && (j == array.GetLength(1) - 1 || array[i, j] > array[i, j+1])
                        )
                {
                        count++;
            }
                }
            }
            return count;
        }
        public static int[,] MirrorArray(int[,] array)
        {                    
            for (int i=0;i<array.GetLength(0); i++)
            {
                for (int j=i+1; j<array.GetLength(1);j++)
                {
                    int tmp = array[i, j];
                    array[i, j]=array[j,i];
                    array[j, i] = tmp;
                }
            }
            return array;
        }
        public static void Write(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                { 
                    Console.Write($"{array[i,j]} ");

                }
                Console.WriteLine();
            }

            
        }

    }
}
