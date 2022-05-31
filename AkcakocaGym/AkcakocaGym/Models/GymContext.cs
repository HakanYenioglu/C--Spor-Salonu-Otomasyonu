using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AkcakocaGym.Models
{
    public partial class GymContext : DbContext
    {
        public GymContext()
            : base("name=GymContext1")
        {
        }

        public virtual DbSet<Abonelik> Abonelik { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<Olcum> Olcum { get; set; }
        public virtual DbSet<Paket> Paket { get; set; }
        public virtual DbSet<Satis> Satis { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public virtual DbSet<Yetki> Yetki { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abonelik>()
                .Property(e => e.ucret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Paket>()
                .Property(e => e.ucret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Satis>()
                .Property(e => e.ucret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Urun>()
                .Property(e => e.fiyat)
                .HasPrecision(19, 4);
        }
    }
}
