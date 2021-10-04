using EcommercePortalMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Controllers
{
    
    public class ProductDetailsController : Controller
    {
        private readonly ILogger<ProductDetailsController> _logger;
        static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(ProductDetailsController));
        [Route("ProductDetails/ProductData/{pid}")]
        public IActionResult ProductData(int pid)
        {
            _log4net.Info("logger initiated");
            Product p = new Product();
            Product product = p.GetProducts().Where(s => s.Id == pid).FirstOrDefault();
            ProductViewModel p1 = new ProductViewModel();
            p1.Product = product;
            p1.Vendor = new VendorStock().GetVendorByProductId(pid);
            _log4net.Info("Displaying Product Data");
            return View(p1);
        }
    }
}
