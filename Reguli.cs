using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Reguli : Form
    {
        public Reguli()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 meniu = new Form1();
            this.Hide();
            meniu.Closed += (s, args) => this.Close();
            meniu.Show();
        }
    }
}
