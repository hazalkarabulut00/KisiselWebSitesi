using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KisiselWebSitesi.Models;

public partial class KisiselWebSitesiDatabaseContext : DbContext
{
    public KisiselWebSitesiDatabaseContext()
    {
    }

    public KisiselWebSitesiDatabaseContext(DbContextOptions<KisiselWebSitesiDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<AnaSayfa> AnaSayfas { get; set; }

    public virtual DbSet<Ikonlarr> Ikonlarrs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=HAZALKARABULUT\\SQLEXPRESS;Database=KisiselWebSitesiDatabase;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Admin>(entity =>
        {
            entity.ToTable("Admin");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.KullaniciAdi)
                .HasMaxLength(50)
                .HasColumnName("kullaniciAdi");
            entity.Property(e => e.Sifre)
                .HasMaxLength(50)
                .HasColumnName("sifre");
        });

        modelBuilder.Entity<AnaSayfa>(entity =>
        {
            entity.ToTable("AnaSayfa");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(50)
                .HasColumnName("aciklama");
            entity.Property(e => e.Iletisim)
                .HasMaxLength(50)
                .HasColumnName("iletisim");
            entity.Property(e => e.Isim)
                .HasMaxLength(50)
                .HasColumnName("isim");
            entity.Property(e => e.Profil)
                .HasMaxLength(50)
                .HasColumnName("profil");
            entity.Property(e => e.Unvan)
                .HasMaxLength(50)
                .HasColumnName("unvan");
        });

        modelBuilder.Entity<Ikonlarr>(entity =>
        {
            entity.ToTable("Ikonlarr");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Ikon)
                .HasMaxLength(50)
                .HasColumnName("ikon");
            entity.Property(e => e.Link)
                .HasMaxLength(50)
                .HasColumnName("link");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
