using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{

    public class FaturaController : Controller
    {
        MVCSiteDBEntities3 _db = new MVCSiteDBEntities3();
        // GET: Fatura
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FaturaEkle()
        {
            FaturaVM model = new FaturaVM()
            {
                Kamyonlar = _db.tbl_Kamyonlar.ToList(),
                Musteriler = _db.tbl_Musteri.ToList(),
                Soforler = _db.tbl_Soforler.ToList(),
                DurumAciklamalari = _db.OdenmeDurumlari.ToList(),
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult FaturaEkle(FaturaVM model)
        {
            return View();
        }


        [HttpPost]
        public ActionResult Save(FaturaVM model, tbl_Faturalar rapor)
        {
            rapor.DurumID = model.DurumID;
            rapor.MusteriID = model.MusteriID;
            rapor.KamyonID = model.KamyonID;
            rapor.SoforID = model.SoforID;
            rapor.Tarih = model.Tarih;
            rapor.Miktar = model.Miktar;
            rapor.FaturaSeriNo = model.FaturaSeriNo;
            _db.tbl_Faturalar.Add(rapor);
            int satir = 0;
            satir = _db.SaveChanges();
            if (satir > 0)
            {
                TempData["msg"] = "<script>alert('Başarıyla kaydedildi');</script>";
                return RedirectToAction("FaturaEkle");

            }
            else
            {
                TempData["msg"] = "<script>alert('Lutfen Bilgileri kontrol edin');</script>";
                return View();
            }

        }


        public ActionResult Save()
        {
            return View();
        }
    }
}