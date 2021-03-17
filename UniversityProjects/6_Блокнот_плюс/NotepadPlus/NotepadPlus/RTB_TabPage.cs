using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
 



namespace NotepadPlus
{
    class RTB_TabPage : System.Windows.Forms.TabPage
    {
        bool saved;
        RichTextBox rtb;
        FileInfo fileInfo;
        /// <summary>
        /// Информация о файле.
        /// </summary>
        public FileInfo FileInformation
        {
            get { return fileInfo; }
            set { fileInfo = value;  }
        }
        /// <summary>
        /// Текстовая коробка.
        /// </summary>
        public RichTextBox RichTextBox 
        {
            get { return rtb; }
            set { rtb = value; } 
        }

        public bool Saved
        {
            get { return saved; }
            set { saved = value; }
        }

        private void ReadTextFromFile(string filePath)
        {
            var type = Path.GetExtension(filePath);
            switch(type)
            {
                case ".txt":
                    rtb.Text = File.ReadAllText(filePath);
                    break;
                case ".rtf":
                    rtb.LoadFile(filePath);
                    break;
            }
            
        }

        public RTB_TabPage(ContextMenuStrip cms) : base()
        {
            try
            {
                AddRTB(cms);
                this.Text = "unnamed";
                saved = false;
            }
            catch { }
        }

        /// <summary>
        /// Метод добавления текстовой коробки без текста.
        /// </summary>
        /// <param name="cms">
        /// Контекстное меню для текстовой коробки.
        /// </param>
        private void AddRTB(ContextMenuStrip cms)
        {
            if (rtb == null)
            {
                ConstructRTB(cms);
                this.Controls.Add(rtb);
            }
        }

        /// <summary>
        /// Метод добавления текстовой коробки с текстом из файла.
        /// </summary>
        /// <param name="cms">
        /// Контекстное меню для текстовой коробки.
        /// </param>
        /// <param name="filePath">
        /// Путь к файлу.
        /// </param>
        private void AddRTB(ContextMenuStrip cms, string filePath)
        {
            if (rtb == null)
            {
                ConstructRTB(cms);
                ReadTextFromFile(filePath);
                this.Controls.Add(rtb);
            }
        }

        /// <summary>
        /// Метод для конструирования стандартной текстовой коробки.
        /// </summary>
        /// <param name="cms"></param>
        private void ConstructRTB(ContextMenuStrip cms)
        {
            rtb = new RichTextBox();
            rtb.Location = new Point(0, 0);
            rtb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtb.ContextMenuStrip = cms;
            rtb.Size = new Size(this.Size.Width, this.Size.Height);
            rtb.TextChanged += new EventHandler(rtb_TextChanged);
        }

        public RTB_TabPage(ContextMenuStrip cms, string text) : base(text)
        {
            try
            {
                AddRTB(cms, text);
                fileInfo = new FileInfo(text);
                this.Text = fileInfo.Name;
                saved = true;
            }
            catch { }

        }

        public void ChangeFileInfo(string filePath)
        {
            fileInfo = new FileInfo(filePath);
            this.Text = fileInfo.Name;
            
        }

        /// <summary>
        /// Хрень которвая возвращает путь к файлу, если он есть. Если его нет, то возвращает "unnamed".
        /// </summary>
        /// <returns></returns>
        public string GetWayToFile()
        {
            if (fileInfo == null)
                return "unnamed";
            else
                return fileInfo.FullName;
        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            saved = false;
        }

        /// <summary>
        /// Метод для сохранения содержимого текстовой коробки в файл.
        /// </summary>
        public void SaveFile()
        {
            try
            {
                if (fileInfo != null)
                {
                    if (saved == false)
                    {
                        switch (Path.GetExtension(fileInfo.FullName))
                        {
                            // Если пользователь выбрал файл формата txt, то используем File.WriteAllText.
                            case ".txt":
                                File.WriteAllText(fileInfo.FullName, rtb.Text);
                                break;
                            // Иначе используем метод rich text box .saveFile.
                            case ".rtf":
                                rtb.SaveFile(fileInfo.FullName);
                                break;
                        }
                        saved = true;
                    }
                }
            }
            catch {
                MessageBox.Show("File Wasnt saved");
            }
        }
        
    }
}
