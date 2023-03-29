using System.Collections.Generic;
using System.Diagnostics;
using System;
using System.Drawing.Text;
using System.Security.Policy;

namespace JosephusGUI
{
    public partial class Form1 : Form
    {
        readonly int RADIUS = 250;
        readonly int CENTER = 300;
        readonly int SOLDIER_H = 65;
        readonly int SOLDIER_W = 25;
        readonly int BLINK_TIME = 1000;

        List<PictureBox> soldiers = new List<PictureBox>();

        public Form1()
        {
            InitializeComponent();
            InitialSoldiers();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nSoldiers_ValueChanged(object sender, EventArgs e)
        {
            var numSoldiers = (int)nSoldiers.Value;

            CreateSoldiers(numSoldiers);
        }

        private void InitialSoldiers()
        {
            CreateSoldiers(3);
        }
        private void CreateSoldiers(int numSoldiers)
        {
            soldiers.Clear();
            pnlBattleField.Controls.Clear();
            for (int ns = 0; ns < numSoldiers; ns++) 
            {
                MakeSoldier(ns, numSoldiers);
                
            }
        }

        private void MakeSoldier(int ns, int numSoldiers)
        {
            PictureBox soldier = new PictureBox();
            pnlBattleField.Controls.Add(soldier);
            soldier.BackgroundImage = pbSoldier.Image;
            soldier.Visible = true;
            soldier.Size = new Size(SOLDIER_W, SOLDIER_H);
            double degree = 360 / numSoldiers;
            double radians = ns * (degree / 180 * Math.PI);
            int xCord = (int)(CENTER + RADIUS * Math.Cos(radians));
            int yCord = (int)(CENTER - RADIUS * Math.Sin(radians));
            soldier.Location = new Point(xCord, yCord);
            soldiers.Add(soldier);
        }


        private void bGo_Click(object sender, EventArgs e)
        {
            pnlBattleField.Controls.Add(pbSword);
            GoCountdown((int)nSoldiers.Value, (int)nCount.Value);
        }

        private void GoCountdown(int nSoldiers, int nCount)
        {
            List<bool> soldierStatus = new List<bool>();

            for (int i = 0; i < nSoldiers; i++)
            {
                soldierStatus.Add(true);
            }

            int liveSoldiers = nSoldiers;
            int whichSoldier = 0;
            int count = 0;

            while (liveSoldiers > 1)
            {
                
                while (count+1 < nCount)
                {
                    //Only move the dagger to the soldier spot if it is alive
                    if (soldierStatus[whichSoldier] == true)
                    {
                        pnlBattleField.Refresh();
                        //move sword at this soldiers point
                        Point beginLoc = new Point(soldiers[whichSoldier].Location.X,
                            soldiers[whichSoldier].Location.Y - 50);
                        pbSword.Location = beginLoc;
                        pbSword.Visible = true;
                        System.Threading.Thread.Sleep(BLINK_TIME);

                       
                        count++;
                    }
                    whichSoldier++;
                    //If reached the end of the cycle, need to start at 0 again
                    if (whichSoldier == nSoldiers)
                    {
                        whichSoldier = 0;
                    }

                }
                while (soldierStatus[whichSoldier] == false)
                {
                    whichSoldier++;
                    if(whichSoldier == nSoldiers)
                    {
                        whichSoldier = 0;
                    }
                }
                Point deadLoc = new Point(soldiers[whichSoldier].Location.X,
                            soldiers[whichSoldier].Location.Y - 50);
                pbSword.Location = deadLoc;
                pbSword.Visible = true;
                pnlBattleField.Refresh();
              
                soldierStatus[whichSoldier] = false;
                soldiers[whichSoldier].Image = dead_soldier.Image; 
                soldiers[whichSoldier].Visible = true;
                
                System.Threading.Thread.Sleep(BLINK_TIME);
                liveSoldiers--;
                count = 0;

                //If reached the end of the cycle, need to start at 0 again
                if (whichSoldier == nSoldiers)
                {
                    whichSoldier = 0;
                }
            }
            MessageBox.Show("Killing Complete!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dead_soldier_Click(object sender, EventArgs e)
        {

        }
    }
}