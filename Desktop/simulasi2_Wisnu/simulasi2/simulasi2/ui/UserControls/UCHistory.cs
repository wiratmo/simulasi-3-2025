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
    public partial class UCHistory : UserControl
    {
        public UCHistory()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UCHistory_Load(object sender, EventArgs e)
        {

            cbTableName.DataSource = HistoryRepo.GetTable();
            cbTableName.DisplayMember = "Name";
            cbTableName.ValueMember = "TableID";

            dgvTransaction.DataSource = HistoryRepo.GetTransaction();
            dgvTransaction.Columns["TableID"].Visible = false;

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbTableName.SelectedValue);
            dgvTransaction.DataSource = HistoryRepo.GetTransactionSearch(id);
        }

        private void dgvTransaction_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvTransaction.Rows[e.RowIndex];

            dgvOrder.DataSource = HistoryRepo.GetOrder(Convert.ToInt32(row.Cells["Transaction ID"].Value));
            dgvOrderDetail.DataSource = HistoryRepo.GetOrderDetail(Convert.ToInt32(row.Cells["Transaction ID"].Value));
        }
    }
}
