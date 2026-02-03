namespace simulasi2.ui
{
    partial class TableSeatingDetailForm
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
            btnFinish = new Button();
            btnCancel = new Button();
            tbPaxSize = new TextBox();
            label3 = new Label();
            tbCustomerName = new TextBox();
            label2 = new Label();
            tbWaiterss = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnFinish
            // 
            btnFinish.Location = new Point(281, 206);
            btnFinish.Name = "btnFinish";
            btnFinish.Size = new Size(121, 23);
            btnFinish.TabIndex = 15;
            btnFinish.Text = "Finish Table";
            btnFinish.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(79, 206);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(121, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel Table";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbPaxSize
            // 
            tbPaxSize.Location = new Point(201, 140);
            tbPaxSize.Name = "tbPaxSize";
            tbPaxSize.Size = new Size(224, 23);
            tbPaxSize.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 148);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 12;
            label3.Text = "Pax Size";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Location = new Point(201, 96);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(224, 23);
            tbCustomerName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 104);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(94, 15);
            label2.TabIndex = 10;
            label2.Text = "Customer Name";
            // 
            // tbWaiterss
            // 
            tbWaiterss.Location = new Point(201, 56);
            tbWaiterss.Name = "tbWaiterss";
            tbWaiterss.Size = new Size(224, 23);
            tbWaiterss.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 64);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "Waiterss";
            // 
            // TableSeatingDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 244);
            Controls.Add(btnFinish);
            Controls.Add(btnCancel);
            Controls.Add(tbPaxSize);
            Controls.Add(label3);
            Controls.Add(tbCustomerName);
            Controls.Add(label2);
            Controls.Add(tbWaiterss);
            Controls.Add(label1);
            Name = "TableSeatingDetailForm";
            Text = "TableSeatingDetailForm";
            Load += TableSeatingDetailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFinish;
        private Button btnCancel;
        private TextBox tbPaxSize;
        private Label label3;
        private TextBox tbCustomerName;
        private Label label2;
        private TextBox tbWaiterss;
        private Label label1;
    }
}