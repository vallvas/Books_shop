using Books_shop.Data.Models;
using System.Collections.Generic;

namespace Books_shop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Book> favBooks { get; set; }
    }
}
