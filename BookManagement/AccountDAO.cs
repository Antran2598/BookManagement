using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class AccountDAO: GeneralDAO
    {
        public DataSet GetAllAccount()
        {
            return GetAll("account");
        }
        public DataSet SearchByName(string name)
        {
            return Search("account", "user_name like '%" + name + "%'");
        }
        public SqlDataReader FindById(string id)
        {
            OpenConnection();
            SqlDataReader dataReader = FindById("account" + "ID='" + id + "'");
            return dataReader;
        }

        public bool register(Account account)
        {
            try
            {
                string sql = "insert into [account] (user_name, password, role) " +
                             "values ('" + account.user_name + "','" + account.password + "' , '" + 2 + "') ";
                return Insert_Update_Delete(sql) > 0;// -1 if error
            }
            catch (Exception ex)
            {
                //log
                return false;
            }
        }

        public bool checkLogin(string username, string password)
        {
            OpenConnection();
            SqlDataReader dr = FindById("account", "user_name='" + username + "' and password='" + password + "'");
            if (dr.Read())
            {
                CloseConnection();
                return true;
            }
            else
            {
                CloseConnection();
                return false;
            }
        }
    }
}
