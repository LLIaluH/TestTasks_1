using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace TestTasks_1
{
    static class Task8
    {
        public static int DoIt()
        {
            List<int> list = new List<int>();
            list.Add(Convert.ToInt32(true));
            list.Add(Convert.ToInt32(true));
            list.Add(Convert.ToInt32(true));
            list.Add(Convert.ToInt32(true));
            list.Add(Convert.ToInt32(true));
            var res = list.Sum();
            return res;
        }
    }
}
