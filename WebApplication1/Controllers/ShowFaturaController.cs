using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Controllers
{
    public class ShowFaturaController : Controller
    {
        MVCSiteDBEntities3 _db = new MVCSiteDBEntities3();
        // GET: ShowFatura
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult DatalariGetir()
        {


            List<FaturaShowVM> FaturaDataList = (from f in _db.tbl_Faturalar
                                                 join m in _db.tbl_Musteri on f.MusteriID equals m.MusteriID
                                                 join k in _db.tbl_Kamyonlar on f.KamyonID equals k.KamyonID
                                                 join s in _db.tbl_Soforler on f.SoforID equals s.SoforID
                                                 join d in _db.OdenmeDurumlari on f.DurumID equals d.DurumID
                                                 select new FaturaShowVM
                                                 {
                                                     FaturaID = f.FaturaID,
                                                     KamyonPlakaNo = k.KamyonPlakaNo,
                                                     MusteriAdi = m.MusteriAdi,
                                                     SoforAdiSoyadi = s.SoforAdiSoyadi,
                                                     Tarih=f.Tarih.ToString(),
                                                     Miktar = f.Miktar,
                                                     DurumAciklama = d.DurumAciklama,
                                                     FaturaSeriNo=f.FaturaSeriNo,

                                                 }).ToList();
            return Json(new { data = FaturaDataList }, JsonRequestBehavior.AllowGet);


        }
        public ActionResult Duzenle(int? FaturaID)
        {
            tbl_Faturalar SecilenFatura = null;
            if (FaturaID.HasValue)
            {
                SecilenFatura = _db.tbl_Faturalar.Find(FaturaID);
                return View(SecilenFatura);
            }
            else
                return RedirectToAction("DatalariGetir");

        }
        [HttpPost]
        public ActionResult Duzenle(tbl_Faturalar SecilenFatura)
        {
            if(SecilenFatura.FaturaID!=null)
            {
                tbl_Faturalar GuncellenecekFatura = _db.tbl_Faturalar.Where(a => a.FaturaID == SecilenFatura.FaturaID).FirstOrDefault();
                GuncellenecekFatura.OdenmeDurumlari = SecilenFatura.OdenmeDurumlari;
            }
            int sonuc = _db.SaveChanges();
            if (sonuc > 0)
            {
                ViewBag.status = "success";
                ViewBag.message = "Kişinin Bilgileri Başarıyla Düzenlendi.";
            }
            else
            {
                ViewBag.status = "danger";
                ViewBag.message = "Düzenleme işlemi yapılırken bir sorun yaşanadı.";
            }
            return View();
        }
    }


          
}
    