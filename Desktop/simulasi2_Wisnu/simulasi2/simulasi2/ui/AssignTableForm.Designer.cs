namespace simulasi2.ui
{
    partial class AssignTableForm
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
            label1 = new Label();
            tbCustomer = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbWaiterss = new ComboBox();
            nudPaxSize = new NumericUpDown();
            btnOK = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPaxSize).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 44);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Waiterss";
            // 
            // tbCustomer
            // 
            tbCustomer.Location = new Point(198, 85);
            tbCustomer.Name = "tbCustomer";
            tbCustomer.Size = new Size(230, 23);
            tbCustomer.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 88);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 2;
            label2.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 129);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 3;
            label3.Text = "Pax Size";
            // 
            // cbWaiterss
            // 
            cbWaiterss.FormattingEnabled = true;
            cbWaiterss.Location = new Point(198, 41);
            cbWaiterss.Name = "cbWaiterss";
            cbWaiterss.Size = new Size(230, 23);
            cbWaiterss.TabIndex = 4;
            // 
            // nudPaxSize
            // 
            nudPaxSize.Location = new Point(198, 129);
            nudPaxSize.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            nudPaxSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPaxSize.Name = "nudPaxSize";
            nudPaxSize.Size = new Size(230, 23);
            nudPaxSize.TabIndex = 5;
            nudPaxSize.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnOK
            // 
            btnOK.Location = new Point(59, 188);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(353, 188);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AssignTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 236);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(nudPaxSize);
            Controls.Add(cbWaiterss);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbCustomer);
            Controls.Add(label1);
            Name = "AssignTableForm";
            Text = "AssignTableForm";
            Load += AssignTableForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudPaxSize).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbCustomer;
        private Label label2;
        private Label label3;
        private ComboBox cbWaiterss;
        private NumericUpDown nudPaxSize;
        private Button btnOK;
        private Button btnCancel;
    }
}