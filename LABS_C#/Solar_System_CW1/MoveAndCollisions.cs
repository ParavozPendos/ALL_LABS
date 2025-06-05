using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solar_System_CW1
{
    internal class MoveAndCollisions
    {
        public static void UpdateBodyPosition(Tbody body, double globalSpeed)
        {
            body.rotationCenter = body.parent.currentPos;
            double angularSpeed = (body.speed / body.radius) * globalSpeed * 0.001;
            body.angle += angularSpeed;

            body.currentPos = new Coordinate(
                body.rotationCenter.x + body.radius * Math.Cos(body.angle),
                body.rotationCenter.y + body.radius * Math.Sin(body.angle)
            );
        }

        public static void UpdateAllPositions(double globalSpeed)
        { 
            foreach (var body in Tbody.AllObjects)
            {
                if (body.parent != null)
                {
                    UpdateBodyPosition(body, globalSpeed);
                }
            }
        }

        public static bool CheckCollision(Tbody body1, Tbody body2)
        {
            double dx = body1.currentPos.x - body2.currentPos.x;
            double dy = body1.currentPos.y - body2.currentPos.y;
            double distance = Math.Sqrt(dx * dx + dy * dy);
            double sizeSum = body1.size + body2.size;

            if (distance <= sizeSum)
            {
                Tbody.Deleter(body1);
                Tbody.Deleter(body2);
                return true;
            }
            else return false;
        }

        public static void CheckAllCollisions()
        {
            var objectsCopy = new List<Tbody>(Tbody.AllObjects);
            for (int i = 0; i < objectsCopy.Count; i++)
            {
                Tbody body1 = objectsCopy[i];
                if (body1.name == "Sun") continue;

                for (int j = i + 1; j < objectsCopy.Count; j++)
                {
                    Tbody body2 = objectsCopy[j];
                    if (body2.name == "Sun") continue;
                    if (CheckCollision(body1, body2)) break; 
                }
            }
        }
    }
}
