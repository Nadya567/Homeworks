using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    struct Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }

        public Complex Subtraction(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        public override string ToString()
        {
            return re + "+" + im + "i";
        }

    }

    class ComplexN
    {
        public double re;
        public double im;

        public ComplexN Plus(ComplexN x2)
        {
            ComplexN x3 = new ComplexN();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }

        public ComplexN Multi(ComplexN x2)
        {
            ComplexN x3 = new ComplexN();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

        public ComplexN Subtraction(ComplexN x2)
        {
            ComplexN x3 = new ComplexN();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        public override string ToString()
        {
            return re + "+" + im + "i";
        }

    }

    class Class1
    {
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

        public void MultiDr(int chisl, int znam, int chisl2, int znam2)
        {
            int chAnsw;
            int znAnsw;
            chAnsw = chisl * chisl2;
            znAnsw = znam * znam2;

            Console.WriteLine($"Результат умножения дроби {chisl}/{znam} на дробь {chisl2}/{znam2} равен {chAnsw}/{znAnsw}");
        }

        public void SubDr(int chisl, int znam, int chisl2, int znam2)
        {
            int chAnsw;
            int znAnsw;
            chAnsw = chisl * znam2;
            znAnsw = znam * chisl2;

            Console.WriteLine($"Результат деления дроби {chisl}/{znam} на дробь {chisl2}/{znam2} равен {chAnsw}/{znAnsw}");
           }
        public void AddDr(int chisl, int znam, int chisl2, int znam2)
        {
                int chAnsw;
                int znAnsw;
                int genZnam;
                genZnam = znam * znam2;
                
                chAnsw = chisl * znam2 + chisl2 * znam;
                znAnsw = genZnam;

                Console.WriteLine($"Результат сложения дроби {chisl}/{znam} и дроби {chisl2}/{znam2} равен {chAnsw}/{znAnsw}");
        }

        public void SubstrDr(int chisl, int znam, int chisl2, int znam2)
        {
            int chAnsw;
            int znAnsw;
            int genZnam;
            genZnam = znam * znam2;

            chAnsw = chisl * znam2 - chisl2 * znam;
            znAnsw = genZnam;

            Console.WriteLine($"Результат вычитания из дроби {chisl}/{znam} дробь {chisl2}/{znam2} равен {chAnsw}/{znAnsw}");
        }



        public void Print(int value)
        {
            Console.WriteLine(value);
        }
    }
}