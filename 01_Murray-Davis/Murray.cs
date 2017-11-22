using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Murray_Davis
{
    static class Murray
    {
        //static double solid;
        //static double raster;

        static public double Density(double dotsol, double dotras)
        {
            if (dotras == 0) return 0;
            if (dotsol < dotras) return 0; // заглушка для исключения

            return 100 * ((1 - Math.Pow(10, -dotras)) / (1 - Math.Pow(10, -dotsol)));
        }


    }
}
