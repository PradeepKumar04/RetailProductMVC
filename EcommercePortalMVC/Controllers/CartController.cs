using EcommercePortalMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Controllers
{
    [Route("Cart")]
    public class CartController : Controller
    {
        

          
          public static List<Wishlist> wishlists = new List<Wishlist>();

        [Route("Cart")]
        public IActionResult Cart()
        {
            
            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            List<Cart> carts = new Cart().GetCartsById(id);
            if(carts==null)
            {
                return View(null);
            }

            foreach (var item in carts)
            {
                item.Product = new Product().GetProducts().Where(s => s.Id == item.ProductId).FirstOrDefault();
                
                item.ZipCode = 530026;
            }
            return View(carts);
        }

        [Route("UserCart/{productId}")]
        public async Task<IActionResult> UserCartAsync( int productId)
        {
            TempData["message"] = null;
            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            Cart cart = new Cart() { Id = id,
                ProductId = productId,
                ZipCode = 530026,
                DeliveryDate = DateTime.Now.AddDays(5)
            };
           Cart c=await cart.AddProductToCartAsync();
            if (c == null)
            {
                return RedirectToAction("GetProducts", "Products");
            }

            else if (c.Vendor==null)
            {
                
                return RedirectToAction("UserWishlist",productId);
            }
            
            return RedirectToAction("Cart","Cart");
            
        }

        [Route("UserWishlist")]
        public IActionResult Wishlist()
        {
            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            List<Wishlist> wishlists = new Wishlist().GetWishlists(id);
            foreach (var item in wishlists)
            {
                item.Product = new Product().GetProducts().Where(s => s.Id == item.ProductId).FirstOrDefault();
            }
            return View(wishlists);
        }

        [Route("UserWishlist/{productId}")]
        public IActionResult UserWishlist( int productId)
        {
            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            Product p = new Product();
            Wishlist wishlist = new Wishlist() {  ProductId = productId };
            wishlist.Id = id;
            wishlist.DateAddedToWishList = DateTime.Now;
            wishlist.Product = p.GetProducts().Where(s=>s.Id==productId).FirstOrDefault();
            if(new Wishlist().AddToWishlistAsync(wishlist).Result)
            {
                return RedirectToAction("Wishlist");
            }
            else
            {
                return View("Wishlist");
            }

        }


        

        [Route("RemoveCartItem/{productId}")]
        public IActionResult RemoveCartItem( int productId)
        {
            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            if (new Cart().RemoveProductFromCart(id,productId).Result)
            {
                return RedirectToAction("Cart");
            }
            return RedirectToAction("Cart");
        }

        [Route("MoveToCart/{productId}")]
        public IActionResult MoveToCart(int productId)
        {
            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            RemoveCartItem(productId);
            UserWishlist(productId);
            return RedirectToAction("Wishlist");
        }

        [Route("RemoveWishlistItem/{productId}")]
        public IActionResult RemoveWishlistItem(int productId)
        {
            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            if (new Wishlist().RemoveProductFromWishlist(id, productId).Result)
            {
                return RedirectToAction("Wishlist");
            }
            return RedirectToAction("Wishlist");
        }


    }
}
