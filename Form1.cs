﻿using System;
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
        public List<Label> lbllist = new List<Label>();
        
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
                            //ensure empty space
                        bool occupied = false;
                        foreach (Actor act in actlist)
                            if ((point.X > act.X - 32 && point.Y > act.Y - 85) && (point.X < act.X + 32 && point.Y < act.Y + 85))
                                occupied = true;

                        if (occupied)
                            break;

                            //ensure actor has a name
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
                        lbllist.Add(label);
                        break;

                    case 2: //draw use case

                        break;

                    case 3: //draw line

                        break;
                }
            }

            if (rbtn_modesSelect.Checked)
            {
                //links boven -actor {x-15 y-30}
                //rechts onder -actor {x+15 y+35}
                foreach (Actor a in actlist)
                {
                    if ((point.X > a.X - 16 && point.Y > a.Y - 31) && (point.X < a.X + 16 && point.Y < a.Y + 36))
                    {
                        a.Selected = true;

                        //change color of label
                        foreach(Label l in lbllist)
                        {
                            if (l.Name == Convert.ToString(a.Id))
                            {
                                l.ForeColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        a.Selected = false;

                        //change color of label
                        foreach (Label l in lbllist)
                        {
                            if (l.Name == Convert.ToString(a.Id))
                            {
                                l.ForeColor = Color.Black;
                            }
                        }
                    }
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

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            lbllist.Clear();
            actlist.Clear();
            Pn_useCase.Controls.Clear();
            Pn_useCase.Refresh();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            //check of en welke actor selected is
            bool actorSelected = false;
            int actorID = -1;
            int actorPos = 0;
            int counter = 0;
            foreach (Actor a in actlist)
            {
                if (a.Selected)
                {
                    actorSelected = true;
                    actorID = a.Id;
                    actorPos = counter;
                }
                counter++;
            }

            if (actorSelected && actorID != -1)
            {
                //remove label op bepaalde positie
                for (int i = 0; i <= lbllist.Count-1; i++)
                    if (lbllist[i].Name == Convert.ToString(actorID))
                    {
                        Pn_useCase.Controls.Remove(lbllist[i]);
                        lbllist.RemoveAt(i);
                        i--;
                    }

                //remove actor
                actlist.RemoveAt(actorPos);
            }

            //re-draw panel
            Pn_useCase.Refresh();
            foreach (Actor a in actlist)
                a.Draw();
        }
    }
}
