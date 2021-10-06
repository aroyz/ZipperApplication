using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZipperApplication.Models;

namespace ZipperApplication.Data
{
    public class ZipperApplicationContext : DbContext
    {
        public ZipperApplicationContext (DbContextOptions<ZipperApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<ZipperApplication.Models.Zipper> Zipper { get; set; }
    }
}
