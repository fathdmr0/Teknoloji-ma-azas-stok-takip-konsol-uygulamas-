using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp56
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void anasayfayaDönToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 anotherForm = new Form2();
            anotherForm.Show();
            this.Hide();
        }

        private void oTURUMUKAPATToolStripMenuItem_Click(object sender, EventArgs e)
        {
        this.Close();
        }

        private void anasayfayaDönToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form2 anotherForm = new Form2();
            anotherForm.Show();
            this.Hide();
        }
    }
}
