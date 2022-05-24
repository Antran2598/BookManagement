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
            comboBox1.ValueMember = "author";
            comboBox1.SelectedIndex = -1;
            comboBox1.DataSource = bs;

            ds = mngCate.ViewCates();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "cate_name";
            comboBox2.ValueMember = "category";
            comboBox2.SelectedIndex = -1;
            comboBox2.DataSource = bs;

            ds = mngPub.ViewPubs();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            comboBox3.DisplayMember = "pub_name";
            comboBox3.ValueMember = "publisher";
            comboBox3.SelectedIndex = -1;
            comboBox3.DataSource = bs;
        }

        private void gv_books_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
