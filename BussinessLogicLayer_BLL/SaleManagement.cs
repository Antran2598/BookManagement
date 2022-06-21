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
    public class SaleManagement
    {
        InvoiceDAO invoiceDAO = new InvoiceDAO();
        InvoiceDetailDAO invoiceDetailDAO = new InvoiceDetailDAO();
        public DataSet ViewInvoice()
        {
            return invoiceDAO.GetAllInvoice();
        }

        public DataSet ViewInvoiceDetails()
        {
            return invoiceDetailDAO.GetAllInvoiceDetail();
        }

        public SqlDataReader getDetailInvoice(string id)
        {
            return invoiceDetailDAO.findById(id);
        }

        public int RemoveInvoiceItem(string id)
        {
            // check valid

            //call DAO
            return invoiceDetailDAO.deleteInvoiceDetail(id);

        }

        public void closeConnection1()
        {
            invoiceDetailDAO.CloseConnection();
        }

        public int AddInvoiceDetails(Invoice_Detail invoice_Detail)
        {
            // check valid

            //call DAO
            return invoiceDetailDAO.createInvoiceDetail(invoice_Detail);

        }

        public SqlDataReader getDetails(string id)
        {
            return invoiceDAO.findById(id);
        }

        public int RemoveInvoice(string id)
        {
            // check valid

            //call DAO
            return invoiceDAO.deleteInvoice(id);

        }

        public int AddInvoice(Invoice invoice)
        {
            // check valid

            //call DAO
            return invoiceDAO.createInvoice(invoice);

        }

        public int UpdateInvoice(Invoice invoice)
        {
            // check valid

            //call DAO
            return invoiceDAO.updateInvoice(invoice);
        }
        public void closeConnection()
        {
            invoiceDAO.CloseConnection();
        }
    }
}
