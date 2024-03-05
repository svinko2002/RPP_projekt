using EntitiesLayer.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public partial class EventBuddyModel : DbContext
    {
        public EventBuddyModel()
            : base("name=EventBuddyModel")
        {
        }

        public virtual DbSet<dogadaj> dogadaj { get; set; }
        public virtual DbSet<jezik> jezik { get; set; }
        public virtual DbSet<kategorija> kategorija { get; set; }
        public virtual DbSet<korisnik> korisnik { get; set; }
        public virtual DbSet<prijevodi> prijevodi { get; set; }
        public virtual DbSet<status> status { get; set; }
        public virtual DbSet<uloga> uloga { get; set; }
        public virtual DbSet<zahtjev_kategorija> zahtjev_kategorija { get; set; }
        public virtual DbSet<zahtjev_organizator> zahtjev_organizator { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dogadaj>()
                .HasMany(e => e.korisnik1)
                .WithMany(e => e.dogadaj1)
                .Map(m => m.ToTable("sudionici").MapLeftKey("ID_dogadaj").MapRightKey("ID_korisnik"));

            modelBuilder.Entity<dogadaj>()
                .HasMany(e => e.korisnik2)
                .WithMany(e => e.dogadaj2)
                .Map(m => m.ToTable("sudionici_zabrana").MapLeftKey("ID_dogadaj").MapRightKey("ID_korisnik"));

            modelBuilder.Entity<jezik>()
                .HasMany(e => e.prijevodi)
                .WithRequired(e => e.jezik)
                .HasForeignKey(e => e.ID_jezika)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<jezik>()
                .HasMany(e => e.korisnik)
                .WithMany(e => e.jezik)
                .Map(m => m.ToTable("prijevodi_korisnik").MapLeftKey("ID_jezik").MapRightKey("ID_korisnik"));

            modelBuilder.Entity<kategorija>()
                .HasMany(e => e.dogadaj)
                .WithRequired(e => e.kategorija)
                .HasForeignKey(e => e.ID_kategorija)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<korisnik>()
                .HasMany(e => e.dogadaj)
                .WithRequired(e => e.korisnik)
                .HasForeignKey(e => e.ID_korisnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<korisnik>()
                .HasMany(e => e.zahtjev_kategorija)
                .WithRequired(e => e.korisnik)
                .HasForeignKey(e => e.ID_korisnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<korisnik>()
                .HasMany(e => e.zahtjev_organizator)
                .WithRequired(e => e.korisnik)
                .HasForeignKey(e => e.ID_korisnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<korisnik>()
                .HasMany(e => e.uloga)
                .WithMany(e => e.korisnik)
                .Map(m => m.ToTable("uloge").MapLeftKey("ID_korisnik").MapRightKey("ID_uloga"));

            modelBuilder.Entity<status>()
                .HasMany(e => e.dogadaj)
                .WithRequired(e => e.status)
                .HasForeignKey(e => e.ID_status)
                .WillCascadeOnDelete(false);
        }
    }
}
