using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class AuthorDAO : GeneralDAO
    {
        public DataSet GetAllAuthor()
        {
            return GetAll("author");
        }
        public DataSet SearchByName(string name)
        {
            return Search("author", "author_name like '%" + name + "%'");
        }
        public SqlDataReader findById(string id)
        {
            OpenConnection();
            SqlDataReader dataReader = FindById("author", " ID='" + id + "' ");
            return dataReader;
        }

        public int deleteAuthor(string id)
        {
            try
            {
                string sql = "delete [author] where ID ='" + id + "' ";
                return Insert_Update_Delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }

        }

        public int createAuthor(Author author)
        {
            try
            {
                string sql = string.Format("insert [author] " +" values('{0}')", author.author_name);

                return Insert_Update_Delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }
        }

        public int updateAuthor(Author author)
        {
            try
            {
                //Dname, Dnumber, Mgr_ssn, Mgr_start_date
                string sql = string.Format("update author " +
                                                "set author_name='{0}'" +
                                                 " where ID ='{1}'",
                                             author.author_name, author.ID);
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
