using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Books_shop.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string description { set; get; }
        public List<Book> books { set; get; }
    }
}
