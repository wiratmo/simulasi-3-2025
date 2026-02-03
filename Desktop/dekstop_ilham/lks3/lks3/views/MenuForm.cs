using lks2.Database;
using lks3.models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lks3.views
{
    public partial class MenuForm : Form
    {
        MenuController controller = new MenuController();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            dgvTable.DataSource = controller.GetMenu();
            cmbCategory.DataSource = controller.FillCategory();
            cmbCategory.ValueMember = "categoryid";
            cmbCategory.DisplayMember = "Name";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(cmbCategory.SelectedValue);
            string n = txtName.Text;
            dgvTable.DataSource = controller.Search(c, n);
        }

        private void btnTableSeating_Click(object sender, EventArgs e)
        {
            new TableSeatingForm().Show();
            this.Hide();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new MenuForm().Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            new HistoryForm().Show();
            this.Hide();
        }
    }
}
