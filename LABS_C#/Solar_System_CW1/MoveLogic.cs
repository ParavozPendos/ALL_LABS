using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar_System_CW1
{
    internal class MoveLogic
    {
        //private const double G = 6.67430e-11;

        private static void UpdatePosition(Tbody body, double angularSpeed)
        {
            body.angle += angularSpeed;
            body.currentPos = new Coordinate(
                body.rotationCenter.x + body.radius * Math.Cos(body.angle),
                body.rotationCenter.y + body.radius * Math.Sin(body.angle)
            );
        }

        public static void UpdateAllPositions(double globalSpeed)
        {
            foreach(var body in Tbody.AllObjects)
            {
                if (body.speed != 0) 
                {
                    double angularSpeed = (body.speed / (body.radius)) * globalSpeed * 0.001;
                    body.rotationCenter = body.parent.currentPos;
                    UpdatePosition(body, angularSpeed);
                }
            }
        }
    }
}
