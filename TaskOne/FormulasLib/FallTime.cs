using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormulasLib
{
    /// Обчислення математичної формули
    public class FallTime
    {
        /// <summary>
        /// Метод для обчислення часу падіння цеглини (у секундах) 
        /// </summary>
        /// <param name="h">Висота будинку (у метрах)</param>
        /// <returns>Повератє час падіння цеглини (у секундах)</returns>

        public static double GetBrickFallTime(double h)
        {
            double g = 9.8;
            return Math.Sqrt(2 * h / g);
        }
    }
}