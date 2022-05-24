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
    }
}
