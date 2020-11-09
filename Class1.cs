using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2._1
{
    class Class1
    {
        public void Print(int value)
        {
            Console.WriteLine($"{value}");
        }

        public int MinOfThree(int a, int b, int c)
        {
            int min;
            if ((a < b) && (a < c))
                min = a;
            else if ((b < a) && (b < c))
                min = b;
            //if ((c < a) && (c < b))
            else
                min = c;

            return min;
        }

        public int CountOfNumbers(int number)
        {
            int k = 0;
            while (number != 0)
            {
                number = number / 10;
                k = k + 1;
            }
            return k;
        }

        public int Sum(int ch)
        {
            if ((ch % 2 != 0) && (ch > 0))
            {
                return ch;
            }

            else
            {
                return 0;
            }
        }

        public bool CheckLogin(string login)
        {
            bool accessL = false;
            string loginR = "root";
            if (loginR == login)
                accessL = true;

            else
                accessL = false;

            return accessL;
        }

        public bool CheckPassword(string password)
        {
            bool accessP = false;
            string passwordR = "GeekBrains";
            if (passwordR == password)
                accessP = true;

            else
                accessP = false;

            return accessP;
        }
                
        public double CheckFat(double h, double m)
        {
            double I;
            I = m / (h* h);
            return I;
        }
        public double CheckI(double I, double h)
        {
            double rightI;
            double rightH;
            if (I < 18.5)
            {
                Console.WriteLine($"IMT= {I:0.00}");
                Console.WriteLine("Слишком маленький вес ");
                rightI = 18.5 - I;
                rightH = rightI * h * h;
                Console.WriteLine($"Вам нужно набрать {rightH:0.00} кг");
            }


            else if ((I >= 18.5) && (I < 25))
            {
                Console.WriteLine($"IMT= {I:0.00}");
                Console.WriteLine("Нормальный вес ");
            }


            else if (I >= 25)
            {
                Console.WriteLine($"IMT= {I:0.00}");
                Console.WriteLine("Слишком большой вес ");
                rightI = I - 25;
                rightH = rightI * h * h;
                Console.WriteLine($"Вам нужно похудеть на {rightH:0.00} кг");
            }
            return 0;
        }

        public int CountN()
        {
            DateTime start = DateTime.Now;
            int k = 0;
            int i;
            
            for (i = 1; i < 1000000000; i++)
            {
                int sum = 0;
                int j = i;
                do
                {
                    //sum = 0;
                    sum = sum + (j % 10);
                    j = j / 10;
                }
                while (j != 0);

                if (i % sum == 0)
                    k++;
            }
            DateTime finish = DateTime.Now;
            double time = (finish - start).TotalSeconds;
            Console.WriteLine($"Время, потраченное на подсчет, равно {time}");
            return k;
        }

        public void RecurF(int a, int b, int summ)
        {
            //Console.WriteLine($"\n");
            if (a <= b)
            {
                Console.WriteLine($"{a} ");
                summ = summ + a;
                a++;
                RecurF(a, b, summ);
            }
            else if (a == b+1)
                Console.WriteLine($"\nСумма чисел равна {summ}");

        }
    }
}