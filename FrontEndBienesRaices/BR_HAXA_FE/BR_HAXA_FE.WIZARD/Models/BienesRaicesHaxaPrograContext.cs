using Microsoft.EntityFrameworkCore;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BR_HAXA_FE.WIZARD.Models
{
    public partial class BienesRaicesHaxaPrograContext : DbContext
    {
        public BienesRaicesHaxaPrograContext()
        {
        }

        public BienesRaicesHaxaPrograContext(DbContextOptions<BienesRaicesHaxaPrograContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Cita> Cita { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Imagenes> Imagenes { get; set; }
        public virtual DbSet<Propiedad> Propiedad { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=PC-OSCAR;Database=BienesRaicesHaxaProgra;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.Property(e => e.RoleId).IsRequired();

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria)
                    .HasName("pk_categoria");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(60)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cita>(entity =>
            {
                entity.HasKey(e => e.IdCita)
                    .HasName("pk_cita");

                entity.Property(e => e.IdCita).HasColumnName("idCita");

                entity.Property(e => e.FechaFinal)
                    .HasColumnName("fechaFinal")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaInicio)
                    .HasColumnName("fechaInicio")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdPropiedad).HasColumnName("idPropiedad");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.HasOne(d => d.IdPropiedadNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdPropiedad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cita_propiedad");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cita_usuario");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("pk_empleado");

                entity.Property(e => e.IdEmpleado).HasColumnName("idEmpleado");

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasColumnName("apellido1")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasColumnName("apellido2")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CedulaIdentificacion)
                    .IsRequired()
                    .HasColumnName("cedula_identificacion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Estado>(entity =>
            {
                entity.HasKey(e => e.IdEstado)
                    .HasName("pk_Estado");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Imagenes>(entity =>
            {
                entity.HasKey(e => e.IdImagen)
                    .HasName("pk_imagenes");

                entity.Property(e => e.IdImagen).HasColumnName("idImagen");

                entity.Property(e => e.IdPropiedad).HasColumnName("idPropiedad");

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPropiedadNavigation)
                    .WithMany(p => p.Imagenes)
                    .HasForeignKey(d => d.IdPropiedad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_imagenes_propiedad");
            });

            modelBuilder.Entity<Propiedad>(entity =>
            {
                entity.HasKey(e => e.IdPropiedad)
                    .HasName("pk_propiedad");

                entity.Property(e => e.IdPropiedad).HasColumnName("idPropiedad");

                entity.Property(e => e.Baños).HasColumnName("baños");

                entity.Property(e => e.Canton)
                    .IsRequired()
                    .HasColumnName("canton")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasColumnName("direccion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Distrito)
                    .IsRequired()
                    .HasColumnName("distrito")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Garage).HasColumnName("garage");

                entity.Property(e => e.Habitacion).HasColumnName("habitacion");

                entity.Property(e => e.IdCategoria).HasColumnName("idCategoria");

                entity.Property(e => e.IdEstado).HasColumnName("idEstado");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.M2).HasColumnName("m2");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Pisos).HasColumnName("pisos");

                entity.Property(e => e.Precio)
                    .IsRequired()
                    .HasColumnName("precio")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.Provincia)
                    .IsRequired()
                    .HasColumnName("provincia")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Propiedad)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_propiedad_categoria");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.Propiedad)
                    .HasForeignKey(d => d.IdEstado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_propiedad_estado");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Propiedad)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_propiedad_usuario");
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("pkRol");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.NombreRol)
                    .HasColumnName("nombreRol")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("pk_usuario");

                entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasColumnName("apellido1")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .HasColumnName("apellido2")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.CedulaIdentificacion)
                    .IsRequired()
                    .HasColumnName("cedula_identificacion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuario)
                    .HasForeignKey(d => d.IdRol)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuario_rol");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
