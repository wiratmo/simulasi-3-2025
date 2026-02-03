using simulasi.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulasi.Controllers
{
    public class MenuController
    {
        public DataTable GetAll()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select m.MenuItemId, c.Name as Category, m.Name, m.Price, m.Description from MenuItems m JOIN Categories c on c.CategoryId = m.MenuItemId",con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;

            }
            
        }
    }
}
