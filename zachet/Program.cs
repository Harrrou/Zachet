using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zachet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            int summ = 0;
            foreach (char c in str)
            {
                if (Char.IsDigit(c) == true)
                    summ += int.Parse(c.ToString());
            }
            Console.Write("Сумма чисел в строке = " + summ);
            Console.Read();
        }
    }
}
