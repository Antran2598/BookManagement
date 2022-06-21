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
    public partial class CateManage : Form
    {
        CategoryManagement mngCate = new CategoryManagement();
        DataSet ds;
        BindingSource bs;
        public CateManage()
        {
            InitializeComponent();
        }

        private void CateManage_Load(object sender, EventArgs e)
        {
            ds = mngCate.ViewCates();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_cates.DataSource = bs;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            AdminManagement frmAdmin = new AdminManagement();
            frmAdmin.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            if (txt_search.Text.Trim() == "")
            {
                ds = mngCate.searchByName(txt_search.Text);
            }
            else
            {
                ds = mngCate.searchByName(txt_search.Text);
            }

            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_cates.DataSource = bs;
        }

        private void gv_cates_Click(object sender, EventArgs e)
        {
            int index = gv_cates.CurrentRow.Index;
            string cateId = gv_cates.Rows[index].Cells[0].Value.ToString();
            SqlDataReader dr = mngCate.getDetails(cateId);
            //select * from employee where ...
            if (dr.Read())
            {
                txt_id.Text = dr.GetInt32(0).ToString();
                txt_bookName.Text = dr.GetString(1);
            }
            mngCate.closeConnection();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Category cate = new Category()
            {
                cate_name = txt_bookName.Text,
            };
            // 
            int result = mngCate.AddCate(cate);
            if (result < 0)
            {
                MessageBox.Show("SORRY BAE");
            }
            else
            {
                MessageBox.Show("DONE");
            }

            // refresh
            DataSet ds = mngCate.ViewCates();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_cates.DataSource = bs;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            int result = mngCate.RemoveCate(txt_id.Text); // cot phone dang su dung lam khoa chinh ssn
            if (result < 0)
            {
                MessageBox.Show("SORRY BAE");
            }
            else
            {
                MessageBox.Show("DONE");
            }
            // refresh
            DataSet ds = mngCate.ViewCates();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_cates.DataSource = bs;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Category cate = new Category()
            {
                ID = int.Parse(txt_id.Text.ToString()),
                cate_name = txt_bookName.Text,
            };
            // 
            int result = mngCate.UpdateCate(cate);
            if (result < 0)
            {
                MessageBox.Show("SORRY BAE");
            }
            else
            {
                MessageBox.Show("DONE");
            }

            // refresh
            DataSet ds = mngCate.ViewCates();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_cates.DataSource = bs;
        }
    }
}
