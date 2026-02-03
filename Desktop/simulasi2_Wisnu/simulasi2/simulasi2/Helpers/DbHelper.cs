using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace simulasi2.Helpers
{
    internal class DbHelper
    {
        private static readonly string connectionString = "Server=localhost\\SQLEXPRESS;Database=HovSedhepDatabase;Trusted_Connection=true;TrustServerCertificate=true;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
        {
            using SqlConnection conn = GetConnection();

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (parameters != null)
                    cmd.Parameters.AddRange(parameters);

                return cmd.ExecuteNonQuery();
            }
        }

        public static DataTable ExecuteQuery(string sql, params SqlParameter[] parameters)
        {
            using(SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static int ExecuteSaclar(string sql, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}
