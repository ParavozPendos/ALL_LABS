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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Solar_System_CW1
{
	public partial class MainForm : Form
	{
		private Graphics graphics;
		private Coordinate systemCenter = new Coordinate();
		private Coordinate lastMousePos = new Coordinate();
		private double globalSpeed;
		private double scale;
		private int fps = 144;
		private int generation = 0;
		private bool isDragging = false;
		private bool isSimulationStated = false;
		
		private Tbody Sun;
		private Tbody Earth;
		private Tbody Mars;
		private Tbody Venus;
		private Tbody Mercury;
		private Tbody Moon;
		private Tbody Phobos;
		private Tbody Deimos;

		private Tbody selectedBody = null;

		private void InitializeSolarSystem()
		{
			//Солнце
			Sun = new Tbody(
				description: 
				"Центральная звезда нашей планетарной системы, вокруг которой вращаются все остальные объекты. " +
				"Представляет собой огромный раскалённый плазменный шар, излучающий свет и энергию. " +
				"Играет ключевую роль в поддержании жизни на Земле, определяя климат и погодные условия. " +
				"В древних культурах почиталось как божество. Современная наука изучает солнечную активность и её влияние на космическую погоду.",

                name: "Sun",
				currentPos: new Coordinate(),
				rotationCenter: new Coordinate(),
				radius: 0,
				speed: 0,
				size: 10,
				color: Brushes.Yellow
			);

			//Земля
			Earth = new Tbody(
				description: 
				"Уникальная голубая планета, единственная известная науке, где существует жизнь. " +
				"Отличается наличием больших запасов жидкой воды и кислородной атмосферы. " +
				"Имеет сложную геологическую структуру с подвижными тектоническими плитами. " +
				"Естественный спутник - Луна - оказывает значительное влияние на приливы и отливы. " +
				"На поверхности сочетаются океаны, материки и разнообразные экосистемы.",

                name: "Earth",
				currentPos: new Coordinate(150, 0),
				rotationCenter: Sun.currentPos,
				radius: 150,
				speed: 0.1,
				size: 6,
				color: Brushes.Green
			);

			//Марс
			Mars = new Tbody(
				description:
				"Красноватая планета, получившая своё название в честь римского бога войны. " +
				"Поверхность покрыта кратерами, вулканами и каньонами, включая гигантскую систему долин Маринер. " +
				"Атмосфера разрежена и непригодна для дыхания. В прошлом, вероятно, имела реки и озёра. " +
				"Интерес учёных вызывает возможное наличие примитивной жизни в прошлом или настоящем. " +
				"Имеет два небольших спутника неправильной формы.",

				name: "Mars",
				currentPos: new Coordinate(228, 0),
				rotationCenter: Sun.currentPos,
				radius: 228,
				speed: 0.053,
				size: 4,
				color: Brushes.Red
			);

			//Венера
			Venus = new Tbody(
				description: 
				"Ярчайший объект на ночном небе после Луны, названный в честь богини любви. " +
				"Покрыта плотным слоем облаков, создающих сильный парниковый эффект. " +
				"Поверхность скрыта от наблюдения, но радиолокационные исследования выявили многочисленные вулканы и лавовые равнины. " +
				"Вращается в обратном направлении по сравнению с другими планетами. " +
				"Атмосферное давление у поверхности чрезвычайно высокое.",

				name: "Venus",
				currentPos: new Coordinate(108, 0),
				rotationCenter: Sun.currentPos,
				radius: 108,
				speed: 0.416,
				size: 5,
				color: Brushes.OrangeRed
			);

			//Меркурий
			Mercury = new Tbody(
                description:
                "Самая маленькая и ближайшая к Солнцу планета системы. " +
				"Характеризуется крайне разреженной газовой оболочкой. " +
				"Поверхность испещрена многочисленными ударными кратерами, напоминающими лунный ландшафт. " +
				"Имеет крупное железное ядро, составляющее значительную часть её объёма. " +
				"Из-за близости к светилу наблюдать его с Земли можно только на рассвете или закате. " +
				"Совершает сложное движение по орбите.",

                name: "Mercury",
				currentPos: new Coordinate(58, 0),
				rotationCenter: Sun.currentPos,
				radius: 58,
				speed: 0.416,
				size: 3,
				color: Brushes.RosyBrown
			);

			//Луна
			Moon = new Tbody(
                description:
                "Единственный естественный спутник Земли, оказывающий существенное влияние на нашу планету. " +
				"Поверхность состоит из светлых материковых и тёмных морских участков, образованных древними лавовыми потоками. " +
				"Отсутствие атмосферы приводит к резким перепадам между дневными и ночными температурами. " +
				"Является самым изученным внеземным телом, на которое высаживались люди. " +
				"Приливы, вызываемые её гравитацией, важны для земных экосистем.",

                name: "Moon",
				currentPos: new Coordinate(Earth.currentPos.x + 15, 0),
				rotationCenter: Earth.currentPos,
				radius: 15,
				speed: 1.3,
				size: 2,
				color: Brushes.WhiteSmoke
			);

			//Фобос
			Phobos = new Tbody(
				description:
                "Больший из двух марсианских спутников, названный в честь мифологического персонажа, олицетворявшего страх. " +
				"Имеет неправильную форму с многочисленными кратерами и бороздами. " +
				"Орбита расположена экстремально близко к поверхности Марса. " +
				"Постепенно приближается к планете под действием приливных сил. " +
				"Поверхность покрыта толстым слоем реголита. " +
				"Предполагается, что может быть захваченным астероидом.",

				name: "Phobos",
				currentPos: new Coordinate(Mars.currentPos.x + 7, 0),
				rotationCenter: Mars.currentPos,
				radius: 7,
				speed: 114.4,
				size: 1,
				color: Brushes.DarkGray
			);

			//Деймос
			Deimos = new Tbody(
				description:
                "Меньший спутник Марса, получивший имя мифологического бога ужаса. " +
				"Отличается более гладкой поверхностью по сравнению с Фобосом, так как большинство кратеров засыпаны рыхлым материалом. " +
				"Орбита постепенно удаляется от Марса. Имеет вытянутую форму с относительно ровными очертаниями. " +
				"Как и Фобос, вероятно, является захваченным астероидом. " +
				"Поверхность выглядит более однородной из-за толстого слоя пыли.",

				name: "Deimos",
				currentPos: new Coordinate(Mars.currentPos.x + 12, 0),
				rotationCenter: Mars.currentPos,
				radius: 12,
				speed: 30.4,
				size: 1,
				color: Brushes.Pink
			);

			//Запись списка спутников
			Sun.AddSatellite(Earth, Mars, Venus, Mercury);
			Earth.AddSatellite(Moon);
			Mars.AddSatellite(Phobos, Deimos);
		}
		
		public MainForm()
		{
			InitializeComponent();
			InitializeSolarSystem();
			globalSpeed = hsbSpeed.Value;
			scale = hsbApprox.Value;
			timer.Interval = 1000 / fps;

			pictureBox.MouseWheel += PictureBox_MouseWheel;
			
		}

		private void PictureBox_MouseWheel(object sender, MouseEventArgs e)
		{
			int change = hsbApprox.LargeChange;
			int newValue = hsbApprox.Value + (e.Delta > 0 ? change : -change);

			if (newValue < hsbApprox.Minimum)
				hsbApprox.Value = hsbApprox.Minimum;
			else if (newValue > hsbApprox.Maximum)
				hsbApprox.Value = hsbApprox.Maximum;
			else hsbApprox.Value = newValue;
		}
		private void MainForm_Load(object sender, EventArgs e) { }
		private void StartSimulation()
		{
			isSimulationStated = true;
			pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
			graphics = Graphics.FromImage(pictureBox.Image);
			timer.Start();
		}
		private void StopSimulation()
		{
			if (globalSpeed != 0)
			{
				globalSpeed = 0;
				bStop.Text = "Continue";
				bStop.BackColor = Color.LightGreen;
			}
			else
			{
				globalSpeed = hsbSpeed.Value;
				bStop.Text = "Stop";
				bStop.BackColor= Color.Yellow;
			}
		}
		private void DrawSimulation()
		{
			//UI
			labelGeneration.Text = $"Generation: {generation}";
			labelSpeed.Text = $"Speed: {globalSpeed}";
			labelApprox.Text = $"Approx: {scale}x";
			
			

            //pictuteBox
            graphics.Clear(Color.Black);

			Coordinate center = new Coordinate(
				pictureBox.Width / 2.0 - systemCenter.x * scale,
				pictureBox.Height / 2.0 - systemCenter.y * scale
			);

			//Цикл отрисовки объектов
			foreach (var body in Tbody.AllObjects)
			{
				Coordinate screenPos = center + (body.currentPos * scale);
				double radius = body.size * scale;

				//Рисуем орбиты
				Coordinate orbitCenter = center + (body.rotationCenter * scale);
				double orbitRadius = body.radius * scale;

				graphics.DrawEllipse(
					Pens.DarkGray,
					(float)(orbitCenter.x - orbitRadius),
					(float)(orbitCenter.y - orbitRadius),
					(float)(orbitRadius * 2),
					(float)(orbitRadius * 2)
				);

				//Рисуем объекты 
				graphics.FillEllipse(
					body.color,
					(float)(screenPos.x - radius),
					(float)(screenPos.y - radius),
					(float)radius * 2,
					(float)radius * 2
				);
			}

			//Цикл отрисовки надписей
			foreach (var body in Tbody.AllObjects)
			{
				//Рисуем подпись и ореол выбранного тела
				if (selectedBody == body)
				{
                    Coordinate screenPos = center + (body.currentPos * scale);
                    double radius = body.size * scale;

                    string info = $"{selectedBody.name} ({selectedBody.currentPos.x:F2} : {selectedBody.currentPos.y:F2})";
					Font font = new Font("Arial", 14);
					SizeF textSize = graphics.MeasureString(info, font);


					// Рисуем задник для текста
					var selectedInfoBox = new List<Coordinate>
					{
						new Coordinate(screenPos.x + 15, screenPos.y - radius - textSize.Height - 5),
						new Coordinate(textSize.Width + 5, textSize.Height + 3)
					};

					graphics.FillRectangle(
						Brushes.DarkGray,
						(float)(selectedInfoBox[0].x),
						(float)(selectedInfoBox[0].y),
                        (float)(selectedInfoBox[1].x),
                        (float)(selectedInfoBox[1].y)
                    );

					graphics.DrawRectangle(
                        new Pen(selectedBody.color, 2),
                        (float)(selectedInfoBox[0].x - 1),
                        (float)(selectedInfoBox[0].y - 1),
                        (float)(selectedInfoBox[1].x + 1),
                        (float)(selectedInfoBox[1].y + 1)
                        );

					// Рисуем текст
					graphics.DrawString(info, font, Brushes.Black,
						(float)(screenPos.x + 20),
						(float)(screenPos.y - radius - textSize.Height - 5)
					);

					// Рисуем ореол
					graphics.DrawEllipse(
						new Pen(Color.White, 2),
						(float)(screenPos.x - radius - 3),
						(float)(screenPos.y - radius - 3),
						(float)(radius + 3) * 2,
						(float)(radius + 3) * 2
					);

					// Рисуем горизонтальную координатную линию 
					graphics.DrawLine(new Pen(Color.Blue, 1)
					{
						DashStyle = System.Drawing.Drawing2D.DashStyle.Dash,
						DashPattern = new float[] { 1, 1 }
					},

						(float)(0),
						(float)(screenPos.y),
						(float)(pictureBox.Width),
						(float)(screenPos.y)
					);

					// Рисуем вертикальную координатную линию 
					graphics.DrawLine(new Pen(Color.Blue, 2)
					{
						DashStyle = System.Drawing.Drawing2D.DashStyle.Dash,
						DashPattern = new float[] { 1, 1 }
					},
						(float)(screenPos.x),
						(float)(0),
						(float)(screenPos.x),
						(float)(pictureBox.Height)
					);
				}
			}

			pictureBox.Invalidate();
		}
		private void timer_Tick(object sender, EventArgs e)
		{
			generation += (int)globalSpeed;

			MoveLogic.UpdateAllPositions(globalSpeed, Sun);
			DrawSimulation();
		}

		// Обработчики управления
		private void bStart_MouseClick(object sender, EventArgs e)
		{
			StartSimulation();

			bStop.Enabled = true;
			bStart.Enabled = false;
		}

		private void bStop_MouseClick(object sender, EventArgs e)
		{
			StopSimulation();
		}

		private void hsbSpeed_ValueChanged(object sender, EventArgs e)
		{
			globalSpeed = (float)hsbSpeed.Value;
		}

		private void hsbApprox_ValueChanged(object sender, EventArgs e)
		{
			scale = (float)hsbApprox.Value;
		}

		private void pictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			lastMousePos.x = e.Location.X;
			lastMousePos.y = e.Location.Y;

			if (e.Button == MouseButtons.Middle)
			{
				isDragging = true;
				
				pictureBox.Cursor = Cursors.Hand;
			}
			if (e.Button == MouseButtons.Left)
			{
				Coordinate LMB_Pos = new Coordinate(
					((e.X - pictureBox.Width / 2.0) / scale) + systemCenter.x,
					((e.Y - pictureBox.Height / 2.0) / scale) + systemCenter.y
				);

				foreach (var body in Tbody.AllObjects)
				{
					if (body.IsPointOnBody(LMB_Pos, scale))
					{
						selectedBody = body;
						rtbDescription.Visible = true;
                        rtbDescription.Text = $"Описание: {selectedBody.description}";
                        Console.WriteLine($"{LMB_Pos.x} |\t {LMB_Pos.y} |\t {selectedBody.name}");
					}

					if (selectedBody != null && !selectedBody.IsPointOnBody(LMB_Pos, scale))
					{
						rtbDescription.Visible = false;
						selectedBody = null;
					}
				}
            }
		}

		private void pictureBox_MouseMove(object sender, MouseEventArgs e)
		{
			if (isDragging && e.Button == MouseButtons.Middle)
			{
                int deltaX = e.X - (int)lastMousePos.x;
				int deltaY = e.Y - (int)lastMousePos.y;

				systemCenter.x -= deltaX / scale;
				systemCenter.y -= deltaY / scale;

                lastMousePos.x = e.Location.X;
				lastMousePos.y = e.Location.Y;
            }
		}

		private void pictureBox_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Middle)
			{
				isDragging = false;
				pictureBox.Cursor = Cursors.Default;
			}
		}

		private void pictureBox_MouseLeave(object sender, EventArgs e)
		{
			isDragging = false;
			pictureBox.Cursor = Cursors.Default;
		}

        private void MainForm_Resize(object sender, EventArgs e)
        {
			if (isSimulationStated)
			{
                pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
                graphics = Graphics.FromImage(pictureBox.Image);
            }
        }
    }
}
