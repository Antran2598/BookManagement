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
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
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
        }

        private void btn_loginNavigate_Click(object sender, EventArgs e)
        {
            FormLogin frmLogin = new FormLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {

        }

        private void txt_username_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_username.Text))
            {
                e.Cancel = true;
                txt_username.Focus();
                errorProvider1.SetError(txt_username, "Username is not left blank!");
            }
            else
            {
                errorProvider1.SetError(txt_username, null);
                e.Cancel = false;
            }
        }

        private void txt_password_Validating_1(object sender, CancelEventArgs e)
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

        private void txt_confirmPasssword_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_confirmPasssword.Text))
            {
                e.Cancel = true;
                txt_confirmPasssword.Focus();
                errorProvider1.SetError(txt_confirmPasssword, "Password is not left blank!");
            }
            else if (txt_confirmPasssword.Text.Trim().Length < 6)
            {
                errorProvider1.SetError(txt_confirmPasssword, "at least 6 characters");

            }
            else
            {
                errorProvider1.SetError(txt_confirmPasssword, null);
                e.Cancel = false;
            }
        }
    }
}
