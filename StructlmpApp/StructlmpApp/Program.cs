using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructlmpApp
{
    interface IVector
    {
        void Insert(int n);
        void ScalarSum(int n);
        void PrintVector();
    }

    struct Vector : IVector
    {
        private int[] v;
        private int index, size;
        public Vector(int size)
        {
            v = new int[size];
            this.size = size;
            index = 0;
        }
        public void Insert(int n)
        {
            if (index >= size)
                Console.WriteLine("Error :  arrayoverflow");
            else v[index++] = n;
        }
        public void ScalarSum(int n)
        {
            for(int i=0; i<index; i++)
                v[i] += n;
        }
        public void PrintVector()
        {
            Console.Write("Contents:");
            for (int i = 0; i < index; i++)
                Console.Write(" " + v[i]);
            Console.WriteLine();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Vector v = new Vector(100);

            v.Insert(10);

            v.ScalarSum(10);

            v.PrintVector();
        }
    }
}
