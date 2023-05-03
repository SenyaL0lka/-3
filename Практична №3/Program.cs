using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практична__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y = 0, x = 0, i = 16, h = 0.1 * i, psum = 0 , vid_chis = 0;

            for (x = -(i + 8); x <= i + 8; x += h)
            {
                y = ((2 * Math.Pow(Math.Log(Math.Abs(x - 1.5)), 6)) / (Math.Log(Math.Abs(x - 3.7) + 8, 10)));


                Console.WriteLine($"x = {x} \t y = {y}");
                if (y > 0)
                {
                    psum += y;
                }
                else if (y < 0)
                {
                    vid_chis++;
                }
            }

            Console.WriteLine($"Додатні: {psum}");
            Console.WriteLine($"Від'ємні: {vid_chis}");
        }
    }
}
