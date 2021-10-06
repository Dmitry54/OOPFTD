using System;

class GoldenRatio
{
    static double Func(double x)
    {
        double y = 0;
        y = Math.Pow((x + 1), 3) + 5 * Math.Pow(x, 2);
        return y;
    }
    public double FindMin(double a, double b, double e)
    {
        double xmin = 0;
        double x1 = 0;
        double x2 = 0;
        double f1 = 0;
        double f2 = 0;
        double ratio = (-1 + Math.Sqrt(5)) / 2;
        while (e <= Math.Abs(b - a))
        {
            x1 = a + (1 - ratio) * (b - a);
            x2 = a + ratio * (b - a);
            f1 = Func(x1);
            f2 = Func(x2);
            if (f1 >= f2)
            {
                a = x1;
                xmin = x2;
            }
            else
            {
                b = x2;
                xmin = x1;
            }

        }
        return xmin;
    }
    public double FindMax(double a, double b, double e)
    {
        double xmax = 0;
        double x1 = 0;
        double x2 = 0;
        double f1 = 0;
        double f2 = 0;
        double ratio = (-1 + Math.Sqrt(5)) / 2;
        while (e <= Math.Abs(b - a))
        {
            x1 = a + (1 - ratio) * (b - a);
            x2 = a + ratio * (b - a);
            f1 = Func(x1);
            f2 = Func(x2);
            if (f1 <= f2)
            {
                a = x1;
                xmax = x2;
            }
            else
            {
                b = x2;
                xmax = x1;
            }

        }
        return xmax;
    }
}
