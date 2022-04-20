using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddEditForm fr1 = new AddEditForm();
            fr1.Show();
            Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddEditForm fr1 = new AddEditForm();
            fr1.Show();
            Hide();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About hl = new About();
            hl.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditForm fr1 = new AddEditForm();
            fr1.Show();
            Hide();
        }

        private void editToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AddEditForm fr1 = new AddEditForm();
            fr1.Show();
            Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
