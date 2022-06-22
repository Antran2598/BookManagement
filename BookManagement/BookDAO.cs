using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class BookDAO : GeneralDAO
    {
        public DataSet GetAllBook()
        {
            //return GetAll("vw_View1");
            return GetAll("vw_book");
        }
        public DataSet SearchByName(string name)
        {
            return Search("book", "book_name like '%" + name + "%'");
        }
        public SqlDataReader findById(string id)
        {
            OpenConnection();
            SqlDataReader dr = FindById("vw_book", " ID='" + id + "' ");
            return dr;
        }
        public int deleteBook(string id)
        {
            try
            {
                string sql = "delete [book] where ID ='" + id + "' ";
                return Insert_Update_Delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }

        }

        public int createBook(Book book)
        {
            try
            {
                string sql = string.Format("insert [book] " +
                    "                      values('{0}', '{1}', '{2}','{3}','{4}','{5}','{6}','{7}')",
                                           book.book_name, book.author, book.publisher, book.category, book.original_price, book.sale_price, book.qty_instock, book.img);

                return Insert_Update_Delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }
        }

        public int updateBook(Book book)
        {
            try
            {
                //Dname, Dnumber, Mgr_ssn, Mgr_start_date
                string sql = string.Format("update book " +
                                                "set book_name='{0}', author='{1}', publisher='{2}', category='{3}', original_price='{4}', sale_price='{5}', qty_instock='{6}', img='{7}'" +
                                                 " where ID ='{8}'",
                                              book.book_name, book.author, book.publisher, book.category, book.original_price, book.sale_price, book.qty_instock, book.img, book.ID);
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
