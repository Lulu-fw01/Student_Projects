namespace Graduate_App
{
    partial class CustomDialog1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lowpasscheckBox = new System.Windows.Forms.CheckBox();
            this.hightpasscheckBox = new System.Windows.Forms.CheckBox();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plusisdowncheckbox = new System.Windows.Forms.CheckBox();
            this.plusisupcheckbox = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.changing_electric_way_CheckBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите частоту lowpassfilter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(358, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введите частоту hightpassfilter";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 5;
            this.numericUpDown1.Location = new System.Drawing.Point(17, 27);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 5;
            this.numericUpDown2.Location = new System.Drawing.Point(362, 27);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(525, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(545, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "вкл/выкл";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lowpasscheckBox
            // 
            this.lowpasscheckBox.AutoSize = true;
            this.lowpasscheckBox.Location = new System.Drawing.Point(169, 29);
            this.lowpasscheckBox.Name = "lowpasscheckBox";
            this.lowpasscheckBox.Size = new System.Drawing.Size(88, 21);
            this.lowpasscheckBox.TabIndex = 8;
            this.lowpasscheckBox.Text = "вкл/выкл";
            this.lowpasscheckBox.UseVisualStyleBackColor = true;
            // 
            // hightpasscheckBox
            // 
            this.hightpasscheckBox.AutoSize = true;
            this.hightpasscheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hightpasscheckBox.Location = new System.Drawing.Point(517, 27);
            this.hightpasscheckBox.Name = "hightpasscheckBox";
            this.hightpasscheckBox.Size = new System.Drawing.Size(88, 21);
            this.hightpasscheckBox.TabIndex = 9;
            this.hightpasscheckBox.Text = "вкл/выкл";
            this.hightpasscheckBox.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Location = new System.Drawing.Point(20, 84);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown3.TabIndex = 10;
            this.numericUpDown3.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(17, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "сила тока (I) * q";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "направление тока";
            // 
            // plusisdowncheckbox
            // 
            this.plusisdowncheckbox.AutoSize = true;
            this.plusisdowncheckbox.Location = new System.Drawing.Point(17, 143);
            this.plusisdowncheckbox.Name = "plusisdowncheckbox";
            this.plusisdowncheckbox.Size = new System.Drawing.Size(73, 21);
            this.plusisdowncheckbox.TabIndex = 13;
            this.plusisdowncheckbox.Text = "на нас";
            this.plusisdowncheckbox.UseVisualStyleBackColor = true;
            this.plusisdowncheckbox.CheckStateChanged += new System.EventHandler(this.plusisdowncheckbox_CheckStateChanged);
            // 
            // plusisupcheckbox
            // 
            this.plusisupcheckbox.AutoSize = true;
            this.plusisupcheckbox.Location = new System.Drawing.Point(17, 163);
            this.plusisupcheckbox.Name = "plusisupcheckbox";
            this.plusisupcheckbox.Size = new System.Drawing.Size(72, 21);
            this.plusisupcheckbox.TabIndex = 14;
            this.plusisupcheckbox.Text = "от нас";
            this.plusisupcheckbox.UseVisualStyleBackColor = true;
            this.plusisupcheckbox.CheckStateChanged += new System.EventHandler(this.plusisupcheckbox_CheckStateChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 71);
            this.button2.TabIndex = 15;
            this.button2.Text = "цвет для смешанного режима";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // changing_electric_way_CheckBox
            // 
            this.changing_electric_way_CheckBox.AutoSize = true;
            this.changing_electric_way_CheckBox.Location = new System.Drawing.Point(17, 200);
            this.changing_electric_way_CheckBox.Name = "changing_electric_way_CheckBox";
            this.changing_electric_way_CheckBox.Size = new System.Drawing.Size(288, 21);
            this.changing_electric_way_CheckBox.TabIndex = 16;
            this.changing_electric_way_CheckBox.Text = "смена направления тока в проводнике";
            this.changing_electric_way_CheckBox.UseVisualStyleBackColor = true;
            this.changing_electric_way_CheckBox.CheckedChanged += new System.EventHandler(this.changing_electric_way_CheckBox_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(312, 198);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 17;
            // 
            // CustomDialog1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 226);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.changing_electric_way_CheckBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.hightpasscheckBox);
            this.Controls.Add(this.plusisupcheckbox);
            this.Controls.Add(this.plusisdowncheckbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.lowpasscheckBox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CustomDialog1";
            this.Text = "проводник";
            this.Load += new System.EventHandler(this.CustomDialog1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox lowpasscheckBox;
        private System.Windows.Forms.CheckBox hightpasscheckBox;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox plusisdowncheckbox;
        private System.Windows.Forms.CheckBox plusisupcheckbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox changing_electric_way_CheckBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}