
namespace Product_Warehouse
{
    partial class ProductControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.skuLabel = new System.Windows.Forms.Label();
            this.descriptionRtb = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.toCartNud = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toCartNud)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numLabel);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.skuLabel);
            this.groupBox1.Controls.Add(this.descriptionRtb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(3, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.groupBox1.Size = new System.Drawing.Size(213, 149);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item info:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 6F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(93, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "USD";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Font = new System.Drawing.Font("Tahoma", 6F);
            this.numLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numLabel.Location = new System.Drawing.Point(93, 52);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(61, 12);
            this.numLabel.TabIndex = 8;
            this.numLabel.Text = "numInStock";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Tahoma", 6F);
            this.priceLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.priceLabel.Location = new System.Drawing.Point(47, 40);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(50, 12);
            this.priceLabel.TabIndex = 7;
            this.priceLabel.Text = "priceLabel";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Tahoma", 7F);
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameLabel.Location = new System.Drawing.Point(47, 25);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(65, 14);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "nameLabel";
            // 
            // skuLabel
            // 
            this.skuLabel.AutoSize = true;
            this.skuLabel.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.skuLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skuLabel.Location = new System.Drawing.Point(40, 11);
            this.skuLabel.Name = "skuLabel";
            this.skuLabel.Size = new System.Drawing.Size(44, 12);
            this.skuLabel.TabIndex = 5;
            this.skuLabel.Text = "skuLabel";
            // 
            // descriptionRtb
            // 
            this.descriptionRtb.BackColor = System.Drawing.SystemColors.Control;
            this.descriptionRtb.Enabled = false;
            this.descriptionRtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.descriptionRtb.ForeColor = System.Drawing.SystemColors.MenuText;
            this.descriptionRtb.Location = new System.Drawing.Point(6, 67);
            this.descriptionRtb.MaxLength = 200;
            this.descriptionRtb.Name = "descriptionRtb";
            this.descriptionRtb.Size = new System.Drawing.Size(201, 76);
            this.descriptionRtb.TabIndex = 4;
            this.descriptionRtb.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 6F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(6, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "NUM IN STOCK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 6F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRICE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 6F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "SKU:";
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.LimeGreen;
            this.editButton.Location = new System.Drawing.Point(139, 81);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 23);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "EDIT";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteButton.Location = new System.Drawing.Point(139, 110);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.ErrorImage = global::Product_Warehouse.Properties.Resources.download_error_image;
            this.pictureBox.Image = global::Product_Warehouse.Properties.Resources.clothesImageNotChosen;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(130, 130);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addToCartBtn.Location = new System.Drawing.Point(139, 3);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(75, 50);
            this.addToCartBtn.TabIndex = 7;
            this.addToCartBtn.Text = "Add to cart";
            this.addToCartBtn.UseVisualStyleBackColor = false;
            this.addToCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // toCartNud
            // 
            this.toCartNud.Location = new System.Drawing.Point(139, 59);
            this.toCartNud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.toCartNud.Name = "toCartNud";
            this.toCartNud.Size = new System.Drawing.Size(71, 22);
            this.toCartNud.TabIndex = 10;
            this.toCartNud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ProductControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.toCartNud);
            this.Controls.Add(this.addToCartBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProductControl";
            this.Size = new System.Drawing.Size(223, 289);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toCartNud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox descriptionRtb;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label skuLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addToCartBtn;
        private System.Windows.Forms.NumericUpDown toCartNud;
    }
}
