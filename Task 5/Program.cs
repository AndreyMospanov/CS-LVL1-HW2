using System;
using static System.Console;
using static Library.Commands;

namespace Task_5
{
    class Program
    {   //Андрей Моспанов
        //5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, 
        //нужно ли человеку похудеть, набрать вес или все в норме;
        //б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
    
       
        static void Main(string[] args)
        {
                #region ИМТ v1.1

                Print("Введите свой рост, см");
                double height = Convert.ToDouble(Console.ReadLine()) / 100;
                Print("Введите свой вес, кг");
                double weight = Convert.ToDouble(Console.ReadLine());

                double index = weight / (height * height);

                Print($"Ваш индекс массы тела равен {index:N}");

                 
                #region условия для индекса
                if (index <= 18)
                { Print("У Вас недостаток веса 2ой степени"); }
                else if (index > 18 && index <= 20)
                { Print("У Вас недостаток веса 1ой степени"); }
                else if (index > 20 && index <= 25)
                { Print("У Вас нормальный вес"); }
                else if (index > 25 && index <= 27)
                { Print("У Вас лишний вес"); }
                else if (index > 27 && index <= 30)
                { Print("У Вас ожирение 1ой степени"); }
                else if (index > 30 && index <= 35)
                { Print("У Вас ожирение 2ой степени"); }
                else
                { Print("У Вас ожирение 3ей степени"); }
                #endregion

                #region ваша норма
                double norm1 = height * height * 20;
                double norm2 = height * height * 25;
            if (index <= 20 && index > 25)
            {
                Print($"Ваш нормальный вес должен быть в диапазоне {norm1:N}-{norm2:N}кг");
            }

                #endregion

                #region отклонение от нормы
            if (index<=20)
            {
                Print($"Вам нужно набрать {norm1 - weight:N}-{norm2 - weight:N}кг");
            }
                else if (index >25)
                {
                    Print($"Вам нужно сбросить {weight - norm2:N}-{weight - norm1:N}кг");
                }
            #endregion



            Pause();

                #endregion
        }
        
    }

}
    

