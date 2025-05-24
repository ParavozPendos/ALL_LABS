using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public TbodyManager(Tbody body, ContextMode contextMode)
        {
            InitializeComponent();
            
            if (contextMode == ContextMode.editMode)
            {
                editingBody = body;
                isEditMode = true; 
                Text = "Edit Mode"; 
            }
            else if (contextMode == ContextMode.addMode) 
            {
                isAddMode = true; 
                Text = "Add mode"; 
            }
        }
        private void TbodyManager_Load(object sender, EventArgs e)
        {
            if (isEditMode)
            {
                TB_Name.Text = editingBody.name;
                TB_Position_X.Text = editingBody.currentPos.x.ToString("0.###");
                TB_Position_Y.Text = editingBody.currentPos.y.ToString("0.###");
                TB_Parent.Text = editingBody.parent?.name.ToString() ?? "";
                TB_Radius.Text = editingBody.radius.ToString("0.###");
                TB_Speed.Text = editingBody.speed.ToString();
                TB_Size.Text = editingBody.size.ToString();

                if (editingBody.color is SolidBrush solidBrush)
                {
                    bSelectColor.BackColor = solidBrush.Color;
                }
                else
                {
                    bSelectColor.BackColor = Color.White;
                }
            }
        }

        private void Editor()
        {
            double relX, relY;
            if (editingBody.parent != null)
            {
                relX = double.Parse(TB_Position_X.Text) - editingBody.parent.currentPos.x;
                relY = double.Parse(TB_Position_Y.Text) - editingBody.parent.currentPos.y;
                editingBody.radius = Math.Sqrt(relY * relY + relX * relX);
            }
            else
            {
                relX = double.Parse(TB_Position_X.Text);
                relY = double.Parse(TB_Position_Y.Text);
                editingBody.radius = Math.Sqrt(relY * relY + relX * relX);
            }
            if (editingBody.parent != null) editingBody.parent.name = TB_Parent.Text;

            editingBody.name = TB_Name.Text;
            editingBody.currentPos.x = double.Parse(TB_Position_X.Text);
            editingBody.currentPos.y = double.Parse(TB_Position_Y.Text);
            editingBody.speed = double.Parse(TB_Speed.Text);
            editingBody.size = double.Parse(TB_Size.Text);
            editingBody.color = new SolidBrush(BodyColorDialog.Color);


        }
        private void Adder()
        {
            Tbody itParent = Tbody.AllObjects.First();
            foreach (var item in Tbody.AllObjects)
            {
                if (TB_Parent.Text == item.name)
                {
                    itParent = item;
                }
            }
            double relX, relY,itRadius;
            
            if (itParent != null)
            {
                relX = double.Parse(TB_Position_X.Text) - itParent.currentPos.x;
                relY = double.Parse(TB_Position_Y.Text) - itParent.currentPos.y;
                itRadius = Math.Sqrt(relY * relY + relX * relX);
            }
            else
            {
                relX = double.Parse(TB_Position_X.Text);
                relY = double.Parse(TB_Position_Y.Text);
                itRadius = Math.Sqrt(relY * relY + relX * relX);
            }

            editingBody = new Tbody
                (

                    description:
                    "Ваш новый объект!",

                    name: TB_Name.Text,
                    currentPos: new Coordinate(double.Parse(TB_Position_X.Text), double.Parse(TB_Position_Y.Text)),
                    parent: itParent,
                    radius: itRadius,
                    speed: double.Parse(TB_Speed.Text),
                    size: double.Parse(TB_Size.Text),
                    color: new SolidBrush(BodyColorDialog.Color)
                );
        }


        private void bSelectColor_Click(object sender, EventArgs e)
        {
            BodyColorDialog.ShowDialog();
            bSelectColor.BackColor = BodyColorDialog.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isAddMode)
            {
                Adder();
            }
            else if (isEditMode)
            {
                Editor();
            }
            Close();
        }
    }
}
