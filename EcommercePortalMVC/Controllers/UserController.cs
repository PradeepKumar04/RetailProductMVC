using EcommercePortalMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
           if(user.PhoneNumber!=null && user.Password!=null)
            {
                return RedirectToAction("GetProducts", "Products",new {id=user.Id});
            }
            else
            {
                return View(user);
            }
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(User user)
        {
            
            if(!ModelState.IsValid)
            {
                return View(user);
            }
            else
            {
                return RedirectToAction("GetProducts", "Products");
            }
        }

    }
}
