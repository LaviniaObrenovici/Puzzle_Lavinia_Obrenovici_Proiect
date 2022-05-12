using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Puzzle_Lavinia_Obrenovici
{
    public partial class Jucator : Form
    {
        public Jucator()
        {
            InitializeComponent();
        }

        private void btnJocNou_Click(object sender, EventArgs e)
        {
            Alegere jform = new Alegere();
            jform.Show();
        }

        private void Jucator_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clasament jform = new Clasament();
            jform.Show();
        }
    }
}
