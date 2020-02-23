using System;
using static System.Console;
using static Library.Commands;

namespace Task_4
{
    class Program
        //4. Реализовать метод проверки логина и пароля.
        //На вход подается логин и пароль.На выходе истина, если прошел авторизацию, и ложь, 
        //если не прошел (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, 
        //написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или
        //не пропускает.С помощью цикла do while ограничить ввод пароля тремя попытками.
    {
        static bool Log(string login)
        {
            if (login == "root")
            { return true; }
            else { return false; }
        }
        static bool Pass(string password)
        {
            if (password == "GEEKBRAINS")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            #region логин пароль без ограничения попыток
            //int count = 0;//Количество попыток
            //string login;
            //string password;
            //do
            //{
            //    WriteLine("Введите Логин");
            //    login = ReadLine();
            //    WriteLine("Введите Пароль");
            //    password = ReadLine();
            //    count++;
            //}
            //while (  password != "GEEKBRAINS" || login != "root");
            //WriteLine($"Добро пожаловать в систему, У вас было {count} попыток");
            //Pause();
            #endregion

            int count=0;
            string login;
            string password;
            do
            {
                WriteLine("Введите Логин");
                login = ReadLine();
                Log(login);
                WriteLine("Введите Пароль");
                password = ReadLine();
                Pass(password);
                count++;
                if (Log(login) == true && Pass(password) == true)
                {
                    WriteLine("Добро пожаловать в систему");
                    break;
                }
            }
            while (count < 3);
            if (count == 3)
            { 
                WriteLine("Превышено количество попыток"); 
            }
            Pause();

        }




    }
}
