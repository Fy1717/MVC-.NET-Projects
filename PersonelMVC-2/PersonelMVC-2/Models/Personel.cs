using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonelMVC_2.Models
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public int DepartmanId { get; set; }
    }
}