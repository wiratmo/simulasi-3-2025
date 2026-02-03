using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using simulasi2.Models;
using simulasi2.Helpers;
using System.Data;

namespace simulasi2.Repositories
{
    internal class TransactionsRepo
    {
        public static bool TambahTransactions(Transactions tran)
        {
            try
            {
                DbHelper.ExecuteNonQuery(
                    @"INSERT INTO Transactions(TableID, CustomerName) VALUES(@tabelID, @name)",
                    new SqlParameter("@tableID", tran.TableID),
                    new SqlParameter("@name", tran.CustomerName)
                );

                return true;
            } catch (Exception ex)
            {
                throw new Exception("ERROR: " + ex.Message);
            }
        }

        private static bool UpdateStatus(Transactions tran)
        {
            try
            {
                DbHelper.ExecuteNonQuery(
                    @"UPDATE Transactions SET Status = @status WHERE TransactionsID = @ID",
                    new SqlParameter("@status", tran.Status),
                    new SqlParameter("@ID", tran.TransactionsID)
                );

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR: " + ex.Message);
            }
        }

        //private static DataRow MejaTrpakai(int id)
        //{
        //    try
        //    {
        //        DbHelper.ExecuteNonQuery(
        //            @"SELET FROM "
        //        );
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("ERROR: " + ex.Message);
        //    }
        //}
    }
}
