using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class GeneralDAO
    {
        public String ConnectionString = "Data Source = AN\\ANTRAN; User ID = sa; Password = 1 ; Initial Catalog = BookStore";
        //public String ConnectionString = "Data Source = DESKTOP-PCH6BP9; User ID = sa; Password = 1 ; Initial Catalog = BookStore";
        public string select_from = "select * from ";

        SqlConnection connection = null;

        public DataSet GetAll(string tableName)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(select_from + tableName, ConnectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }
        public DataSet Search(string tableName, string whereSql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(select_from + tableName + " where " + whereSql, ConnectionString);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        public SqlConnection OpenConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(ConnectionString);
            }
            connection.Open();
            return connection;
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection = null;
        }

        public void CloseConnection(SqlConnection connection)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            connection = null;
        }

        //SqlDataReader sử dụng khi chỉ trả về một hàng
        public SqlDataReader FindById(string tableName, string where_primarykey_Id)
        {
            string sql = select_from + tableName + " where " + where_primarykey_Id;
            SqlCommand cmd = new SqlCommand(sql, connection);
            SqlDataReader dataReader = cmd.ExecuteReader();
            return dataReader;
        }

        public int Insert_Update_Delete(string sql)
        {
            SqlConnection con = OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, con);
            int result = cmd.ExecuteNonQuery();
            CloseConnection(con);
            return result;
        }
    }
}
