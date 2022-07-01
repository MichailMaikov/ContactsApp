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
    public partial class ContactForm : Form
    {

        /// <summary>
        /// Экземпляр контакта
        /// </summary>
        private Contact _contact;


        /// <summary>
        /// Геттер и Сеттер для контакта
        /// </summary>
        public Contact Contact
        {
            get => _contact;
            set
            {
                _contact = (Contact)value.Clone();
                if (value != null)
                {
                    SurNameBox.Text = _contact.Surname;
                    NameBox.Text = _contact.Name;
                    DateOfBirthBox.Value = _contact.DateOfBirth;
                    NumberPhoneBox.Text = _contact.PhoneNumber.Number.ToString();
                    EmailBox.Text = _contact.Mail;
                    VKBox.Text = _contact.VkId;
                }
            }
        }

        /// <summary>
        /// Сообщение об ошибке в поле _surname
        /// </summary>
        private string _surnameError;


        /// <summary>
        /// Сообщение об ошибке в поле _name
        /// </summary>
        private string _nameError;


        /// <summary>
        /// Сообщение об ошибке в поле _email
        /// </summary>
        private string _mailError;


        /// <summary>
        /// Сообщение об ошибке в поле _vkId
        /// </summary>
        private string _vkIdError;


        /// <summary>
        /// Сообщение об ошибке в поле _vkId
        /// </summary>
        private string _dateOfBirthError;


        /// <summary>
        /// Сообщение об ошибке в поле _number
        /// </summary>
        private string _phoneNumberError;


        /// <summary>
        /// Конструктор
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            _contact = new Contact("Michail", "Maikov", new PhoneNumber(78005553535), DateTime.Now, "michail@mail.ru", "Mishan9");
            UpdateForm();
        }



        /// <summary>
        /// Обновляет поля формы.
        /// </summary>
        private void UpdateForm()
        {
            SurNameBox.Text = _contact.Surname;
            NameBox.Text = _contact.Name;
            EmailBox.Text = _contact.Mail;
            DateOfBirthBox.Value = _contact.DateOfBirth;
            NumberPhoneBox.Text = _contact.PhoneNumber.Number.ToString();
            VKBox.Text = _contact.VkId;
        }

        /// <summary>
        /// Проверяет есть ли ошибки валидации в полях
        /// </summary>
        private bool CheckFormOnErrors()
        {
            string textError = "";
            if (_surnameError != "")
            {
                textError += "Enter surname\n";
            }
            if (_nameError != "")
            {
                textError += "Enter name\n";
            }
            if (_dateOfBirthError != "")
            {
                textError += "Enter date of birth\n";
            }
            if (_phoneNumberError != "")
            {
                textError += "Enter phone number\n";
            }
            if (_mailError != "")
            {
                textError += "Enter email\n";
            }
            if (_vkIdError != "")
            {
                textError += "Enter vk id\n";
            }
            if (textError != "")
            {
                MessageBox.Show(textError);
                return false;
            }
            return true;
        }



        /// <summary>
        /// Отслеживает изменения в ContactMail.
        /// </summary>
        private void Mail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Mail = EmailBox.Text;
                EmailBox.BackColor = Color.White;
                _mailError = "";
            }
            catch (Exception exception)
            {
                EmailBox.BackColor = Color.LightPink;
                _mailError = exception.Message;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddEditForm_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Отслеживает изменения в ContactBirthday.
        /// </summary>
        private void BirthdayTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.DateOfBirth = DateOfBirthBox.Value;
                DateOfBirthBox.BackColor = Color.White;
                _dateOfBirthError = "";
            }
            catch (Exception exception)
            {
                DateOfBirthBox.BackColor = Color.LightPink;
                _dateOfBirthError = exception.Message;
            }
        }


        /// <summary>
        /// Добавляет данные контакта
        /// </summary>
        private void OK_Click(object sender, EventArgs e)
        {
            if (CheckFormOnErrors())
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        /// <summary>
        /// Закрывает форму
        /// </summary>
        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        /// <summary>
        /// Отслеживает изменения в ContactPhone.
        /// </summary>
        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.PhoneNumber.Number = Int64.Parse(NumberPhoneBox.Text);
                NumberPhoneBox.BackColor = Color.White;
                _phoneNumberError = "";
            }
            catch (Exception exception)
            {
                NumberPhoneBox.BackColor = Color.LightPink;
                _phoneNumberError = exception.Message;
            }
        }


        /// <summary>
        /// Отслеживает изменения в ContactSurname
        /// </summary>
        private void SurNameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Surname = SurNameBox.Text;
                SurNameBox.BackColor = Color.White;
                _surnameError = "";
            }
            catch (Exception exception)
            {
                SurNameBox.BackColor = Color.LightPink;
                _surnameError = exception.Message;
            }
        }


        /// <summary>
        /// Отслеживает изменения в ContactName
        /// </summary>
        private void NameBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Name = NameBox.Text;
                NameBox.BackColor = Color.White;
                _nameError = "";
            }
            catch (Exception exception)
            {
                NameBox.BackColor = Color.LightPink;
                _nameError = exception.Message;
            }
        }

        private void VKBox_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Отслеживает изменения в ContactVkId.
        /// </summary>
        private void VKBox_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                _contact.VkId = VKBox.Text;
                VKBox.BackColor = Color.White;
                _vkIdError = "";
            }
            catch (Exception exception)
            {
                VKBox.BackColor = Color.LightPink;
                _vkIdError = exception.Message;
            }
        }
    }
}
