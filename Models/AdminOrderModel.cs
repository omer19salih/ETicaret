using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Entity;

namespace WebApplication2.Models
{
    public class AdminOrderModel
    {
        public int Id { get; set; } // Siparişin benzersiz kimliği
        public string SiparisNumarasi { get; set; } // Sipariş numarası
        public double Toplam { get; set; } // Toplam tutar
        public EnumOrderState SiparisDurumu { get; set; } // Sipariş durumu
        public DateTime SiparisTarihi { get; set; } // Sipariş tarihi
        public int UrunAdedi { get; set; } // Siparişteki ürün adedi
    }
}
