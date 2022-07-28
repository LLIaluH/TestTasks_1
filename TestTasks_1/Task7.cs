using System;
using System.Collections.Generic;
using System.Text;

namespace TestTasks_1
{
    public static class Task7
    {
        public static int DoIt(int strNum)
        {
            if (strNum < 1)
                throw new Exception("Минимальное допустимое число число: 1");            
            var startNum = strNum * strNum - strNum + 1;
            var res = 0;
            for (int i = 0; i < strNum; i++)
                res += startNum + 2 * i;
            return res;
        }
    }
}
