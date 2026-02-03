namespace simulasi2.ui
{
    partial class MenuForm
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
            btnSearch = new Button();
            tbName = new TextBox();
            cbCategory = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvMenu = new DataGridView();
            btnHistory = new Button();
            btnMenu = new Button();
            btnTableSeating = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMenu).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(groupBox2);
            panel1.Location = new Point(401, 177);
            panel1.Name = "panel1";
            panel1.Size = new Size(1441, 713);
            panel1.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(cbCategory);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 29);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1400, 106);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filter";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(326, 73);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(102, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            tbName.Location = new Point(124, 73);
            tbName.Name = "tbName";
            tbName.Size = new Size(171, 23);
            tbName.TabIndex = 3;
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(124, 29);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(171, 23);
            cbCategory.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 76);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 37);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvMenu);
            groupBox2.Location = new Point(20, 186);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1400, 498);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu";
            // 
            // dgvMenu
            // 
            dgvMenu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMenu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMenu.Location = new Point(19, 37);
            dgvMenu.Name = "dgvMenu";
            dgvMenu.ReadOnly = true;
            dgvMenu.RowHeadersVisible = false;
            dgvMenu.Size = new Size(1362, 437);
            dgvMenu.TabIndex = 0;
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Segoe UI", 20F);
            btnHistory.Location = new Point(83, 770);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(141, 120);
            btnHistory.TabIndex = 6;
            btnHistory.Text = "HISTORY";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.ActiveCaption;
            btnMenu.Font = new Font("Segoe UI", 20F);
            btnMenu.Location = new Point(83, 448);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(141, 120);
            btnMenu.TabIndex = 5;
            btnMenu.Text = "MENU";
            btnMenu.UseVisualStyleBackColor = false;
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
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(panel1);
            Controls.Add(btnHistory);
            Controls.Add(btnMenu);
            Controls.Add(btnTableSeating);
            Name = "MenuForm";
            Text = "MenuForm";
            Load += MenuForm_Load;
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnHistory;
        private Button btnMenu;
        private Button btnTableSeating;
        private GroupBox groupBox1;
        private Button btnSearch;
        private TextBox tbName;
        private ComboBox cbCategory;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dgvMenu;
    }
}