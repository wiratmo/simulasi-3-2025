namespace simulasi2.ui
{
    partial class HistoryForm
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
            panel1 = new Panel();
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
            btnHistory = new Button();
            btnMenu = new Button();
            btnTableSeating = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetail).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Controls.Add(groupBox3);
            panel1.Controls.Add(groupBox4);
            panel1.Location = new Point(401, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(1441, 713);
            panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Controls.Add(btnApply);
            groupBox1.Controls.Add(cbTableName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1400, 106);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
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
            groupBox2.Location = new Point(20, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1400, 134);
            groupBox2.TabIndex = 6;
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
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dgvOrder);
            groupBox3.Location = new Point(20, 350);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1400, 134);
            groupBox3.TabIndex = 7;
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
            groupBox4.Location = new Point(20, 515);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1400, 134);
            groupBox4.TabIndex = 8;
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
            // btnHistory
            // 
            btnHistory.BackColor = SystemColors.ActiveCaption;
            btnHistory.Font = new Font("Segoe UI", 20F);
            btnHistory.Location = new Point(83, 770);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(141, 120);
            btnHistory.TabIndex = 6;
            btnHistory.Text = "HISTORY";
            btnHistory.UseVisualStyleBackColor = false;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 20F);
            btnMenu.Location = new Point(83, 448);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(141, 120);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "MENU";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnTableSeating
            // 
            btnTableSeating.Font = new Font("Segoe UI", 20F);
            btnTableSeating.Location = new Point(83, 170);
            btnTableSeating.Name = "btnTableSeating";
            btnTableSeating.Size = new Size(141, 120);
            btnTableSeating.TabIndex = 4;
            btnTableSeating.Text = "TABLE SEATING";
            btnTableSeating.UseVisualStyleBackColor = true;
            btnTableSeating.Click += btnTableSeating_Click;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(panel1);
            Controls.Add(btnHistory);
            Controls.Add(btnMenu);
            Controls.Add(btnTableSeating);
            Name = "HistoryForm";
            Text = "HistoryForm";
            Load += HistoryForm_Load;
            panel1.ResumeLayout(false);
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

        private Panel panel1;
        private Button btnHistory;
        private Button btnMenu;
        private Button btnTableSeating;
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