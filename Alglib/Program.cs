using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Alglib
{
    class Program
    {
        static void Main(string[] args)
        {
            //double[] x = new double[6] { 0, 1, 3, 6, 8, 10 };
            //double[] y = new double[6] { 0, 5, 8, 10, 15, 30 };

            double[][] h = new double[2][];

            h[0] = new double[6] { 0, 1, 3, 6, 8, 10 };
            h[1] = new double[6] { 0, 5, 8, 10, 15, 30 };

            alglib.spline1dinterpolant s;




            alglib.spline1dbuildlinear(h[0], h[1], out s);

            for (int i = 0; i <= 10; i++)
            {


            }

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Значение х - {i}   Значение y - {alglib.spline1dcalc(s, i)}");
            }


           






            Console.ReadKey();
        }
    }
}
