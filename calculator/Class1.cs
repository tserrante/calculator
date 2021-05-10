using System;
using System.Collections.Generic;
using System.Text;


namespace calculator
{
    class Operators
    {
        public static int Add(int n1, int n2)
        { return n1 + n2; }

        public static double Add(double n1, double n2)
        { return n1 + n2; }

        public static int Sub(int n1, int n2)
        { return n1 - n2; }

        public static double Sub(double n1, double n2)
        { return n1 - n2; }

        public static int Mult(int n1, int n2)
        { return n1 * n2; }

        public static double Mult(double n1, double n2)
        { return n1 * n2; }
        
        public static int Div(int n1, int n2)
        {   
                return n1 / n2;
        }

        public static double Div(double n1, double n2)
        {
                return n1 / n2;
        }
        
        public static int Sqrt(int n1)
        { return (int) Math.Sqrt(n1); }

        public static double Sqrt(double n1)
        { return Math.Sqrt(n1); }

        public static int nrt(int n1, int n2)
        { return (int)Math.Pow(n1, 1/n2); }

        public static double nrt(double n1, double n2)
        { return Math.Pow(n1, 1/n2); }

        public static int Sq(int n1)
        { return (int)Math.Pow(n1, 2); }

        public static double Sq(double n1)
        { return Math.Pow(n1, 2); }

        public static int x_n(int n1, int n2)
        { return (int)Math.Pow(n1, n2); }
        
        public static double x_n(double n1, double n2)
        { return Math.Pow(n1, n2); }
    }
}
