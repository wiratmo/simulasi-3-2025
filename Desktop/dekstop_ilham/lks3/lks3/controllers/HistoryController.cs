using lks2.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lks3.controllers
{
    internal class HistoryController
    {
        public DataTable GetTransaction()
        {
            SqlConnection conn = Koneksi.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT transactions.transactionid as 'Transaction ID', restauranttables.name as 'Table Name', transactions.CustomerName as 'Customer Name', transactions.transactiondate as 'Date', SUM(orderdetails.quantity * orderdetails.price) as 'Total Price' FROM transactions JOIN restauranttables ON transactions.tableid = restauranttables.tableid JOIN orders ON transactions.transactionid = orders.transactionid JOIN orderdetails ON orders.orderid = orderdetails.orderid GROUP BY transactions.transactionid, restauranttables.name, transactions.customername, transactions.transactiondate", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetOrder()
        {
            SqlConnection conn = Koneksi.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT transactions.transactionid as 'Transaction ID', orders.orderid as 'Order ID', orders.ordertime AS 'Order Time', employees.name as 'Input By Waitress', COUNT(orderdetails.orderid) AS 'Number Of Item Ordered' FROM orders JOIN employees ON orders.employeeid = employees.employeeid JOIN transactions ON orders.transactionid = transactions.transactionid JOIN orderdetails ON orders.orderid = orderdetails.orderid GROUP BY transactions.transactionid, orders.orderid, orders.ordertime, employees.name", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetOrderDetail()
        {
            SqlConnection conn = Koneksi.GetConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT orderdetails.orderid as 'Order ID', orderdetails.orderdetailid as 'Order Detail ID', menuitems.name as 'Menu Name', orderdetails.Quantity, orderdetails.Price FROM orderdetails JOIN menuitems ON orderdetails.menuitemid = menuitems.menuitemid", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
