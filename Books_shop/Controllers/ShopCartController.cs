using Books_shop.Data.Interfaces;
using Books_shop.Data.Models;
using Books_shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;

public class ShopCartController : Controller
{
    private readonly IAllBooks _bookRep;
    private readonly ShopCart _shopCart;

    public ShopCartController(IAllBooks bookRep, ShopCart shopCart)
    {
        _bookRep = bookRep;
        _shopCart = shopCart;
    }
    
    public ViewResult Index()
    {
        var items = _shopCart.getShopItems();
        _shopCart.listShopItems = items;

        var obj = new ShopCartViewModel
        {
            shopCart = _shopCart
        };
        return View(obj);
    }

    public RedirectToActionResult AddToCart(int id)
    {
        var item = _bookRep.Books.FirstOrDefault(i => i.id == id);
        if (item != null)
        {
            _shopCart.AddToCart(item);
        }
        return RedirectToAction("Index");
    }
}