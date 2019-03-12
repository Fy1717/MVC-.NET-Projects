

namespace PersonelMVCUI2.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Personel
    {
        public int Id { get; set; }


        [Display (Name = "Departman")]
        [Required(ErrorMessage = "Departman Alan� Bo� B�rak�lamaz...")]
        public Nullable<int> DepartmanId { get; set; }


        [Required(ErrorMessage = "Ad Alan� Bo� B�rak�lamaz...")]
        public string Ad { get; set; }


        [Required(ErrorMessage = "Soyad� Alan� Bo� B�rak�lamaz...")]
        public string Soyad { get; set; }


        [Display(Name = "Maa�")]
        [Required(ErrorMessage = "Maa� Alan� Bo� B�rak�lamaz...")]
        [Range(1399,8000,ErrorMessage ="Maa� Alan� 1400 ile 8000 Aras�nda Olmal�d�r...")]
        public Nullable<short> Maas { get; set; }


        [Display(Name = "Do�um Tarihi")]
        [Required(ErrorMessage = "L�tfen Do�um Tarihi Se�iniz...")]
        public Nullable<System.DateTime> DogumTarihi { get; set; }

        public Nullable<bool> Cinsiyet { get; set; }

        [Display(Name = "Evlilik Durumu")]
        public Nullable<bool> EvliMi { get; set; }
    
        public virtual Departman Departman { get; set; }
    }
}
