using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1
            int[,] a = new int[10, 10];
            int sum = 0;
            Int64 mult = 1;
            int count = 0;
            Console.WriteLine("Исходный массив:");
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                    Console.Write("{0,4}", a[i, j]);
                    if (a[i, j] > 0)
                        sum += a[i, j];
                    else if (a[i, j] < 0)
                        mult *= a[i, j];
                    else
                        count++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма положительных элементов: " + sum);
            Console.WriteLine("Произведение отрицательных элементов: " + mult);
            Console.WriteLine("Количество элементов равных нулю: " + count);

            // задание 2
            Console.WriteLine("Введите целое число");
            int p = int.Parse(Console.ReadLine());
            int countN = (int)Math.Log10(p) + 1;
            Console.WriteLine("Число x: " + p);
            Console.WriteLine("Количество цифр числа x: " + countN);

            // задание 3
            Console.WriteLine("Введите начало промежутка для построения массива");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец промежутка для построения массива");
            int end = int.Parse(Console.ReadLine());
            int[,] s = new int[10, 10];

            Console.WriteLine("Исходный массив:");
            Random rand1 = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    a[i, j] = rand1.Next(start, end);
                    Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();
            }

            /// задание 4
            Console.WriteLine("Введите первое число");
            int abba = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int baba = int.Parse(Console.ReadLine());

            if (abba % baba == 0) 
            {
                Console.WriteLine("Да, одно из чисел является делителем");
            }
            else if (baba % abba == 0) 
            {
                Console.WriteLine("Да, одно из чисел является делителем");
            }
            else { Console.WriteLine("Нет, ни одно из чисел не является делителем"); }

            /// задание 5
            Console.WriteLine("Введите значение поворота часовой стрелки в градусах:");
            double turn = double.Parse(Console.ReadLine());
            double hour = turn / 30;
            double minut = (hour - Math.Floor(hour)) * 60;

            int roundHour = (int)Math.Round(hour);
            int roundMinut = (int)Math.Round(minut, MidpointRounding.ToEven);

            Console.WriteLine($"С начала дня прошло {roundHour} часов и {roundMinut} минут");
        }
    }
}
