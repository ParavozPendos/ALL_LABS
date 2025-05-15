using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace LIFE_GAME
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolution;
        private bool isGameStarted = false;
        private GameEngine gameEngine;
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void StartGame()
        {
            nudResolution.Enabled = false;
            nudDensity.Enabled = false;
            nudBorn.Enabled = false;
            nudDieLess.Enabled = false;
            nudDieMore.Enabled = false;
            bClear.Enabled = true;
            bStop.Enabled = true;

            resolution = (int)nudResolution.Value;

            gameEngine = new GameEngine
                (
                    rows: pictureBox1.Height / resolution,
                    cols: pictureBox1.Width / resolution,
                    dencity: (int)nudDensity.Minimum + (int)nudDensity.Maximum - (int)nudDensity.Value,
                    rule_CellBorn: (uint)nudBorn.Value,
                    rule_CellDieLess: (uint)nudDieLess.Value,
                    rule_CellDieMore: (uint)nudDieMore.Value
                );

            

            Text = $"Generation: {gameEngine.CurrentGeneration}";

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            timer1.Start();

            bStart.Text = "Refrash";
            isGameStarted = true;
            ChangeReliedTick();
        }

        
        private void StopGame()
        {
            
            if (timer1.Enabled)
            {
                
                timer1.Stop();

                nudResolution.Enabled = true;
                nudDensity.Enabled = true;
                nudBorn.Enabled = true;
                nudDieLess.Enabled = true;
                nudDieMore.Enabled = true;
                bClear.Enabled = false;
            }

            else if (!timer1.Enabled)
            {
                timer1.Start();

                nudResolution.Enabled = false;
                nudDensity.Enabled = false;
                nudBorn.Enabled = false;
                nudDieLess.Enabled = false;
                nudDieMore.Enabled = false;
                bClear.Enabled = true;
            }
        }


        private void DrawNextGeneration()
        {
            graphics.Clear(Color.Black);

            var field = gameEngine.GetCurrentGeneration();
            for (int x = 0; x < field.GetLength(0); x++)
            {
                for (int y = 0; y < field.GetLength(1); y++)
                {
                    if (field[x, y])
                        graphics.FillRectangle(Brushes.Red, x * resolution, y * resolution, resolution - 1, resolution - 1);
                }
                        
            }

            pictureBox1.Refresh();
            Text = $"Generation {gameEngine.CurrentGeneration}";
            gameEngine.NextGeneration();
        }

        private void ChangeReliedTick()
        {
            if (!timer1.Enabled)
            {                
                bStop.Text = "Continue";
            }
            else if (timer1.Enabled) 
            {
                bStop.Text = "Stop";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000 / (int)nudSpeed.Value;
            DrawNextGeneration();
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            StartGame();

            ChangeReliedTick();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            StopGame();


            ChangeReliedTick();
        }
        private void bClear_Click(object sender, EventArgs e)
        {
            gameEngine.FieldClear();
            timer1.Enabled = true;
            ChangeReliedTick();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!timer1.Enabled)
                return;

            var x = e.Location.X / resolution;
            var y = e.Location.Y / resolution;

            if (e.Button == MouseButtons.Left)
            {
                gameEngine.AddCell(x, y);
            }

            if (e.Button == MouseButtons.Right)
            {
                gameEngine.RemoveCell(x, y);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
