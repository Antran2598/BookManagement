using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class Account
    {
        public int ID { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }
        public int role { get; set; }

        public Account() { }
    }
}
