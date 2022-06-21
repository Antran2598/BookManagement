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
    public partial class AuthorManage : Form
    {
        DataSet ds;
        BindingSource bs;
        AuthorManagement mngAuthor = new AuthorManagement();
        public AuthorManage()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            AdminManagement frmAdmin = new AdminManagement();
            frmAdmin.Show();
            this.Hide();
        }

        private void AuthorManage_Load(object sender, EventArgs e)
        {
            ds = mngAuthor.ViewAuthors();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_authors.DataSource = bs;
        }

        private void gv_authors_Click(object sender, EventArgs e)
        {
            int index = gv_authors.CurrentRow.Index;
            string authorId = gv_authors.Rows[index].Cells[0].Value.ToString();
            SqlDataReader dr = mngAuthor.getDetails(authorId);
            //select * from employee where ...
            if (dr.Read())
            {
                txt_id.Text = dr.GetInt32(0).ToString();
                txt_bookName.Text = dr.GetString(1);
            }
            mngAuthor.closeConnection();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            if (txt_search.Text.Trim() == "")
            {
                ds = mngAuthor.searchByName(txt_search.Text);
            }
            else
            {
                ds = mngAuthor.searchByName(txt_search.Text);
            }

            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_authors.DataSource = bs;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Author author = new Author()
            {
                author_name = txt_bookName.Text,
            };
            // 
            int result = mngAuthor.AddAuthor(author);
            if (result < 0)
            {
                MessageBox.Show("SORRY BAE");
            }
            else
            {
                MessageBox.Show("DONE");
            }

            // refresh
            DataSet ds = mngAuthor.ViewAuthors();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_authors.DataSource = bs;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int result = mngAuthor.RemoveAuthor(txt_id.Text); // cot phone dang su dung lam khoa chinh ssn
            if (result < 0)
            {
                MessageBox.Show("SORRY BAE");
            }
            else
            {
                MessageBox.Show("DONE");
            }
            // refresh
            DataSet ds = mngAuthor.ViewAuthors();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_authors.DataSource = bs;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Author author = new Author()
            {
                ID = int.Parse(txt_id.Text.ToString()),
                author_name = txt_bookName.Text
            };
            // 
            int result = mngAuthor.UpdateAuthor(author);
            if (result < 0)
            {
                MessageBox.Show("SORRY BAE");
            }
            else
            {
                MessageBox.Show("DONE");
            }

            // refresh
            DataSet ds = mngAuthor.ViewAuthors();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_authors.DataSource = bs;
        }
    }
}
