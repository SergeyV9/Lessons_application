using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_number
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] mas_y = { 1.9, 2.8, 3, 4.9, -1.1, 5.5, 6.1, 7, 8, 9, 0 };
            double[] mas_x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            double sh = 4.8;

            double x = SearchNamber.Search(mas_x, mas_y, sh);


            //double temp = 0, t = double.MaxValue;
            //for (int i = 0; i < mas.Length; i++)
            //{
            //    double a = Math.Abs(mas[i] - R);
            //    if (a < t)
            //    {
            //        temp = mas[i];
            //        t = a;
            //    }
            //}

            Console.WriteLine($"x = {x} искомый y = {sh}");

            Console.ReadKey();

        }


        static class SearchNamber
        {

            static public double Search(double[] search_x, double[] search_y, double x)
            {
                double a, rezalt = 0, t = double.MaxValue;

                if (search_x.Length == search_y.Length)
                {
                    for (int i = 0; i < search_y.Length; i++)
                    {
                        a = Math.Abs(search_y[i] - x);
                        if (a < t)
                        {
                            rezalt = search_x[i];
                            t = a;
                        }
                        else break;
                    }
                }

                return rezalt;
            }

        }


    }
}
