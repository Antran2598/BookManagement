using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class AdminManagement : Form
    {
        public AdminManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookManagement frmBook = new BookManagement();
            frmBook.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dashboard ds = new Dashboard();
            ds.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                FormLogin f = new FormLogin();
                f.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AuthorManage frmAuthor = new AuthorManage();
            frmAuthor.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CateManage frmCate = new CateManage();
            frmCate.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PubManage frmPub = new PubManage();
            frmPub.Show();
            this.Hide();
        }
    }
}
