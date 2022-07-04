using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace RS2_seminarski_tattoostudio.Database
{
    public partial class TattooStudioRSIIContext : DbContext
    {
        public TattooStudioRSIIContext()
        {
        }

        public TattooStudioRSIIContext(DbContextOptions<TattooStudioRSIIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Izvjestaj> Izvjestajs { get; set; }
        public virtual DbSet<Klijent> Klijents { get; set; }
        public virtual DbSet<Narudzba> Narudzbas { get; set; }
        public virtual DbSet<Obavijest> Obavijests { get; set; }
        public virtual DbSet<Portfolio> Portfolios { get; set; }
        public virtual DbSet<Proizvod> Proizvods { get; set; }
        public virtual DbSet<Spol> Spols { get; set; }
        public virtual DbSet<StavkeNarudzbe> StavkeNarudzbes { get; set; }
        public virtual DbSet<StavkePortfolium> StavkePortfolia { get; set; }
        public virtual DbSet<Termin> Termins { get; set; }
        public virtual DbSet<TipProizvodum> TipProizvoda { get; set; }
        public virtual DbSet<TipTermina> TipTerminas { get; set; }
        public virtual DbSet<Uposlenik> Uposleniks { get; set; }
        public virtual DbSet<Zanimanje> Zanimanjes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=TattooStudioRSII; Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Bosnian_Latin_100_CI_AS");

            modelBuilder.Entity<Izvjestaj>(entity =>
            {
                entity.ToTable("Izvjestaj");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Detalji).HasMaxLength(500);

                entity.HasOne(d => d.Uposlenik)
                    .WithMany(p => p.Izvjestajs)
                    .HasForeignKey(d => d.UposlenikId)
                    .HasConstraintName("fk_izvjestaj_uposlenik");
            });

            modelBuilder.Entity<Klijent>(entity =>
            {
                entity.ToTable("Klijent");

                entity.Property(e => e.DatumRodjenja).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Ime).HasMaxLength(20);

                entity.Property(e => e.KorisnickoIme).HasMaxLength(20);

                entity.Property(e => e.LozinkaHash).HasMaxLength(100);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(100);

                entity.Property(e => e.Prezime).HasMaxLength(30);

                entity.Property(e => e.Telefon).HasMaxLength(20);

                entity.HasOne(d => d.Spol)
                    .WithMany(p => p.Klijents)
                    .HasForeignKey(d => d.SpolId)
                    .HasConstraintName("fk_klijent_spol");
            });

            modelBuilder.Entity<Narudzba>(entity =>
            {
                entity.ToTable("Narudzba");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.IsIsporucena).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPlacena).HasDefaultValueSql("((0))");

                entity.Property(e => e.UkupniIznos).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Narudzbas)
                    .HasForeignKey(d => d.KlijentId)
                    .HasConstraintName("fk_narudzba_klijent");
            });

            modelBuilder.Entity<Obavijest>(entity =>
            {
                entity.ToTable("Obavijest");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Naslov).HasMaxLength(50);

                entity.Property(e => e.Sadrzaj).HasMaxLength(500);

                entity.HasOne(d => d.Uposlenik)
                    .WithMany(p => p.Obavijests)
                    .HasForeignKey(d => d.UposlenikId)
                    .HasConstraintName("fk_obavijest_uposlenik");
            });

            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.ToTable("Portfolio");

                entity.HasIndex(e => e.UposlenikId, "fk_uposlenik_portfolio")
                    .IsUnique();

                entity.Property(e => e.Opis).HasMaxLength(100);

                entity.HasOne(d => d.Uposlenik)
                    .WithOne(p => p.Portfolio)
                    .HasForeignKey<Portfolio>(d => d.UposlenikId)
                    .HasConstraintName("FK__Portfolio__Uposl__44FF419A");
            });

            modelBuilder.Entity<Proizvod>(entity =>
            {
                entity.ToTable("Proizvod");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Naziv).HasMaxLength(35);

                entity.Property(e => e.Opis).HasMaxLength(40);

                entity.HasOne(d => d.TipProizvoda)
                    .WithMany(p => p.Proizvods)
                    .HasForeignKey(d => d.TipProizvodaId)
                    .HasConstraintName("fk_proizvod_tip");
            });

            modelBuilder.Entity<Spol>(entity =>
            {
                entity.ToTable("Spol");

                entity.Property(e => e.Naziv).HasMaxLength(6);
            });

            modelBuilder.Entity<StavkeNarudzbe>(entity =>
            {
                entity.ToTable("StavkeNarudzbe");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.StavkeNarudzbes)
                    .HasForeignKey(d => d.NarudzbaId)
                    .HasConstraintName("fk_narudzbaproizvod");

                entity.HasOne(d => d.Proizvod)
                    .WithMany(p => p.StavkeNarudzbes)
                    .HasForeignKey(d => d.ProizvodId)
                    .HasConstraintName("fk_narudzba_proizvod");
            });

            modelBuilder.Entity<StavkePortfolium>(entity =>
            {
                entity.HasKey(e => e.StavkaPortfoliaId)
                    .HasName("pk_stavkaportfoliaid");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.Opis).HasMaxLength(100);

                entity.HasOne(d => d.Portfolio)
                    .WithMany(p => p.StavkePortfolia)
                    .HasForeignKey(d => d.PortfolioId)
                    .HasConstraintName("fk_stavka_portfolio");
            });

            modelBuilder.Entity<Termin>(entity =>
            {
                entity.ToTable("Termin");

                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Datum).HasColumnType("date");

                entity.Property(e => e.IsOdobren).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOtkazan).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsPlacen).HasDefaultValueSql("((0))");

                entity.Property(e => e.Komentar).HasMaxLength(60);

                entity.Property(e => e.Opis).HasMaxLength(200);

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Termins)
                    .HasForeignKey(d => d.KlijentId)
                    .HasConstraintName("fk_klijent_termin");

                entity.HasOne(d => d.TipTermina)
                    .WithMany(p => p.Termins)
                    .HasForeignKey(d => d.TipTerminaId)
                    .HasConstraintName("fk_termin_tip");

                entity.HasOne(d => d.Uposlenik)
                    .WithMany(p => p.Termins)
                    .HasForeignKey(d => d.UposlenikId)
                    .HasConstraintName("fk_uposlenik_termin");
            });

            modelBuilder.Entity<TipProizvodum>(entity =>
            {
                entity.HasKey(e => e.TipProizvodaId)
                    .HasName("pk_tipproizovda");

                entity.Property(e => e.Naziv).HasMaxLength(50);
            });

            modelBuilder.Entity<TipTermina>(entity =>
            {
                entity.ToTable("TipTermina");

                entity.Property(e => e.Naziv).HasMaxLength(50);
            });

            modelBuilder.Entity<Uposlenik>(entity =>
            {
                entity.ToTable("Uposlenik");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Ime).HasMaxLength(20);

                entity.Property(e => e.KorisnickoIme).HasMaxLength(20);

                entity.Property(e => e.LozinkaHash).HasMaxLength(100);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(100);

                entity.Property(e => e.Prezime).HasMaxLength(30);

                entity.Property(e => e.Telefon).HasMaxLength(20);

                entity.HasOne(d => d.Spol)
                    .WithMany(p => p.Uposleniks)
                    .HasForeignKey(d => d.SpolId)
                    .HasConstraintName("fk_uposlenik_spol");

                entity.HasOne(d => d.Zanimanje)
                    .WithMany(p => p.Uposleniks)
                    .HasForeignKey(d => d.ZanimanjeId)
                    .HasConstraintName("fk_uposlenik_zanimanje");
            });

            modelBuilder.Entity<Zanimanje>(entity =>
            {
                entity.ToTable("Zanimanje");

                entity.Property(e => e.Naziv).HasMaxLength(40);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
