using simulasi.Controllers;
using simulasi.Helpers;
using simulasi.Models;
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
    public partial class UCMenu : UserControl
    {
        
        public UCMenu()
        {
            InitializeComponent();
        }

        private void UCMenu_Load(object sender, EventArgs e)
        {
            LoadMenu();
            LoadCategory();
        }

        private void LoadMenu()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m.MenuItemId, c.Name as Category, m.Name, m.Price, m.Description from MenuItems m JOIN Categories c on c.CategoryId = m.MenuItemId", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMenu.DataSource = dt;
            }
        }

        private void LoadCategory()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT CategoryId, Name from Categories", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cmbCategory.DataSource = dt;
                cmbCategory.SelectedIndex = -1;
                cmbCategory.ValueMember = "CategoryId";
                cmbCategory.DisplayMember = "Name";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = Database.GetConnection())
            {
                string query = "Select m.MenuItemId, c.Name as Category, m.Name, m.Price, m.Description from MenuItems m JOIN Categories c on c.CategoryId = m.MenuItemId where m.Name like @search or m.Name like @category";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtName.Text + "%");
                da.SelectCommand.Parameters.AddWithValue("@category", cmbCategory.ValueMember);

                if (txtName.Text == "")
                {
                    LoadMenu();
                }

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMenu.DataSource= dt;
            }
        }
    }
}
