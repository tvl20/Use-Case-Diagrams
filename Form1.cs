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
                        //ensure name actor
                        string str = tb_Actor_Name.Text;
                        if (str.Length < 1)
                        {
                            str = "Actor";
                        }

                        //create actor
                        Actor a = new Actor(str, point.X, point.Y, Pn_useCase);
                        actlist.Add(a);
                        

                        //create label
                        Label label = new Label();
                        label.Name = Convert.ToString(a.Id);
                        label.Text = a.Name;

                        //position label
                        var stringFont = new Font("Ariel", 10);
                        var lblwidth = graphics.MeasureString(label.Text, stringFont).Width;
                        label.Location = new Point(a.X - (Convert.ToInt32(lblwidth) / 2), a.Y + 40);
                        label.AutoSize = true;

                        //add label
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
            foreach (Actor a in actlist)
            {
                a.Draw();
            }
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
            
        }
    }
}
