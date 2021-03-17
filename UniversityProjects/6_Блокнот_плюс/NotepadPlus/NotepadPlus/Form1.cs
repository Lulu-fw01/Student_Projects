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


    public partial class Form1 : Form
    {

        Color currentForeColor, currentBackColor;
        
        CloseForm clForm;
        CloseForm allFilesClForm;
        bool cancelClosing, cancelAllSaving;
        RichTextBox mainRichTextBox;
        public Form1()
        {
            
            InitializeComponent();
            mainRichTextBox = new RichTextBox();
            //currentFilePath = "";
            currentBackColor = Color.White;
            currentForeColor = Color.Black;
            clForm = new CloseForm();
            allFilesClForm = new CloseForm();
            cancelClosing = false;
            cancelAllSaving = false;
            //mainRichTextBox = new RichTextBox();
            //mainRichTextBox.ContextMenuStrip = rtbContextMenuStrip;

            clForm.SaveClicked += (clForm, EventArgs) => { clFormSaveButton_Click(); };
            clForm.DontSaveClicked += (clForm, EventArgs) => { this.clForm.Close();  cancelClosing = false; };

            allFilesClForm.SaveClicked += (allFilesClForm, EventArgs) => { saveToolStripMenuItem_Click(saveToolStripMenuItem, null); cancelClosing = false; cancelAllSaving = false; };
            allFilesClForm.DontSaveClicked += (allFilesClForm, EventArgs) => { cancelClosing = false; cancelAllSaving = false; };
            allFilesClForm.CancelClicked += (allFilesClForm, EventArgs) => { cancelClosing = true; cancelAllSaving = true; };
            //CloseForm.CancelClicked += (clFoem, EventArgs) => { cancelClosing = true; };

            savingTimer = new Timer();
            savingTimer.Enabled = false;

            //var s = File.ReadAllLines("settings.txt");
            // Тут должно быть чтение файла и установка настроек, но я не успел.
            // потом тут должен быть еще один файл, где есть список файлов, открытых в прошлую сессию , но я не успел(((
        }

        
         
        

        /// <summary>
        /// При нажатии на данную кнопку открывается диалоговой окно,
        /// где можно выбрать куда сохранить текст, размещенный в текстовом поле.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileAs();
            }
            catch
            {
                // Ловим ошибку и выводим сообщение если что-то пойдет не так.
                MessageBox.Show("h-m-m-m, something went wrong \n and we didn't opened save as dialog window file.");
            }
        }

        /// <summary>
        /// Метод для сохранения файла как.
        /// </summary>
        private void SaveFileAs()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;
            var currentFilePath = saveFileDialog.FileName;
            var tp = (RTB_TabPage)textBoxesTabControl.SelectedTab;
            tp.ChangeFileInfo(currentFilePath);
            SaveFile();
            cancelClosing = false;
            clForm.Close();
        }

        /// <summary>
        /// Метод для сохранения файла.
        /// </summary>
        private void SaveFile()
        {
            var tp = (RTB_TabPage)textBoxesTabControl.SelectedTab;
            tp.SaveFile();
            clForm.Close();
        }

        /// <summary>
        /// При нажатии на данную кнопку текст сохраняется в файл, если файл уже выбран.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ChooseSaveMeth();
            }
            catch
            {
                // Ловим ошибку и выводим сообщение если что-то пойдет не так.
                MessageBox.Show("h-m-m-m, something went wrong \n and we didn't saved file.");
            }
        }

        /// <summary>
        /// В данном методе выбирается следующий метод сохранения.
        /// </summary>
        private void ChooseSaveMeth()
        {
            var tp = (RTB_TabPage)textBoxesTabControl.SelectedTab;
            // Если текст не привязан к файлу то пользователю будет предложено выбрать файл, куда сохранить.
            if (tp.GetWayToFile() == "unnamed" || tp.GetWayToFile() == null)
            {
                SaveFileAs();
            }
            else
            {
                // Если текст уже привязан к файлу, то он сохранится в него.
                SaveFile();
            }
        }

        /// <summary>
        /// Нажатие на эту кнопку выбрасывает окно, где можно выбрать файл, который надо открыть.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;
                var filePath = openFileDialog.FileName;
                var tpNum = IsThisFileOpened(filePath);
                if (tpNum == -1)
                {
                    OpenChosenFile(filePath);
                    //currentFilePath = filePath;
                    //mainRichTextBox.Text = File.ReadAllText(filePath);
                }
                else
                {
                    textBoxesTabControl.SelectedTab = textBoxesTabControl.TabPages[tpNum];
                }
            }
            catch
            {
                // Ловим ошибку и выводим сообщение если что-то пойдет не так.
                MessageBox.Show("h-m-m-m, something went wrong \n and we didn't opened file.");
            }
        }

        /// <summary>
        /// Метод открытия выбранного файла в новой TabPage.
        /// </summary>
        /// <param name="filePath">
        /// Путь к файлу.
        /// </param>
        private void OpenChosenFile(string filePath)
        {
            textBoxesTabControl.TabPages.Add(new RTB_TabPage(rtbContextMenuStrip, filePath));
            textBoxesTabControl.SelectedTab = textBoxesTabControl.TabPages[textBoxesTabControl.TabPages.Count - 1];
           
            textBoxesTabControl_SelectedIndexChanged(textBoxesTabControl, null);
        }

        /// <summary>
        /// Если пользователь хочет открыть файл, то эта функция проверяет не открыт ли уже данный файл.
        /// </summary>
        /// <param name="filePath">
        /// Путь к файлу.
        /// </param>
        /// <returns></returns>
        private int IsThisFileOpened(string filePath)
        {
            for(int i = 0; i < textBoxesTabControl.TabPages.Count; i++)
            {
                var t = (RTB_TabPage)textBoxesTabControl.TabPages[i];
                if(t.GetWayToFile() == filePath)
                {
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// При нажатии на эту кнопку закрывается окно приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Метод для процесса закрытия приложения.
        /// Тут всякая байда по типу окна, которое выпадает если файл не сохранен.
        /// </summary>
        private void CloseFormMephedron()
        {
            //clForm.ShowDialog();
            RTB_TabPage tp;
            for(int i = 0; i < textBoxesTabControl.TabPages.Count; i++ )
            {
                tp = (RTB_TabPage)(textBoxesTabControl.TabPages[i]);
                if(tp.Saved == false)
                {
                    if (cancelClosing == true)
                        break;
                    else
                    {
                        textBoxesTabControl.SelectedTab = tp;
                        allFilesClForm.ChangeText($"File {tp.Text} is not saved. Do you want to save it?");
                        allFilesClForm.ShowDialog();
                    }
                }

            }
        }

        private void clFormSaveButton_Click()
        {
            ChooseSaveMeth();
        }
 
        
        /// <summary>
        /// При нажатии на эту кнопку выделенная область в текстовом окне
        /// выделяется жирным.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boldButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем новый стиль.
                SetNewSelectionFontStyle(FontStyle.Bold);
            }
            catch
            {
                MessageBox.Show("h-m-m-m, something went wrong .");
            }
        }

        /// <summary>
        /// При нажатии на эту кнопку выделенная область в текстовом окне
        /// выделяется курсивом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void italicButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем новый стиль.
                SetNewSelectionFontStyle(FontStyle.Italic);
            }
            catch
            {
                MessageBox.Show("h-m-m-m, something went wrong .");
            }
        }

        /// <summary>
        /// Метод для изменения стиля шрифта выделенной области.
        /// </summary>
        /// <param name="newFontStyle">
        /// Новый стиль.
        /// </param>
        private void ChangeSelectionFontStyle(FontStyle newFontStyle)
        {
            // Присваивание нового стиля.
            mainRichTextBox.SelectionFont = new Font(
                mainRichTextBox.SelectionFont.FontFamily,
                mainRichTextBox.SelectionFont.Size,
                newFontStyle);
        }

        /// <summary>
        /// Метод для добавления(или удаления) эффекта в выделенный текст.
        /// </summary>
        /// <param name="modStyle">
        /// Эффект, который необходимо наложить(или убрать).
        /// </param>
        /// <returns></returns>
        private void SetNewSelectionFontStyle( FontStyle modStyle)
        {
            // Тут возникла такая проблема, что когда ты выделяешь фрагмент, где два разных шрифта, и хочешь наложить на фрагмент эффект, 
            // то выпадает nullReferenceException( это может быть если в тексте 
            // есть русский и английский шрифт например, потом мы заменяем тип шрифта, где поддеживается только западноевропейский, а кириллица - нет.). 
            // Поэтому пришлось сделать другую реализацию и выделять каждый символ и накладывать эффеты на каждый отдельно.

            // Начало выделения.
            int selectionStart = mainRichTextBox.SelectionStart;
            // Длина выделения.
            int selectionLength = mainRichTextBox.SelectionLength;
            // Конец выделения.
            int selectionEnd = selectionStart + selectionLength;

            var newStyle = FontStyle.Regular;
            FontStyle currentStyle;
            for (int x = selectionStart; x < selectionEnd; x++)
            {
                // Выделяем один символ из всего выделения.
                mainRichTextBox.Select(x, 1); 
                currentStyle = mainRichTextBox.SelectionFont.Style;
                // Получаем новый шрифт.
                switch (modStyle)
                {
                    // Жирный.
                    case FontStyle.Bold:
                        newStyle = mainRichTextBox.SelectionFont.Bold ? currentStyle ^ modStyle : currentStyle | modStyle;
                        break;
                    // Курсив.
                    case FontStyle.Italic:
                        newStyle = mainRichTextBox.SelectionFont.Italic ? currentStyle ^ modStyle : currentStyle | modStyle;
                        break;
                    // Зачеркивание.
                    case FontStyle.Strikeout:
                        newStyle = mainRichTextBox.SelectionFont.Strikeout ? currentStyle ^ modStyle : currentStyle | modStyle;
                        break;
                    // Подчеркивание.
                    case FontStyle.Underline:
                        newStyle = mainRichTextBox.SelectionFont.Underline ? currentStyle ^ modStyle : currentStyle | modStyle;
                        break;
                }
                // Меняем шрифт ны выделенном фрагменте.
                ChangeSelectionFontStyle(newStyle);
            }
            // Выделяем все как было.
            mainRichTextBox.Select(selectionStart, selectionLength);
            SetFontstyle(modStyle);
        }

        /// <summary>
        /// Метод для наложения эффекта на шрифт который будет печататься.
        /// </summary>
        /// <param name="modStyle">
        /// Эффект, который надо наложить.
        /// </param>
        private void SetFontstyle(FontStyle modStyle)
        { 
            if(mainRichTextBox.SelectionLength == 0)
            {
                var newStyle = FontStyle.Regular;
                FontStyle currentStyle = mainRichTextBox.SelectionFont.Style;
                // Получаем новый шрифт.
                switch (modStyle)
                {
                    // Жирный.
                    case FontStyle.Bold:
                        newStyle = mainRichTextBox.SelectionFont.Bold ? currentStyle ^ modStyle : currentStyle | modStyle;
                        break;
                    // Курсив.
                    case FontStyle.Italic:
                        newStyle = mainRichTextBox.SelectionFont.Italic ? currentStyle ^ modStyle : currentStyle | modStyle;
                        break;
                    // Зачеркивание.
                    case FontStyle.Strikeout:
                        newStyle = mainRichTextBox.SelectionFont.Strikeout ? currentStyle ^ modStyle : currentStyle | modStyle;
                        break;
                    // Подчеркивание.
                    case FontStyle.Underline:
                        newStyle = mainRichTextBox.SelectionFont.Underline ? currentStyle ^ modStyle : currentStyle | modStyle;
                        break;
                }
                ChangeSelectionFontStyle(newStyle);
            }
        }

        /// <summary>
        /// При нажатии на эту кнопку выделенная область в текстовом окне
        /// выделяется зачеркивается.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void crossOutButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем новый стиль.
                SetNewSelectionFontStyle(FontStyle.Strikeout);
            }
            catch
            {
                MessageBox.Show("h-m-m-m, something went wrong .");
            }
        }

        /// <summary>
        /// При нажатии на эту кнопку выделенная область в текстовом окне
        /// выделяется gдчеркиванием.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void underlineButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем новый стиль.
                SetNewSelectionFontStyle(FontStyle.Underline);
            }
            catch
            {
                MessageBox.Show("h-m-m-m, something went wrong .");
            }
        }

        /// <summary>
        /// При нажатии на данную кнопку открывается окно настройки основного шрифта.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Если пользователь нажал "ок", то изменяется основной шрифт.
                if (fontDialog.ShowDialog() == DialogResult.Cancel) return;
                mainRichTextBox.Font = new Font(
                fontDialog.Font.Name,
                fontDialog.Font.Size,
                fontDialog.Font.Style);
            }
            catch
            {
                // Ловим ошибку и выводим сообщение если что-то пойдет не так.
                MessageBox.Show("h-m-m-m, something went wrong \n and we didn't opened file.");
            }
        }

        /// <summary>
        /// При нажатии на данную кнопку вылетает messageBox, подсказки к приложению.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void shortcutKeysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Properties.Resources.ShortcutKeys);
            }
            catch { }
        }

        /// <summary>
        /// Кнопка контекстного меню, при нажатии на которую выбирается весь текст.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Используем метод нашей "текстовой коробки" для выбора текста.
                mainRichTextBox.SelectAll();
            }
            catch
            {
                MessageBox.Show("h-m-m-m, something went wrong \n and we didn't select all text.");
            }
        }

        /// <summary>
        /// Кнопка контекстного меню, при нажатии на которую "вырезается" выделенная часть текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainRichTextBox.Cut();
            }
            catch
            {
                MessageBox.Show("h-m-m-m, something went wrong \n and we didn't cut selected part.");
            }
        }

        /// <summary>
        /// Кнопка контекстного меню, при нажатии на которую создается копия выбранного текста в буфер обмена.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainRichTextBox.Copy();
            }
            catch
            {
                MessageBox.Show("h-m-m-m, something went wrong \n and we didn't copy selected text.");
            }
        }

        /// <summary>
        /// Кнопка контекстного меню, при нажатии на которую, вставляется текст из буфера обмена. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                mainRichTextBox.SelectedText = Clipboard.GetText();
            }
            catch
            {
                MessageBox.Show("h-m-m-m, something went wrong \n and we didn't insert text.");
            }
        }

        /// <summary>
        /// Кнопка контекстного меню при нажатии на которую, пользователь может настроить шрифт выделенного фрагмента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fontFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Если пользователь нажал "ок", то изменяется шрифт выделенной области.
                if (fontDialog.ShowDialog() == DialogResult.Cancel) return;
                mainRichTextBox.SelectionFont = new Font(
                fontDialog.Font.Name,
                fontDialog.Font.Size,
                fontDialog.Font.Style);
            }
            catch
            {
                // Ловим ошибку и выводим сообщение если что-то пойдет не так.
                MessageBox.Show("h-m-m-m, something went wrong \n and we didn't open font dialog.");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Флаг. Если он изменится, то форма не закроется.
            cancelClosing = false; 
            CloseFormMephedron();
            if (cancelClosing == true)
                e.Cancel = true;
            string s = "";
            s = s + Convert.ToString(currentForeColor) + '\n' + Convert.ToString(currentBackColor) +'\n';
            if (savingTimer.Enabled == false)
                s = s + savingTimer.Interval.ToString();
            else
            {
                s = s + "off";
            }
            File.WriteAllText("settings.txt", s);
                    
        }

        /// <summary>
        /// При нажатии на данную кнопку появляется новая вкладка с пустым документом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newDocButton_click(object sender, EventArgs e)
        {
            textBoxesTabControl.TabPages.Add(new RTB_TabPage(rtbContextMenuStrip));
            textBoxesTabControl.SelectedTab = textBoxesTabControl.TabPages[textBoxesTabControl.TabPages.Count - 1];
            textBoxesTabControl_SelectedIndexChanged(textBoxesTabControl, null);
        }

        /// <summary>
        /// При изменении выбранного tabPage меняется ссылка на текстовую коробку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxesTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                label1.Text = textBoxesTabControl.SelectedIndex.ToString();
                var tb = (RTB_TabPage)(textBoxesTabControl.SelectedTab);
                mainRichTextBox = tb.RichTextBox;
                //ChangeColors(tb, currentForeColor, currentBackColor);
                //ChangeColors(mainRichTextBox, currentForeColor, currentBackColor);
            }
            catch
            {

            }
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColors(menuStrip, Color.Black, SystemColors.Control);
            toolStrip.BackColor = Color.FromArgb(255, 192, 255);
            toolStrip.ForeColor = Color.Black;

            ChangeColors(textBoxesTabControl, Color.Black, Color.White);

            currentBackColor = Color.White;
            currentForeColor = Color.Black;
        }
        
        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeColors(menuStrip, Color.White, Color.DarkSlateBlue);

            ChangeColors(textBoxesTabControl, Color.White, Color.Black);

            currentBackColor = Color.Black;
            currentForeColor = Color.White;
        }

        private void ChangeColors(TabControl tc, Color foreColor, Color backColor)
        {
            
                for (int i = 0; i < tc.TabPages.Count; i++)
                {
                    for (int n = 0; n < tc.TabPages[i].Controls.Count; n++)
                        ChangeColors(tc.TabPages[i].Controls[n], foreColor, backColor);
                    tc.TabPages[i].ForeColor = foreColor;
                    tc.TabPages[i].BackColor = backColor;
                }
            
            
        }

        private void ChangeColors(Control contr, Color foreColor, Color backColor)
        {
            
                for(int i = 0; i < contr.Controls.Count; i++)
                {
                    ChangeColors(contr.Controls[i], foreColor, backColor);
                }
            
            contr.ForeColor = foreColor;
            contr.BackColor = backColor;
        }

        private void ChangeColors(MenuStrip ms, Color foreColor, Color backColor)
        {
            
                for (int i = 0; i < ms.Items.Count; i++)
                {
                    ChangeColors(ms.Items[i], foreColor, backColor);
                }
            
            ms.ForeColor = foreColor;
            ms.BackColor = backColor;
        }

        private void ChangeColors(ToolStripItem tsi,Color foreColor, Color backColor)
        {
            tsi.ForeColor = foreColor;
            tsi.BackColor = backColor;
        }

        Color darkBackColor = Color.DarkSlateBlue;
        Color darkForeColor = Color.White;
        Color lightForeColor = Color.Black;
        Color lightBackColor = Color.White;


        /// <summary>
        /// При нажатии на данную кнопку сохраняются все файлы, открытые в данном окне.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                cancelAllSaving = false;
                RTB_TabPage tp;
                for (int i = 0; i < textBoxesTabControl.TabPages.Count; i++)
                {
                    tp = (RTB_TabPage)(textBoxesTabControl.TabPages[i]);
                    if (tp.Saved == false)
                    {
                        if (cancelAllSaving == true)
                            break;
                        else
                        {
                            if (tp.GetWayToFile() != "unnamed")
                            {
                                tp.SaveFile();
                            }
                            else
                            {
                                textBoxesTabControl.SelectedTab = tp;
                                allFilesClForm.ChangeText($"File {tp.Text} has not got a way. Do you want to save it?");
                                allFilesClForm.ShowDialog();
                            }
                        }
                    }

                }
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("hmmm, something went wrong. We din't save all files.");
            }
        }

        /// <summary>
        /// Каждый интервал сохраняются файлы, к которым есть путь.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void savingTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                RTB_TabPage tp;
                for (int i = 0; i < textBoxesTabControl.TabPages.Count; i++)
                {
                    tp = (RTB_TabPage)(textBoxesTabControl.TabPages[i]);
                    if (tp.Saved == false)
                    {
                            if (tp.GetWayToFile() != "unnamed")
                            {
                                tp.SaveFile();
                            }
                    }
                }
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                MessageBox.Show("hmmm, something went wrong. We din't save all files.");
            }
        }

        /// <summary>
        /// Установка интервала таймера в 10 минут.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tenMinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                savingTimer.Stop();
                savingTimer.Interval = 10000;
                savingTimer.Start();
                thirtyMinsToolStripMenuItem.Checked = false;
                offToolStripMenuItem.Checked = false;
                fifteenMinsoolStripMenuItem.Checked = false;
                tenMinsToolStripMenuItem.Checked = true;
            }
            catch { }
        }

        /// <summary>
        /// Установка интервала таймера в 15 минут.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fiftenMinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                savingTimer.Stop();
                savingTimer.Interval = 15000;
                savingTimer.Start();
                tenMinsToolStripMenuItem.Checked = false;
                thirtyMinsToolStripMenuItem.Checked = false;
                offToolStripMenuItem.Checked = false;
                fifteenMinsoolStripMenuItem.Checked = true;
            }
            catch { }
        }

        /// <summary>
        /// Установка интервала тайимера в 30 минут.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thirtyMinsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                savingTimer.Stop();
                savingTimer.Interval = 30000;
                savingTimer.Start();
                tenMinsToolStripMenuItem.Checked = false;
                fifteenMinsoolStripMenuItem.Checked = false;
                thirtyMinsToolStripMenuItem.Checked = true;
                offToolStripMenuItem.Checked = false;
            }
            catch { }
        }

        /// <summary>
        /// Кнопка отключения таймера.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                savingTimer.Stop();
                tenMinsToolStripMenuItem.Checked = false;
                fifteenMinsoolStripMenuItem.Checked = false;
                thirtyMinsToolStripMenuItem.Checked = false;
                offToolStripMenuItem.Checked = true;
            }
            catch { }
        }

        /// <summary>
        /// При нажжатии на данную кнопку создается пустой файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createHereTooltripMenuItem_Click(object sender, EventArgs e)
        {
            newDocButton_click(createHereToolStripMenuItem, null);
        }

        /// <summary>
        /// При нажатии на данную кнопку открывается новое окно с пустым файлом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createWindTooltripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            f.newDocButton_click(this, null);
           
        }

    }
}
