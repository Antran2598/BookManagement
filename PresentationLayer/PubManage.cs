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
    public partial class PubManage : Form
    {
        PublisherManagement mngPub = new PublisherManagement();
        DataSet ds;
        BindingSource bs;
        public PubManage()
        {
            InitializeComponent();
        }

        private void PubManage_Load(object sender, EventArgs e)
        {
            ds = mngPub.ViewPubs();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_pubs.DataSource = bs;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            AdminManagement frmAdmin = new AdminManagement();
            frmAdmin.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int result = mngPub.RemovePub(txt_id.Text); // cot phone dang su dung lam khoa chinh ssn
            if (result < 0)
            {
                MessageBox.Show("SORRY BAE");
            }
            else
            {
                MessageBox.Show("DONE");
            }
            // refresh
            DataSet ds = mngPub.ViewPubs();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_pubs.DataSource = bs;
        }

        private void gv_pubs_Click(object sender, EventArgs e)
        {
            int index = gv_pubs.CurrentRow.Index;
            string pubId = gv_pubs.Rows[index].Cells[0].Value.ToString();
            SqlDataReader dr = mngPub.getDetails(pubId);
            //select * from employee where ...
            if (dr.Read())
            {
                txt_id.Text = dr.GetInt32(0).ToString();
                txt_bookName.Text = dr.GetString(1);
            }
            mngPub.closeConnection();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Publisher publisher  = new Publisher()
            {
                pub_name = txt_bookName.Text,
            };
            // 
            int result = mngPub.AddPub(publisher);
            if (result < 0)
            {
                MessageBox.Show("SORRY BAE");
            }
            else
            {
                MessageBox.Show("DONE");
            }

            // refresh
            DataSet ds = mngPub.ViewPubs();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_pubs.DataSource = bs;
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            Publisher publisher = new Publisher()
            {
                ID = int.Parse(txt_id.Text.ToString()),
                pub_name = txt_bookName.Text,
            };
            // 
            int result = mngPub.UpdatePub(publisher);
            if (result < 0)
            {
                MessageBox.Show("SORRY BAE");
            }
            else
            {
                MessageBox.Show("DONE");
            }

            // refresh
            DataSet ds = mngPub.ViewPubs();
            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_pubs.DataSource = bs;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataSet ds = null;
            if (txt_search.Text.Trim() == "")
            {
                ds = mngPub.searchByName(txt_search.Text);
            }
            else
            {
                ds = mngPub.searchByName(txt_search.Text);
            }

            bs = new BindingSource();
            bs.DataSource = ds.Tables[0];
            gv_pubs.DataSource = bs;
        }
    }
}

