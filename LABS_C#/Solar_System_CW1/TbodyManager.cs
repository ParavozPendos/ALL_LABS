using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Solar_System_CW1
{
    public enum ContextMode
    {
        editMode = 0,
        addMode = 1,
    }

    public partial class TbodyManager : Form
    {
        private Tbody editingBody;
        private bool isEditMode;
        private bool isAddMode;
        private MainForm mainForm;

        private double radAngle;
        private Coordinate eLastMousePosition;

        
        public TbodyManager(Tbody body, ContextMode contextMode, MainForm form)
        {
            eLastMousePosition = MainForm.currentMousePos_field;

            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(Cursor.Position.X - Width - 30, Cursor.Position.Y - Height/2);

            mainForm = form;
            mainForm.Enabled = false;
            if (mainForm.isGo == true)MainForm.StopSimulation(mainForm);
            
            if (contextMode == ContextMode.editMode)
            {
                editingBody = body;
                isEditMode = true; 
                Text = "Edit Mode"; 
            }
            else if (contextMode == ContextMode.addMode) 
            {
                editingBody = body;
                isAddMode = true; 
                Text = "Add mode";

                
                TB_Radius.Text = Math.Sqrt(Math.Pow(eLastMousePosition.x, 2) + Math.Pow(eLastMousePosition.y, 2)).ToString("0.###");

                radAngle = (Math.Atan2(eLastMousePosition.y, eLastMousePosition.x));
                TB_Angle.Text = (radAngle / Math.PI * 180).ToString("0.###");
            }

            CB_Parent.Items.AddRange(Tbody.AllObjects.ToArray());
            CB_Parent.DisplayMember = "name";
        }
        private void TbodyManager_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                TB_Name.Text = editingBody.name;
                labelPosition.Text = $"Position: ({editingBody.currentPos.x:F3} ; {editingBody.currentPos.y:F3})";
                CB_Parent.SelectedItem = editingBody.parent;
                TB_Radius.Text = editingBody.radius.ToString("0.###");
                TB_Speed.Text = editingBody.speed.ToString();
                TB_Size.Text = editingBody.size.ToString();
                TB_Angle.Text = ((editingBody.angle / Math.PI * 180) % 180).ToString("0.###");

                if (editingBody.color is SolidBrush solidBrush) bSelectColor.BackColor = solidBrush.Color;
                else bSelectColor.BackColor = Color.Red;

                foreach (var item in editingBody.satelliteList)
                {
                    if (CB_Parent.Items.Contains(item)) CB_Parent.Items.Remove(item);
                }
            }
            else if (isAddMode)
            {
                labelPosition.Text = $"Position: ({eLastMousePosition.x:F3} ; {eLastMousePosition.y:F3})";
            }
        }

        private void Editor()
        {
            editingBody.name = TB_Name.Text;
            radAngle = (double.Parse(TB_Angle.Text) / 180 * Math.PI);
            editingBody.angle = radAngle; 
            editingBody.radius = double.Parse(TB_Radius.Text);
            editingBody.currentPos.x = editingBody.radius * Math.Cos(radAngle);
            editingBody.currentPos.y = editingBody.radius * Math.Sin(radAngle);
            if (editingBody.parent != null) editingBody.parent = (Tbody)CB_Parent.SelectedItem;
            editingBody.speed = double.Parse(TB_Speed.Text);
            editingBody.size = double.Parse(TB_Size.Text);
            editingBody.color = new SolidBrush(bSelectColor.BackColor);
        }
        private void Adder()
        {
            Tbody itParent = (Tbody)CB_Parent.SelectedItem;
            double itRadius = double.Parse(TB_Radius.Text);

            editingBody = new Tbody
            (
                description: "Ваш новый объект!",
                name: TB_Name.Text,
                currentPos: new Coordinate
                (
                    itParent.currentPos.x + itRadius * Math.Cos(double.Parse(TB_Angle.Text) * Math.PI / 180),
                    itParent.currentPos.y + itRadius * Math.Sin(double.Parse(TB_Angle.Text) * Math.PI / 180)
                ),
                parent: itParent,
                radius: itRadius,
                speed: double.Parse(TB_Speed.Text),
                size: double.Parse(TB_Size.Text),
                color: new SolidBrush(bSelectColor.BackColor),
                angle: double.Parse(TB_Angle.Text)
            );
            
            if (itParent != null)
            {
                itParent.AddSatellite(editingBody);
            }
        }
        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(TB_Name.Text)) return false;
            if (string.IsNullOrEmpty(CB_Parent.Text)) return false;
            if (string.IsNullOrWhiteSpace(TB_Radius.Text)) return false;
            if (string.IsNullOrWhiteSpace(TB_Speed.Text)) return false;
            if (string.IsNullOrWhiteSpace(TB_Size.Text)) return false;
            if (string.IsNullOrWhiteSpace(TB_Angle.Text)) return false;
            return true;
        }

        private void bSelectColor_Click(object sender, EventArgs e)
        {
            BodyColorDialog.ShowDialog();
            bSelectColor.BackColor = BodyColorDialog.Color;
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            try
            {
                if (isAddMode) Adder();
                else if (isEditMode) Editor();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный ввод!");
            }
        }

        private void TbodyManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Enabled = true;
            MainForm.StopSimulation(mainForm);
        }
    }
}
