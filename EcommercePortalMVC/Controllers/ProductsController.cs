using EcommercePortalMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Controllers
{
    [Route("Products")]
    public class ProductsController : Controller
    {

        [Route("GetProducts/{id}")]
        public IActionResult GetProducts(int id)
        {
            TempData["user"] = id;
            Product p = new Product();
            List<Product> products = p.GetProducts();
            return View(products);
        }

        

        [Route("SearchProduct/{item:int}")]
        public IActionResult SearchProduct(int item)
        {
            Product p1 = new Product();
            List<Product> products = p1.GetProducts();
            Product p = products.Where(s => s.Id == item).FirstOrDefault();
            List<Product> ps = new List<Product>();
            ps.Add(p);
            return View("GetProducts", ps);
        }


       
        

        [Route("SearchProduct/{item}")]
        public IActionResult SearchProduct(string item)
        {
            bool isint = int.TryParse(item, out int data);
            Product p1 = new Product();
            List<Product> products = p1.GetProducts();
            if (isint)
            {
                Product p = products.Where(s => s.Id==data).FirstOrDefault();
                if (p != null)
                {
                    List<Product> ps = new List<Product>();
                    ps.Add(p);
                    return View("GetProducts", ps);
                }
                else
                {
                    return View("GetProducts", null);
                }
                
            }
            else
            {
                Product p = products.Where(s => s.Name.ToLower().Contains(item.ToLower())).FirstOrDefault();
                List<Product> ps = new List<Product>();
                ps.Add(p);
                return View("GetProducts", ps);
            }
            
        }

        
    }
}
