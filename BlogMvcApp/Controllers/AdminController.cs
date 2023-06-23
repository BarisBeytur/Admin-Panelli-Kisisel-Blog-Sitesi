using BlogMvcApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BlogMvcApp.Controllers
{
    public class AdminController : Controller
    {

        BlogContext c = new BlogContext();

        // GET: Admin

       
        public ActionResult Index()
        {       
                return View();
        }

        [HttpPost]
        public ActionResult Index(Admin ad)
        {
            var bilgiler = c.Adminler.FirstOrDefault(x => x.KullaniciAdi == ad.KullaniciAdi && x.Sifre == ad.Sifre);
            if (bilgiler != null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.KullaniciAdi, false);
                Session["kullaniciAdi"] = bilgiler.KullaniciAdi.ToString();
                return RedirectToAction("AdminPanel", "Admin");
            }
            else
            {
                return View();

            }
        }

        [Authorize]
        public ActionResult AdminPanel()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index","Admin");
        }


    }
}