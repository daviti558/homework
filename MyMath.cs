using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15;
internal class MyMath
{
    public static int Min(int x, int y)
    {
        return x < y ? x : y;
    }

    public static int Max(int x, int y)
    {
        return x > y ? x : y;
    }

    public static int Clamp(int value, int min, int max)
    {
        return Max(min, Min(value, max));
    }

    public static int Sqrt(int x)
    {   
        for (int i = 0; i <= x; i++)
        {
            if (i * i == x)
                return i;
        }

        return x;
    }
    public static long Pow(int x, int y) {
        long result = 1;
        for (int i = 0; i < y; i++)
        {
            result *= x;
        }

        return result;
    }