using EcommercePortalMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Controllers
{
    [Route("Products")]
    [AllowAnonymous]
    public class ProductsController : Controller
    {
        private readonly ILogger<ProductsController> _logger;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(ProductsController));
        [Route("GetProducts")]
        public IActionResult GetProducts()
        {
            _log4net.Info("logger initiated");
            Product p = new Product();
            List<Product> products = p.GetProducts();
            _log4net.Info("Returned Products Successfully");
            return View(products);
        }
        
        [Route("SearchProduct/{item:int}")]
        public IActionResult SearchProduct(int item)
        {
            _log4net.Info("logger initiated");
            Product p1 = new Product();
            List<Product> products = p1.GetProducts();
            Product p = products.Where(s => s.Id == item).FirstOrDefault();
            List<Product> ps = new List<Product>();
            ps.Add(p);
            _log4net.Info("Searching Products");
            return View("GetProducts", ps);
        }


        [Route("SearchProduct/{item}")]
        public IActionResult SearchProduct(string item)
        {
            _log4net.Info("logger initiated");
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
                    _log4net.Error("Products Not Found");
                    return View("GetProducts", ps);
                }
                else
                {
                    _log4net.Info("Returned Products Successfully");
                    return View("GetProducts", null);
                }
                
            }
            else
            {
                Product p = products.Where(s => s.Name.ToLower().Contains(item.ToLower())).FirstOrDefault();
                List<Product> ps = new List<Product>();
                ps.Add(p);
                _log4net.Info("Returning List Of Products Successfully");
                return View("GetProducts", ps);
            }
            
        }

        
    }
}
