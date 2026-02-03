namespace simulasi2.ui.UserControls
{
    partial class UCHistory
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dtpDate = new DateTimePicker();
            btnApply = new Button();
            cbTableName = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvTransaction = new DataGridView();
            groupBox3 = new GroupBox();
            dgvOrder = new DataGridView();
            groupBox4 = new GroupBox();
            dgvOrderDetail = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Controls.Add(btnApply);
            groupBox1.Controls.Add(cbTableName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1400, 106);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(125, 31);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 5;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(348, 67);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(102, 23);
            btnApply.TabIndex = 4;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // cbTableName
            // 
            cbTableName.FormattingEnabled = true;
            cbTableName.Location = new Point(125, 68);
            cbTableName.Name = "cbTableName";
            cbTableName.Size = new Size(200, 23);
            cbTableName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 76);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 1;
            label2.Text = "TableName";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 37);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Date";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvTransaction);
            groupBox2.Location = new Point(20, 149);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1400, 134);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transaction";
            // 
            // dgvTransaction
            // 
            dgvTransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaction.Location = new Point(19, 22);
            dgvTransaction.Name = "dgvTransaction";
            dgvTransaction.ReadOnly = true;
            dgvTransaction.RowHeadersVisible = false;
            dgvTransaction.Size = new Size(1349, 95);
            dgvTransaction.TabIndex = 1;
            dgvTransaction.CellDoubleClick += dgvTransaction_CellDoubleClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvOrder);
            groupBox3.Location = new Point(20, 309);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1400, 134);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Order";
            // 
            // dgvOrder
            // 
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(19, 22);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.ReadOnly = true;
            dgvOrder.RowHeadersVisible = false;
            dgvOrder.Size = new Size(1349, 95);
            dgvOrder.TabIndex = 1;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dgvOrderDetail);
            groupBox4.Location = new Point(20, 474);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1400, 134);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "OrderDetail";
            // 
            // dgvOrderDetail
            // 
            dgvOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetail.Location = new Point(19, 22);
            dgvOrderDetail.Name = "dgvOrderDetail";
            dgvOrderDetail.ReadOnly = true;
            dgvOrderDetail.RowHeadersVisible = false;
            dgvOrderDetail.Size = new Size(1349, 95);
            dgvOrderDetail.TabIndex = 1;
            // 
            // UCHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UCHistory";
            Size = new Size(1441, 713);
            Load += UCHistory_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DateTimePicker dtpDate;
        private Button btnApply;
        private ComboBox cbTableName;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvTransaction;
        private GroupBox groupBox3;
        private DataGridView dgvOrder;
        private GroupBox groupBox4;
        private DataGridView dgvOrderDetail;
    }
}
