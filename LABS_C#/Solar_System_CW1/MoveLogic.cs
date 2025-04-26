using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar_System_CW1
{
    internal class MoveLogic
    {
        public static void UpdatePosition(Tbody body, double globalSpeed)
        {
            body.angle = body.speed * globalSpeed;

            body.currentPos.x = body.rotationCenter.x + body.radius * Math.Cos(body.angle);
            body.currentPos.y = body.rotationCenter.y + body.radius * Math.Sin(body.angle);

            foreach (var satellite in body.satelliteList)
                UpdatePosition(satellite, globalSpeed);
        }
    }
}
