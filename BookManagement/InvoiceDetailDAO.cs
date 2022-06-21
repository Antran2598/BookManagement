using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer_DAL
{
    public class InvoiceDetailDAO : GeneralDAO
    {
        public DataSet GetAllInvoiceDetail()
        {
            return GetAll("Vw_detail");
        }
        public SqlDataReader findById(string id)
        {
            OpenConnection();
            SqlDataReader dr = FindById("Vw_detail", " ID='" + id + "' ");
            return dr;
        }
        public int deleteInvoiceDetail(string id)
        {
            try
            {
                string sql = "delete [invoice_detail] where ID ='" + id + "' ";
                return Insert_Update_Delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }

        }

        public int createInvoiceDetail(Invoice_Detail invoice_detail)
        {
            try
            {
                string sql = string.Format("insert [invoice_detail] " +
                    "                      values('{0}', '{1}', '{2}','{3}','{4}')",
                                           invoice_detail.invoice_id, invoice_detail.book_id, invoice_detail.amount, invoice_detail.price, invoice_detail.total_price);

                return Insert_Update_Delete(sql); // -1 if error

            }
            catch (Exception ex)
            {
                // log
                return -1;
            }
        }

        public int updateInvoiceDetail(Invoice_Detail invoice_detail)
        {
            try
            {
                //Dname, Dnumber, Mgr_ssn, Mgr_start_date
                string sql = string.Format("update invoice_detail " +
                                                "set amount='{0}'" +
                                                 " where ID ='{1}'",
                                              invoice_detail.amount, invoice_detail.ID);
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
