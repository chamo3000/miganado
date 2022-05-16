using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Migan.Models
{
    public partial class MIGANContext : DbContext
    {
        public MIGANContext()
        {
        }

        public MIGANContext(DbContextOptions<MIGANContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clase> Clases { get; set; } = null!;
        public virtual DbSet<Clasecliente> Claseclientes { get; set; } = null!;
        public virtual DbSet<Cliente> Clientes { get; set; } = null!;
        public virtual DbSet<Factura> Facturas { get; set; } = null!;
        public virtual DbSet<Gasto> Gastos { get; set; } = null!;
        public virtual DbSet<Perfile> Perfiles { get; set; } = null!;
        public virtual DbSet<Sexo> Sexos { get; set; } = null!;
        public virtual DbSet<Tipocliente> Tipoclientes { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<VistaComprador> VistaCompradors { get; set; } = null!;
        public virtual DbSet<VistaPropietario> VistaPropietarios { get; set; } = null!;
        public virtual DbSet<Vistafactura> Vistafacturas { get; set; } = null!;
        public virtual DbSet<Vistahaciendum> Vistahacienda { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=CHAMO\\SQLEXPRESS;Initial Catalog=MIGAN;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clase>(entity =>
            {
                entity.ToTable("CLASE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Clase1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("clase");

                entity.Property(e => e.ClaseGanado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("claseGanado")
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");
            });

            modelBuilder.Entity<Clasecliente>(entity =>
            {
                entity.HasKey(e => new { e.IdCliente, e.IdTipoCliente })
                    .HasName("PK__CLASECLI__57B38B4529540DEE");

                entity.ToTable("CLASECLIENTE");

                entity.Property(e => e.IdCliente).HasColumnName("idCliente");

                entity.Property(e => e.IdTipoCliente).HasColumnName("idTipoCliente");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Claseclientes)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CLASECLIE__idCli__2739D489");

                entity.HasOne(d => d.IdTipoClienteNavigation)
                    .WithMany(p => p.Claseclientes)
                    .HasForeignKey(d => d.IdTipoCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CLASECLIE__idTip__282DF8C2");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("CLIENTE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cedula)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cedula");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FACTURA");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.Cabezas).HasColumnName("cabezas");

                entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");

                entity.Property(e => e.Corral).HasColumnName("corral");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.IdClaseGanado).HasColumnName("id_claseGanado");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdSexo).HasColumnName("id_sexo");

                entity.Property(e => e.Kilos).HasColumnName("kilos");

                entity.Property(e => e.Reunion).HasColumnName("reunion");

                entity.Property(e => e.ValorKg).HasColumnName("valorKg");

                entity.Property(e => e.ValorTotal).HasColumnName("valorTotal");

                entity.HasOne(d => d.IdClaseGanadoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdClaseGanado)
                    .HasConstraintName("id_claseGanado");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("id_cliente");

                entity.HasOne(d => d.IdSexoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdSexo)
                    .HasConstraintName("id_sexo");
            });

            modelBuilder.Entity<Gasto>(entity =>
            {
                entity.ToTable("GASTO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Anticipo).HasColumnName("anticipo");

                entity.Property(e => e.Bano).HasColumnName("bano");

                entity.Property(e => e.Bascula).HasColumnName("bascula");

                entity.Property(e => e.Cliente).HasColumnName("cliente");

                entity.Property(e => e.ComisionF).HasColumnName("comisionF");

                entity.Property(e => e.ComisionG).HasColumnName("comisionG");

                entity.Property(e => e.Observacion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("observacion");

                entity.Property(e => e.Otros).HasColumnName("otros");

                entity.Property(e => e.Recibida).HasColumnName("recibida");

                entity.Property(e => e.Reunion).HasColumnName("reunion");

                entity.Property(e => e.Transporte).HasColumnName("transporte");

                entity.Property(e => e.Vacuna).HasColumnName("vacuna");

                entity.HasOne(d => d.ClienteNavigation)
                    .WithMany(p => p.Gastos)
                    .HasForeignKey(d => d.Cliente)
                    .HasConstraintName("FK__GASTO__cliente__114A936A");
            });

            modelBuilder.Entity<Perfile>(entity =>
            {
                entity.ToTable("PERFILES");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPCION");
            });

            modelBuilder.Entity<Sexo>(entity =>
            {
                entity.ToTable("SEXO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Sexo1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("sexo")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Tipocliente>(entity =>
            {
                entity.ToTable("TIPOCLIENTE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Valor)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("valor")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("USUARIO");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("APELLIDO");

                entity.Property(e => e.Contrasena)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CONTRASENA");

                entity.Property(e => e.Idperfil).HasColumnName("IDPERFIL");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("NOMBRE");

                entity.Property(e => e.Usuario1)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("USUARIO");

                entity.HasOne(d => d.IdperfilNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.Idperfil)
                    .HasConstraintName("FK__USUARIO__IDPERFI__57A801BA");
            });

            modelBuilder.Entity<VistaComprador>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vistaComprador");

                entity.Property(e => e.Cédula)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripción)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");
            });

            modelBuilder.Entity<VistaPropietario>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vistaPropietario");

                entity.Property(e => e.Cédula)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descripción)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vistafactura>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VISTAFACTURA");

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.Apellido)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoComprador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Apellido_Comprador");

                entity.Property(e => e.Cabezas).HasColumnName("cabezas");

                entity.Property(e => e.ClaseGanado)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Clase_Ganado");

                entity.Property(e => e.Consecutivo).HasColumnName("consecutivo");

                entity.Property(e => e.Corral).HasColumnName("corral");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Kilos).HasColumnName("kilos");

                entity.Property(e => e.NombreComprador)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Comprador");

                entity.Property(e => e.NombrePropietario)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Propietario");

                entity.Property(e => e.Reunion).HasColumnName("reunion");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("sexo");

                entity.Property(e => e.ValorKg)
                    .HasColumnType("money")
                    .HasColumnName("valorKg");

                entity.Property(e => e.ValorTotal)
                    .HasColumnType("money")
                    .HasColumnName("valorTotal");
            });

            modelBuilder.Entity<Vistahaciendum>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VISTAHACIENDA");

                entity.Property(e => e.CedulaCliente)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Cedula_Cliente");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Municipio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCliente)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Cliente");

                entity.Property(e => e.NombreHacienda)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Nombre_Hacienda");

                entity.Property(e => e.PrimerApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("primerApellido");

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("segundoApellido");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
