using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 a = new Class1();

            //Нахождение минимального из трех чисел
             a.Print(a.MinOfThree(5, 2, 3));
             Console.WriteLine("\n");

             //Нахождение количества цифр в числе
             a.Print(a.CountOfNumbers(1234463));
             Console.WriteLine("\n");

             //Подсчет количества нечетных пложительных чисел
             Console.WriteLine("Подсчет количества нечетных пложительных чисел\n");
             int ch = 1;
             int sum = 0;
             while(ch != 0)
             {
                 Console.WriteLine("Введите число, если хотите закончить - введите ноль ");
                 ch =Convert.ToInt32(Console.ReadLine());
                 sum = sum + a.Sum(ch);
             }
             Console.WriteLine("Сумма положительных нечетных чисел равна: ");
             a.Print(sum);
             Console.WriteLine("\n");

             //Проверка логина и пароля
             int tr = 0;
             bool accessL;
             string login;
             do
             {
                 Console.WriteLine($"Введите логин, осталось {3-tr} попыток: ");
                 login = Console.ReadLine();
                 tr++;                
                 accessL = a.CheckLogin(login);

                 if (accessL == true)
                 {
                     Console.WriteLine("Логин введен правильно ");
                     break;
                 }
             }
             while (tr != 3);

             if (accessL == false)
                 Console.WriteLine("Доступ запрещен");

             else
             {
                 tr = 0;
                 bool accessP;
                 string password;
                 do
                 {
                     Console.WriteLine($"Введите пароль, осталось {3 - tr} попыток: ");
                     password = Console.ReadLine();
                     accessP = a.CheckPassword(password);
                     tr++;
                     if (accessP == true)
                     {
                         Console.WriteLine("Логин введен правильно ");
                         break;
                     }
                 }
                 while (tr != 3);

                 if (accessP == false)
                     Console.WriteLine("Доступ запрещен");
             }
             Console.WriteLine("\n");

             //Подсчет индекса массы тела
             Console.WriteLine("Подсчет индекса массы тела\n");
             Console.WriteLine("Введите Ваш рост");
             double h = Convert.ToDouble(Console.ReadLine()) / 100;

             Console.WriteLine("Введите Ваш вес ");
             double m = Convert.ToDouble(Console.ReadLine());

             double I = a.CheckFat(h, m);
             a.CheckI(I, h);
             Console.WriteLine("\n");

             //Подсчет "Хороших" чисел
             int k;
             k = a.CountN();
             Console.WriteLine($"Количество Хороших чисел равно {k}");
             Console.WriteLine("\n");
            
            //Рекурсивный вывод чисел
            Console.WriteLine("Рекурсивный вывод чисел\n");

            Console.WriteLine("Введите первое число ");
            int first= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число ");
            int second = Convert.ToInt32(Console.ReadLine());
            
            int summ = 0;

            a.RecurF(first, second, summ);
            
            Console.ReadKey();    
        }
    }
}