using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer_DAL;

namespace BussinessLogicLayer_BLL
{
    public class AccountManagement
    {
        AccountDAO accountDao = new AccountDAO();
        public bool loginUser(Account account)
        {
            return accountDao.checkLogin(account.user_name, account.password);
        }
        public bool registerUser(Account account)
        {
            return accountDao.register(account);
        }
        public DataSet ViewAccounts()
        {
            return accountDao.GetAllAccount();
        }

    }
}
