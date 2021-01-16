using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniquePaths_DP_LeetCode
{
    class Program
    {
        /// <summary>
        /// Program Unique Paths Leet code Dynamic programming
        /// </summary>
        /// <param name="args"></param>
        //1.In 2D matrix robot at staring position at (0,0) and finish line at (m-1,n-1) of matrix.
        //2.Rule For robot its forward right or downward at it's position

        //step to solve 
        //Create a 2d matrix MxN 
        

        static void Main(string[] args)
        {
            int m = 3, n = 7;

            int[,] dp = new int[m, n];

            for (int i = 0; i < m; i++)
                dp[i, 0] = 1;
            for (int j = 0; j < n; j++)
                dp[0, j] = 1;

            for(int i=1;i<m;i++)
            {
                for(int j=1;j<n;j++)
                {
                    dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
                }
            }

            Console.WriteLine("Unique Paths in " + m + "*" + n + " matrix is " + dp[m - 1, n - 1]);
            Console.ReadLine();
        }
    }
}
