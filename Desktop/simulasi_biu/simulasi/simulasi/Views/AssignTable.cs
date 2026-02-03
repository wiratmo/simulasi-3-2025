using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using simulasi.Controllers;
using simulasi.Models;
using simulasi.Helpers;
using System.Data.SqlClient;

namespace simulasi.Views
{
    public partial class AssignTable : Form
    {
        EmployeeController em = new EmployeeController();
        public AssignTable()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (nudPax.Value > 6)
            {
                MessageBox.Show("Pax tidak boleh lebih dari 6!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void AssignTable_Load(object sender, EventArgs e)
        {
            LoadWaitress();
        }

        private void LoadWaitress()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select EmployeeId, Name from Employees", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbWaitress.DataSource = dt;
                cmbWaitress.SelectedIndex = -1;
                cmbWaitress.DisplayMember = "Name";
                cmbWaitress.ValueMember = "EmployeeId";

            }
            
        }
    }
}
