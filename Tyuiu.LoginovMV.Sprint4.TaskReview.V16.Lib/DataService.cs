using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LoginovMV.Sprint4.TaskReview.V16.Lib
{
    public class DataService : ISprint4Task7V16
    {
        public int Calculate(int n, int m, string value)
        {
            int sum = 1;
            int[,] maxt = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    maxt[i, j] = int.Parse(value.Substring(i * m + j, 1));
                    if (maxt[i, j] % 2 == 0)
                    {
                        sum *= maxt[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
