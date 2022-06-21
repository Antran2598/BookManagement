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
    public class PublisherManagement
    {
        PublisherDAO pubDao = new PublisherDAO();
        public DataSet ViewPubs()
        {
            return pubDao.GetAllPublisher();
        }
        public void closeConnection()
        {
            pubDao.CloseConnection();
        }
        public SqlDataReader getDetails(string id)
        {
            return pubDao.findById(id);
        }

        public DataSet searchByName(string name)
        {
            return pubDao.SearchByName(name);
        }
        public int RemovePub(string id)
        {
            // check valid

            //call DAO
            return pubDao.deletePub(id);

        }

        public int AddPub(Publisher publisher)
        {
            // check valid

            //call DAO
            return pubDao.createPub(publisher);

        }

        public int UpdatePub(Publisher publisher)
        {
            // check valid

            //call DAO
            return pubDao.updatePub(publisher);

        }
    }
}
