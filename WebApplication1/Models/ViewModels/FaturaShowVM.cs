using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.ViewModels
{
    public class FaturaShowVM
    {
        public int FaturaID { get; set; }
        public string FaturaSeriNo { get; set; }
        public int MusteriID { get; set; }
        public string MusteriAdi { get; set; }
        public int KamyonID { get; set; }
        public string KamyonPlakaNo { get; set; }
        public string Tarih { get; set; }
        public int Miktar { get; set; }
        public int DurumID { get; set; }
        public string DurumAciklama { get; set; }
        public int SoforID { get; set; }
        public string SoforAdiSoyadi { get; set; }

    }
}