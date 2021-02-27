using System;

namespace ConsoleFallTime
{
    class Program
    {
        /// <summary>
        /// Виклик бібліотечнога метода GetBrickFallTime(h) з FallTime.dll
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть висоту будинку h у метрах");
            double h = double.Parse(Console.ReadLine());
            double FallTime = FormulasLib.FallTime.GetBrickFallTime(h);
            Console.WriteLine("Час падіння цеглини t (у секундах): {0}", FallTime);
        }
    }
}