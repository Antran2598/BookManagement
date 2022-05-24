using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class AuthorDAO : GeneralDAO
    {
        public DataSet GetAllAuthor()
        {
            return GetAll("author");
        }
        public DataSet SearchByName(string name)
        {
            return Search("author", "author_name like '%" + name + "%'");
        }
        public SqlDataReader FindById(string id)
        {
            OpenConnection();
            SqlDataReader dataReader = FindById("author" + "ID='" + id + "'");
            return dataReader;
        }
    }
}
