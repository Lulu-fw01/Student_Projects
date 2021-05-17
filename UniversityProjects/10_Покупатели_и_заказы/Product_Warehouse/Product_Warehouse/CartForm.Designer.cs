
namespace Product_Warehouse
{
    partial class CartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartForm));
            this.datagb = new System.Windows.Forms.GroupBox();
            this.itemsDataGV = new System.Windows.Forms.DataGridView();
            this.SKUColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label = new System.Windows.Forms.Label();
            this.fullPriceLabel = new System.Windows.Forms.Label();
            this.createOrderBtn = new System.Windows.Forms.Button();
            this.datagb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // datagb
            // 
            this.datagb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datagb.Controls.Add(this.itemsDataGV);
            this.datagb.Location = new System.Drawing.Point(3, 4);
            this.datagb.Name = "datagb";
            this.datagb.Size = new System.Drawing.Size(815, 503);
            this.datagb.TabIndex = 0;
            this.datagb.TabStop = false;
            this.datagb.Text = "Items";
            // 
            // itemsDataGV
            // 
            this.itemsDataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsDataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKUColumn,
            this.nameColumn,
            this.numColumn,
            this.priceColumn,
            this.fullPriceColumn,
            this.removeColumn});
            this.itemsDataGV.Location = new System.Drawing.Point(0, 21);
            this.itemsDataGV.Name = "itemsDataGV";
            this.itemsDataGV.RowHeadersWidth = 51;
            this.itemsDataGV.RowTemplate.Height = 24;
            this.itemsDataGV.Size = new System.Drawing.Size(806, 476);
            this.itemsDataGV.TabIndex = 0;
            // 
            // SKUColumn
            // 
            this.SKUColumn.HeaderText = "SKU";
            this.SKUColumn.MinimumWidth = 6;
            this.SKUColumn.Name = "SKUColumn";
            this.SKUColumn.ReadOnly = true;
            this.SKUColumn.Width = 125;
            // 
            // nameColumn
            // 
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 125;
            // 
            // numColumn
            // 
            this.numColumn.HeaderText = "Num";
            this.numColumn.MinimumWidth = 6;
            this.numColumn.Name = "numColumn";
            this.numColumn.ReadOnly = true;
            this.numColumn.Width = 125;
            // 
            // priceColumn
            // 
            this.priceColumn.HeaderText = "Price";
            this.priceColumn.MinimumWidth = 6;
            this.priceColumn.Name = "priceColumn";
            this.priceColumn.ReadOnly = true;
            this.priceColumn.Width = 125;
            // 
            // fullPriceColumn
            // 
            this.fullPriceColumn.HeaderText = "Full Price";
            this.fullPriceColumn.MinimumWidth = 6;
            this.fullPriceColumn.Name = "fullPriceColumn";
            this.fullPriceColumn.ReadOnly = true;
            this.fullPriceColumn.Width = 125;
            // 
            // removeColumn
            // 
            this.removeColumn.HeaderText = "Remove";
            this.removeColumn.MinimumWidth = 6;
            this.removeColumn.Name = "removeColumn";
            this.removeColumn.ReadOnly = true;
            this.removeColumn.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.createOrderBtn);
            this.groupBox1.Controls.Add(this.fullPriceLabel);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Location = new System.Drawing.Point(824, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 503);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(6, 21);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(69, 17);
            this.label.TabIndex = 0;
            this.label.Text = "Full price:";
            // 
            // fullPriceLabel
            // 
            this.fullPriceLabel.AutoSize = true;
            this.fullPriceLabel.Location = new System.Drawing.Point(82, 20);
            this.fullPriceLabel.Name = "fullPriceLabel";
            this.fullPriceLabel.Size = new System.Drawing.Size(16, 17);
            this.fullPriceLabel.TabIndex = 1;
            this.fullPriceLabel.Text = "_";
            // 
            // createOrderBtn
            // 
            this.createOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.createOrderBtn.Location = new System.Drawing.Point(9, 72);
            this.createOrderBtn.Name = "createOrderBtn";
            this.createOrderBtn.Size = new System.Drawing.Size(223, 53);
            this.createOrderBtn.TabIndex = 2;
            this.createOrderBtn.Text = "Create order";
            this.createOrderBtn.UseVisualStyleBackColor = false;
            this.createOrderBtn.Click += new System.EventHandler(this.createOrderBtn_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datagb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CartForm";
            this.Text = "Cart";
            this.datagb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsDataGV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox datagb;
        private System.Windows.Forms.DataGridView itemsDataGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKUColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullPriceColumn;
        private System.Windows.Forms.DataGridViewButtonColumn removeColumn;
        private System.Windows.Forms.Button createOrderBtn;
        private System.Windows.Forms.Label fullPriceLabel;
        private System.Windows.Forms.Label label;
    }
}