
namespace Product_Warehouse
{
    partial class OrdersForm
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
            this.ordersDataGv = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.orderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGv)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersDataGv
            // 
            this.ordersDataGv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersDataGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderId,
            this.dateColumn,
            this.statusColumn,
            this.payColumn});
            this.ordersDataGv.Location = new System.Drawing.Point(6, 21);
            this.ordersDataGv.Name = "ordersDataGv";
            this.ordersDataGv.RowHeadersWidth = 51;
            this.ordersDataGv.RowTemplate.Height = 24;
            this.ordersDataGv.Size = new System.Drawing.Size(557, 405);
            this.ordersDataGv.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.ordersDataGv);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 426);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // orderId
            // 
            this.orderId.HeaderText = "Order Id";
            this.orderId.MinimumWidth = 6;
            this.orderId.Name = "orderId";
            this.orderId.ReadOnly = true;
            this.orderId.Width = 125;
            // 
            // dateColumn
            // 
            this.dateColumn.HeaderText = "date of Issue";
            this.dateColumn.MinimumWidth = 6;
            this.dateColumn.Name = "dateColumn";
            this.dateColumn.ReadOnly = true;
            this.dateColumn.Width = 125;
            // 
            // statusColumn
            // 
            this.statusColumn.HeaderText = "Status";
            this.statusColumn.MinimumWidth = 6;
            this.statusColumn.Name = "statusColumn";
            this.statusColumn.ReadOnly = true;
            this.statusColumn.Width = 125;
            // 
            // payColumn
            // 
            this.payColumn.HeaderText = "Pay for the order";
            this.payColumn.MinimumWidth = 6;
            this.payColumn.Name = "payColumn";
            this.payColumn.Width = 125;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "OrdersForm";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGv)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersDataGv;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusColumn;
        private System.Windows.Forms.DataGridViewButtonColumn payColumn;
    }
}