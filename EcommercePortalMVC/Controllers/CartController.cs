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
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace EcommercePortalMVC.Controllers
{
    [Route("Cart")]
    [Authorize]
    public class CartController : Controller
    {
        private readonly ILogger<CartController> _logger;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(CartController));


        public static List<Wishlist> wishlists = new List<Wishlist>();

        [Route("Cart")]
        public IActionResult Cart()
        {
            _log4net.Info("logger initiated");

            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            List<Cart> carts = new Cart().GetCartsById(id);
            if(carts==null)
            {
                _log4net.Error("Not Found");
                return View(null);
            }

            foreach (var item in carts)
            {
                item.Product = new Product().GetProducts().Where(s => s.Id == item.ProductId).FirstOrDefault();
                
                item.ZipCode = 530026;
            }
            _log4net.Info("Successfully Returned Carts");
            return View(carts);
        }

        [Route("UserCart/{productId}")]
        public async Task<IActionResult> UserCartAsync( int productId)
        {
            _log4net.Info("logger initiated");
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
                _log4net.Error("Not Found");
                return RedirectToAction("GetProducts", "Products");
            }

            else if (c.Vendor==null)
            {
                Product p = new Product();
                Wishlist wishlist = new Wishlist() { ProductId = productId };
                wishlist.Id = id;
                wishlist.DateAddedToWishList = DateTime.Now;
                wishlist.Product = p.GetProducts().Where(s => s.Id == productId).FirstOrDefault();
                if (new Wishlist().AddToWishlistAsync(wishlist).Result)
                {
                    _log4net.Info("Added Product to Wishlist");
                    return RedirectToAction("Wishlist");
                }
                _log4net.Info("Returned User Wishlist");
                return RedirectToAction("UserWishlist");
            }
            
            return RedirectToAction("Cart","Cart");
            
        }

        [Route("UserWishlist/{productId}")]
        public IActionResult UserWishlist(int productId)
        {
            _log4net.Info("logger initiated");
            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            Product p = new Product();
            Wishlist wishlist = new Wishlist() { ProductId = productId };
            wishlist.Id = id;
            wishlist.DateAddedToWishList = DateTime.Now;
            wishlist.Product = p.GetProducts().Where(s => s.Id == productId).FirstOrDefault();
            if (new Wishlist().AddToWishlistAsync(wishlist).Result)
            {
                _log4net.Info("logger initiated");
                return RedirectToAction("Wishlist");
            }
            else
            {
                _log4net.Info("Displaying Wishlist");
                return View("Wishlist");
            }

        }


        [Route("UserWishlist")]
        public IActionResult Wishlist()
        {
            _log4net.Info("logger initiated");
            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            List<Wishlist> wishlists = new Wishlist().GetWishlists(id);
            foreach (var item in wishlists)
            {
                item.Product = new Product().GetProducts().Where(s => s.Id == item.ProductId).FirstOrDefault();
            }
            _log4net.Info("Products in Wishlist");
            return View(wishlists);
        }

        

        

        [Route("RemoveCartItem/{productId}")]
        public IActionResult RemoveCartItem( int productId)
        {
            _log4net.Info("logger initiated");
            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            if (new Cart().RemoveProductFromCart(id,productId).Result)
            {
                _log4net.Info("Product removed from Cart Successfully");
                return RedirectToAction("Cart");
            }
            _log4net.Info("Displaying Cart after removing");
            return RedirectToAction("Cart");
        }

        [Route("MoveToCart/{productId}")]
        public IActionResult MoveToCart(int productId)
        {
            _log4net.Info("logger initiated");
            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            RemoveCartItem(productId);
            UserWishlist(productId);
            _log4net.Info("Successfully moved Product from Wishlist to Cart ");
            return RedirectToAction("Wishlist");
        }

        [Route("RemoveWishlistItem/{productId}")]
        public IActionResult RemoveWishlistItem(int productId)
        {
            _log4net.Info("logger initiated");
            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            if (new Wishlist().RemoveProductFromWishlist(id, productId).Result)
            {
                _log4net.Info("Product removed from Wishlist Successfully");
                return RedirectToAction("Wishlist");
            }
            _log4net.Info("Displaying Cart after removing");
            return RedirectToAction("Wishlist");
        }


    }
}
