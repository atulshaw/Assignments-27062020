using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter input ");
            while (true)
            {
                double s1 = 0; double s2 = 0; double s3 = 0;               
                string val = Console.ReadLine();
                string[] valarr = val.Split(' ');
                s1 = Convert.ToDouble(valarr[0]); s2 = Convert.ToDouble(valarr[1]); s3 = Convert.ToDouble(valarr[2]);
                if (s2 > s1 && (s3 < s1 || s3 < s2))
                {
                    Console.WriteLine("right-angled");
                }
                else if (s2 == s3 && (s1 < s2 || s1 < s3))
                {
                    Console.WriteLine("isosceles");
                }
                else if (s1 == s2 && s2 == s3)
                {
                    Console.WriteLine("equilateral");
                }
                else if (s1 == s2 && s3 > s2)
                {
                    Console.WriteLine("invalid");
                }
                else
                {
                    Console.WriteLine("notspecial");
                }
               
            }           

        }

    }
}
