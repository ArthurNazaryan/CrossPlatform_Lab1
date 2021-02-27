using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeriesSumLib
{
    /// Обчислення суми ряду
    public class SeriesSum
    {
        /// <summary>
        /// Метод для обчислення суми ряду
        /// </summary>
        /// <param name="z">Аргумент функції(змінна)</param>
        /// <param name="n">Верхня межа суми ряду</param>
        /// <param name="eps">Точність Епсилон</param>
        /// <returns>Повертає суму ряду</returns>
        public static double Sum(double z, int n, double eps)
        {
            double sum = 0;

            for (int i = 0; i <= n; i++)
            {
                sum += (2 * i + 1) / F(i) * Math.Pow(z, 2 * i);
                if (Math.Abs(sum) < eps)
                {
                    break;
                }
            }

            return sum;
        }

        /// <summary>
        /// Метод для знаходження факторіалу числа
        /// </summary>
        /// <param name="n">Число, факторіал якого потрібно обчислити</param>
        /// <returns>Повертає факторіал числа n</returns>
        static double F(int n)
        {
            double tmp = 1;
            for (int i = 1; i <= n; i++)
            {
                tmp *= i;
            }
            return tmp;
        }

        /// <summary>
        /// Метод для обчислення точного значення функції для x
        /// </summary>
        /// <param name="z">Аргумент функції(змінна)</param>
        /// <returns>Повертає точне значення функції для x</returns>
        public static double ExactFuncVal(double z)
        {
            return (1 - 2 * Math.Pow(z, 2)) * Math.Exp(Math.Pow(z, 2));
        }

        /// <summary>
        /// Метод для підрахування помилок обчислень (t)
        /// </summary>
        /// <param name="sum">Сума ряду</param>
        /// <param name="exactVal">Точне значення функції для x</param>
        /// <returns>Повертає помилку обчислень</returns>
        public static double CalcInaccuracy(double sum, double exactVal)
        {
            double t = Math.Abs(sum - exactVal) / exactVal * 1;
            return t;
        }
    }
}
