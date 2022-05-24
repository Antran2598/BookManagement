using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class CategoryDAO : GeneralDAO
    {
        public DataSet GetAllCategory()
        {
            return GetAll("category");
        }
        public DataSet SearchByName(string name)
        {
            return Search("category", "cate_name like '%" + name + "%'");
        }
        public SqlDataReader FindById(string id)
        {
            OpenConnection();
            SqlDataReader dataReader = FindById("category" + "ID='" + id + "'");
            return dataReader;
        }
    }
}
