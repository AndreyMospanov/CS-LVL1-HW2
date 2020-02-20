using System;
using static System.Console;
using static Library.Commands;

namespace Task_3
// Андрей Моспанов 
// 3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
{

    class Program
    {
        static void Main(string[] args)
        {
            int i = default;
            int sum = 0;
            Print("Введите числа");
            
            do
            {
                i = GetInt();
                if (i > 0 && i % 2 == 0)
                {
                    sum += i;
                }                
            }
            while (i != 0);
            WriteLine(sum);
            Pause();
        }
    }
}
