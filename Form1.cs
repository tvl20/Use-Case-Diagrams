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
        public List<UseCase> uselist = new List<UseCase>();
        public List<Label> lblactorlist = new List<Label>();
        public List<Label> lbluselist = new List<Label>();

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

                        //ensure actor has a name
                        string str = tb_Actor_Name.Text;
                        if (str.Length < 1)
                            str = "Actor";

                        //create actor
                        Actor a = new Actor(str, point.X, point.Y, Pn_useCase);
                        actlist.Add(a);

                        //create label
                        Label label = new Label();
                        label.Name = "a" + Convert.ToString(a.Id);
                        label.Text = a.Name;

                        //label positioning
                        var stringFont = new Font("Ariel", 10);
                        var lblwidth = graphics.MeasureString(label.Text, stringFont).Width;
                        label.Location = new Point(a.X - (Convert.ToInt32(lblwidth) / 2), a.Y + 40);
                        label.AutoSize = true;

                        //add label
                        Pn_useCase.Controls.Add(label);
                        lblactorlist.Add(label);
                        break;

                    case 2: //draw use case
                        //ensure usecase has a name
                        string str2 = tb_UseCase.Text;
                        if (str2.Length < 1)
                            str2 = "UseCase";

                        //create usecase
                        UseCase u = new UseCase(str2, point.X - 50, point.Y - 20, Pn_useCase);
                        uselist.Add(u);

                        //create label
                        Label label2 = new Label();
                        label2.Name = "u" + Convert.ToString(u.Id);
                        label2.Text = u.Name;

                        //label positioning
                        var stringFont2 = new Font("Ariel", 10);
                        var lblwidth2 = graphics.MeasureString(label2.Text, stringFont2).Width;
                        label2.Location = new Point(u.X - (Convert.ToInt32(lblwidth2) / 2 - label2.Text.Length * 5), u.Y + 15);
                        label2.AutoSize = true;

                        //add label
                        Pn_useCase.Controls.Add(label2);
                        lbluselist.Add(label2);
                        break;

                    case 3: //draw line

                        break;
                }
            }

            if (rbtn_modesSelect.Checked)
            {
                foreach (Actor a in actlist)
                {
                    if ((point.X > a.X - 16 && point.Y > a.Y - 31) && (point.X < a.X + 16 && point.Y < a.Y + 36))
                    {
                        a.Selected = true;

                        //change color of label
                        foreach (Label l in lblactorlist)
                        {
                            if (l.Name == "a" + Convert.ToString(a.Id))
                            {
                                l.ForeColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        a.Selected = false;

                        //change color of label
                        foreach (Label l in lblactorlist)
                        {
                            if (l.Name == "a" + Convert.ToString(a.Id))
                            {
                                l.ForeColor = Color.Black;
                            }
                        }
                    }
                }


                foreach (UseCase u in uselist)
                {
                    if ((point.X > u.X && point.Y > u.Y) && (point.X < u.X + 100 && point.Y < u.Y + 40))
                    {
                        if (u.Selected)
                        {
                            UseCaseDetails frm2 = new UseCaseDetails(u);
                            frm2.ShowDialog();
                            u.Redefine(frm2.newUseCase);
                            foreach (Label label in lbluselist)
                            {
                                if (label.Name == "u" + Convert.ToString(u.Id))
                                {
                                    label.Text = u.Name;
                                    break;
                                }
                            }
                        }

                        u.Selected = true;

                        foreach (Label l in lbluselist)
                        {
                            if (l.Name == "u" + Convert.ToString(u.Id))
                            {
                                l.ForeColor = Color.Red;
                            }
                        }
                    }
                    else
                    {
                        u.Selected = false;

                        //change color of label
                        foreach (Label l in lbluselist)
                        {
                            if (l.Name == "u" + Convert.ToString(u.Id))
                            {
                                l.ForeColor = Color.Black;
                            }
                        }
                    }
                }

                tb_Actor_Name.Clear();
                tb_UseCase.Clear();
            }
            //re-draw panel
            Pn_useCase.Refresh();
            foreach (Actor a in actlist)
                a.Draw();
            foreach (UseCase u in uselist)
                u.Draw();
        }

        private void Pn_useCase_MouseMove(object sender, MouseEventArgs e)
        {
            //set bool below to 'false' to hide mouse coordinates
            bool debug = true;

            if (!debug)
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
            }
            else
            {
                Point point = Pn_useCase.PointToClient(Cursor.Position);
                label1.Text = Convert.ToString(point.X);
                label2.Text = Convert.ToString(point.Y);
            }
            
        }

        private void btn_clearAll_Click(object sender, EventArgs e)
        {
            lblactorlist.Clear();
            lbluselist.Clear();
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

            //check of er een actor is geselecteerd
            if (actorSelected && actorID != -1)
            {
                //remove label op bepaalde positie
                for (int i = 0; i <= lblactorlist.Count - 1; i++)
                    if (lblactorlist[i].Name == "a" + Convert.ToString(actorID))
                    {
                        Pn_useCase.Controls.Remove(lblactorlist[i]);
                        lblactorlist.RemoveAt(i);
                        i--;
                    }

                //remove actor
                actlist.RemoveAt(actorPos);
            }

            //check of en welke usecase selected is
            bool useCaseSelected = false;
            int useCaseID = -1;
            int useCasePos = 0;
            counter = 0;
            foreach (UseCase u in uselist)
            {
                if (u.Selected)
                {
                    useCaseSelected = true;
                    useCaseID = u.Id;
                    useCasePos = counter;
                }
                counter++;
            }

            //check of er een usecase is geselecteerd
            if (useCaseSelected && useCaseID != -1)
            {
                //remove label op bepaalde positie
                for (int i = 0; i <= lbluselist.Count - 1; i++)
                    if (lbluselist[i].Name == "u" + Convert.ToString(useCaseID))
                    {
                        Pn_useCase.Controls.Remove(lbluselist[i]);
                        lbluselist.RemoveAt(i);
                        i--;
                    }

                //remove usecase
                uselist.RemoveAt(useCasePos);
            }

            //re-draw panel
            Pn_useCase.Refresh();
            foreach (Actor a in actlist)
                a.Draw();
            foreach (UseCase u in uselist)
                u.Draw();
        }
    }
}
