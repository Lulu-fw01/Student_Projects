namespace Graduate_App
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.magbut1 = new System.Windows.Forms.Button();
            this.magbut2 = new System.Windows.Forms.Button();
            this.magbut3 = new System.Windows.Forms.Button();
            this.magbut4 = new System.Windows.Forms.Button();
            this.magbut5 = new System.Windows.Forms.Button();
            this.magbut6 = new System.Windows.Forms.Button();
            this.magbut7 = new System.Windows.Forms.Button();
            this.magbut8 = new System.Windows.Forms.Button();
            this.button_editor = new System.Windows.Forms.Button();
            this.button_playingfromAUX = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filetoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.updatefrom_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericUpDown1.BackColor = System.Drawing.Color.Maroon;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numericUpDown1.ForeColor = System.Drawing.Color.Snow;
            this.numericUpDown1.Location = new System.Drawing.Point(9, 70);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(131, 36);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Maroon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(9, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "количество магнитов";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(606, 701);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "запуск из файла";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(562, 674);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(238, 22);
            this.textBox1.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(693, 621);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 47);
            this.button2.TabIndex = 4;
            this.button2.Text = "выбрать файл";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // magbut1
            // 
            this.magbut1.Enabled = false;
            this.magbut1.Location = new System.Drawing.Point(14, 168);
            this.magbut1.Name = "magbut1";
            this.magbut1.Size = new System.Drawing.Size(105, 23);
            this.magbut1.TabIndex = 5;
            this.magbut1.Text = "проводник 1";
            this.magbut1.UseVisualStyleBackColor = true;
            this.magbut1.Click += new System.EventHandler(this.magbut1_Click);
            // 
            // magbut2
            // 
            this.magbut2.Enabled = false;
            this.magbut2.Location = new System.Drawing.Point(14, 197);
            this.magbut2.Name = "magbut2";
            this.magbut2.Size = new System.Drawing.Size(105, 23);
            this.magbut2.TabIndex = 6;
            this.magbut2.Text = "проводник 2";
            this.magbut2.UseVisualStyleBackColor = true;
            this.magbut2.Click += new System.EventHandler(this.magbut2_Click);
            // 
            // magbut3
            // 
            this.magbut3.Enabled = false;
            this.magbut3.Location = new System.Drawing.Point(14, 226);
            this.magbut3.Name = "magbut3";
            this.magbut3.Size = new System.Drawing.Size(105, 23);
            this.magbut3.TabIndex = 7;
            this.magbut3.Text = "проводник 3";
            this.magbut3.UseVisualStyleBackColor = true;
            this.magbut3.Click += new System.EventHandler(this.magbut3_Click);
            // 
            // magbut4
            // 
            this.magbut4.Enabled = false;
            this.magbut4.Location = new System.Drawing.Point(14, 255);
            this.magbut4.Name = "magbut4";
            this.magbut4.Size = new System.Drawing.Size(105, 23);
            this.magbut4.TabIndex = 8;
            this.magbut4.Text = "проводник 4";
            this.magbut4.UseVisualStyleBackColor = true;
            this.magbut4.Click += new System.EventHandler(this.magbut4_Click);
            // 
            // magbut5
            // 
            this.magbut5.Enabled = false;
            this.magbut5.Location = new System.Drawing.Point(14, 284);
            this.magbut5.Name = "magbut5";
            this.magbut5.Size = new System.Drawing.Size(105, 23);
            this.magbut5.TabIndex = 9;
            this.magbut5.Text = "проводник 5";
            this.magbut5.UseVisualStyleBackColor = true;
            this.magbut5.Click += new System.EventHandler(this.magbut5_Click);
            // 
            // magbut6
            // 
            this.magbut6.Enabled = false;
            this.magbut6.Location = new System.Drawing.Point(12, 313);
            this.magbut6.Name = "magbut6";
            this.magbut6.Size = new System.Drawing.Size(105, 23);
            this.magbut6.TabIndex = 10;
            this.magbut6.Text = "проводник 6";
            this.magbut6.UseVisualStyleBackColor = true;
            this.magbut6.Click += new System.EventHandler(this.magbut6_Click);
            // 
            // magbut7
            // 
            this.magbut7.Enabled = false;
            this.magbut7.Location = new System.Drawing.Point(14, 342);
            this.magbut7.Name = "magbut7";
            this.magbut7.Size = new System.Drawing.Size(105, 23);
            this.magbut7.TabIndex = 11;
            this.magbut7.Text = "проводник 7";
            this.magbut7.UseVisualStyleBackColor = true;
            this.magbut7.Click += new System.EventHandler(this.magbut7_Click);
            // 
            // magbut8
            // 
            this.magbut8.Enabled = false;
            this.magbut8.Location = new System.Drawing.Point(14, 371);
            this.magbut8.Name = "magbut8";
            this.magbut8.Size = new System.Drawing.Size(105, 23);
            this.magbut8.TabIndex = 12;
            this.magbut8.Text = "проводник 8";
            this.magbut8.UseVisualStyleBackColor = true;
            this.magbut8.Click += new System.EventHandler(this.magbut8_Click);
            // 
            // button_editor
            // 
            this.button_editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_editor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_editor.ForeColor = System.Drawing.Color.Snow;
            this.button_editor.Location = new System.Drawing.Point(-1, 703);
            this.button_editor.Name = "button_editor";
            this.button_editor.Size = new System.Drawing.Size(194, 34);
            this.button_editor.TabIndex = 21;
            this.button_editor.Text = "редактор";
            this.button_editor.UseVisualStyleBackColor = false;
            this.button_editor.Click += new System.EventHandler(this.button_editor_Click);
            // 
            // button_playingfromAUX
            // 
            this.button_playingfromAUX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_playingfromAUX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_playingfromAUX.ForeColor = System.Drawing.Color.Snow;
            this.button_playingfromAUX.Location = new System.Drawing.Point(594, 426);
            this.button_playingfromAUX.Name = "button_playingfromAUX";
            this.button_playingfromAUX.Size = new System.Drawing.Size(194, 33);
            this.button_playingfromAUX.TabIndex = 22;
            this.button_playingfromAUX.Text = "запуск из...";
            this.button_playingfromAUX.UseVisualStyleBackColor = false;
            this.button_playingfromAUX.Click += new System.EventHandler(this.button_playingfromAUX_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.ForeColor = System.Drawing.Color.Snow;
            this.button3.Location = new System.Drawing.Point(246, 73);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 53);
            this.button3.TabIndex = 23;
            this.button3.Text = "цвет фона";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Snow;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(484, 456);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(304, 24);
            this.comboBox1.TabIndex = 24;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.ForeColor = System.Drawing.Color.Snow;
            this.button4.Location = new System.Drawing.Point(336, 73);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 53);
            this.button4.TabIndex = 25;
            this.button4.Text = "цвет векторов";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(488, 483);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "размер фрейма";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.Color.Maroon;
            this.numericUpDown2.DecimalPlaces = 1;
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numericUpDown2.ForeColor = System.Drawing.Color.Snow;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(246, 171);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 36);
            this.numericUpDown2.TabIndex = 28;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(241, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "ширина вектора";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.Snow;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(484, 511);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 31;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filetoolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filetoolStripMenuItem1
            // 
            this.filetoolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.filetoolStripMenuItem1.Name = "filetoolStripMenuItem1";
            this.filetoolStripMenuItem1.Size = new System.Drawing.Size(56, 24);
            this.filetoolStripMenuItem1.Text = "файл";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.saveAsToolStripMenuItem.Text = "сохранить как";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.loadToolStripMenuItem.Text = "открыть";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(493, 73);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(270, 28);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "режим смешанных цветов";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numericUpDown3.DecimalPlaces = 1;
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.numericUpDown3.ForeColor = System.Drawing.Color.White;
            this.numericUpDown3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown3.Location = new System.Drawing.Point(493, 103);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 36);
            this.numericUpDown3.TabIndex = 34;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk_2);
            // 
            // updatefrom_but
            // 
            this.updatefrom_but.Location = new System.Drawing.Point(403, 456);
            this.updatefrom_but.Name = "updatefrom_but";
            this.updatefrom_but.Size = new System.Drawing.Size(75, 23);
            this.updatefrom_but.TabIndex = 35;
            this.updatefrom_but.Text = "update";
            this.updatefrom_but.UseVisualStyleBackColor = true;
            this.updatefrom_but.Click += new System.EventHandler(this.updatefrom_but_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 737);
            this.Controls.Add(this.updatefrom_but);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button_playingfromAUX);
            this.Controls.Add(this.button_editor);
            this.Controls.Add(this.magbut8);
            this.Controls.Add(this.magbut7);
            this.Controls.Add(this.magbut6);
            this.Controls.Add(this.magbut5);
            this.Controls.Add(this.magbut4);
            this.Controls.Add(this.magbut3);
            this.Controls.Add(this.magbut2);
            this.Controls.Add(this.magbut1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(818, 784);
            this.MinimumSize = new System.Drawing.Size(818, 784);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "меню";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button magbut1;
        private System.Windows.Forms.Button magbut2;
        private System.Windows.Forms.Button magbut3;
        private System.Windows.Forms.Button magbut4;
        private System.Windows.Forms.Button magbut5;
        private System.Windows.Forms.Button magbut6;
        private System.Windows.Forms.Button magbut7;
        private System.Windows.Forms.Button magbut8;
        private System.Windows.Forms.Button button_editor;
        private System.Windows.Forms.Button button_playingfromAUX;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filetoolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button updatefrom_but;
    }
}

