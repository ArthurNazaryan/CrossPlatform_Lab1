using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyLib
{
    /// Обчислення математичних функцій
    public class MySin
    {
        /// <summary>
        /// Sin(x)
        /// </summary>
        /// <param name="x">Кут в радіанах - перший аргумент функції Sin</param>
        /// <param name="y">Показник ступеня - другий аргумент функнції Sin</param>
        /// <returns>Повертає значення функції Sin для заданого кута</returns>
        public static double Sin(double x, int n)
        {
            double result = 0;
            for (int i = 0; i < n; i++)
            {
                result = result + (Math.Pow((-1), i) * Math.Pow(x, (2 * i + 1))) / F(2 * i + 1);

            }
            return result;
        }


        static double F(int n)
        {
            double tmp = 1;
            for (int i = 1; i <= n; i++)
            {
                tmp = tmp * i;
            }
            return tmp;
        }
    }
}
