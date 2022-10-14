using System;
using System.Collections.Generic;
using System.Numerics;

namespace VMathLaba1._2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Без изменения формулы {0}", IntErrorFucn(3));
            Console.WriteLine("Расчёт факториала с числом целого типа {0}", IntErrorFucn(3));
            Console.WriteLine("Расчёт факториала с числом вещественного типа {0}", DoubleErrorFucn(3));
            Console.WriteLine("Расчёт формулы через предыдущий член ряда {0}", ErrorFuncModify(3));
            Console.ReadKey();
        }


        private static int Factorial(int n)
        {
            int factorial = 1;
            if (n == 0)
            {
                return 1;
            }
            for (int i = 1; i <= n; i++)
            {
                factorial = checked(factorial * i);
            }

            return factorial;
        }


        private static double Factorial(double n)
        {
            double factorial = 1;
            if (n == 0)
            {
                return 1;
            }
            for (double i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }



        public static double DoubleErrorFucn(int x)
        {

            double sum = 0d;

            for (double n = 0; ; n++)
            {

                double res = 0d;


                var fact = Factorial(n);
                if (fact <= 0 || double.IsInfinity(fact))
                {
                    break;
                }

                res = Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / (fact * (2 * n + 1));

                if (double.IsInfinity(res) || res == 0d)
                {
                    break;
                }



                sum += res;
            }

            return (2 / Math.Sqrt(Math.PI)) * sum;
        }


        public static double IntErrorFucn(int x)
        {

            double sum = 0d;

            for (int n = 0; ; n++)
            {
                double res = 0d;

                var fact = Factorial(n);


                if (fact >= int.MaxValue)
                {
                    break;
                }

                try
                {
                    res = checked(Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / (fact * (2 * n + 1)));
                }
                catch (OverflowException)
                {
                    break;
                }


                if (double.IsInfinity(res) || res == 0d)
                {
                    break;
                }



                sum += res;
            }

            return (2 / Math.Sqrt(Math.PI)) * sum;
        }

        public static double ErrorFuncModify(double x)
        {

            double sum = x, mult = 1, memb;
            int n = 0;
            //https://ru.wikipedia.org/wiki/Функция_ошибок

            //https://math.stackexchange.com/questions/3694975/evaluating-erfx-using-taylors-series

            do
            {
                n++;
                mult *= -x * x / n;
                memb = x / (2 * n + 1) * mult;
                if (memb == 0d)
                {
                    break;
                }
                sum += memb;
            } while (true);

            return (2 / Math.Sqrt(Math.PI)) * sum;
        }

    }
}
