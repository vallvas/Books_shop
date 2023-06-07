using Books_shop.Data.Interfaces;
using Books_shop.Data.Models;
using Books_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Books_shop.Controllers
{
  
    public class BooksController : Controller
    {
        private readonly IAllBooks _allBooks;
        private readonly IBooksCategory _allCatagories;

        public BooksController(IAllBooks iAllBooks,
            IBooksCategory iBooksCateory)
        {
            _allBooks = iAllBooks;
            _allCatagories = iBooksCateory;
        }

        [Route("Books/List")]
        [Route("Books/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Book> books = null;
            string currCategory = "";

            if (string.IsNullOrEmpty(category))
            {
                books = _allBooks.Books.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("self-development", category,
               System.StringComparison.OrdinalIgnoreCase))
                {
                   books = _allBooks.Books.Where(i =>
                   i.Category.categoryName.Equals("Саморозвиток та психологія")).OrderBy(i => i.id);
                    currCategory = "Саморозвиток та психологія";
                }
                else if (string.Equals("fiction", category,
               System.StringComparison.OrdinalIgnoreCase))
                {
                   books = _allBooks.Books.Where(i =>
                   i.Category.categoryName.Equals("Художня література")).OrderBy(i =>
                   i.id);
                    currCategory = "Художня література";
                }
                else if (string.Equals("nonfiction", category,
               System.StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i =>
                    i.Category.categoryName.Equals("Наукова література")).OrderBy(i =>
                    i.id);
                    currCategory = "Наукова література";
                }
                else if (string.Equals("historical", category,
              System.StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i =>
                    i.Category.categoryName.Equals("Історична література")).OrderBy(i =>
                    i.id);
                    currCategory = "Історична література";
                }
                else if (string.Equals("biographies", category,
              System.StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i =>
                    i.Category.categoryName.Equals("Біографії та мемуари")).OrderBy(i =>
                    i.id);
                    currCategory = "Біографії та мемуари";
                }
                else if (string.Equals("religious", category,
              System.StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i =>
                    i.Category.categoryName.Equals("Релігійна література")).OrderBy(i =>
                    i.id);
                    currCategory = "Релігійна література";
                }
                else if (string.Equals("hobbies", category,
              System.StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i =>
                    i.Category.categoryName.Equals("Хобі та розваги")).OrderBy(i =>
                    i.id);
                    currCategory = "Хобі та розваги";
                }
                else if (string.Equals("business", category,
             System.StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i =>
                    i.Category.categoryName.Equals("Ділова література")).OrderBy(i =>
                    i.id);
                    currCategory = "Ділова література";
                }
                else if (string.Equals("educational", category,
             System.StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i =>
                    i.Category.categoryName.Equals("Підручники та навчальні матеріали")).OrderBy(i =>
                    i.id);
                    currCategory = "Підручники та навчальні матеріали";
                }
                else if (string.Equals("children's", category,
             System.StringComparison.OrdinalIgnoreCase))
                {
                    books = _allBooks.Books.Where(i =>
                    i.Category.categoryName.Equals("Дитяча література")).OrderBy(i =>
                    i.id);
                    currCategory = "Дитяча література";
                }
            }

            var bookObj = new BooksListViewModel
            {
                allBooks = books,
                currCategory = currCategory
            };
            ViewBag.Title = "Сторінка з книгами";
            return View(bookObj);
        }

    }

}

