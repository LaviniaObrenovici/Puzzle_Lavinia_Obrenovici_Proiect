using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Puzzle_Lavinia_Obrenovici
{
    public partial class Joc4Piese : Form
    {
        int inNullSliceIndex, inmoves = 0;
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
        System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();

        public Joc4Piese()
        {
            InitializeComponent();
            lstOriginalPictureList.AddRange(new Bitmap[] { Properties.Resources._4_1, Properties.Resources._4_2, Properties.Resources._4_3, Properties.Resources._4_4, Properties.Resources._null });
            lblMovesMadeGame.Text += inmoves;
            lblTimer.Text = "00:00:00";
        }

        private void Joc4Piese_Load(object sender, EventArgs e)
        {
            Shuffle();
        }

        void Shuffle()
        {
            do
            {
                int j;
                List<int> Indexes = new List<int>(new int[] { 0, 1, 3 });//8 is not present - since it is the last slice.
                Random r = new Random();
                for (int i = 0; i < 3; i++)
                {
                    Indexes.Remove((j = Indexes[r.Next(0, Indexes.Count)]));
                    ((PictureBox)gb2.Controls[i]).Image = lstOriginalPictureList[j];
                    if (j == 3) inNullSliceIndex = i;//store empty picture box index
                }
            } while (CheckWin());
        }

        private void btnShufflePiese_Click(object sender, EventArgs e)
        {
            DialogResult YesOrNo = new DialogResult();
            if (lblTimer.Text != "00:00:00")
            {
                YesOrNo = MessageBox.Show("Are You Sure To RESTART ?", "Panda Puzzle", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
            if (YesOrNo == DialogResult.Yes || lblTimer.Text == "00:00:00")
            {
                Shuffle();
                timer.Reset();
                lblTimer.Text = "00:00:00";
                inmoves = 0;
                lblMovesMadeGame.Text = "Moves Made : 0";
            }
        }

        bool CheckWin()
        {
            int i;
            for (i = 0; i < 3; i++)
            {
                if ((gb2.Controls[i] as PictureBox).Image != lstOriginalPictureList[i]) break;
            }
            if (i == 8) return true;
            else return false;
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SwitchPictureBox(object sender, EventArgs e)
        {
            if (lblTimer.Text == "00:00:00")
                timer.Start();
            int inPictureBoxIndex = gb2.Controls.IndexOf(sender as Control);
            if (inNullSliceIndex != inPictureBoxIndex)
            {
                List<int> FourBrothers = new List<int>(new int[] { ((inPictureBoxIndex % 3 == 0) ? -1 : inPictureBoxIndex - 1), inPictureBoxIndex - 3, (inPictureBoxIndex % 3 == 2) ? -1 : inPictureBoxIndex + 1, inPictureBoxIndex + 3 });
                if (FourBrothers.Contains(inNullSliceIndex))
                {
                    ((PictureBox)gb2.Controls[inNullSliceIndex]).Image = ((PictureBox)gb2.Controls[inPictureBoxIndex]).Image;
                    ((PictureBox)gb2.Controls[inPictureBoxIndex]).Image = lstOriginalPictureList[3];
                    inNullSliceIndex = inPictureBoxIndex;
                    lblMovesMadeGame.Text = "Moves Made : " + (++inmoves);
                    if (CheckWin())
                    {
                        timer.Stop();
                        (gb2.Controls[8] as PictureBox).Image = lstOriginalPictureList[8];
                        MessageBox.Show("Congratulations...\nYour Rabbit Is Happy\nTime Elapsed : " + timer.Elapsed.ToString().Remove(8) + "\nTotal Moves Made : " + inmoves, "Rabbit Puzzle");
                        inmoves = 0;
                        lblMovesMadeGame.Text = "Moves Made : 0";
                        lblTimer.Text = "00:00:00";
                        timer.Reset();
                        Shuffle();
                    }
                }
            }
        }

        private void PauseOrResume(object sender, EventArgs e)
        {
            if (btnPauseGame.Text == "Pause")
            {
                timer.Stop();
                gb2.Visible = false;
                btnPauseGame.Text = "Resume";
            }
            else
            {
                timer.Start();
                gb2.Visible = true;
                btnPauseGame.Text = "Pause";
            }
        }

    }



}
