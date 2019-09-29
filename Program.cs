using System;

namespace Assignment2_F19
{
    class Program
    {
        static void Main(string[] args)
        {
            //minimum meeting rooms required
            int[,] a = { { 40, 30 }, { 20, 10 }, { 15, 20 } };
            Console.WriteLine(MinMeetingRooms(a));

            //SortedSquares
            int[] input = { -4, -1, 0, 3, 10 };
            int[] o = new int[input.Length];
            o = SortedSquares(input);
            for(int j=0;j<o.Length;j++)
            {
                Console.Write(o[j]+" ");
            }
            


        }

        public static int MinMeetingRooms(int[,] intervals)
        {

            int[] d = new int[3];
            for (int i = 0; i < 3; i++)
            {
                int j = 0, k = 0, t = 0;
                if (intervals[i, j] > intervals[i, j + 1])
                {

                    t = intervals[i, j];
                    intervals[i, j] = intervals[i, j + 1];
                    intervals[i, j + 1] = t;

                    k = intervals[i, j + 1] - intervals[i, j];
                    d[i] = k;
                }
                else
                {
                    k = intervals[i, j + 1] - intervals[i, j];
                    d[i] = k;
                }

            }
            Array.Sort(d);
            return d[0];


        }

        public static int[] SortedSquares(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[i] * A[i];

            }
            Array.Sort(A);
            return A;
            
        }
    }
}
