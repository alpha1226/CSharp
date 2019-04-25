using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0425_Interface01
{

    //public int height;
    //public int width;

    interface Irectangle
    {
        void Area(int width, int height);
    }
    interface Itriangle
    {
        void Area(int width, int height);
    }
    class Shape : Irectangle, Itriangle
    {
        void Irectangle.Area(int width, int height)
        {
            Console.WriteLine("Rect Area : " + (width * height));
        }
        void Itriangle.Area(int width, int height)
        {
            Console.WriteLine("Triangle Area : " + (width * height)/2);
        }
    }
    static class Program
    {
        public static void Main()
        {
            Shape s = new Shape();
            ((Irectangle)s).Area(20, 20);
            ((Itriangle)s).Area(20, 20);
            Irectangle r = s;
            Itriangle t = s;
            r.Area(30, 30);
            t.Area(30, 30);
        }
    }
}
