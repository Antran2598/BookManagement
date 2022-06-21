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
    public class AuthorManagement
    {
        AuthorDAO authorDao = new AuthorDAO();
        public DataSet ViewAuthors()
        {
            return authorDao.GetAllAuthor();
        }
        public void closeConnection()
        {
            authorDao.CloseConnection();
        }

        public SqlDataReader getDetails(string id)
        {
            return authorDao.findById(id);
        }

        public DataSet searchByName(string name)
        {
            return authorDao.SearchByName(name);
        }
        public int RemoveAuthor(string id)
        {
            // check valid

            //call DAO
            return authorDao.deleteAuthor(id);

        }

        public int AddAuthor(Author author)
        {
            // check valid

            //call DAO
            return authorDao.createAuthor(author);

        }

        public int UpdateAuthor(Author author)
        {
            // check valid

            //call DAO
            return authorDao.updateAuthor(author);

        }
    }
}
