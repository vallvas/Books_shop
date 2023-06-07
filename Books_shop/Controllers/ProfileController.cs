using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Books_shop.Data.Interfaces;
using System.Collections.Generic;

namespace Books_shop.Controllers
{
    [Authorize(Roles = "Client, Admin")]
    public class ProfileController : Controller
    {
        public readonly IUser _userRepository;

        public ProfileController(IUser userRepository)
        {
            _userRepository = userRepository;
        }

        [Route("/profile")]
        public IActionResult General()
        {
            ViewBag.User = _userRepository.GetUserByEmail(User.Identity.Name);
            return View();
        }
    }
}