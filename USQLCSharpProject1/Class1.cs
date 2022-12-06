using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace USQLCSharpProject1
{
    public class Class1
    {
        public double Sec(double x)
        {
            x = Double.Parse(Console.ReadLine());
            x = 1 / Math.Cos(x);
            return x;
        }
    }
}