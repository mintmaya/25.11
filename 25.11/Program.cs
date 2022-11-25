using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse("10");
            double b = double.Parse("23,56");
            decimal c = decimal.Parse("12,45");
            byte d = byte.Parse("4");
            Console.WriteLine($"a={a}  b={b}  c={c}  d={d}");



            Console.WriteLine("Введите строку:");
            string input = Console.ReadLine();

            bool result = int.TryParse(input, out var number);
            if (result == true)
                Console.WriteLine($"Преобразование прошло успешно. Число: {number}");
            else
                Console.WriteLine("Преобразование завершилось неудачно");
        }
    }
}
