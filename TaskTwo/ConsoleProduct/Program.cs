using System;

namespace ConsoleProduct
{

    class Program
    {
        /// <summary>
        /// Виклик бібліотечнога метода NumberSeriesProduct(n) з MathProductLib.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть натуральне число n");
            int n = Int32.Parse(Console.ReadLine());
            double product = MathProductLib.Product.NumberSeriesProduct(n);
            Console.WriteLine("Добуток: {0}", product);
        }
    }
}
