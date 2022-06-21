using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormSale : Form
    {
        SaleManagement mngSale = new SaleManagement();
        AccountManagement accountManagement = new AccountManagement();
        BookManage mngBook = new BookManage();
        DataSet ds;
        BindingSource bs;
        public FormSale()
        {
            InitializeComponent();
            txt_invoiceID.Enabled = false;
            txt_price.Enabled = false;
            txt_total.Enabled = false;
            txt_itemId.Enabled = false;
        }

        private void FormSale_Load(object sender, EventArgs e)
        {
            ds = mngSale.ViewInvoice();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;

            ds = mngSale.ViewInvoiceDetails();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            dataGridView2.DataSource = bs;

            ds = accountManagement.ViewAccounts();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            cbx_staff.DisplayMember = "user_name";
            cbx_staff.ValueMember = "ID";
            cbx_staff.DataSource = bs;

            ds = mngBook.ViewBooks();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            cbx_book.DisplayMember = "book_name";
            cbx_book.ValueMember = "ID";
            cbx_book.DataSource = bs;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice()
            {
                account_id = int.Parse(cbx_staff.SelectedValue.ToString())
            };
            int result = mngSale.AddInvoice(invoice);
            if (result < 0)
            {
                MessageBox.Show("SORRY BAE");
            }
            else
            {
                MessageBox.Show("DONE");
            }
            DataSet ds = mngSale.ViewInvoice();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            dataGridView1.DataSource = bs;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            string invoiceId = dataGridView1.Rows[index].Cells[0].Value.ToString();
            SqlDataReader dr = mngSale.getDetails(invoiceId);
            if (dr.Read())
            {
                txt_invoiceID.Text = dr.GetInt32(0).ToString();
                cbx_staff.Text = dr.GetString(2);
            }
            mngSale.closeConnection();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Invoice_Detail invoice_Detail = new Invoice_Detail()
            {
                invoice_id = int.Parse(txt_invoiceID.Text.ToString()),
                book_id = int.Parse(cbx_book.SelectedValue.ToString()),
                amount = int.Parse(txt_quantity.Text.ToString()),
                price = float.Parse(txt_price.Text.ToString()),
                total_price = float.Parse(txt_total.Text.ToString())
            };
            int result = mngSale.AddInvoiceDetails(invoice_Detail);
            if (result < 0)
            {
                MessageBox.Show("SORRY BAE");
            }
            else
            {
                MessageBox.Show("DONE");
            }
            DataSet ds = mngSale.ViewInvoiceDetails();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            dataGridView2.DataSource = bs;
        }

        private void cbx_book_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bookId = cbx_book.SelectedValue.ToString();
            SqlDataReader dr = mngBook.getDetails(bookId);
            if (dr.Read())
            {
                txt_price.Text = dr.GetValue(6).ToString();
            }
            mngBook.closeConnection();
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            float price = float.Parse(txt_price.Text);
            int amount = int.Parse(txt_quantity.Text);
            float total = price * amount;
            txt_total.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPrint frmPrint = new FormPrint();
            frmPrint.Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            AdminManagement frmAdmin = new AdminManagement();
            frmAdmin.Show();
            this.Hide();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            int index = dataGridView2.CurrentRow.Index;
            string itemId = dataGridView2.Rows[index].Cells[0].Value.ToString();
            SqlDataReader dr = mngSale.getDetailInvoice(itemId);
            //select * from employee where ...
            if (dr.Read())
            {
                txt_itemId.Text = dr.GetInt32(0).ToString();
                cbx_book.Text = dr.GetString(3);
                txt_total.Text = dr.GetValue(6).ToString();
                txt_quantity.Text = dr.GetInt32(4).ToString();
            }
            mngSale.closeConnection1();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int result = mngSale.RemoveInvoiceItem(txt_itemId.Text); // cot phone dang su dung lam khoa chinh ssn
            if (result < 0)
            {
                MessageBox.Show("SORRY BAE");
            }
            else
            {
                MessageBox.Show("DONE");
            }
            DataSet ds = mngSale.ViewInvoiceDetails();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            dataGridView2.DataSource = bs;
        }
    }
}
