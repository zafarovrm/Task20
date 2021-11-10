using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{   
    class Program
    {
        delegate double MyDelegate(double radius);
        static void Main(string[] args)
        {
            Console.Write("Радиус=");

            double rad = Convert.ToInt64(Console.ReadLine());
            MyDelegate myDelegate1 = Figures.GetLength;
            if (myDelegate1 != null)
            {                
                double d = myDelegate1(rad);
                Console.WriteLine("D={0}", d);
            }
            MyDelegate myDelegate2 = Figures.GetArea;
            if (myDelegate2 != null)
            {
                double s = myDelegate2(rad);
                Console.WriteLine("S={0}", s);
            }
            MyDelegate myDelegate3 = Figures.GetVolume;
            if (myDelegate3 != null)
            {
                double v = myDelegate3(rad);
                Console.WriteLine("V={0}", v);
            }
            Console.ReadKey();
        }
    }
    class Figures
    {
        public static double GetLength(double radius)
        {
            double length = 2 * Math.PI * radius;
            return length;
        }
        public static double GetArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2.0);
            return area;
        }
        public static double GetVolume(double radius)
        {
            double volume = Math.PI * Math.Pow(radius, 3.0) * 4.0 / 3.0;
            return volume;
        }
    }
}
