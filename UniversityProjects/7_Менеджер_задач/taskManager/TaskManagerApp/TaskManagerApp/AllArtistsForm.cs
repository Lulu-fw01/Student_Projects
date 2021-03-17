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
    /// Форма, в которй отображаются все пользователи.
    /// Тут можно добавлять новых пользователей, удалять старых.
    /// </summary>
    public partial class AllArtistsForm : Form
    {
        List<Artist> artistsList;
        List<Artist> deletedArtists;
        public Action<List<Artist>> CheckDeletedArtists;

        NewArtistForm naf;
        public AllArtistsForm()
        {
            InitializeComponent();
            naf = new NewArtistForm();
            naf.AddNewArtistAction = AddNewArtist;

            deletedArtists = new List<Artist>();
        }

        public void ShowDialog(List<Artist> artists)
        {
            try
            {
                deletedArtists.Clear();
                artistsListBox.Items.Clear();

                artistsList = artists;

                foreach (var e in artistsList)
                    artistsListBox.Items.Add(e);
            }
            catch { }
            this.ShowDialog();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            CheckDeletedArtists?.Invoke(deletedArtists);
            this.Close();
        }

        public void deleteMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var i = artistsListBox.SelectedIndex;
                if (i == -1)
                    throw new Exception();

                deletedArtists.Add(artistsList[i]);
                artistsListBox.Items.RemoveAt(i);
                artistsList.RemoveAt(i);
            }
            catch { }
        }

        /// <summary>
        /// Кнопка добавления нового пользователя.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNewButton_Click(object sender, EventArgs e)
        {
            naf.ShowDialog();
        }

        /// <summary>
        /// Метод добавления нового исполнителя.
        /// </summary>
        /// <param name="newArtist"></param>
        private void AddNewArtist(Artist newArtist)
        {
            try
            {
                artistsList.Add(newArtist);
                artistsListBox.Items.Add(newArtist);
            }
            catch { }
        }
    }
}
