
namespace Product_Warehouse
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTb = new System.Windows.Forms.TextBox();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.visitorBtn = new System.Windows.Forms.Button();
            this.createAccLinkLabel = new System.Windows.Forms.LinkLabel();
            this.emailEp = new System.Windows.Forms.ErrorProvider(this.components);
            this.passwordEp = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbGroupBox = new System.Windows.Forms.GroupBox();
            this.responseEp = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.emailEp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseEp)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password:";
            // 
            // emailTb
            // 
            this.emailTb.Location = new System.Drawing.Point(118, 6);
            this.emailTb.Name = "emailTb";
            this.emailTb.Size = new System.Drawing.Size(293, 22);
            this.emailTb.TabIndex = 4;
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(118, 37);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(293, 22);
            this.passwordTb.TabIndex = 5;
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(118, 66);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(152, 32);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // visitorBtn
            // 
            this.visitorBtn.Location = new System.Drawing.Point(276, 65);
            this.visitorBtn.Name = "visitorBtn";
            this.visitorBtn.Size = new System.Drawing.Size(135, 33);
            this.visitorBtn.TabIndex = 7;
            this.visitorBtn.Text = "Continue as visitor";
            this.visitorBtn.UseVisualStyleBackColor = true;
            this.visitorBtn.Click += new System.EventHandler(this.visitorBtn_Click);
            // 
            // createAccLinkLabel
            // 
            this.createAccLinkLabel.AutoSize = true;
            this.createAccLinkLabel.Location = new System.Drawing.Point(203, 101);
            this.createAccLinkLabel.Name = "createAccLinkLabel";
            this.createAccLinkLabel.Size = new System.Drawing.Size(133, 17);
            this.createAccLinkLabel.TabIndex = 8;
            this.createAccLinkLabel.TabStop = true;
            this.createAccLinkLabel.Text = "Create new account";
            this.createAccLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createAccLinkLabel_LinkClicked);
            // 
            // emailEp
            // 
            this.emailEp.ContainerControl = this;
            // 
            // passwordEp
            // 
            this.passwordEp.ContainerControl = this;
            // 
            // tbGroupBox
            // 
            this.tbGroupBox.Location = new System.Drawing.Point(108, -3);
            this.tbGroupBox.Name = "tbGroupBox";
            this.tbGroupBox.Size = new System.Drawing.Size(357, 63);
            this.tbGroupBox.TabIndex = 9;
            this.tbGroupBox.TabStop = false;
            // 
            // responseEp
            // 
            this.responseEp.ContainerControl = this;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 126);
            this.Controls.Add(this.createAccLinkLabel);
            this.Controls.Add(this.visitorBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.emailTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login ";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emailEp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordEp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseEp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTb;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button visitorBtn;
        private System.Windows.Forms.LinkLabel createAccLinkLabel;
        private System.Windows.Forms.ErrorProvider emailEp;
        private System.Windows.Forms.ErrorProvider passwordEp;
        private System.Windows.Forms.GroupBox tbGroupBox;
        private System.Windows.Forms.ErrorProvider responseEp;
    }
}