using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class PublisherDAO : GeneralDAO
    {
        public DataSet GetAllPublisher()
        {
            return GetAll("publisher");
        }
        public DataSet SearchByName(string name)
        {
            return Search("publisher", "pub_name like '%" + name + "%'");
        }
        public SqlDataReader FindById(string id)
        {
            OpenConnection();
            SqlDataReader dataReader = FindById("publisher" + "ID='" + id + "'");
            return dataReader;
        }
    }
}
