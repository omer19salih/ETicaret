using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Entity
{
    public enum EnumOrderState
    {
        [Display(Name = "Onay Bekleniyor")]
        Waiting,

        [Display(Name = "Tamamlandı")]
        Completed
    }
}