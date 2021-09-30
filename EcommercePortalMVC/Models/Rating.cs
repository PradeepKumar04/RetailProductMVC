using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommercePortalMVC.Models
{
    public class Rating
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public double ProductRating { get; set; }
    }
}
