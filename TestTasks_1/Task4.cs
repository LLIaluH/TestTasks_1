using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestTasks_1
{
    public static class Task4
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
            var res = numbers.Sum();
            if (res > 9)            
                res = DoIt(res);            
            return res;
        }
    }
}
