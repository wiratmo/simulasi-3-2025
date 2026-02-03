using lks2.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lks3.models
{
    internal class MenuController
    {
        public DataTable FillCategory()
        {
            SqlConnection conn = Koneksi.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM categories", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow row = dt.NewRow();
            row["categoryid"] = 0;
            row["name"] = "All";
            dt.Rows.InsertAt(row, 0);
            return dt;
        }

        public DataTable GetMenu()
        {
            SqlConnection conn = Koneksi.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT menuitems.menuitemid AS 'Menu ID', categories.name AS Category, menuitems.name, menuitems.price, menuitems.description FROM menuitems JOIN categories ON menuitems.categoryid = categories.categoryid", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable Search(int c, string n)
        {
            SqlCommand cmd;
            SqlConnection conn = Koneksi.GetConnection();
            conn.Open();
            if (c == 0)
            {
                cmd = new SqlCommand("SELECT menuitems.menuitemid AS 'Menu ID', categories.name AS Category, menuitems.name, menuitems.price, menuitems.description FROM menuitems JOIN categories ON menuitems.categoryid = categories.categoryid WHERE menuitems.name LIKE @n", conn);
            }
            else
            {
                cmd = new SqlCommand("SELECT menuitems.menuitemid AS 'Menu ID', categories.name AS Category, menuitems.name, menuitems.price, menuitems.description FROM menuitems JOIN categories ON menuitems.categoryid = categories.categoryid WHERE menuitems.categoryid = @c and menuitems.name LIKE @n", conn);
            }
            cmd.Parameters.AddWithValue("@c", c);
            cmd.Parameters.AddWithValue("@n", "%" + n + "%");
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
