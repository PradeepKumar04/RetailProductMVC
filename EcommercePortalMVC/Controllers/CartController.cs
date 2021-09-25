using EcommercePortalMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Controllers
{
    [Route("Cart")]
    public class CartController : Controller
    {
        

       public static List<Cart> carts = new List<Cart>();
       public static List<Wishlist> wishlists = new List<Wishlist>();

        [Route("UserCart")]
        public IActionResult UserCart()
        {
            return View(carts);
        }

        [Route("UserCart/{userId}/{productId}")]
        public IActionResult UserCart(int userId, int productId)
        {
            TempData["user"] = userId;
            Product p = new Product();
            VendorStock vendorStock = new VendorStock();
            Vendor vendor = new Vendor();
            List<Product> products = p.GetProducts();
            
            VendorStock vendorStocks = vendorStock.GetStocks().Where(s => s.ProductId==productId).Where(s=>s.Quantity>0).ToList<VendorStock>().FirstOrDefault();
            
            if (vendorStocks==null)
            {
                return RedirectToAction("UserWishlist", new { userId = userId, productId = productId });
            }
            Vendor vendors = vendor.GetVendors().Where(s => s.Id == vendorStocks.VendorId).FirstOrDefault();
            Product p1= p.GetProducts().Where(s=>s.Id==productId).FirstOrDefault();
            Cart c = new Cart() { ProductId = productId, Id = userId, ExpectedDelivery = DateTime.Now.AddDays(5), Product = p1, Vendor = vendors };
            carts.Add(c);
            return RedirectToAction("UserCart");
        }

        [Route("UserWishlist")]
        public IActionResult UserWishlist()
        {
            return View(wishlists);
        }

        [Route("UserWishlist/{productId}")]
        public IActionResult UserWishlist( int productId)
        {
            Product p = new Product();
            Wishlist wishlist = new Wishlist() {  ProductId = productId };
            wishlist.Id = (int)TempData["user"];
            wishlist.Product = p.GetProducts().Find(s => s.Id == productId);
            wishlists.Add(wishlist);
            return View(wishlists);
        }

            [Route("UserWishlist/{userId}/{productId}")]
        public IActionResult UserWishlist(int userId,int productId)
        {
            Product p = new Product();
            Wishlist wishlist = new Wishlist() { Id=userId,ProductId=productId};
            wishlist.Product = p.GetProducts().Find(s=>s.Id==productId);
            wishlists.Add(wishlist);
            return View(wishlists);
        }

    }
}
