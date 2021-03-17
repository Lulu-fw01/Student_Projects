using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjectLibrary;

namespace TaskManagerApp
{
    /// <summary>
    /// Форма добавления нового разработчика.
    /// </summary>
    public partial class NewArtistForm : Form
    {
        public NewArtistForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие добавления нового пользователя.
        /// </summary>
        public Action<Artist> AddNewArtistAction;

        /// <summary>
        /// При нажатии на данную кнопку вызыыается событие добавления нового пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTextBox.Text.Length == 0)
                    throw new ArgumentException("New artist has not got name");
                else
                {
                    AddNewArtistAction?.Invoke(new Artist(nameTextBox.Text));
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
