using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Mrgun.MvcWebUI.Entity;
using Mrgun.MvcWebUI.Models;

namespace Mrgun.MvcWebUI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    
        public int CategoryId { get; set; }

        public string Image { get; set; }
    }
}