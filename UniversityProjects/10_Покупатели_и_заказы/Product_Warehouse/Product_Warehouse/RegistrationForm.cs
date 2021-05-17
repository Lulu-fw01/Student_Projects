using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Resources;
using System.IO;

namespace Product_Warehouse
{
    public partial class RegistrationForm : Form
    {
        UserMode mode;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        static Icon wrongIcon;
        static Icon correctIcon;
        static RegistrationForm()
        {
            wrongIcon = new Icon(Product_Warehouse.Properties.Resources.wrong_icon, new Size(2, 2));
            correctIcon = new Icon(Product_Warehouse.Properties.Resources.correct_icon, new Size(2, 2));
        }
        
        /// <summary>
        /// Событие добавления нового покупателя.
        /// </summary>
        public Action<Customer> AddNewCustomer;

        /// <summary>
        /// Событие добавления нового продавца.
        /// </summary>
        public Action<Administrator> AddNewSeller;


        /// <summary>
        /// Проверка Email.
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        private static bool IsValidEmail(string email)
        {
            try
            {
                var ea = new EmailAddressAttribute();
                return ea.IsValid(email);
            }
            catch
            {
                return false;
            }
        }

      

        /// <summary>
        /// Метка, что email веден верно.
        /// </summary>
        private void MarkThatControlIsCorrect(ErrorProvider ep, Control ctrl, string message)
        {
            ep.Icon = correctIcon;
            ep.SetError(ctrl, message);
        }

        /// <summary>
        /// Метка, что email веден неверно.
        /// </summary>
        private void MarkThatControlIsUnCorrect(ErrorProvider ep, Control ctrl, string message)
        {
            ep.Icon = wrongIcon;
            ep.SetError(ctrl, message);
        }

        /// <summary>
        /// Загрузка формы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            customerRb.Checked = true;
            sellerRb.Checked = false;
        }

        /// <summary>
        /// Нажатие на кнопку создать аккаунт.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (mode == UserMode.Customer)
                {
                    CheckFullName();
                    CheckPhoneNumber();
                    CheckAdress();
                }
                CheckEmail();
                CheckPassword();

                if (mode == UserMode.Customer)
                {
                    var adress = countryTb.Text + ", " + cityTb.Text + ", " + postcodeMtb.Text + ", " + streetTb.Text;
                    AddNewCustomer?.Invoke(new Customer(emailTextBox.Text, passwordOneTb.Text, phoneMtb.Text, new FullUserName(surnameTb.Text, nameTb.Text, patronymicTb.Text), adress));
                }
                else
                {
                    AddNewSeller?.Invoke(new Administrator(emailTextBox.Text, passwordOneTb.Text));
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (RequiredFieldsAreEmptyException ex)
            {
               
            }
            catch (FieldFilledIncorrectlyException ex)
            {
                
            }
            catch(Exception)
            { }
        }

        /// <summary>
        /// Проверка заполнения имени.
        /// </summary>
        private void CheckFullName()
        {
            if (nameTb.Text == "")
            {
                MarkThatControlIsUnCorrect(nameErrorProvider, nameTb, "Required field Name is empty.");
                throw new RequiredFieldsAreEmptyException(nameTb, "Name");
            }
            MarkThatControlIsCorrect(nameErrorProvider ,nameTb, "Correct.");

            if (surnameTb.Text == "")
            {
                MarkThatControlIsUnCorrect(surnameErrorProvider, surnameTb, "Required field Surname is empty.");
                throw new RequiredFieldsAreEmptyException(surnameTb, "Surname");
            }
            MarkThatControlIsCorrect(surnameErrorProvider, surnameTb, "Correct.");
        }

        /// <summary>
        /// Проверка ввода телефонного номера.
        /// </summary>
        private void CheckPhoneNumber()
        {
            if (!phoneMtb.MaskCompleted)
            {
                MarkThatControlIsUnCorrect(phoneErrorProvider, phoneMtb, "Required field Phone Number is empty.");
                throw new RequiredFieldsAreEmptyException(phoneMtb, "Phone Number");
            }

            MarkThatControlIsCorrect(phoneErrorProvider, phoneMtb, "Correct");
        }

        /// <summary>
        /// Проверка введенного адреса.
        /// </summary>
        private void CheckAdress()
        {
            if (countryTb.Text == "")
            {
                MarkThatControlIsUnCorrect(adressErrorProvider, adressGb, "Required field Country is empty.");
                throw new RequiredFieldsAreEmptyException(countryTb, "Country");
            }
            if (cityTb.Text == "")
            {
                MarkThatControlIsUnCorrect(adressErrorProvider, adressGb, "Required field City is empty.");
                throw new RequiredFieldsAreEmptyException(cityTb, "City");
            }
            if (streetTb.Text == "")
            {
                MarkThatControlIsUnCorrect(adressErrorProvider, adressGb, "Required field Sreet is empty.");
                throw new RequiredFieldsAreEmptyException(streetTb, "Street, House, flat");
            }
            if (!postcodeMtb.MaskCompleted)
            {
                MarkThatControlIsUnCorrect(adressErrorProvider, adressGb, "Required field Postcode is empty.");
                throw new RequiredFieldsAreEmptyException(postcodeMtb, "Postocde");
            }

            MarkThatControlIsCorrect(adressErrorProvider, adressGb, "Correct");
        }

        /// <summary>
        /// Проверка введенного пароля.
        /// </summary>
        private void CheckPassword()
        {
            if (passwordOneTb.Text != passwordTwoTb.Text)
            {
                MarkThatControlIsUnCorrect(passwordsErrorProvider, passwordGroupBox, "Passwords are not the same.");
                throw new FieldFilledIncorrectlyException(passwordGroupBox, "Passwords are not the same.");
            }
            if (passwordOneTb.Text.Length < 7)
            {
                MarkThatControlIsUnCorrect(passwordsErrorProvider, passwordGroupBox, "Password is too short");
                throw new FieldFilledIncorrectlyException(passwordGroupBox, "Password is too short");
            }

            MarkThatControlIsCorrect(passwordsErrorProvider, passwordGroupBox, "Correct");
        }

        /// <summary>
        /// Проверка введенного Email.
        /// </summary>
        private void CheckEmail()
        {
            if (!IsValidEmail(emailTextBox.Text))
            {
                MarkThatControlIsUnCorrect(emailErrorProvider, emailTextBox, "E-mail has wrong format");
                throw new FieldFilledIncorrectlyException(emailTextBox, "E-mail has wrong format");
            }

            bool check = EmailEntred?.Invoke(emailTextBox.Text) ?? false;
            if (check)
            {
                MarkThatControlIsUnCorrect(emailErrorProvider, emailTextBox, "Customer with this E-mail is alredy exists.");
                throw new FieldFilledIncorrectlyException(emailTextBox, "Customer with this E-mail is alredy exists.");
            }
            
            MarkThatControlIsCorrect(emailErrorProvider, emailTextBox, "Correct.");
        }


        /// <summary>
        /// происходит при изменении текста в поле Email.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CheckEmail();
            }
            catch (FieldFilledIncorrectlyException ex)
            {
            }
        }



        public delegate bool EmailEntredEventHandler(string login);
        public event EmailEntredEventHandler EmailEntred;

        /// <summary>
        /// Изменение текста в поле ввода пароля.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void passwordOneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerRb_CheckedChanged(object sender, EventArgs e)
        {
            if (customerRb.Checked == true)
            {
                mode = UserMode.Customer;
                nspGb.Visible = true;
                adressGb.Visible = true;
            }
        }

        private void sellerRb_CheckedChanged(object sender, EventArgs e)
        {
            if (sellerRb.Checked == true)
            {
                mode = UserMode.Adminisrator;
                nspGb.Visible = false;
                adressGb.Visible = false;
            }
        }
    }
}
