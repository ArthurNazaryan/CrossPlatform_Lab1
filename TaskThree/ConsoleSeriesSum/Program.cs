using System;

namespace ConsoleSeriesSum
{

    class Program
    {
        /// <summary>
        /// Виклик бібліотечних методів Sum, ExactFuncVal, CalcInaccuracy з SeriesSum.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть z");
            double z = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введіть n (верхню межу суми)");
            int n = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введіть точність Епсилон");
            double eps = Double.Parse(Console.ReadLine());
            double sum = SeriesSumLib.SeriesSum.Sum(z, n, eps);
            double exactVal = SeriesSumLib.SeriesSum.ExactFuncVal(z);
            double t = SeriesSumLib.SeriesSum.CalcInaccuracy(sum, exactVal);
            Console.WriteLine();
            Console.WriteLine("Сума ряду: {0}", sum);
            Console.WriteLine("Точне значення функції для x: {0}", exactVal);
            Console.WriteLine("Помилка обчислень: {0}", t);
        }
    }
}
