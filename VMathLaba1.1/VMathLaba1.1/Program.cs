using System;

namespace VMathLaba1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Машинный эпсилон для типа float, полученный при расчетах: ");
            PrintColoredText(string.Format("{0}", GetFloatMachineEpsilon()), ConsoleColor.Cyan);

            Console.Write("\nМашинный ноль для типа float в C#: ");
            PrintColoredText(string.Format("{0}\n", float.Epsilon), ConsoleColor.Cyan);

            Console.Write("\nМашинный эпсилон для типа double, полученный при расчетах: ");
            PrintColoredText(string.Format("{0}", GetDoubleMachineEpsilon()), ConsoleColor.Cyan);

            Console.Write("\nМашинный ноль для типа double в C#: ");
            PrintColoredText(string.Format("{0}\n", double.Epsilon), ConsoleColor.Cyan);

            Console.Write("\nМашинная бесконечность для типа float равна: ");
            PrintColoredText(string.Format("{0}\n", GetFloatMachineInfinity()), ConsoleColor.Cyan);

            Console.Write("\nМашинная бесконечность для типа double: ");
            PrintColoredText(string.Format("{0}", GetDoubleMachineInfinity()), ConsoleColor.Cyan);
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
            float epsilon = 1.0f;
            float value = 1.0f;
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

            double epsilon = 1.0d;
            double value = 1.0d;
            while (value + 1d > 1d)
            {
                value /= 2;
                if (value != 0)
                {
                    epsilon = value;
                }
            }

            return epsilon;
        }


        private static float GetFloatMachineInfinity()
        {
            float infinity = 0.1f;
            float value = 0.1f;
            while (true)
            {
                value *= 2;

                if (value == float.PositiveInfinity) break;

                infinity = value;
            }

            return infinity;
        }




        private static double GetDoubleMachineInfinity()
        {
            double infinity = 0.1d;
            double value = 0.1d;
            while (true)
            {
                value *= 2;

                if (value == double.PositiveInfinity) break;

                infinity = value;
            }

            return infinity;
        }
    }
}
