namespace simulasi2.ui
{
    partial class MainForm
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
            btnTableSeating = new Button();
            btnMenu = new Button();
            btnHistory = new Button();
            panel1 = new Panel();
            btnC2 = new Button();
            btnC1 = new Button();
            btnB2 = new Button();
            btnB1 = new Button();
            btnA4 = new Button();
            btnA3 = new Button();
            btnA2 = new Button();
            btnA1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnTableSeating
            // 
            btnTableSeating.Font = new Font("Segoe UI", 20F);
            btnTableSeating.Location = new Point(83, 131);
            btnTableSeating.Name = "btnTableSeating";
            btnTableSeating.Size = new Size(141, 120);
            btnTableSeating.TabIndex = 0;
            btnTableSeating.Text = "TABLE SEATING";
            btnTableSeating.UseVisualStyleBackColor = true;
            btnTableSeating.Click += btnTableSeating_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Segoe UI", 20F);
            btnMenu.Location = new Point(83, 409);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(141, 120);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "MENU";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Segoe UI", 20F);
            btnHistory.Location = new Point(83, 731);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(141, 120);
            btnHistory.TabIndex = 2;
            btnHistory.Text = "HISTORY";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnC2);
            panel1.Controls.Add(btnC1);
            panel1.Controls.Add(btnB2);
            panel1.Controls.Add(btnB1);
            panel1.Controls.Add(btnA4);
            panel1.Controls.Add(btnA3);
            panel1.Controls.Add(btnA2);
            panel1.Controls.Add(btnA1);
            panel1.Location = new Point(401, 138);
            panel1.Name = "panel1";
            panel1.Size = new Size(1441, 713);
            panel1.TabIndex = 3;
            // 
            // btnC2
            // 
            btnC2.Font = new Font("Segoe UI", 20F);
            btnC2.Location = new Point(393, 524);
            btnC2.Name = "btnC2";
            btnC2.Size = new Size(655, 127);
            btnC2.TabIndex = 15;
            btnC2.Text = "C2";
            btnC2.UseVisualStyleBackColor = true;
            // 
            // btnC1
            // 
            btnC1.Font = new Font("Segoe UI", 20F);
            btnC1.Location = new Point(393, 61);
            btnC1.Name = "btnC1";
            btnC1.Size = new Size(655, 127);
            btnC1.TabIndex = 14;
            btnC1.Text = "C1";
            btnC1.UseVisualStyleBackColor = true;
            // 
            // btnB2
            // 
            btnB2.Font = new Font("Segoe UI", 20F);
            btnB2.Location = new Point(907, 285);
            btnB2.Name = "btnB2";
            btnB2.Size = new Size(485, 127);
            btnB2.TabIndex = 13;
            btnB2.Text = "B2";
            btnB2.UseVisualStyleBackColor = true;
            // 
            // btnB1
            // 
            btnB1.Font = new Font("Segoe UI", 20F);
            btnB1.Location = new Point(48, 285);
            btnB1.Name = "btnB1";
            btnB1.Size = new Size(485, 127);
            btnB1.TabIndex = 12;
            btnB1.Text = "B1";
            btnB1.UseVisualStyleBackColor = true;
            // 
            // btnA4
            // 
            btnA4.Font = new Font("Segoe UI", 20F);
            btnA4.Location = new Point(1132, 524);
            btnA4.Name = "btnA4";
            btnA4.Size = new Size(260, 127);
            btnA4.TabIndex = 11;
            btnA4.Text = "A$";
            btnA4.UseVisualStyleBackColor = true;
            // 
            // btnA3
            // 
            btnA3.Font = new Font("Segoe UI", 20F);
            btnA3.Location = new Point(48, 524);
            btnA3.Name = "btnA3";
            btnA3.Size = new Size(260, 127);
            btnA3.TabIndex = 10;
            btnA3.Text = "A3";
            btnA3.UseVisualStyleBackColor = true;
            // 
            // btnA2
            // 
            btnA2.Font = new Font("Segoe UI", 20F);
            btnA2.Location = new Point(1132, 61);
            btnA2.Name = "btnA2";
            btnA2.Size = new Size(260, 127);
            btnA2.TabIndex = 9;
            btnA2.Text = "A2";
            btnA2.UseVisualStyleBackColor = true;
            // 
            // btnA1
            // 
            btnA1.Font = new Font("Segoe UI", 20F);
            btnA1.Location = new Point(48, 61);
            btnA1.Name = "btnA1";
            btnA1.Size = new Size(260, 127);
            btnA1.TabIndex = 8;
            btnA1.Text = "A1";
            btnA1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1061);
            Controls.Add(panel1);
            Controls.Add(btnHistory);
            Controls.Add(btnMenu);
            Controls.Add(btnTableSeating);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnTableSeating;
        private Button btnMenu;
        private Button btnHistory;
        private Panel panel1;
        private Button btnC2;
        private Button btnC1;
        private Button btnB2;
        private Button btnB1;
        private Button btnA4;
        private Button btnA3;
        private Button btnA2;
        private Button btnA1;
    }
}