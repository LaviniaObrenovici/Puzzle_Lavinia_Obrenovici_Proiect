using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puzzle_Lavinia_Obrenovici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (username == "jucator" && password == "jucator")
            {
                Jucator jform = new Jucator();
                jform.Show();
            }

            else if (username == "admin" && password == "admin")
            {
                Admin aform = new Admin();
                aform.Show();


            }
        }
    }
}
