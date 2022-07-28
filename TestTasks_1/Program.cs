using System;
using System.Linq;

namespace TestTasks_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = 942;
            Console.WriteLine(@"Функция, которая из цифр числа составляет сумму и так пока не будет одна цифра в числе. Из числа ({0}) получилось: {1}", b, Task4.DoIt(b));

            var mon = 4.935;
            var resMon = Task5.DoIt(mon);
            Console.WriteLine(@"Функция, которая из центов подбирает необходимую комбинацию монет, чтобы собрать {0} центов необходимы:", mon);
            Console.WriteLine("\t" + @"{0} Pennies, {1} Nickels, {2} Dimes, {3} Quarters", resMon["Pennies"], resMon["Nickels"], resMon["Dimes"], resMon["Quarters"]);
            

            var n = 42145;
            Console.WriteLine(@"Функция, которая из цифр числа составляет максимальное число, из числа ({0}) получилось: {1}", n, Task6.DoIt(n));
            

            Console.WriteLine(@"Функция, которая по номеру строки из пирамиды возвращает сумму чисел: {0}", Task7.DoIt(5));

            Console.WriteLine(@"Функция, которая возвращает число пять: {0}", Task8.DoIt());
            Console.ReadKey();
        }
    }
}
