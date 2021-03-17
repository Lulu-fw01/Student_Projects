using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NotepadPlus
{
    public partial class CloseForm : Form
    {
        bool cancel;
        public CloseForm()
        {
            InitializeComponent();
            cancel = true;
        }

        public void ChangeText(string newText)
        {
            label1.Text = newText;
        }

        public  event SaveEventHandler SaveClicked;

        public  event DontSaveEventHandler DontSaveClicked;

        public event CancelEventHandler CancelClicked;
        

        /// <summary>
        /// Save Button.
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            SaveClicked(this, null);
            cancel = false;
            this.Close();
        }


        private void notSaveButton_Click(object sender, EventArgs e)
        {
            DontSaveClicked(this, null);
            cancel = false;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            cancel = true;
            this.Close();
        }

        private void CloseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(cancel == true && CancelClicked != null)
            {
                CancelClicked(this, null);
            }
            cancel = true;
        }
    }

    public delegate void SaveEventHandler(object sender, EventArgs e);

    public delegate void DontSaveEventHandler(object sender, EventArgs e);

    public delegate void CancelEventHandler(object sender, EventArgs e);
    


}
