using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Web;

namespace Mrgun.MvcWebUI.Models
{
    public class ShippingDetails
    {
        public string Username { get; set; }
        [Required(ErrorMessage = "Lütfen adres tanımı giriniz.")]
        public string AdresBasligi { get; set; }
        [Required(ErrorMessage = "Lütfen adres giriniz.")]
        public string Adres { get; set; }
        [Required(ErrorMessage = "Lütfen yaşadığınız şehri giriniz.")]
        public string Sehir { get; set; }
        [Required(ErrorMessage = "Lütfen yaşadığınız ilçeyi giriniz.")]
        public string Ilce { get; set; }
        [Required(ErrorMessage = "Lütfen yaşadığınız mahalleyi giriniz.")]
        public string Mahalle { get; set; }
        public string PostaKodu { get; set; }
    }
}