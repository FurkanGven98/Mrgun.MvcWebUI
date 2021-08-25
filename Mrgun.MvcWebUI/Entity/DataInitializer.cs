using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mrgun.MvcWebUI.Entity
{
    public class DataInitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){Name = "Kumaş Pantalonlar", Description = "Kumaş çeşitli pantolanlarımızı bu kategoride bulabilirsiniz."},
                new Category(){Name = "Kot Pantalonlar", Description = "Kot çeşitli pantolanlarımızı bu kategoride bulabilirsiniz."},
                new Category(){Name = "Keten Pantalonlar", Description = "Keten çeşitli pantolanlarımızı bu kategoride bulabilirsiniz."},
                new Category(){Name = "Mezuniyet Pantalonlar", Description = "Mezuniyet kutlama pantolanlarımızı bu kategoride bulabilirsiniz."},
                new Category(){Name = "Düğün Pantalonlar", Description = "Düğün  pantolanlarımızı bu kategoride bulabilirsiniz."}
            };

            foreach (var kategori in kategoriler)
            {
                context.Categories.Add(kategori);
            }

            context.SaveChanges();

            var urunler = new List<Product>()
            {
                new Product(){Name = "Kumaş Pantolon",Description = "Rahat",Price = 50,Stock= 10,İsApproved = true,CategoryId=1,İsHome = true,Image = "1.jpg"},
                new Product(){Name = "Kumaş 2 Pantolon",Description = "Rahat",Price = 50,Stock= 10,İsApproved = false,CategoryId=1,İsHome = true,Image = "1.jpg"},
                new Product(){Name = "Kumaş 3 Pantolon",Description = "Rahat",Price = 50,Stock= 10,İsApproved = true,CategoryId=1,Image = "1.jpg"},

                new Product(){Name = "Kot",Description = "Kot",Price = 75,Stock= 20,İsApproved = true,CategoryId= 2,İsHome = true,Image = "2.jpg"},
                new Product(){Name = "Kot 2",Description = "Kot",Price = 75,Stock= 20,İsApproved = true,CategoryId= 2,İsHome = true,Image = "2.jpg"},
                new Product(){Name = "Kot 3",Description = "Kot",Price = 75,Stock= 20,İsApproved = true,CategoryId= 2,Image = "2.jpg"},

                new Product(){Name = "Keten",Description = "Ketennn",Price = 40,Stock= 60,İsApproved = true,CategoryId= 3,İsHome = true,Image = "3.jpg"},
                new Product(){Name = "Keten 3",Description = "Ketennn",Price = 40,Stock= 60,İsApproved = true,CategoryId= 3,Image = "3.jpg"},
                new Product(){Name = "Keten 2",Description = "Ketennn",Price = 40,Stock= 60,İsApproved = true,CategoryId= 3, Image = "3.jpg"},

                new Product(){Name = "Mezun,yet",Description = "kep foto",Price = 55,Stock= 10,İsApproved = false,CategoryId= 4,İsHome = true,Image = "4.jpg"},

                new Product(){Name = "Düğün",Description = "Damat",Price = 100,Stock= 22,İsApproved = true,CategoryId= 5,İsHome = true,Image = "5.jpg"},
                new Product(){Name = "Düğün2",Description = "Damat",Price = 100,Stock= 22,İsApproved = false,CategoryId= 5,İsHome = true,Image = "5.jpg"},
            };
            foreach (var urun in urunler)
            {
                context.Products.Add(urun);
            }

            context.SaveChanges();
            base.Seed(context);

        }
    }
}