using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar_System_CW1
{
    internal class Coordinate
    {
        public double x, y;
        public Coordinate()
        {
            x = 0;
            y = 0;
        }
        public Coordinate(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //Перегрузки операторов
        public static Coordinate operator +(Coordinate a, Coordinate b)
        {
            return new Coordinate(a.x + b.x, a.y + b.y);
        }
        public static Coordinate operator -(Coordinate a, Coordinate b)
        {
            return new Coordinate(a.x - b.x, a.y - b.y);
        }
        public static Coordinate operator *(Coordinate a, double scalar)
        {
            return new Coordinate(a.x * scalar, a.y * scalar);
        }
        public static Coordinate operator /(Coordinate a, double scalar)
        {
            return new Coordinate(a.x / scalar, a.y / scalar);
        }
    }
}
