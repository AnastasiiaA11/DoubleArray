using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArray
{
    public enum TDAMockType
    {
        first,
        second,
        third,
        Empty,
        HUFirst,
        HUSecond,
        HUThird
    }
    public static class TwoDMock
    {
        public static int[,] GetMock(TDAMockType type)
        {
            switch (type)
            {
                case TDAMockType.first:
                    return new int[,] 
                    {
                        { 8, 7, 3 },
                        { 11, 9, 8 },
                        { 7, 9, 10 }
                    };
                case TDAMockType.second:
                    return new int[,] {
                        { 1, 7, -7 },
                        { 11, 9, 8 },
                        { 50, -3, 0 }
                    };
                case TDAMockType.third:
                    return new int[,] {
                        { 16, -7, 15 },
                        { 1, 5, -100 },
                        { 500, -3, 0 }
                    };
                case TDAMockType.Empty:
                    return new int[,] { };

                default:
                    throw new Exception();

                case TDAMockType.HUFirst:
                    return new int[,]
                    {
                        { 1, 9, -9 },
                        { 18, 30, 0 },
                        { -6, 14, 31 },
                    };

                case TDAMockType.HUSecond:
                    return new int[,]
                    {
                        { -11, 7, 4 },
                        { 1, 7, -2 },
                        { 7, 1, 13 },
                    };

                case TDAMockType.HUThird:
                    return new int[,]
                    {
                        { 25, 7, 2 },
                        { -9, 8, 4 },
                        { 114, 7, 6 },
                    };               
            }
        }
    }
}
