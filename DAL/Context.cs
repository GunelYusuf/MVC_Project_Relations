using System;
using Microsoft.EntityFrameworkCore;
using MVC_Projects.Models;

namespace MVC_Projects.DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options):base(options)
        {
            
        }
        public DbSet<ShopProduct>  shopProducts{ get; set; }

        public DbSet<ImagesProducts> images { get; set; }
    }
}
