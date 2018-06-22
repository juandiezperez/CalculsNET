using System;
using System.Collections.Generic;

namespace CalcNet
{
    public class Range
    {
        public readonly int Min;
        public readonly int Max;
        public readonly List<int> Values;

        public Range (int a, int b)
        {
            Min = a;
            Max = b;

            Values = new List<int>();
            for (int i = Min; i < Max; i++)
                Values.Add(i);
        }

        public bool Includes (int x)
        {
            return (Min <= x) && (x <= Max);
        }

        public override string ToString()
        {
            return String.Format("[{0} {1}]", Min, Max);
        }

        public static Range U_01_09  = new Range ( 1,  9);
        public static Range DU_10_19 = new Range (10, 19);
        public static Range DU_20_29 = new Range (20, 29);
    }
}



