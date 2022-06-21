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
        public SqlDataReader findById(string id)
        {
            OpenConnection();
            SqlDataReader dataReader = FindById("category", " ID='" + id + "' ");
            return dataReader;
        }

        public int deleteCate(string id)
        {
            try
            {
                string sql = "delete [category] where ID ='" + id + "' ";
                return Insert_Update_Delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }

        }

        public int createCate(Category cate)
        {
            try
            {
                string sql = string.Format("insert [category] " + " values('{0}')", cate.cate_name);

                return Insert_Update_Delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }
        }

        public int updateCate(Category cate)
        {
            try
            {
                //Dname, Dnumber, Mgr_ssn, Mgr_start_date
                string sql = string.Format("update category " +
                                                "set cate_name='{0}'" +
                                                 " where ID ='{1}'",
                                             cate.cate_name, cate.ID);
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
