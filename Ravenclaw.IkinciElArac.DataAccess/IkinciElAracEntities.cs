using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Ravenclaw.IkinciElArac.DataAccess
{
    public partial class IkinciElAracEntities : DbContext
    {
        public IkinciElAracEntities()
            : base("name=IkinciElAracEntities")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Arac> Aracs { get; set; }
        public virtual DbSet<AracFoto> AracFotoes { get; set; }
        public virtual DbSet<AracOzellik> AracOzelliks { get; set; }
        public virtual DbSet<AracSati> AracSatis { get; set; }
        public virtual DbSet<AracStatu> AracStatus { get; set; }
        public virtual DbSet<BireyselKullanici> BireyselKullanicis { get; set; }
        public virtual DbSet<FavoriArama> FavoriAramas { get; set; }
        public virtual DbSet<Fiyat> Fiyats { get; set; }
        public virtual DbSet<Ihale> Ihales { get; set; }
        public virtual DbSet<IhaleFiyat> IhaleFiyats { get; set; }
        public virtual DbSet<IhaleStatu> IhaleStatus { get; set; }
        public virtual DbSet<IletisimTuru> IletisimTurus { get; set; }
        public virtual DbSet<il> ils { get; set; }
        public virtual DbSet<ilan> ilans { get; set; }
        public virtual DbSet<ilanDetay> ilanDetays { get; set; }
        public virtual DbSet<ilce> ilces { get; set; }
        public virtual DbSet<KomisyonUcret> KomisyonUcrets { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<KullaniciIletisim> KullaniciIletisims { get; set; }
        public virtual DbSet<KullaniciTipi> KullaniciTipis { get; set; }
        public virtual DbSet<KurumsalKullanici> KurumsalKullanicis { get; set; }
        public virtual DbSet<Marka> Markas { get; set; }
        public virtual DbSet<Model> Models { get; set; }
        public virtual DbSet<NoterUcret> NoterUcrets { get; set; }
        public virtual DbSet<Paket> Pakets { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<StatuDegisiklik> StatuDegisikliks { get; set; }
        public virtual DbSet<Stok> Stoks { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TramerDetay> TramerDetays { get; set; }
        public virtual DbSet<Yetki> Yetkis { get; set; }
        public virtual DbSet<IhaleArac> IhaleAracs { get; set; }
        public virtual DbSet<RolYetki> RolYetkis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Arac>()
                .HasMany(e => e.IhaleAracs)
                .WithRequired(e => e.Arac)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AracOzellik>()
                .HasMany(e => e.ilanDetays)
                .WithOptional(e => e.AracOzellik)
                .HasForeignKey(e => e.AracOzellikID);

            modelBuilder.Entity<AracOzellik>()
                .HasMany(e => e.ilanDetays1)
                .WithOptional(e => e.AracOzellik1)
                .HasForeignKey(e => e.AracOzellikID);

            modelBuilder.Entity<Fiyat>()
                .Property(e => e.Fiyat1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Ihale>()
                .HasMany(e => e.IhaleAracs)
                .WithRequired(e => e.Ihale)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IhaleFiyat>()
                .Property(e => e.IhaleBaslangicFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<IhaleFiyat>()
                .Property(e => e.IhaleMinAlimFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<IletisimTuru>()
                .HasMany(e => e.KullaniciIletisims)
                .WithOptional(e => e.IletisimTuru)
                .HasForeignKey(e => e.İletisimTuruID);

            modelBuilder.Entity<KomisyonUcret>()
                .Property(e => e.KomisyonUcret1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KomisyonUcret>()
                .Property(e => e.MinFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<KomisyonUcret>()
                .Property(e => e.MaxFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Kullanici>()
                .Property(e => e.Sifre)
                .IsFixedLength();

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.ilans)
                .WithOptional(e => e.Kullanici)
                .HasForeignKey(e => e.KullaniciID);

            modelBuilder.Entity<Kullanici>()
                .HasMany(e => e.ilans1)
                .WithOptional(e => e.Kullanici1)
                .HasForeignKey(e => e.KullaniciID);

            modelBuilder.Entity<NoterUcret>()
                .Property(e => e.NoterUcret1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.RolYetkis)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TramerDetay>()
                .Property(e => e.SagArkaCamurluk)
                .IsFixedLength();

            modelBuilder.Entity<TramerDetay>()
                .Property(e => e.ArkaKaput)
                .IsFixedLength();

            modelBuilder.Entity<TramerDetay>()
                .Property(e => e.SolArkaKapi)
                .IsFixedLength();

            modelBuilder.Entity<TramerDetay>()
                .Property(e => e.SagOnKapi)
                .IsFixedLength();

            modelBuilder.Entity<TramerDetay>()
                .Property(e => e.Tavan)
                .IsFixedLength();

            modelBuilder.Entity<TramerDetay>()
                .Property(e => e.SolOnKapi)
                .IsFixedLength();

            modelBuilder.Entity<TramerDetay>()
                .Property(e => e.SagOnCamurluk)
                .IsFixedLength();

            modelBuilder.Entity<TramerDetay>()
                .Property(e => e.MotorKaputu)
                .IsFixedLength();

            modelBuilder.Entity<TramerDetay>()
                .Property(e => e.SolOnCamurluk)
                .IsFixedLength();

            modelBuilder.Entity<TramerDetay>()
                .Property(e => e.OnTampon)
                .IsFixedLength();

            modelBuilder.Entity<TramerDetay>()
                .Property(e => e.ArkaTampon)
                .IsFixedLength();

            modelBuilder.Entity<TramerDetay>()
                .Property(e => e.TramerUcret)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Yetki>()
                .HasMany(e => e.RolYetkis)
                .WithRequired(e => e.Yetki)
                .WillCascadeOnDelete(false);
        }
    }
}
