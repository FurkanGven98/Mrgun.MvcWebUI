using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Mrgun.MvcWebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public bool İsHome { get; set; }
        public bool İsApproved { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        public string Image { get; set; }


    }
}