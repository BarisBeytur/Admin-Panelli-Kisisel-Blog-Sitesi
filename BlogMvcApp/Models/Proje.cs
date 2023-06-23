using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class Proje
    {
        public int Id { get; set; }
        public string ProjeAd { get; set; }
        public string ProjeOzet { get; set; }
        public string ProjeAciklama { get; set; }
        public string ProjeGorsel { get; set; }
        public DateTime ProjeTarihi { get; set; }

    }
}