﻿using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class ShippingDetails
    {
        public string KullanıcıAdi { get; set; }

        [Required(ErrorMessage = "Lütfen adres tanımını giriniz.")]
        public string AdresBasligi { get; set; }

        [Required(ErrorMessage = "Lütfen bir adres giriniz.")]
        public string Adres { get; set; }

        [Required(ErrorMessage = "Lütfen şehir giriniz.")]
        public string Sehir { get; set; }

        [Required(ErrorMessage = "Lütfen semt giriniz.")]
        public string Semt { get; set; }

        [Required(ErrorMessage = "Lütfen mahalle giriniz.")]
        public string Mahalle { get; set; }

        public string PostaKodu { get; set; }
    }
}