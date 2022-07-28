using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestTasks_1
{
    public static class Task6
    {
        public static int DoIt(int num)
        {
            int CountDigit = num.ToString().Length;
            List<int> numbers = new List<int>(CountDigit);
            for (int i = 0; i < CountDigit; i++)
            {
                numbers.Add(num % 10);
                num = num / 10;
            }
            int res = 0;
            for (int i = 0; i < CountDigit; i++)
            {
                var temp = numbers.Max();
                res = res * 10 + temp;
                numbers.Remove(temp);
            }
            return res;
        }
    }
}
