using System;
using System.Collections.Generic;
using System.Text;

namespace TestTasks_1
{
    public static class Task5
    {
        public static Dictionary<string, int> DoIt(double money_)
        {
            Dictionary<string, int> res = new Dictionary<string, int>();            
            res.Add("Pennies",  0);
            res.Add("Nickels",  0);
            res.Add("Dimes",    0);
            res.Add("Quarters", 0);
            if (money_ < 0)
                return res;
            int money = Convert.ToInt32(Math.Floor(money_));
            res["Quarters"] = money / 25;
            money = money % 25;
            res["Dimes"] = money / 10;
            money = money % 10;
            res["Nickels"] = money / 5;
            money = money % 5;
            res["Pennies"] = money;
            return res;
        } 
    }
}
