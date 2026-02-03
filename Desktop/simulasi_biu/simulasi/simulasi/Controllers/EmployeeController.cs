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
    public class EmployeeController
    {
        public DataTable GetEmployees()
        {
            using (SqlConnection con = Database.GetConnection())
            {
                SqlDataAdapter da = new SqlDataAdapter("Select EmployeeId, Name from Employees", con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                
            }
            return null;
        }
    }
}
