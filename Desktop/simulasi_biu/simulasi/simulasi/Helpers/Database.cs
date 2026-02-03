using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace simulasi.Helpers
{
    public class Database
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=localhost\\SQLEXPRESS;database = HovSedhepDatabase;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";");
        }
    }
}
