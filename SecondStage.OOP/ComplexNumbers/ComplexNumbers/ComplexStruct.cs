using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    struct Complex
    {
        private double x;
        private double y;
        public Complex(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public string GetValue()
        {
            if (y > 0)
            {

                return (x != 0) ? $"{x} + {y}i" : $"{y}i";
            }
            else if (y < 0)
            {
                return (x != 0) ? $"{x} - {y * (-1)}i" : $"{y}i";
            }
            else
            {
                return $"{x}";
            }
        }
        public void SetValue(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Complex Plus(Complex a, Complex b)
        {
            return new Complex(a.x + b.x, a.y + b.y);
        }
        public Complex Minus(Complex a, Complex b)
        {
            return new Complex(a.x - b.x, a.y - b.y);
        }

        public Complex Multiplication(Complex a, Complex b)
        {
            return new Complex(a.x * b.x - a.y * b.y, a.x * b.y + a.y * b.x);
        }
        public Complex Division(Complex a, Complex b)
        {
            return new Complex((a.x * b.x + a.y * b.y) / (Math.Pow(b.x, 2) + Math.Pow(b.y, 2)),
                (a.y * b.x - a.x * b.y) / (Math.Pow(b.x, 2) + Math.Pow(b.y, 2)));
        }
        public Complex Absalute(Complex a)
        {
            return new Complex(Math.Pow((Math.Pow(a.x, 2) + Math.Pow(a.y, 2)), 0.5), 0);
        }
    }

}
