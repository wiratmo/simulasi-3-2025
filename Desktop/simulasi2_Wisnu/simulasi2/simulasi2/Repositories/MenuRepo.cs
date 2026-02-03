using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;
using simulasi2.Helpers;

namespace simulasi2.Repositories
{
    internal class MenuRepo
    {
        public static DataTable GetCategory()
        {
            try
            {
                DataTable dt = DbHelper.ExecuteQuery(
                    @"SELECT * FROM Categories"
                );

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR: " + ex.Message);
            }
        }


        public static DataTable GetData(string keyword = null)
        {
            try
            {
                DataTable dt = DbHelper.ExecuteQuery(
                    @"SELECT MI.MenuItemID AS [Menu ID], C.CategoryID, C.Name AS [Category], MI.Name, MI.Price, MI.Description
                    FROM MenuItems MI
                    JOIN Categories C ON MI.CategoryID = C.CategoryID
                    WHERE @keyword = null OR @keyword = '' OR C.Name LIKE '%' + @keyword + '%'",
                    new SqlParameter("@keyword", keyword ?? "")
                );

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR: " + ex.Message);
            }
        }
    }
}
