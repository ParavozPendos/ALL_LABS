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
        public Tbody(
            Coordinate currentPos,
            Coordinate rotationCenter,
            double radius,
            double speed,
            double size,
            Brush color,

            double angle = 0
        )
        {
            this.currentPos = currentPos;
            this.rotationCenter = rotationCenter;
            this.radius = radius;
            this.speed = speed;
            this.size = size;
            this.color = color;
            this.angle = angle;
        }

        public Coordinate currentPos { get; set; }
        public Coordinate rotationCenter { get; set; }
        public double radius { get; set; }
        public double speed { get; set; }
        public double size { get; set; }
        public Brush color { get; set; }
        public List<Tbody> satelliteList = new List<Tbody>();

        public double angle { get; set; }
        public void AddSatellite(params Tbody[] satellites)
        {
            satelliteList.AddRange(satellites);
        }
    }
}
