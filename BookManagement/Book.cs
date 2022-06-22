using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_DAL
{
    public class Book
    {
        public int ID { get; set; }
        public string book_name { get; set; }
        public int author { get; set; }
        public int publisher { get; set; }
        public int category { get; set; }
        public float original_price { get; set; }
        public float sale_price { get; set; }
        public int qty_instock { get; set; }
        public string img { get; set; }

        public Book() { }
    }
}
