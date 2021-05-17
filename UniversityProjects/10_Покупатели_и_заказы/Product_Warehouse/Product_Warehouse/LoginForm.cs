using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Product_Warehouse
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        static LoginForm()
        {
            wrongIcon = new Icon(Product_Warehouse.Properties.Resources.wrong_icon, new Size(2, 2));
            correctIcon = new Icon(Product_Warehouse.Properties.Resources.correct_icon, new Size(2, 2));
        }
        static Icon wrongIcon;
        static Icon correctIcon;
        /// <summary>
        /// Пользователь решил зарегистрироваться.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAccLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateNewAccountRequest?.Invoke();
            this.Close();
        }
        /// <summary>
        /// Событие, если пользователь решил зарегистрироваться.
        /// </summary>
        public Action CreateNewAccountRequest;

        /// <summary>
        /// Нажатие на кнопку входа.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                CheckEmail();
                CheckPasswor();
                (bool, string) response = EmailPasswordEntred?.Invoke(emailTb.Text, passwordTb.Text) ?? (false, "wrong");
                var result = response.Item1;
                var message = response.Item2;
                if (!result)
                    throw new FieldFilledIncorrectlyException(tbGroupBox, message);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(RequiredFieldsAreEmptyException )
            {}
            catch(FieldFilledIncorrectlyException ex)
            {
                responseEp.Icon = wrongIcon;
                responseEp.SetError(ex.Control, ex.Message);
            }
        }

        /// <summary>
        /// Проверка введенного логина.
        /// </summary>
        /// <param name="email"></param>
        private void CheckEmail()
        {
            if (emailTb.Text == "")
            {
                emailEp.Icon = wrongIcon;
                emailEp.SetError(emailTb, "Email field is empty");
                throw new RequiredFieldsAreEmptyException(emailTb, "Email");
            }
        }

        /// <summary>
        /// Проверка введенного пароля.
        /// </summary>
        private void CheckPasswor()
        {
            if(passwordTb.Text == "")
            {
                passwordEp.Icon = wrongIcon;
                passwordEp.SetError(passwordTb, "Password field is empty");
                throw new RequiredFieldsAreEmptyException(passwordTb, "Password");
            }
        }

        public delegate (bool, string) EmailAndPasswordentredEventHandler(string login, string password);
        public event EmailAndPasswordentredEventHandler EmailPasswordEntred;

        /// <summary>
        /// Нажатие на кнопку входа в качестве посетителя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void visitorBtn_Click(object sender, EventArgs e)
        {
            VisitorModeSelected?.Invoke();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Action VisitorModeSelected;

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
