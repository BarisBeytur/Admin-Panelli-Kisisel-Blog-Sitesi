using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> categories = new List<Category>()
            {
                new Category() { KategoriAdi = "C#"},
                new Category() { KategoriAdi = "ASP.NET MVC"},
                new Category() { KategoriAdi = "ASP.NET WEB FORM"},
                new Category() { KategoriAdi = "Windows Form"}
            };

            foreach (var category in categories)
            {
                context.Kategoriler.Add(category);
            }
            context.SaveChanges();


            List<Blog> blogs = new List<Blog>()
            {
                new Blog() { Baslik = "C# Delegates Hakkında", Aciklama="C# Delegates Hakkında acıklama kısmı burası", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik= "C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında içerik kısmı", Resim="1.jpg", CategoryId=1},
                new Blog() { Baslik = "Python Delegates Hakkında", Aciklama="C# Delegates Hakkında acıklama kısmı burası", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=false, Icerik= "C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında içerik kısmı", Resim="1.jpg", CategoryId=1},
                new Blog() { Baslik = "C# Syntax Hakkında", Aciklama="C# Delegates Hakkında acıklama kısmı burası", EklenmeTarihi=DateTime.Now.AddDays(-30), Anasayfa=false, Onay=true, Icerik= "C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında içerik kısmı", Resim="1.jpg", CategoryId=1},
                new Blog() { Baslik = "Python Syntax Hakkında", Aciklama="C# Delegates Hakkında acıklama kısmı burası", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik= "C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında içerik kısmı", Resim="2.jpg", CategoryId=2},
                new Blog() { Baslik = "C# Delegates Hakkında", Aciklama="C# Delegates Hakkında acıklama kısmı burası", EklenmeTarihi=DateTime.Now.AddDays(-20), Anasayfa=true, Onay=false, Icerik= "C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında içerik kısmı", Resim="1.jpg", CategoryId=2},
                new Blog() { Baslik = "C# Koşullar Hakkında", Aciklama="C# Delegates Hakkında acıklama kısmı burası", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik= "C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında içerik kısmı", Resim="2.jpg", CategoryId=2},
                new Blog() { Baslik = "Java Delegates Hakkında", Aciklama="C# Delegates Hakkında acıklama kısmı burası", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=true, Icerik= "C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında içerik kısmı", Resim="1.jpg", CategoryId=3},
                new Blog() { Baslik = "JavaScript Delegates Hakkında", Aciklama="C# Delegates Hakkında acıklama kısmı burası", EklenmeTarihi=DateTime.Now.AddDays(-30), Anasayfa=true, Onay=true, Icerik= "C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında içerik kısmı", Resim="2.jpg", CategoryId=3},
                new Blog() { Baslik = "C# Delegates Hakkında", Aciklama="C# Delegates Hakkında acıklama kısmı burası", EklenmeTarihi=DateTime.Now.AddDays(-20), Anasayfa=true, Onay=true, Icerik= "C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında içerik kısmı", Resim="1.jpg", CategoryId=3},
                new Blog() { Baslik = "Generic List Hakkında", Aciklama="C# Delegates Hakkında acıklama kısmı burası", EklenmeTarihi=DateTime.Now.AddDays(-15), Anasayfa=true, Onay=true, Icerik= "C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında içerik kısmı", Resim="2.jpg", CategoryId=4},
                new Blog() { Baslik = "C# Delegates Hakkında", Aciklama="C# Delegates Hakkında acıklama kısmı burası", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=false, Onay=true, Icerik= "C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında içerik kısmı", Resim="1.jpg", CategoryId=4},
                new Blog() { Baslik = "C# Delegates Hakkında", Aciklama="C# Delegates Hakkında acıklama kısmı burası", EklenmeTarihi=DateTime.Now.AddDays(-10), Anasayfa=true, Onay=true, Icerik= "C# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates HakkındaC# Delegates Hakkında içerik kısmı", Resim="1.jpg", CategoryId=4},
            }; 

            foreach (var item in blogs)
            {
                context.Bloglar.Add(item);
            }





            base.Seed(context);
        }
    }
}