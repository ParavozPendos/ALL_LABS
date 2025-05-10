using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solar_System_CW1
{
    internal class Tbody
    {
        public static List<Tbody> AllObjects = new List<Tbody>();

        public Tbody(
            string name,
            string description,
            Coordinate currentPos,
            Coordinate rotationCenter,
            double radius,
            double speed,
            double size,
            Brush color,

            double angle = 0
        )
        {
            this.name = name;
            this.description = description;
            this.currentPos = currentPos;
            this.rotationCenter = rotationCenter;
            this.radius = radius;
            this.speed = speed;
            this.size = size;
            this.color = color;
            this.angle = angle;

            AllObjects.Add(this);
        }

        public string name { get; set; }
        public string description { get; set; }
        public Coordinate currentPos { get; set; }
        public Coordinate rotationCenter { get; set; }
        public double radius { get; set; }
        public double speed { get; set; }
        public double size { get; set; }
        public Brush color { get; set; }
        public double angle { get; set; }

        public List<Tbody> satelliteList = new List<Tbody>();

        public void AddSatellite(params Tbody[] satellites)
        {
            satelliteList.AddRange(satellites);
        }
        public void UpdatePosition(double angularSpeed)
        {
            angle += angularSpeed;
            currentPos = new Coordinate(
                rotationCenter.x + radius * Math.Cos(angle),
                rotationCenter.y + radius * Math.Sin(angle)
            );
        }
        public bool IsPointOnBody(Coordinate point, double currentScale)
        {

            // Проверяем попадание в круг
            double dx = point.x - currentPos.x;
            double dy = point.y - currentPos.y;
            return dx * dx + dy * dy <= size * size;
        }
    }
}
