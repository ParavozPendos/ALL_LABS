using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solar_System_CW1
{
	public partial class Form1 : Form
	{
		
		public Form1()
		{
			InitializeComponent();

			//Солнце
			Tbody Sun = new Tbody(
				currentPos: new Coordinate(),
				rotationCenter: new Coordinate(),
				radius: 0,
				speed: 0,
				size: 10,
				color: Brushes.Yellow
			);

			//Земля
			Tbody Earth = new Tbody(
                currentPos: new Coordinate(150, 0),
                rotationCenter: Sun.currentPos,
                radius: 150,
                speed: 0.1,
                size: 6,
                color: Brushes.Green
			);

            //Марс
            Tbody Mars = new Tbody(
                currentPos: new Coordinate(228, 0),
                rotationCenter: Sun.currentPos,
                radius: 228,
                speed: 0.053,
                size: 4,
                color: Brushes.Red
            );

			//Венера
			Tbody Venus = new Tbody(
				currentPos: new Coordinate(108, 0),
				rotationCenter: Sun.currentPos,
				radius: 108,
				speed: 0.416,
				size: 5,
				color: Brushes.OrangeRed
			);

			//Меркурий
			Tbody Mercury = new Tbody(
				currentPos: new Coordinate(58, 0),
				rotationCenter: Sun.currentPos,
				radius: 58,
				speed: 0.416,
				size: 3,
				color: Brushes.RosyBrown
			);

			//Луна
			Tbody Moon = new Tbody(
				currentPos: new Coordinate(Earth.currentPos.x + 15, 0),
				rotationCenter: Earth.currentPos,
				radius: 15,
				speed: 1.3,
				size: 2,
				color: Brushes.WhiteSmoke
			);

			//Фобос
			Tbody Phobos = new Tbody(
				currentPos: new Coordinate(Mars.currentPos.x + 7, 0),
				rotationCenter: Mars.currentPos,
				radius: 7,
				speed: 114.4,
				size: 1,
				color: Brushes.DarkGray
			);

			//Деймос
			Tbody Deimos = new Tbody(
				currentPos: new Coordinate(Mars.currentPos.x + 12, 0),
				rotationCenter: Mars.currentPos,
				radius: 12,
				speed: 30.4,
				size: 1,
				color: Brushes.LightPink
			);

			//Запись списка спутников
			Sun.AddSatellite(Earth, Mars, Venus, Mercury);
			Earth.AddSatellite(Moon);
			Mars.AddSatellite(Phobos, Deimos);
        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
