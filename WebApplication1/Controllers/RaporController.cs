using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;
namespace WebApplication1.Controllers
{
    public class RaporController : Controller
    {
        MVCSiteDBEntities3 _db = new MVCSiteDBEntities3();
        // GET: Rapor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListeleriDoldur()
        {
            RaporVM model = new RaporVM()
            {
                Kamyonlar = _db.tbl_Kamyonlar.ToList(),
                Musteriler= _db.tbl_Musteri.ToList(),
                Soforler=_db.tbl_Soforler.ToList(),
                           };
            return View(model);
        }
        [HttpPost]
        public ActionResult ListeleriDoldur(RaporVM model)
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Kaydet(RaporVM model,tbl_NakliyeRapor rapor)
        {
            rapor.MusteriID = model.MusteriID;
            rapor.KamyonID = model.KamyonID;
            rapor.Tarih = model.Tarih;
            rapor.Miktar = model.Miktar;
            rapor.SoforID = model.SoforID;
            rapor.GidilenYer = model.GidilenYer;            
            _db.tbl_NakliyeRapor.Add(rapor);
            int satir = 0;
            satir = _db.SaveChanges();
            if (satir > 0)
            {
                TempData["msg"] = "<script>alert('Başarıyla kaydedildi');</script>";
                return RedirectToAction("ListeleriDoldur");

            }
            else
            {
                TempData["msg"] = "<script>alert('Lutfen Bilgileri kontrol edin');</script>";
                return View();
            }
        }
        public ActionResult Kaydet()
        {
            return View();
        }
    }
}