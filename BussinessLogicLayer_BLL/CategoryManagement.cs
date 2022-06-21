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
    public class CategoryManagement
    {
        CategoryDAO cateDao = new CategoryDAO();
        public DataSet ViewCates()
        {
            return cateDao.GetAllCategory();
        }
        public void closeConnection()
        {
            cateDao.CloseConnection();
        }

        public SqlDataReader getDetails(string id)
        {
            return cateDao.findById(id);
        }

        public DataSet searchByName(string name)
        {
            return cateDao.SearchByName(name);
        }
        public int RemoveCate(string id)
        {
            // check valid

            //call DAO
            return cateDao.deleteCate(id);

        }

        public int AddCate(Category category)
        {
            // check valid

            //call DAO
            return cateDao.createCate(category);

        }

        public int UpdateCate(Category category)
        {
            // check valid

            //call DAO
            return cateDao.updateCate(category);

        }
    }
}
