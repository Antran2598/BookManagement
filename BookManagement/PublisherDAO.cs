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
        public SqlDataReader findById(string id)
        {
            OpenConnection();
            SqlDataReader dataReader = FindById("publisher", " ID='" + id + "' ");
            return dataReader;
        }

        public int deletePub(string id)
        {
            try
            {
                string sql = "delete [publisher] where ID ='" + id + "' ";
                return Insert_Update_Delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }

        }

        public int createPub(Publisher pub)
        {
            try
            {
                string sql = string.Format("insert [publisher] " + " values('{0}')", pub.pub_name);

                return Insert_Update_Delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }
        }

        public int updatePub(Publisher pub)
        {
            try
            {
                //Dname, Dnumber, Mgr_ssn, Mgr_start_date
                string sql = string.Format("update publisher " +
                                                "set pub_name='{0}'" +
                                                 " where ID ='{1}'",
                                             pub.pub_name, pub.ID);
                return Insert_Update_Delete(sql);
            }
            catch (Exception ex)
            {
                //log
                return -1;
            }
        }
    }
}
