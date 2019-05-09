using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModels
{
    public class FaturaVM
    {
        public int MusteriID { get; set; }
        public List<tbl_Musteri> Musteriler { get; set; }
        public int KamyonID { get; set; }
        public List<tbl_Kamyonlar> Kamyonlar { get; set; }
        public int SoforID { get; set; }
        public List<tbl_Soforler> Soforler { get; set; }
        public DateTime Tarih { get; set; }
        public int Miktar { get; set; }
        public string FaturaSeriNo { get; set; }
        public int DurumID { get; set; }
        public List <OdenmeDurumlari> DurumAciklamalari { get; set; }
    }
}