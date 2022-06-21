using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;

namespace PresentationLayer
{
    public partial class BookManagement : Form
    {
        BookManage mngBook = new BookManage();
        AuthorManagement mngAuthor = new AuthorManagement();
        CategoryManagement mngCate = new CategoryManagement();
        PublisherManagement mngPub = new PublisherManagement();
        DataSet ds;
        BindingSource bs;
        public BookManagement()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            AdminManagement frmAdmin = new AdminManagement();
            frmAdmin.Show();
            this.Hide();
        }

        private void BookManagement_Load(object sender, EventArgs e)
        {
            ds = mngBook.ViewBooks();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_books.DataSource = bs;

            ds = mngAuthor.ViewAuthors();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "author_name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = bs;

            ds = mngCate.ViewCates();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "cate_name";
            comboBox2.ValueMember = "ID";
            comboBox2.DataSource = bs;

            ds = mngPub.ViewPubs();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "pub_name";
            comboBox3.ValueMember = "ID";
            comboBox3.DataSource = bs;
        }

        private void gv_books_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            if (txt_search.Text.Trim() == "")
            {
                ds = mngBook.searchByName(txt_search.Text);
            }
            else
            {
                ds = mngBook.searchByName(txt_search.Text);
            }

            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_books.DataSource = bs;
        }

        private void gv_books_Click(object sender, EventArgs e)
        {
            int index = gv_books.CurrentRow.Index;
            string bookId = gv_books.Rows[index].Cells[0].Value.ToString();
            SqlDataReader dr = mngBook.getDetails(bookId);
            //select * from employee where ...
            if (dr.Read())
            {
                txt_id.Text = dr.GetInt32(0).ToString();
                txt_bookName.Text = dr.GetString(1);
                comboBox1.Text = dr.GetString(8);
                comboBox2.Text = dr.GetString(9);
                comboBox3.Text = dr.GetString(10);
                txt_originalPrice.Text = dr.GetValue(5).ToString();
                txt_salePrice.Text = dr.GetValue(6).ToString();
                txt_instock.Text = dr.GetInt32(7).ToString();
            }
            mngBook.closeConnection();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int result = mngBook.RemoveBook(txt_id.Text); // cot phone dang su dung lam khoa chinh ssn
            if (result < 0)
            {
                MessageBox.Show("SORRY BAE");
            }
            else
            {
                MessageBox.Show("DONE");
            }

            // refresh
            DataSet ds = mngBook.ViewBooks();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_books.DataSource = bs;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                book_name = txt_bookName.Text,
                author = int.Parse(comboBox1.SelectedValue.ToString()),
                publisher = int.Parse(comboBox3.SelectedValue.ToString()),
                category = int.Parse(comboBox2.SelectedValue.ToString()),
                original_price = float.Parse(txt_originalPrice.Text.ToString()),
                sale_price = float.Parse(txt_salePrice.Text.ToString()),
                qty_instock = int.Parse(txt_instock.Text.ToString())
            };
            // 
            int result = mngBook.AddBook(book);
            if (result < 0)
            {
                MessageBox.Show("SORRY BAE");
            }
            else
            {
                MessageBox.Show("DONE");
            }

            // refresh
            DataSet ds = mngBook.ViewBooks();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_books.DataSource = bs;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                ID = int.Parse(txt_id.Text.ToString()),
                book_name = txt_bookName.Text,
                author = int.Parse(comboBox1.SelectedValue.ToString()),
                publisher = int.Parse(comboBox3.SelectedValue.ToString()),
                category = int.Parse(comboBox2.SelectedValue.ToString()),
                original_price = float.Parse(txt_originalPrice.Text.ToString()),
                sale_price = float.Parse(txt_salePrice.Text.ToString()),
                qty_instock = int.Parse(txt_instock.Text.ToString())
            };
            // 
            int result = mngBook.UpdateBook(book);
            if (result < 0)
            {
                MessageBox.Show("SORRY BAE");
            }
            else
            {
                MessageBox.Show("DONE");
            }
            // refresh
            DataSet ds = mngBook.ViewBooks();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_books.DataSource = bs;
        }
    }
}
