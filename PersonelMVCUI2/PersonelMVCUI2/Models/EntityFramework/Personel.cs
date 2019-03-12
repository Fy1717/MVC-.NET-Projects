

namespace PersonelMVCUI2.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Personel
    {
        public int Id { get; set; }


        [Display (Name = "Departman")]
        [Required(ErrorMessage = "Departman Alaný Boþ Býrakýlamaz...")]
        public Nullable<int> DepartmanId { get; set; }


        [Required(ErrorMessage = "Ad Alaný Boþ Býrakýlamaz...")]
        public string Ad { get; set; }


        [Required(ErrorMessage = "Soyadý Alaný Boþ Býrakýlamaz...")]
        public string Soyad { get; set; }


        [Display(Name = "Maaþ")]
        [Required(ErrorMessage = "Maaþ Alaný Boþ Býrakýlamaz...")]
        [Range(1399,8000,ErrorMessage ="Maaþ Alaný 1400 ile 8000 Arasýnda Olmalýdýr...")]
        public Nullable<short> Maas { get; set; }


        [Display(Name = "Doðum Tarihi")]
        [Required(ErrorMessage = "Lütfen Doðum Tarihi Seçiniz...")]
        public Nullable<System.DateTime> DogumTarihi { get; set; }

        public Nullable<bool> Cinsiyet { get; set; }

        [Display(Name = "Evlilik Durumu")]
        public Nullable<bool> EvliMi { get; set; }
    
        public virtual Departman Departman { get; set; }
    }
}
