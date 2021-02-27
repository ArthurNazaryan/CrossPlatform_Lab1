using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathProductLib
{
    /// Обчислення добутку
    public class Product
    {
        ///<summary>
        /// Метод для знаходження добутку
        ///</summary>
        ///<param name="n">Натуральне число</param>
        ///<returns>Повертає добуток числового ряду</returns>

        public static double NumberSeriesProduct(int n)
        {
            double product = 1;
            for (int i = 1; i <= n; i++)
            {
                product *= 1 - Math.Pow(2 * i, -1);
            }
            return product;
        }
    }
}
