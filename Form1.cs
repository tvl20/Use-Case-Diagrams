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

        public void Draw()
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

                if (a.Selected)
                    p.Color = Color.Red;

                graphics.DrawEllipse(p, a.X - 10, a.Y - 30, 20, 20);
                graphics.DrawLine(p, a.X, a.Y - 10, a.X, a.Y + 20);
                graphics.DrawLine(p, a.X - 15, a.Y, a.X + 15, a.Y);
                graphics.DrawLine(p, a.X, a.Y + 20, a.X - 15, a.Y + 35);
                graphics.DrawLine(p, a.X, a.Y + 20, a.X + 15, a.Y + 35);

                //graphics.DrawEllipse(p, a.X - 5, a.Y - 5, 10, 10);
            }
        }

        public Form1()
        {
            InitializeComponent();
            rbtn_actor.Checked = true;
            rbtn_modesSelect.Checked = true;
        }

        private void Pn_useCase_MouseClick(object sender, MouseEventArgs e)
        {
            Graphics graphics = Pn_useCase.CreateGraphics();
            Point point = Pn_useCase.PointToClient(Cursor.Position);
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
                        string str = tb_Actor_Name.Text;
                        if (str.Length < 1)
                        {
                            str = "Actor";
                        }

                        Actor a = new Actor(str, point.X, point.Y);
                        actlist.Add(a);
                        //MessageBox.Show(Convert.ToString(point.X) + ", " + Convert.ToString(point.Y)); --debug

                        Label label = new Label();
                        label.Name = Convert.ToString(a.Id);
                        label.Text = a.Name;

                        var stringFont = new Font("Ariel", 10);
                        var lblwidth = graphics.MeasureString(label.Text, stringFont).Width;
                        label.Location = new Point(a.X - (Convert.ToInt32(lblwidth) / 2), a.Y + 40);
                        label.AutoSize = true;
                        //label.BackColor = Color.Red; --debug
                        Pn_useCase.Controls.Add(label);
                        break;

                    case 2: //draw use case

                        break;

                    case 3: //draw line

                        break;
                }
            }

            if (rbtn_modesSelect.Checked)
            {
                foreach (Actor a in actlist)
                {
                    
                }
            }

            Pn_useCase.Refresh();
            tb_Actor_Name.Clear();
        }

        private void Pn_useCase_MouseMove(object sender, MouseEventArgs e)
        {
            Point point = Pn_useCase.PointToClient(Cursor.Position);
            label1.Text = Convert.ToString(point.X);
            label2.Text = Convert.ToString(point.Y);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Draw();
        }
    }
}
