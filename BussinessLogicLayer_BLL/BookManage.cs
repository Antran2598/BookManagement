using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_DAL;
using System.Data;
using System.Data.SqlClient;

namespace BussinessLogicLayer_BLL
{
    public class BookManage
    {
        BookDAO bookDao = new BookDAO();
        public DataSet ViewBooks()
        {
            return bookDao.GetAllBook();
        }

        public SqlDataReader getDatails(string id)
        {
            return bookDao.FindById(id);
        }

    }
}
