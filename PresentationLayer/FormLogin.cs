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
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void txt_userName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_userName.Text))
            {
                e.Cancel = true;
                txt_userName.Focus();
                errorProvider1.SetError(txt_userName, "Username is not left blank!");
            }
            else
            {
                errorProvider1.SetError(txt_userName, null);
                e.Cancel = false;
            }
        }

        private void txt_password_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_password.Text))
            {
                e.Cancel = true;
                txt_password.Focus();
                errorProvider1.SetError(txt_password, "Password is not left blank!");
            }
            else if (txt_password.Text.Trim().Length < 6)
            {
                errorProvider1.SetError(txt_password, "at least 6 characters");

            }
            else
            {
                errorProvider1.SetError(txt_password, null);
                e.Cancel = false;
            }
        }
    }
}
