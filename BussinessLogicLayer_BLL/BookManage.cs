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

        public SqlDataReader getDetails(string id)
        {
            return bookDao.findById(id);
        }

        public DataSet searchByName(string name)
        {
            return bookDao.SearchByName(name);
        }
        public int RemoveBook(string id)
        {
            // check valid

            //call DAO
            return bookDao.deleteBook(id);

        }

        public int AddBook(Book book)
        {
            // check valid

            //call DAO
            return bookDao.createBook(book);

        }

        public int UpdateBook(Book book)
        {
            // check valid

            //call DAO
            return bookDao.updateBook(book);
        }
        public void closeConnection()
        {
            bookDao.CloseConnection();
        }
    }
}
