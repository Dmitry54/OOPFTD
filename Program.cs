using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcBox
{
    
    class Calculation
    {
        

        static void Main(string[] args)
        {
            GoldenRatio gr = new GoldenRatio();
            double e = 0.001;
            double a = -2;
            double b = 2;
            double ratio = (-1 + Math.Sqrt(5)) / 2;
            double xmin = 0;
            double xmax = 0;
            xmin = gr.FindMin(a, b, e);
            xmax = gr.FindMax(a, b, e);
            Console.WriteLine(xmin);
            Console.WriteLine(xmax);
            Console.ReadLine();
        }
    }

}
