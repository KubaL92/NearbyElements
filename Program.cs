using System;

using System.Collections.Generic;

namespace nearby_elements
{
    class Program
    {
        
    
        static void Main(string[] args)
        {


            foreach (int el in Nearby(1,0,2))
            { Console.WriteLine(el); }


        }

        public static int[] Nearby(int x, int y, int range)
        {
            int[][] multi = new int[][]
            {
            new int[] { 2, 0, 4, 1241, 12, 5, 11, 1110, -42, 424, 1, 12323 },
            new int[] { 1, 3, 5, 7 },
            new int[] { 321, 320, 32, 3, 41241, -11, -12, -13, -66, -688 }
            };
            List<int> retlst = new List<int>();

            int fromIndex;
            int toIndex;

            if (y == 0) { fromIndex = 1; }
            else if (y - range < 0) { fromIndex = 0; }
            else { fromIndex = y - range; }

            if (y + range > multi.Length) { toIndex = multi.Length; }
            else { toIndex = y + range; }

            for (int i = 0; i < multi.Length; i++)
            { if (i >= fromIndex && i <= toIndex && i != y)
                { retlst.Add(multi[x][i]); }
            }
            int[] retArr = retlst.ToArray();
            return retArr;


        }
    }
}
