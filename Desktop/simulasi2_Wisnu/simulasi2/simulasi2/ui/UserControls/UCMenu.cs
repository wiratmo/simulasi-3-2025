using simulasi2.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace simulasi2.ui.UserControls
{
    public partial class UCMenu : UserControl
    {
        public UCMenu()
        {
            InitializeComponent();
        }

        private void UCMenu_Load(object sender, EventArgs e)
        {
            cbCategory.DataSource = MenuRepo.GetCategory();
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "CategoryID";

            dgvMenu.DataSource = MenuRepo.GetData();
            dgvMenu.Columns["CategoryID"].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = tbName.Text;
            dgvMenu.DataSource = MenuRepo.GetData(keyword);
        }
    }
}
