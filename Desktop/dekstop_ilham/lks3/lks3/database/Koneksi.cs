using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lks2.Database
{
    internal class Koneksi
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=HovSedhepDatabase;Integrated Security=True;Encrypt=False");
        }
    }
}
