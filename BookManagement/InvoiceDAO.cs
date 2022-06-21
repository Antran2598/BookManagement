using DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class InvoiceDAO : GeneralDAO
    {
        public DataSet GetAllInvoice()
        {
            return GetAll("Vw_accountInvoice");
        }
        public SqlDataReader findById(string id)
        {
            OpenConnection();
            SqlDataReader dr = FindById("Vw_accountInvoice", " ID='" + id + "' ");
            return dr;
        }
        public int deleteInvoice(string id)
        {
            try
            {
                string sql = "delete [invoice] where ID ='" + id + "' ";
                return Insert_Update_Delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }

        }

        public int createInvoice(Invoice invoice)
        {
            try
            {
                string sql = "insert into [invoice] (account_id) " +
                              "values ('" + invoice.account_id + "') ";

                return Insert_Update_Delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }
        }

        public int updateInvoice(Invoice invoice)
        {
            try
            {
                //Dname, Dnumber, Mgr_ssn, Mgr_start_date
                string sql = string.Format("update invoice " +
                                                "set total='{0}'" +
                                                 " where ID ='{1}'",
                                              invoice.total, invoice.ID);
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
