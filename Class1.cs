using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArray
{
    internal class DoubleArrayDouble
    {
        public static int FindTheMinimumElementOfAnArray()
        {
            int[,] result = new int[,] { { 1, 5 }, { 5, 9 }, { 1, 9 } };
            int minValue = result[0,0];
            for (int i = 1; i < result.Length; i++)
            {

                if (result[i,i] < minValue)
                {
                    minValue = result[i,i];
                }
            }
            return minValue;
        }
        public static int FindTheMaximumElementOfAnArray()
        {
            int[,] result = new int[,] { { 1, 5 }, { 5, 9 }};
            int maxValue = result[0,0];

            for (int i = 1; i < result.Length; i++)
            {

                if (result[i,i] > maxValue)
                {
                    maxValue = result[i,i];
                }
            }
            return maxValue;
        }
        public static int FindTheIndexOfTheMinimumElementOfAnArray()
        {
            int[,] array = new int[,] { { 100, 10}, { 2, 8} };
            int minValue = array[0,0];
            int index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i,i] < minValue)
                {
                    array[i,i] = minValue;
                    index = i;
                }

            }
            return index;
        }
        public static int FindIndexOfMaximumArrayElement()
        {
            int[,] array =new int [,]{{ 100, 800, 105, 865, 205 },{ 100, 800, 105, 865, 205 } };
            int maxValue = array[0,0];
            int result = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i,i] > maxValue)
                {
                    maxValue = array[i,i];
                    result = i;
                }

            }
            return result;
        }

    }
}
