using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Puzzle_Lavinia_Obrenovici
{
    public partial class Alegere : Form
    {
        public Alegere()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Joc4Piese jform = new Joc4Piese();
            jform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Joc9Piese jform = new Joc9Piese();
            jform.Show();
        }

        private void Alegere_Load(object sender, EventArgs e)
        {

        }
    }
}
