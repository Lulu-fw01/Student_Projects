
namespace Product_Warehouse
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passwordTwoTb = new System.Windows.Forms.TextBox();
            this.passwordOneTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.phoneMtb = new System.Windows.Forms.MaskedTextBox();
            this.patronymicTb = new System.Windows.Forms.TextBox();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.passwordGroupBox = new System.Windows.Forms.GroupBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adressGb = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.streetTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cityTb = new System.Windows.Forms.TextBox();
            this.countryTb = new System.Windows.Forms.TextBox();
            this.postcodeMtb = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordsErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.surnameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.phoneErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.adressErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nspGb = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.customerRb = new System.Windows.Forms.RadioButton();
            this.sellerRb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.passwordGroupBox.SuspendLayout();
            this.adressGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressErrorProvider)).BeginInit();
            this.nspGb.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("News706 BT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(161, 300);
            this.emailTextBox.MaxLength = 100;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(238, 22);
            this.emailTextBox.TabIndex = 2;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.BlinkRate = 0;
            this.emailErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.emailErrorProvider.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phone number: +7 ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nspGb);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.passwordGroupBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.adressGb);
            this.groupBox1.Location = new System.Drawing.Point(16, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 386);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact info";
            // 
            // passwordTwoTb
            // 
            this.passwordTwoTb.Location = new System.Drawing.Point(0, 31);
            this.passwordTwoTb.MaxLength = 35;
            this.passwordTwoTb.Name = "passwordTwoTb";
            this.passwordTwoTb.PasswordChar = '*';
            this.passwordTwoTb.Size = new System.Drawing.Size(238, 22);
            this.passwordTwoTb.TabIndex = 20;
            // 
            // passwordOneTb
            // 
            this.passwordOneTb.Location = new System.Drawing.Point(0, 3);
            this.passwordOneTb.MaxLength = 35;
            this.passwordOneTb.Name = "passwordOneTb";
            this.passwordOneTb.PasswordChar = '*';
            this.passwordOneTb.Size = new System.Drawing.Size(238, 22);
            this.passwordOneTb.TabIndex = 19;
            this.passwordOneTb.TextChanged += new System.EventHandler(this.passwordOneTb_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(65, 329);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 357);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Repeat password:";
            // 
            // phoneMtb
            // 
            this.phoneMtb.Location = new System.Drawing.Point(175, 84);
            this.phoneMtb.Mask = "(999) 000-0000";
            this.phoneMtb.Name = "phoneMtb";
            this.phoneMtb.Size = new System.Drawing.Size(91, 22);
            this.phoneMtb.TabIndex = 10;
            // 
            // patronymicTb
            // 
            this.patronymicTb.Location = new System.Drawing.Point(113, 62);
            this.patronymicTb.MaxLength = 100;
            this.patronymicTb.Name = "patronymicTb";
            this.patronymicTb.Size = new System.Drawing.Size(286, 22);
            this.patronymicTb.TabIndex = 7;
            // 
            // surnameTb
            // 
            this.surnameTb.Location = new System.Drawing.Point(95, 34);
            this.surnameTb.MaxLength = 100;
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(304, 22);
            this.surnameTb.TabIndex = 6;
            // 
            // passwordGroupBox
            // 
            this.passwordGroupBox.Controls.Add(this.passwordTwoTb);
            this.passwordGroupBox.Controls.Add(this.passwordOneTb);
            this.passwordGroupBox.Location = new System.Drawing.Point(161, 323);
            this.passwordGroupBox.Name = "passwordGroupBox";
            this.passwordGroupBox.Size = new System.Drawing.Size(241, 57);
            this.passwordGroupBox.TabIndex = 18;
            this.passwordGroupBox.TabStop = false;
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(69, 8);
            this.nameTb.MaxLength = 100;
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(330, 22);
            this.nameTb.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Patronymic:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Surname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Name:";
            // 
            // adressGb
            // 
            this.adressGb.Controls.Add(this.label10);
            this.adressGb.Controls.Add(this.streetTb);
            this.adressGb.Controls.Add(this.label9);
            this.adressGb.Controls.Add(this.label8);
            this.adressGb.Controls.Add(this.cityTb);
            this.adressGb.Controls.Add(this.countryTb);
            this.adressGb.Controls.Add(this.postcodeMtb);
            this.adressGb.Controls.Add(this.label4);
            this.adressGb.Location = new System.Drawing.Point(9, 157);
            this.adressGb.Name = "adressGb";
            this.adressGb.Size = new System.Drawing.Size(393, 121);
            this.adressGb.TabIndex = 11;
            this.adressGb.TabStop = false;
            this.adressGb.Text = "Adress";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Postcode:";
            // 
            // streetTb
            // 
            this.streetTb.Location = new System.Drawing.Point(165, 67);
            this.streetTb.MaxLength = 3000;
            this.streetTb.Name = "streetTb";
            this.streetTb.Size = new System.Drawing.Size(228, 22);
            this.streetTb.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(153, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Street, house, flat:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "City:";
            // 
            // cityTb
            // 
            this.cityTb.Location = new System.Drawing.Point(56, 39);
            this.cityTb.MaxLength = 1000;
            this.cityTb.Name = "cityTb";
            this.cityTb.Size = new System.Drawing.Size(337, 22);
            this.cityTb.TabIndex = 13;
            // 
            // countryTb
            // 
            this.countryTb.Location = new System.Drawing.Point(80, 15);
            this.countryTb.MaxLength = 1000;
            this.countryTb.Name = "countryTb";
            this.countryTb.Size = new System.Drawing.Size(313, 22);
            this.countryTb.TabIndex = 12;
            // 
            // postcodeMtb
            // 
            this.postcodeMtb.Location = new System.Drawing.Point(107, 91);
            this.postcodeMtb.Mask = "000-999";
            this.postcodeMtb.Name = "postcodeMtb";
            this.postcodeMtb.Size = new System.Drawing.Size(62, 22);
            this.postcodeMtb.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Country:";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(165, 474);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 7;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(246, 474);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.BlinkRate = 0;
            this.nameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.nameErrorProvider.ContainerControl = this;
            // 
            // passwordsErrorProvider
            // 
            this.passwordsErrorProvider.BlinkRate = 0;
            this.passwordsErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.passwordsErrorProvider.ContainerControl = this;
            // 
            // surnameErrorProvider
            // 
            this.surnameErrorProvider.BlinkRate = 0;
            this.surnameErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.surnameErrorProvider.ContainerControl = this;
            // 
            // phoneErrorProvider
            // 
            this.phoneErrorProvider.BlinkRate = 0;
            this.phoneErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.phoneErrorProvider.ContainerControl = this;
            // 
            // adressErrorProvider
            // 
            this.adressErrorProvider.BlinkRate = 0;
            this.adressErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.adressErrorProvider.ContainerControl = this;
            // 
            // nspGb
            // 
            this.nspGb.Controls.Add(this.label5);
            this.nspGb.Controls.Add(this.nameTb);
            this.nspGb.Controls.Add(this.label6);
            this.nspGb.Controls.Add(this.surnameTb);
            this.nspGb.Controls.Add(this.label7);
            this.nspGb.Controls.Add(this.phoneMtb);
            this.nspGb.Controls.Add(this.patronymicTb);
            this.nspGb.Controls.Add(this.label3);
            this.nspGb.Location = new System.Drawing.Point(9, 31);
            this.nspGb.Name = "nspGb";
            this.nspGb.Size = new System.Drawing.Size(460, 107);
            this.nspGb.TabIndex = 21;
            this.nspGb.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sellerRb);
            this.groupBox2.Controls.Add(this.customerRb);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 70);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Who are you?";
            // 
            // customerRb
            // 
            this.customerRb.AutoSize = true;
            this.customerRb.Checked = true;
            this.customerRb.Location = new System.Drawing.Point(10, 22);
            this.customerRb.Name = "customerRb";
            this.customerRb.Size = new System.Drawing.Size(89, 21);
            this.customerRb.TabIndex = 0;
            this.customerRb.TabStop = true;
            this.customerRb.Text = "Customer";
            this.customerRb.UseVisualStyleBackColor = true;
            this.customerRb.CheckedChanged += new System.EventHandler(this.customerRb_CheckedChanged);
            // 
            // sellerRb
            // 
            this.sellerRb.AutoSize = true;
            this.sellerRb.Location = new System.Drawing.Point(10, 43);
            this.sellerRb.Name = "sellerRb";
            this.sellerRb.Size = new System.Drawing.Size(65, 21);
            this.sellerRb.TabIndex = 1;
            this.sellerRb.TabStop = true;
            this.sellerRb.Text = "Seller";
            this.sellerRb.UseVisualStyleBackColor = true;
            this.sellerRb.CheckedChanged += new System.EventHandler(this.sellerRb_CheckedChanged);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(497, 509);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegistrationForm";
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.passwordGroupBox.ResumeLayout(false);
            this.passwordGroupBox.PerformLayout();
            this.adressGb.ResumeLayout(false);
            this.adressGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adressErrorProvider)).EndInit();
            this.nspGb.ResumeLayout(false);
            this.nspGb.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox patronymicTb;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.GroupBox adressGb;
        private System.Windows.Forms.TextBox countryTb;
        private System.Windows.Forms.MaskedTextBox postcodeMtb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox phoneMtb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cityTb;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox passwordTwoTb;
        private System.Windows.Forms.TextBox passwordOneTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox streetTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider passwordsErrorProvider;
        private System.Windows.Forms.GroupBox passwordGroupBox;
        private System.Windows.Forms.ErrorProvider surnameErrorProvider;
        private System.Windows.Forms.ErrorProvider phoneErrorProvider;
        private System.Windows.Forms.ErrorProvider adressErrorProvider;
        private System.Windows.Forms.GroupBox nspGb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton sellerRb;
        private System.Windows.Forms.RadioButton customerRb;
    }
}