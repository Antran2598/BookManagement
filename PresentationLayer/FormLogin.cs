using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogicLayer_BLL;
using DataAccessLayer_DAL;

namespace PresentationLayer
{
    public partial class FormLogin : Form
    {
        AccountManagement accountManagement = new AccountManagement();
        public FormLogin()
        {
            InitializeComponent();
            txt_password.PasswordChar = '•';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                user_name = txt_userName.Text,
                password = txt_password.Text
            };
            if (accountManagement.loginUser(account))
            {
                Dashboard frmMain = new Dashboard();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
            }
        }

        private void btn_navigateRegister_Click(object sender, EventArgs e)
        {
            FormSignIn frmRegister = new FormSignIn();
            frmRegister.Show();
            this.Hide();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
