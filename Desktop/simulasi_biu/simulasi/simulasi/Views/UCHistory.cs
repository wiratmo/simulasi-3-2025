using simulasi.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace simulasi.Views
{
    public partial class UCHistory : UserControl
    {
        public UCHistory()
        {
            InitializeComponent();
        }

        private void UCHistory_Load(object sender, EventArgs e)
        {
            LoadTransaction();
            LoadTable();

            dgvOrder.Visible = false;
            dgvOrderDetail.Visible = false;
        }

        private void LoadTable()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT TableId, Name from RestaurantTables", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbTable.DataSource = dt;
                cmbTable.SelectedIndex = -1;
                cmbTable.ValueMember = "TableId";
                cmbTable.DisplayMember = "Name";
            }
        }

        private void LoadTransaction()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * from Transactions", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvTransaction.DataSource = dt;
            }
        }

        private void LoadOrder()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select t.TransactionID as [Transaction ID], o.OrderID as [Order ID], o.OrderTime as [Order Time], e.Name as [Input By Waitress], o.OrderTime as [Order Time] from Orders o JOIN Transactions t on t.TransactionID = o.OrderID JOIN Employees e ON e.EmployeeId = O.OrderID", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOrder.DataSource = dt;
            }
        }

        private void LoadOrderDetail()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select o.OrderID, od.OrderDetailID, m.Name, od.Quantity, od.Price from OrderDetails od JOIN Orders o on o.OrderID = od.OrderDetailID JOIN MenuItems m on m.MenuItemID = od.OrderDetailID", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvOrderDetail.DataSource = dt;
            }
        }
        private void dgvTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dgvOrder.Visible = true;
                dgvOrderDetail.Visible = true;

                string Id = dgvTransaction.Rows[e.RowIndex].Cells["TransactionID"].Value.ToString();

                LoadOrder();
                LoadOrderDetail();
            }
        }
    }
   }
