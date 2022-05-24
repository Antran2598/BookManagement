using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class Invoice_Detail
    {
        public int ID { get; set; }
        public int invoice_id { get; set; }
        public int book_id { get; set; }
        public int amount { get; set; }
        public float price { get; set; }
        public int vat { get; set; }
    }
}
