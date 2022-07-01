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
        private Project Project { get; set; }


        /// <summary>
        /// Текущие объекты в списке
        /// </summary>
        private List<Contact> currentContacts;


        public MainForm()
        {
            InitializeComponent();
            Project = new Project();
            Project = ProjectManager.LoadFromFile();
            currentContacts = new List<Contact>(Project.SortBySurname());
            UpdateListBox();
        }

        /// <summary>
        /// Обновляет данные в ListBox.
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            currentContacts = currentContacts.OrderBy(contact => contact.Surname).ToList();
            foreach (Contact contact in currentContacts)
            {
                ContactsListBox.Items.Add(contact.Surname);
            }
        }


        /// <summary>
        /// Добавляет контакта в список
        /// </summary>
        private void AddContact()
        {
            ContactForm contactForm = new ContactForm();
            DialogResult result = contactForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Contact newContact = contactForm.Contact;
                currentContacts.Add(newContact);
                Project.Contacts.Add(newContact);
                ProjectManager.SaveToFile(Project);
            }

            ClearSelectedContact();

        }


        /// <summary>
        /// Редактирует контакта в списке
        /// </summary>
        private void EditContact(int index)
        {
            if (index == -1)
            {
                MessageBox.Show("Choose contact");
                return;
            }

            ContactForm contactForm = new ContactForm();

            Contact selectedContact = currentContacts[index];
            contactForm.Contact = selectedContact;

            DialogResult result = contactForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                Contact updateContact = contactForm.Contact;

                ContactsListBox.Items.RemoveAt(index);

                int contactIndex = Project.Contacts.FindIndex(contact =>
                (contact.Surname == currentContacts[index].Surname && contact.PhoneNumber.Number == currentContacts[index].PhoneNumber.Number));

                currentContacts.RemoveAt(index);
                currentContacts.Insert(index, updateContact);

                Project.Contacts.RemoveAt(contactIndex);
                Project.Contacts.Insert(contactIndex, updateContact);

                ContactsListBox.Items.Insert(index, updateContact.Surname);
                ProjectManager.SaveToFile(Project);
            }
            ClearSelectedContact();
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
                MessageBox.Show("Item not selected");
                return;
            }

            DialogResult result = MessageBox.Show($"Do you really want to remove {currentContacts[index].Surname}?",
                "Message", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                int contactIndex = Project.Contacts.FindIndex(contact =>
                (contact.Surname == currentContacts[index].Surname && contact.PhoneNumber.Number == currentContacts[index].PhoneNumber.Number));

                currentContacts.RemoveAt(index);
                Project.Contacts.RemoveAt(contactIndex);
                ProjectManager.SaveToFile(Project);
            }
            ClearSelectedContact();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {

        }



        private void RemoveButton_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Вызывает функцию RemoveContact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButton_Click_1(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }


        /// <summary>
        /// Вызывает функцию RemoveContact.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
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
            EditContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        private void editMainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
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
            about.Show();
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
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                ProjectManager.SaveToFile(Project);
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

            Contact contact = currentContacts[index];

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
        

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e) =>
            UpdateSelectedContact(ContactsListBox.SelectedIndex);


        private void RemoveButton_Click_2(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            UpdateListBox();
        }

        private void FindText_TextChanged(object sender, EventArgs e)
        {
            string text = FindText.Text;
            currentContacts = Project.SearchBySurname(text);
            UpdateListBox();
            ClearSelectedContact();
        }
    }
}
