using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar_System_CW1
{
    internal class MoveLogic
    {
        public static void UpdateAllPositions(double globalSpeed, Tbody rootBody)
        {
            UpdatePositionRecursive(rootBody, globalSpeed, true);
        }

        private static void UpdatePositionRecursive(Tbody body, double globalSpeed, bool isRoot)
        {
            if (!isRoot && body.speed > 0)
            {
                double angularSpeed = (body.speed / (body.radius)) * globalSpeed * 0.001;
                body.UpdatePosition(angularSpeed);
            }

            foreach (var satellite in body.satelliteList)
            {
                UpdatePositionRecursive(satellite, globalSpeed, false);
            }

            foreach (var satellite in body.satelliteList)
            {
                foreach (var moon in satellite.satelliteList)
                {
                    moon.rotationCenter = satellite.currentPos;
                }
            }
        }
    }
}
