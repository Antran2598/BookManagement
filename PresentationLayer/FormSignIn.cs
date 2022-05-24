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
    public partial class FormSignIn : Form
    {
        AccountManagement accountManagement = new AccountManagement();
        public FormSignIn()
        {
            InitializeComponent();
            txt_password.PasswordChar = '•';
            txt_confirmPasssword.PasswordChar = '•';
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Account account = new Account()
            {
                user_name = txt_username.Text,
                password = txt_password.Text,
                role = 2
            };
            if (txt_confirmPasssword.Text == txt_password.Text)
            {
                if (accountManagement.registerUser(account))
                {
                    MessageBox.Show("Đăng ký thành công");
                    this.Close();
                    FormLogin frmLogin = new FormLogin();
                    frmLogin.Show();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
            }

        }

        private void btn_loginNavigate_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
            this.Hide();
        }
    }
}
