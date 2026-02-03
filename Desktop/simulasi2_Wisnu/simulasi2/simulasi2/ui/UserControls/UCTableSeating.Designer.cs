namespace simulasi2.ui.UserControls
{
    partial class UCTableSeating
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
            btnA1 = new Button();
            btnA2 = new Button();
            btnA3 = new Button();
            btnA4 = new Button();
            btnB1 = new Button();
            btnB2 = new Button();
            btnC1 = new Button();
            btnC2 = new Button();
            SuspendLayout();
            // 
            // btnA1
            // 
            btnA1.Font = new Font("Segoe UI", 20F);
            btnA1.Location = new Point(56, 58);
            btnA1.Name = "btnA1";
            btnA1.Size = new Size(260, 127);
            btnA1.TabIndex = 0;
            btnA1.Text = "A1";
            btnA1.UseVisualStyleBackColor = true;
            // 
            // btnA2
            // 
            btnA2.Font = new Font("Segoe UI", 20F);
            btnA2.Location = new Point(1140, 58);
            btnA2.Name = "btnA2";
            btnA2.Size = new Size(260, 127);
            btnA2.TabIndex = 1;
            btnA2.Text = "A2";
            btnA2.UseVisualStyleBackColor = true;
            // 
            // btnA3
            // 
            btnA3.Font = new Font("Segoe UI", 20F);
            btnA3.Location = new Point(56, 521);
            btnA3.Name = "btnA3";
            btnA3.Size = new Size(260, 127);
            btnA3.TabIndex = 2;
            btnA3.Text = "A3";
            btnA3.UseVisualStyleBackColor = true;
            // 
            // btnA4
            // 
            btnA4.Font = new Font("Segoe UI", 20F);
            btnA4.Location = new Point(1140, 521);
            btnA4.Name = "btnA4";
            btnA4.Size = new Size(260, 127);
            btnA4.TabIndex = 3;
            btnA4.Text = "A$";
            btnA4.UseVisualStyleBackColor = true;
            // 
            // btnB1
            // 
            btnB1.Font = new Font("Segoe UI", 20F);
            btnB1.Location = new Point(56, 282);
            btnB1.Name = "btnB1";
            btnB1.Size = new Size(485, 127);
            btnB1.TabIndex = 4;
            btnB1.Text = "B1";
            btnB1.UseVisualStyleBackColor = true;
            btnB1.Click += button5_Click;
            // 
            // btnB2
            // 
            btnB2.Font = new Font("Segoe UI", 20F);
            btnB2.Location = new Point(915, 282);
            btnB2.Name = "btnB2";
            btnB2.Size = new Size(485, 127);
            btnB2.TabIndex = 5;
            btnB2.Text = "B2";
            btnB2.UseVisualStyleBackColor = true;
            // 
            // btnC1
            // 
            btnC1.Font = new Font("Segoe UI", 20F);
            btnC1.Location = new Point(401, 58);
            btnC1.Name = "btnC1";
            btnC1.Size = new Size(655, 127);
            btnC1.TabIndex = 6;
            btnC1.Text = "C1";
            btnC1.UseVisualStyleBackColor = true;
            // 
            // btnC2
            // 
            btnC2.Font = new Font("Segoe UI", 20F);
            btnC2.Location = new Point(401, 521);
            btnC2.Name = "btnC2";
            btnC2.Size = new Size(655, 127);
            btnC2.TabIndex = 7;
            btnC2.Text = "C2";
            btnC2.UseVisualStyleBackColor = true;
            // 
            // UCTableSeating
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnC2);
            Controls.Add(btnC1);
            Controls.Add(btnB2);
            Controls.Add(btnB1);
            Controls.Add(btnA4);
            Controls.Add(btnA3);
            Controls.Add(btnA2);
            Controls.Add(btnA1);
            Name = "UCTableSeating";
            Size = new Size(1441, 713);
            ResumeLayout(false);
        }

        #endregion

        private Button btnA1;
        private Button btnA2;
        private Button btnA3;
        private Button btnA4;
        private Button btnB1;
        private Button btnB2;
        private Button btnC1;
        private Button btnC2;
    }
}
