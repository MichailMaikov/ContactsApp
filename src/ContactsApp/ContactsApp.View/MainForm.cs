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
    public partial class MainForm : Form
    {
        /// <summary>
        /// Экземпляр класса Project.
        /// </summary>
        private Project project { get; set; }



        public MainForm()
        {
            InitializeComponent();
            project = new Project();
        }

        /// <summary>
        /// Обновляет данные в ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();

            foreach (Contact contact in project.Contacts)
            {
                ContactsListBox.Items.Add(contact.Surname);
            }
        }

        /// <summary>
        /// Добавляет новый контакт.
        /// </summary>
        private void AddContact()
        {
            string[] names = new string[3] { "Gomer", "Piter", "Eric" };
            string[] surnames = new string[3] { "Simpson", "Griffen", "Cartman" };
            string[] mails = new string[3] { "gomer@gmail.com", "griffen@gmail.com", "erictop1@gmail.com" };
            string[] vkId = new string[3] { "gomerS", "PiterGriffen", "besteric" };

            Random random = new Random();
            Contact newContact = new Contact(
                names[random.Next(names.Length)],
                surnames[random.Next(surnames.Length)],
                new PhoneNumber(random.Next()),
                DateTime.Now,
                mails[random.Next(mails.Length)],
                vkId[random.Next(vkId.Length)]);

            project.Contacts.Add(newContact);
        }

        /// <summary>
        /// Удаляет контакт и обновляет ListBox.
        /// </summary>
        /// <param name="index"></param>
        /// <exception cref="ArgumentException"></exception>
        private void RemoveContact(int index)
        {
            if (index == -1)
            {
                throw new ArgumentException("Item not selected");
            }

            DialogResult result = MessageBox.Show($"Do you really want to remove {project.Contacts[index].Surname}?",
                "Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                project.Contacts.RemoveAt(index);
                UpdateListBox();
            }
        }



        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Вызывает функцию RemoveContact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
        }


        /// <summary>
        /// Добавляет контакт в ListBox и обновляет его.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void NameBox_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Вызывает форму редактирования контакта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {
            AddEditForm Edit = new AddEditForm();
            Edit.ShowDialog();

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
        }

        /// <summary>
        /// ВЫзывает форму с информацией о создателе.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        /// <summary>
        /// Добавляет контакт и обновлят ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddContact();
            UpdateListBox();
        }

        /// <summary>
        /// Вызывает функцию RemoveContact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
        }

        /// <summary>
        /// Закрывает приложение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to close application?",
                "Message", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Очищает информацию о пользователе.
        /// </summary>
        private void ClearSelectedContact()
        {
            SurNameBox.Clear();
            NameBox.Clear();
            DateOfBirthBox.Value = DateTime.Now;
            NumberPhoneBox.Clear();
            EmailBox.Clear();
            VKBox.Clear();
        }

        /// <summary>
        /// Выводит полную информацию о пользователе.
        /// </summary>
        /// <param name="index">Индекс выбранного контакта</param>
        private void UpdateSelectedContact(int index)
        {
            if (index == -1)
            {
                ClearSelectedContact();
                return;
            }

            Contact contact = project.Contacts[index];

            SurNameBox.Text = contact.Surname;
            NameBox.Text = contact.Name;
            DateOfBirthBox.Value = contact.DateOfBirth;
            NumberPhoneBox.Text = contact.PhoneNumber.Number.ToString();
            EmailBox.Text = contact.Mail;
            VKBox.Text = contact.VkId;
        }

        /// <summary>
        /// Выхывает функцию UpdateSelectedContact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactListBox_SelectedIndexChanged(object sender, EventArgs e) =>
            UpdateSelectedContact(ContactsListBox.SelectedIndex);

   
    }
}
