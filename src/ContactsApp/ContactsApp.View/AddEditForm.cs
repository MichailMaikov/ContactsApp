using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;

namespace ContactsApp.View
{
    public partial class AddEditForm : Form
    {
        public AddEditForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            MainForm fr1 = new MainForm();
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MainForm fr1 = new MainForm();
            this.Close();
        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
