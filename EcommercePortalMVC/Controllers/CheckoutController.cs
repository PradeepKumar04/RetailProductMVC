using EcommercePortalMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {
        private readonly ILogger<CheckoutController> _logger;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(CheckoutController));
        public static List<Order> Orders = new List<Order>();

        public IActionResult Order()
        {
            _log4net.Info("View Orders");
            return View("OrderItem",Orders);
        }

        public IActionResult OrderItem()
        {
            _log4net.Info("Redirected to Orders");
            return RedirectToAction("Order");

        }

        public async Task<IActionResult> AddRating(int rating, int pid)
        {
            _log4net.Info("logger initiated");
            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            using (var client = new HttpClient())
            {
                Rating rate = new Rating() { ProductRating = rating, ProductId = pid, UserId = id };
                
                string json = JsonConvert.SerializeObject(rate);

                //Needed to setup the body of the request
                StringContent data = new StringContent(json, Encoding.UTF8, "application/json");


                var url = "https://localhost:44380/Products/AddProductRating";
                var client1 = new HttpClient();

                //Pass in the full URL and the json string content
                var response = await client.PostAsync(url, data);
                var resmess = response.RequestMessage;
                var result = response.Content.ReadAsStringAsync().Result;

                if (response.IsSuccessStatusCode)
                {
                    _log4net.Info("Successfully returned Products after Adding rating");
                    return RedirectToAction("GetProducts", "Products");
                }
                else
                {
                    _log4net.Info("Redirect to Orders");
                    return RedirectToAction("Order");
                }
            }
           
        }

        [Route("Checkout/PaymentAddress/{productId}")]
        public IActionResult PaymentAddress(int productId)
        {
            _log4net.Info("logger initiated");
            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            Order order = new Order()
            {
                OrderTime = DateTime.Now,
                Id = new Random().Next(1, 300),
                Product = new Product().GetProducts().Where(s => s.Id == productId).FirstOrDefault(),
                ProductId = productId,
                UserId = id,
                Vendor = new VendorStock().GetVendorByProductId(productId)
            };
            Orders.Add(order);
            _log4net.Info("Payment Successful. Order initiated");
            return View();
        }

            public IActionResult PaymentAddress()
        {
            _log4net.Info("logger initiated");
            var token = Request.Cookies["token"];
            var handler = new JwtSecurityTokenHandler();
            var jwtSecurityToken = handler.ReadJwtToken(token);
            int id = int.Parse(jwtSecurityToken.Claims.First().Value);
            List<Cart> cart = new Cart().GetCartsById(id);
            foreach (var item in cart)
            {
                Random rnd = new Random();
                int month = rnd.Next(1, 300);
                Order order = new Order();
                order.Id = month;
                order.OrderTime = DateTime.Now;
                order.Product = new Product().GetProducts().Where(s=>s.Id==item.ProductId).FirstOrDefault();
                order.ProductId = item.ProductId;
                order.Vendor = new VendorStock().GetVendorByProductId(item.ProductId);
                order.VendorId = order.Vendor.Id;
                order.UserId = id;
                Orders.Add(order);
            }
            _log4net.Info("Displaying View");
            return View();
        }
        
    }
}
