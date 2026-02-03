using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using simulasi2.Repositories;

namespace simulasi2.ui
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnTableSeating_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
            this.Close();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            cbCategory.DataSource = MenuRepo.GetCategory();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "CategoryID";

            dgvMenu.DataSource = MenuRepo.GetData();
        }
    }
}
