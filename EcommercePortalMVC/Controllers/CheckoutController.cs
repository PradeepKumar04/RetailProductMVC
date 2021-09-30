using EcommercePortalMVC.Models;
using Microsoft.AspNetCore.Mvc;
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
    
    public class CheckoutController : Controller
    {
        public static List<Order> Orders = new List<Order>();

        public IActionResult Order()
        {
            return View("OrderItem",Orders);
        }

        public IActionResult OrderItem()
        {
            return RedirectToAction("Order");

        }

        public async Task<IActionResult> AddRatingAsync(double rating, int pid,int id)
        {
            using (var client = new HttpClient())
            {
                Rating rate = new Rating() { ProductRating = rating+1, ProductId = pid, UserId = id };
                
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
                    return RedirectToAction("GetProducts", "Products");
                }
                else
                {
                    return RedirectToAction("Order");
                }
            }
           
        }

        [Route("Checkout/PaymentAddress/{productId}")]
        public IActionResult PaymentAddress(int productId)
        {
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
            return View();
        }

            public IActionResult PaymentAddress()
        {
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
            return View();
        }
        
    }
}
