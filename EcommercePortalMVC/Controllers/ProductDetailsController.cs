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

        public IActionResult ProductData(int uid, int pid)
        {
            Product p = new Product();
            Product product = p.GetProducts().Where(s => s.Id == pid).FirstOrDefault();
            VendorStock v = new VendorStock().GetStocks().Where(s => s.ProductId == pid && s.Quantity > 0).FirstOrDefault();
            TempData["wish"] = v == null ? "1" : "0";
            
            ProductViewModel p1 = new ProductViewModel();
            p1.Product = product;
            if (v != null)
            {
                p1.Vendor = new Vendor().GetVendors().Where(s => s.Id == v.VendorId).FirstOrDefault();
            }
            return View(p1);
        }
    }
}
