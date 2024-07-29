using System;
using WebApplication2.Entity;

namespace WebApplication2.Models
{
    public class AdminOrderModel
    {
        public int Id { get; set; } 
        public string SiparisNumarasi { get; set; } 
        public double Toplam { get; set; } 
        public EnumOrderState SiparisDurumu { get; set; } 
        public DateTime SiparisTarihi { get; set; }
        public int UrunAdedi { get; set; } 
    }
}
