using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Use_Case_DiagramApp
{
    public partial class Form1 : Form
    {
        public List<Actor> actlist = new List<Actor>();

        public Form1()
        {
            InitializeComponent();
            rbtn_actor.Checked = true;
            rbtn_modesSelect.Checked = true;
        }

        private void Pn_useCase_MouseClick(object sender, MouseEventArgs e)
        {
            tb_Actor_Name.Clear();
            int drawmode = 0;
            if (rbtn_actor.Checked)
            {
                drawmode = 1;
            }
            else if (rbtn_useCase.Checked)
            {
                drawmode = 2;
            }
            else if (rbtn_line.Checked)
            {
                drawmode = 3;
            }

            if (rbtn_modesCreate.Checked)
            {

                switch (drawmode)
                {
                    case 0:
                        MessageBox.Show("error, selecteer een object");
                        break;

                    case 1: //draw actor
                        //actor
                        Point point = Pn_useCase.PointToClient(Cursor.Position);
                        string str = tb_Actor_Name.Text;
                        if (str.Length < 1)
                        {
                            str = "Actor";
                        }
                        Actor a = new Actor(str, point.X, point.Y);

                        actlist.Add(a);
                        MessageBox.Show(Convert.ToString(point.X) + ", " + Convert.ToString(point.Y));

                        Label label = new Label();
                        label.Name = Convert.ToString(a.Id);
                        label.Location = new Point(a.X - label.Width/2, a.Y + 40);
                        //label.BackColor = Color.Red;
                        label.Text = a.Name;
                        Pn_useCase.Controls.Add(label);


                        //label




                        break;

                    case 2: //draw use case

                        break;

                    case 3: //draw line

                        break;
                }
            }
            Pn_useCase.Refresh();
        }

        private void Pn_useCase_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = Pn_useCase.PointToClient(Cursor.Position);
            label1.Text = Convert.ToString(point.X);
            label2.Text = Convert.ToString(point.Y);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = Pn_useCase.CreateGraphics();
            Pen p = new Pen(Color.Black);
            foreach (Actor a in actlist)
            {
                string lbltxt = a.Name;
                if (lbltxt == null)
                {
                    lbltxt = "ActorID: " + Convert.ToString(a.Id);
                }
                
                graphics.DrawEllipse(p, a.X - 10, a.Y - 30, 20, 20);
                graphics.DrawLine(p, a.X, a.Y - 10, a.X, a.Y + 20);
                graphics.DrawLine(p, a.X - 15, a.Y, a.X + 15, a.Y);
                graphics.DrawLine(p, a.X, a.Y + 20, a.X - 15, a.Y + 35);
                graphics.DrawLine(p, a.X, a.Y + 20, a.X + 15, a.Y + 35);
            }
        }
    }
}
