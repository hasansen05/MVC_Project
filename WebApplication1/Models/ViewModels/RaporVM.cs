using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModels
{
    public class RaporVM
    {
        public int MusteriID { get; set; }
        public List<tbl_Musteri> Musteriler { get; set; }
        public int KamyonID { get; set; }
        public List <tbl_Kamyonlar> Kamyonlar { get; set; }
            public int SoforID { get; set; }
        public List<tbl_Soforler> Soforler { get; set; }
        public DateTime Tarih { get; set; }
        public int Miktar { get; set; }
        public string GidilenYer { get; set; }

    }
}