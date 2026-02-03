using lks3.controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lks3.views
{
    public partial class HistoryForm : Form
    {
        HistoryController controller = new HistoryController();
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            dgvTransaction.DataSource = controller.GetTransaction();
            dgvOrder.DataSource = controller.GetOrder();
            dgvOrderDetail.DataSource = controller.GetOrderDetail();
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
