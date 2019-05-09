using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        //Login işlemini burda yaptırıyorum.
        [HttpPost]
        public ActionResult Account(string email, string password)
        {
            using (MVCSiteDBEntities3 _db = new MVCSiteDBEntities3())
            {
                var userDetails = _db.tbl_Kullancilar.Where(a => a.KullaniciAdi == email && a.KullaniciPassword == password).FirstOrDefault();
                if (userDetails == null)
                {
                    TempData["msg"] = "<script>alert('Kullanıcı Adı ve Şifrenizi yanlış girdiniz.');</script>";
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    TempData["msg"] = "<script>alert('Başarıyla Giriş yaptınız Yönlendiriliyorsunuz..');</script>";
                    return RedirectToAction("Index", "Home");
                }
            }
        }
    }
  

   


}