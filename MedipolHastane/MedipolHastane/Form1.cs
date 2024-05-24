using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedipolHastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndok1_Click(object sender, EventArgs e)
        {
            doktor dok = new doktor();
            dok.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnhasta1_Click(object sender, EventArgs e)
        {
            hasta hst = new hasta();
            hst.Show();
        }

        private void btnblm1_Click(object sender, EventArgs e)
        {
            bolum blm = new bolum();
            blm.Show();
        }
    }
}
