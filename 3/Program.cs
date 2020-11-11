using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());

            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());

            result = complex1.Subtraction(complex2);
            Console.WriteLine(result.ToString());


            /////////////////////////////////////////
            Console.WriteLine("\n");

            ComplexN complex1N = new ComplexN();
            complex1N.re = 1;
            complex1N.im = 1;

            ComplexN complex2N = new ComplexN();
            complex2N.re = 2;
            complex2N.im = 2;

            ComplexN resultN = complex1N.Plus(complex2N);
            Console.WriteLine(resultN.ToString());

            resultN = complex1N.Multi(complex2N);
            Console.WriteLine(resultN.ToString());

            resultN = complex1N.Subtraction(complex2N);
            Console.WriteLine(resultN.ToString());


            ///////////////////////////////////
            Console.WriteLine("\n");
            Console.WriteLine("Второй номер: Нахождение суммы нечетных положительных чисел\n");

            Class1 a = new Class1();
            int ch = -1;
            string str = " ";
            int sum = 0;
            bool check;

            do
            {
                check = true;
                Console.WriteLine("Введите число, если хотите закончить, введите ноль ");
                str = Console.ReadLine();
                check = int.TryParse(str, out ch);
                if(check)
                {
                    sum = sum + a.Sum(ch);
                }
                else
                {
                    Console.WriteLine("Ошибка ");
                }
                     
            }
            while (ch != 0 || check == false);

            Console.WriteLine("Сумма положительных нечетных чисел равна ");
            a.Print(sum);

            //////////////////////////////////////////
            Console.WriteLine("\nТретий номер: действия с дробями\n");

            Console.WriteLine("Введите числитель первой дроби ");
            int chisl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знаменатель первой дроби ");
            int znam = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите числитель второй дроби ");
            int chisl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите знаменатель второй дроби ");
            int znam2 = Convert.ToInt32(Console.ReadLine());
            if(znam == 0 || znam2 == 0)
            {
                Console.WriteLine("Ошибка: знаменатель равен нулю ");
            }
            else
            {
                a.MultiDr(chisl, znam, chisl2, znam2);
                a.SubDr(chisl, znam, chisl2, znam2);
                a.AddDr(chisl, znam, chisl2, znam2);
                a.SubstrDr(chisl, znam, chisl2, znam2);
            }           
            Console.ReadKey();
        }
    }
}
