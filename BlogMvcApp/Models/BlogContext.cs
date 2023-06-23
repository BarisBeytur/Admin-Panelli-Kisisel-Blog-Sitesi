using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogContext:DbContext
    {

        public BlogContext() : base("blogDB")
        {
            Database.SetInitializer(new BlogInitializer());
        }

        public DbSet<Blog> Bloglar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }
        public DbSet<Proje> Projeler { get; set; }
        public DbSet<Admin> Adminler { get; set; }


    }
}