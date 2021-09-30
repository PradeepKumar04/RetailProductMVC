using EcommercePortalMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Controllers
{
    
    public class ProductDetailsController : Controller
    {
        [Route("ProductDetails/ProductData/{pid}")]
        public IActionResult ProductData(int pid)
        {
            Product p = new Product();
            Product product = p.GetProducts().Where(s => s.Id == pid).FirstOrDefault();
            ProductViewModel p1 = new ProductViewModel();
            p1.Product = product;
            p1.Vendor = new VendorStock().GetVendorByProductId(pid);
            return View(p1);
        }
    }
}
