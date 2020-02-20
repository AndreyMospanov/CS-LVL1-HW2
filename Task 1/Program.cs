using System;
using static System.Console;
using static Library.Commands;



namespace Task_1
// Андрей Моспанов
//1. Написать метод, возвращающий минимальное из трех чисел.
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("Введите число a");
            int a = GetInt();
            Print("Введите число b");
            int b = GetInt();
            Print("Введите число c");
            int c = GetInt();
            int min = c;
            min = a < b ? a : b;
            min = b < c ? b : c;
            Print($" Наименьшее число - {min}");
            Pause();
        }
    }
}
