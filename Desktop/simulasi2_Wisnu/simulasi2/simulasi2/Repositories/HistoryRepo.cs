using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;
using simulasi2.Helpers;

namespace simulasi2.Repositories
{
    internal class HistoryRepo
    {
        public static DataTable GetTable()
        {
            try
            {
                DataTable dt = DbHelper.ExecuteQuery(
                    @"SELECT * FROM RestaurantTables"
                );

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR: " + ex.Message);
            }

        }

        public static DataTable GetTransaction()
        {
            try
            {
                DataTable dt = DbHelper.ExecuteQuery(
                    @"SELECT T.TransactionID AS [Transaction ID], RT.TableID, RT.Name AS [Table Name], T.CustomerName AS [Customer Name], T.TransactionDate AS [Date], SUM(OD.Price) AS [Total Price]
                    FROM Orders O
                    JOIN Transactions T ON O.TransactionID = T.TransactionID
                    JOIN OrderDetails OD ON O.OrderID = OD.OrderDetailID
                    JOIN RestaurantTables RT ON T.TableID = RT.TableID
                    GROUP BY T.TransactionID, RT.TableID, RT.Name, T.CustomerName, T.TransactionDate"
                );

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR: " + ex.Message);
            }
        }

        public static DataTable GetTransactionSearch(int id)
        {
            try
            {
                DataTable dt = DbHelper.ExecuteQuery(
                    @"SELECT T.TransactionID AS [Transaction ID], RT.TableID, RT.Name AS [Table Name], T.CustomerName AS [Customer Name], T.TransactionDate AS [Date], SUM(OD.Price) AS [Total Price]
                    FROM Orders O
                    JOIN Transactions T ON O.TransactionID = T.TransactionID
                    JOIN OrderDetails OD ON O.OrderID = OD.OrderDetailID
                    JOIN RestaurantTables RT ON T.TableID = RT.TableID
                    WHERE RT.TableId = @id
                    GROUP BY T.TransactionID, RT.TableID, RT.Name, T.CustomerName, T.TransactionDate",
                    new SqlParameter("@id", id)
                );

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR: " + ex.Message);
            }
        }

        public static DataTable GetOrder(int id)
        {
            try
            {
                DataTable dt = DbHelper.ExecuteQuery(
                    @"SELECT T.TransactionID AS [Transaction ID], O.OrderID AS [Order ID], O.OrderTime AS [Order Time], E.EmployeeID, E.Name AS [Input By Waiters], COUNT(OD.OrderDetailID) AS [Number of Item Ordered]
                    FROM Orders O
                    JOIN Transactions T ON O.TransactionID = T.TransactionID
                    JOIN OrderDetails OD ON O.OrderID = OD.OrderDetailID
                    JOIN Employees E ON O.EmployeeID = E.EmployeeID
                    WHERE T.TransactionID = @id
                    GROUP BY T.TransactionID, O.OrderID, O.OrderTime, E.EmployeeID, E.Name",
                    new SqlParameter("@id", id)
                );

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("ERROR: " + ex.Message);
            }
        }

        public static DataTable GetOrderDetail(int id)
        {
            try
            {
                DataTable dt = DbHelper.ExecuteQuery(
                    @"SELECT O.OrderID AS [Order ID], OD.OrderDetailID [Order Detail ID], MI.Name AS [Menu Name], OD.Quantity, OD.Price
                    FROM Orders O
                    JOIN Transactions T ON O.TransactionID = T.TransactionID
                    JOIN OrderDetails OD ON O.OrderID = OD.OrderDetailID
                    JOIN MenuItems MI ON OD.MenuItemID = MI.MenuItemID
                    WHERE T.TransactionID = @id",
                    new SqlParameter("@id", id)
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
