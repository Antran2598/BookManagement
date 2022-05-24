using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class BookDAO : GeneralDAO
    {
        public DataSet GetAllBook()
        {
            return GetAll("vw_book");
        }
        public DataSet SearchByName(string name)
        {
            return Search("book", "book_name like '%" + name + "%'");
        }
        public SqlDataReader FindById(string id)
        {
            OpenConnection();
            SqlDataReader dataReader = FindById("book" + "ID='" + id + "'");
            return dataReader;
        }
    }
}
