using System;

namespace VMathLaba1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расчеты");

            Console.Write("\nМашинный эпсилон для типа float, полученный при расчетах: ");
            PrintColoredText(string.Format("{0}\n", GetFloatMachineEpsilon()), ConsoleColor.Cyan);
           
            Console.Write("\nВычисленный Машинный ноль для типа float в C#: ");
            PrintColoredText(string.Format("{0}\n", GeFloatMachineZero()), ConsoleColor.Cyan);

            Console.Write("\nМашинный эпсилон для типа double, полученный при расчетах: ");
            PrintColoredText(string.Format("{0}\n", GetDoubleMachineEpsilon()), ConsoleColor.Cyan);

            Console.Write("\nВычисленный Машинный ноль для типа double в C#: ");
            PrintColoredText(string.Format("{0}\n", GetDoubleMachineZero()), ConsoleColor.Cyan);

            Console.Write("\nМашинная бесконечность для типа float равна: ");
            PrintColoredText(string.Format("{0}\n", GetFloatMachineInfinity()), ConsoleColor.Cyan);


            Console.Write("\nМашинная бесконечность для типа double: ");
            PrintColoredText(string.Format("{0}\n", GetDoubleMachineInfinity()), ConsoleColor.Cyan);

            Console.WriteLine("\n\nРеференсные значения в .NET");

            Console.Write("\nМашинный ноль для типа float в C#: ");
            PrintColoredText(string.Format("{0}\n", float.Epsilon), ConsoleColor.Cyan);
     

            Console.Write("\nМашинный ноль для типа double в C#: ");
            PrintColoredText(string.Format("{0}\n", double.Epsilon), ConsoleColor.Cyan);

            Console.ReadKey();
        }

        private static void PrintColoredText(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }


        private static float GetFloatMachineEpsilon()
        {
            float epsilon = 1f;
            float value = 1f;
            while (value + 1f > 1f)
            {
                value /= 2;
                if (value != 0)
                {
                    epsilon = value;
                }
            }

            return epsilon;
        }

        private static double GetDoubleMachineEpsilon()
        {

            double epsilon = 1d;
            double value = 1d;
            while (value + 1d > 1d)
            {
                value /= 2d;
                if (value != 0)
                {
                    epsilon = value;
                }
            }

            return epsilon;
        }


        private static float GetFloatMachineInfinity()
        {
            float infinity = 1f;
            float value = 1f;
            while (!float.IsInfinity(value))
            {
                infinity = value;
                value *= 2;
            }

            return infinity;
        }


        private static double GetDoubleMachineInfinity()
        {
            double infinity = 1d;
            double value = 1d;
            while (!double.IsInfinity(value))
            {
                infinity = value;
                value *= 2;
            }

            return infinity;
        }


        private static double GetDoubleMachineZero()
        {

            double zero = 0.1d;
            double value = 0.1d;
            while (value != 0)
            {
               
                if ((value / 2) <= 0d)
                {
                    zero = value;
                }
                value /= 2;
            }


            return zero;
        } 
        
        private static double GeFloatMachineZero()
        {

            float zero = 0.1f;
            float value = 0.1f;

            while (value != 0f)
            {
               
                if ((value / 2) <= 0f)
                {
                    zero = value;
                }
                value /= 2;
            }


            return zero;
        }



    }
}
