using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
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
		public bool isGo = false;

	

		private DateTime timePassed = new DateTime();
		private Tbody selectedBody = null;
		private Tbody contextBody = null;
		

		public MainForm()
		{
			InitializeComponent();
		}

		
		private void MainForm_Load(object sender, EventArgs e) 
		{
            Tbody.InitializeSolarSystem();
			
            globalSpeed = hsbSpeed.Value;
            scale = (double)hsbApprox.Value / 2;
            timer.Interval = 1000 / fps;

            pictureBox.MouseWheel += PictureBox_MouseWheel;
        }
        public static void StartSimulation(MainForm form)
        {
			form.isGo = true;
            form.isSimulationStated = true;
            form.pictureBox.Image = new Bitmap(form.pictureBox.Width, form.pictureBox.Height);
            form.graphics = Graphics.FromImage(form.pictureBox.Image);
            form.timer.Start();
            form.secTimer.Start();
        }

        public static void StopSimulation(MainForm form)
        {
            if (form.isGo)
            {
				form.isGo = false;
                form.globalSpeed = 0;
                form.bStop.Text = "Continue";
                form.bStop.BackColor = Color.LightGreen;
            }
            else
            {
				form.isGo = true;
                form.globalSpeed = form.hsbSpeed.Value;
                form.bStop.Text = "Stop";
                form.bStop.BackColor = Color.Yellow;
            }
        }
        private void DrawSimulation()
		{
			//UI
			labelGeneration.Text = $"Generation: {generation}";
            labelSeconds.Text = $"Seconds: {timePassed.ToLongTimeString()}";
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
					graphics.DrawLine(new Pen(Color.Blue, 1)
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
			if (globalSpeed != 0) generation++;

			MoveLogic.UpdateAllPositions(globalSpeed);
			DrawSimulation();
		}
        private void secTimer_Tick(object sender, EventArgs e)
        {
			timePassed = timePassed.AddSeconds(globalSpeed);
        }


        // Обработчики управления
        private void bStart_MouseClick(object sender, EventArgs e)
		{
			StartSimulation(this);

			bStop.Enabled = true;
			bStart.Enabled = false;
		}

		private void bStop_MouseClick(object sender, EventArgs e)
		{
			StopSimulation(this);
		}

		private void hsbSpeed_ValueChanged(object sender, EventArgs e)
		{
			globalSpeed = (float)hsbSpeed.Value;
		}

		private void hsbApprox_ValueChanged(object sender, EventArgs e)
		{
			scale = (float)hsbApprox.Value / 2;
		}

		private void pictureBox_MouseDown(object sender, MouseEventArgs e)
		{
			lastMousePos.x = e.Location.X;
			lastMousePos.y = e.Location.Y;
            Coordinate LMB_Pos = new Coordinate(
                    ((e.X - pictureBox.Width / 2.0) / scale) + systemCenter.x,
                    ((e.Y - pictureBox.Height / 2.0) / scale) + systemCenter.y
                );

            if (e.Button == MouseButtons.Middle)
			{
				isDragging = true;
				
				pictureBox.Cursor = Cursors.Hand;
			}
			if (e.Button == MouseButtons.Left)
			{
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
            if (e.Button == MouseButtons.Right)
            {
                foreach (var body in Tbody.AllObjects)
                {
                    if (body.IsPointOnBody(LMB_Pos, scale))
                    {
						contextBody = body;
                        ContextOnBody.Show(pictureBox, e.Location);
						break;
                    }
					else
					{
						ContextOnEmpty.Show(pictureBox, e.Location);
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
        private void PictureBox_MouseWheel(object sender, MouseEventArgs e)
        {
			ContextOnBody.Hide();
			ContextOnEmpty.Hide();

            int change = hsbApprox.LargeChange;
            int newValue = hsbApprox.Value + (e.Delta > 0 ? change : -change);

            if (newValue < hsbApprox.Minimum)
                hsbApprox.Value = hsbApprox.Minimum;
            else if (newValue > hsbApprox.Maximum)
                hsbApprox.Value = hsbApprox.Maximum;
            else hsbApprox.Value = newValue;
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

        private void TSM_delete_Click(object sender, EventArgs e)
        {
			Tbody.Deleter(contextBody);
        }
        private void TSM_edit_Click(object sender, EventArgs e)
        {
			TbodyManager TbodyManager = new TbodyManager(contextBody, ContextMode.editMode, this);
			TbodyManager.Show();
        }
        private void TSM_add_Click(object sender, EventArgs e)
        {
			Tbody contextBody = null;
            TbodyManager TbodyManager = new TbodyManager(contextBody, ContextMode.addMode, this);
            TbodyManager.Show();
        }
    }
}
