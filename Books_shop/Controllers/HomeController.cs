using Books_shop.Data.Interfaces;
using Books_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Books_shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllBooks _bookRep;
        public HomeController(IAllBooks bookRep)
        {
            _bookRep = bookRep;
        }
        public ViewResult Index()
        {
            var homeBooks = new HomeViewModel
            {
                favBooks = _bookRep.getFavBooks
            };
        return View(homeBooks);
        }
    }
}
