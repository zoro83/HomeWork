using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondStage.OOP.Operator01
{
    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public static Point operator +(Point LeftPoint, Point rightPoint) //Addition
        {
            return new Point()
            {
                X = LeftPoint.X + rightPoint.X,
                Y = LeftPoint.Y + rightPoint.Y
            };
        }
        public static Point operator +(Point pnt, double num) //Addition
        {
            return new Point()
            {
                X = pnt.X + num,
                Y = pnt.Y + num
            };
        }
        public static Point operator -(Point LeftPoint, Point rightPoint) //Subtraction
        {
            return new Point()
            {
                X = LeftPoint.X - rightPoint.X,
                Y = LeftPoint.Y - rightPoint.Y
            };
        }
        public static Point operator -(Point pnt, double num) //Subtraction
        {
            return new Point()
            {
                X = pnt.X - num,
                Y = pnt.Y - num
            };
        }
        public static Point operator *(Point LeftPoint, Point rightPoint) //Multiplication
        {
            return new Point() //a.x * b.x - a.y * b.y, a.x * b.y + a.y * b.x
            {
                X = LeftPoint.X * rightPoint.X - LeftPoint.Y * rightPoint.Y,
                Y = LeftPoint.X * rightPoint.Y + LeftPoint.Y * rightPoint.X
            };
        }
        public static Point operator /(Point LeftPoint, Point rightPoint) //Division
        {
            return new Point() //((a.x * b.x + a.y * b.y) / (Math.Pow(b.x, 2) + Math.Pow(b.y, 2)),
                //(a.y * b.x - a.x * b.y) / (Math.Pow(b.x, 2) + Math.Pow(b.y, 2)))
            {
                X = (LeftPoint.X * rightPoint.X + LeftPoint.Y * rightPoint.Y)/ 
                (Math.Pow(rightPoint.X, 2) + Math.Pow(rightPoint.Y, 2)),
                Y = (LeftPoint.Y * rightPoint.X - LeftPoint.X * rightPoint.Y) / 
                (Math.Pow(rightPoint.X, 2) + Math.Pow(rightPoint.Y, 2))
            };
        }
        public static bool operator ==(Point LeftPoint, Point rightPoint) //Equal to
        {
            if (LeftPoint.X == rightPoint.X && LeftPoint.Y == rightPoint.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Point LeftPoint, Point rightPoint) //Not equal to
            => !(LeftPoint == rightPoint);

        public static Point operator ++(Point pnt) //Increment
        => pnt + 1;

        public static Point operator --(Point pnt) //Decrement
        => pnt - 1;

        public double ABS(Point pnt) // Return Point`s Absalute value 
        {
        return Math.Pow((Math.Pow(pnt.X, 2) + Math.Pow(pnt.Y, 2)), 0.5);
        }

        public static bool operator >(Point LeftPoint, Point rightPoint) //Greater than
        {
            if (Math.Pow((Math.Pow(LeftPoint.X, 2) + Math.Pow(LeftPoint.Y, 2)), 0.5) >
                Math.Pow((Math.Pow(rightPoint.X, 2) + Math.Pow(rightPoint.Y, 2)), 0.5))
                return true;
            else return false;
        }
        public static bool operator <(Point LeftPoint, Point rightPoint) //Less than
        => !(LeftPoint > rightPoint);

        public static bool operator >=(Point LeftPoint, Point rightPoint) //Greater than or equal to
        => (LeftPoint.ABS(LeftPoint) >= rightPoint.ABS(rightPoint));

        public static bool operator <=(Point LeftPoint, Point rightPoint) //Less than or equal to
        => (LeftPoint.ABS(LeftPoint) <= rightPoint.ABS(rightPoint));

    }
}
