using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QUYNH.Models
{
    public partial class QuynhDbContext : DbContext
    {
        public QuynhDbContext()
            : base("name=QuynhDbContext")
        {
        }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
