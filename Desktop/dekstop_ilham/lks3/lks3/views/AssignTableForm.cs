using lks2.Database;
using lks3.models;
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
    public partial class AssignTableForm : Form
    {
        public AssignTableForm()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string meja;
            if (Meja.A1Dipencet)
            {
                meja = "A1";
            } else if (Meja.A2Dipencet)
            {
                meja = "A2";
            }
            else if (Meja.A3Dipencet)
            {
                meja = "A3";
            }
            else if (Meja.A4Dipencet)
            {
                meja = "A4";
            }
            else if (Meja.B1Dipencet)
            {
                meja = "B1";
            }
            else if (Meja.B2Dipencet)
            {
                meja = "B2";
            }
            else if (Meja.C1Dipencet)
            {
                meja = "C1";
            }
            else if (Meja.C2Dipencet)
            {
                meja = "C2";
            }
            SqlConnection conn = Koneksi.GetConnection();
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("INSERT INTO transactions (tableid, customername) VALUES (@t, @c)", conn);
            SqlCommand cmd2 = new SqlCommand("INSERT INTO orders (transactionid, employeeid) VALUES (@t, @c, @d)", conn);
            cmd1.Parameters.AddWithValue("@t", txtCustomer.Text);
        }

        private void AssignTableForm_Load(object sender, EventArgs e)
        {

        }
    }
}
