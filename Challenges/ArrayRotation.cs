using System;

namespace Challenges
{
    class ArrayRotation
    {
        static void Solve(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = a[(i + k) % n];
            }
            Console.Write(String.Join(" ", b));
        }
    }
}
