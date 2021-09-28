using EcommercePortalMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Controllers
{
    
    public class CheckoutController : Controller
    {
        public static List<Order> Orders = new List<Order>();

        public IActionResult Order()
        {
            return View("OrderItem",Orders);
        }

        public IActionResult OrderItem(int orderID,int productId,int vendorId,int userId)
        {
            Product p = new Product();
            Order o = new Order();
            o.UserId = userId;
            o.ProductId = productId;
            o.VendorId = vendorId;
            Vendor vendor = new Vendor();
            o.Vendor = vendor.GetVendors().Find(s=>s.Id==vendorId);
            o.Product = p.GetProducts().Find(s => s.Id == productId);
            o.User = new User() { Id = userId };
            Orders.Add(o);
            return RedirectToAction("Order");
        }

        public IActionResult AddRating(int rating, int pid,int id)
        {

            return RedirectToAction("GetProducts", "Products",new { id=id});
        }

        public IActionResult PaymentAddress()
        {
            return View();
        }
        
    }
}
