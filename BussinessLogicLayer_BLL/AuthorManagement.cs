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
    }
}
