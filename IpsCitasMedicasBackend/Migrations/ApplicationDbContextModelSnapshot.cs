﻿// <auto-generated />
using System;
using IpsCitasMedicasBackend.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace IpsCitasMedicasBackend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IpsCitasMedicasBackend.Models.Cita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.Property<int>("MedicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.ToTable("Citas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Especialidad = "Medicina General",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 5, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 1
                        },
                        new
                        {
                            Id = 2,
                            Especialidad = "Odontología",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 6, 11, 30, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 2
                        },
                        new
                        {
                            Id = 3,
                            Especialidad = "Medicina General",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 7, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 3
                        },
                        new
                        {
                            Id = 4,
                            Especialidad = "Odontologia",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 8, 14, 15, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 4
                        },
                        new
                        {
                            Id = 5,
                            Especialidad = "Medicina General",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 9, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 1
                        },
                        new
                        {
                            Id = 6,
                            Especialidad = "Odontología",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 10, 15, 0, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 2
                        },
                        new
                        {
                            Id = 7,
                            Especialidad = "Medicina General",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 11, 13, 0, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 3
                        },
                        new
                        {
                            Id = 8,
                            Especialidad = "Odontologia",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 12, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 4
                        },
                        new
                        {
                            Id = 9,
                            Especialidad = "Medicina General",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 13, 16, 45, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 1
                        },
                        new
                        {
                            Id = 10,
                            Especialidad = "Odontología",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 14, 9, 30, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 2
                        },
                        new
                        {
                            Id = 11,
                            Especialidad = "Medicina General",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 15, 11, 15, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 3
                        },
                        new
                        {
                            Id = 12,
                            Especialidad = "Odontologia",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 16, 14, 0, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 4
                        },
                        new
                        {
                            Id = 13,
                            Especialidad = "Medicina General",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 17, 12, 30, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 1
                        },
                        new
                        {
                            Id = 14,
                            Especialidad = "Odontología",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 18, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 2
                        },
                        new
                        {
                            Id = 15,
                            Especialidad = "Medicina General",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 19, 8, 45, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 3
                        },
                        new
                        {
                            Id = 16,
                            Especialidad = "Odontologia",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 20, 13, 30, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 4
                        },
                        new
                        {
                            Id = 17,
                            Especialidad = "Medicina General",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 21, 15, 45, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 1
                        },
                        new
                        {
                            Id = 18,
                            Especialidad = "Odontología",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 22, 9, 0, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 2
                        },
                        new
                        {
                            Id = 19,
                            Especialidad = "Medicina General",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 23, 10, 30, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 3
                        },
                        new
                        {
                            Id = 20,
                            Especialidad = "Odontologia",
                            Estado = "Disponible",
                            FechaHora = new DateTime(2025, 4, 24, 11, 45, 0, 0, DateTimeKind.Unspecified),
                            MedicoId = 4
                        });
                });

            modelBuilder.Entity("IpsCitasMedicasBackend.Models.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Medicos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Especialidad = "Odontologia",
                            Nombre = "Dr. Juan Pérez"
                        },
                        new
                        {
                            Id = 2,
                            Especialidad = "Medicina General",
                            Nombre = "Dra. Ana Gómez"
                        },
                        new
                        {
                            Id = 3,
                            Especialidad = "Odontologia",
                            Nombre = "Dr. Luis Martínez"
                        },
                        new
                        {
                            Id = 4,
                            Especialidad = "Medicina General",
                            Nombre = "Dra. Camila López"
                        },
                        new
                        {
                            Id = 5,
                            Especialidad = "Odontologia",
                            Nombre = "Dr. Sergio Rojas"
                        },
                        new
                        {
                            Id = 6,
                            Especialidad = "Medicina General",
                            Nombre = "Dra. Paula Ruiz"
                        },
                        new
                        {
                            Id = 7,
                            Especialidad = "Odontologia",
                            Nombre = "Dr. Mario Torres"
                        },
                        new
                        {
                            Id = 8,
                            Especialidad = "Medicina General",
                            Nombre = "Dra. Diana Castro"
                        },
                        new
                        {
                            Id = 9,
                            Especialidad = "Odontologia",
                            Nombre = "Dr. Andrés Vélez"
                        },
                        new
                        {
                            Id = 10,
                            Especialidad = "Medicina General",
                            Nombre = "Dra. Lorena Mendoza"
                        },
                        new
                        {
                            Id = 11,
                            Especialidad = "Odontologia",
                            Nombre = "Dr. Esteban Naranjo"
                        },
                        new
                        {
                            Id = 12,
                            Especialidad = "Medicina General",
                            Nombre = "Dra. Silvia Cárdenas"
                        },
                        new
                        {
                            Id = 13,
                            Especialidad = "Odontologia",
                            Nombre = "Dr. Felipe Gómez"
                        },
                        new
                        {
                            Id = 14,
                            Especialidad = "Medicina General",
                            Nombre = "Dra. Marcela Duarte"
                        },
                        new
                        {
                            Id = 15,
                            Especialidad = "Odontologia",
                            Nombre = "Dr. Pedro Lozano"
                        },
                        new
                        {
                            Id = 16,
                            Especialidad = "Medicina General",
                            Nombre = "Dra. Claudia Ramírez"
                        },
                        new
                        {
                            Id = 17,
                            Especialidad = "Odontologia",
                            Nombre = "Dr. Ricardo Torres"
                        },
                        new
                        {
                            Id = 18,
                            Especialidad = "Medicina General",
                            Nombre = "Dra. Patricia Ortiz"
                        },
                        new
                        {
                            Id = 19,
                            Especialidad = "Odontologia",
                            Nombre = "Dr. Julián Arias"
                        },
                        new
                        {
                            Id = 20,
                            Especialidad = "Medicina General",
                            Nombre = "Dra. Carolina Silva"
                        });
                });

            modelBuilder.Entity("IpsCitasMedicasBackend.Models.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pacientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Apellidos = "Ramírez",
                            Documento = "123456789",
                            FechaNacimiento = new DateTime(1995, 5, 10, 10, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Carlos",
                            Telefono = "3001234567"
                        },
                        new
                        {
                            Id = 2,
                            Apellidos = "Gómez",
                            Documento = "987654321",
                            FechaNacimiento = new DateTime(1988, 8, 15, 8, 30, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Laura",
                            Telefono = "3019876543"
                        },
                        new
                        {
                            Id = 3,
                            Apellidos = "Fernández",
                            Documento = "1122334455",
                            FechaNacimiento = new DateTime(2000, 12, 25, 14, 15, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Sofía",
                            Telefono = "3152223344"
                        },
                        new
                        {
                            Id = 4,
                            Apellidos = "Pérez",
                            Documento = "123123123",
                            FechaNacimiento = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Andrés",
                            Telefono = "3101231231"
                        },
                        new
                        {
                            Id = 5,
                            Apellidos = "Rodríguez",
                            Documento = "456456456",
                            FechaNacimiento = new DateTime(1993, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Lucía",
                            Telefono = "3124564567"
                        },
                        new
                        {
                            Id = 6,
                            Apellidos = "Hernández",
                            Documento = "789789789",
                            FechaNacimiento = new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Mateo",
                            Telefono = "3117897897"
                        },
                        new
                        {
                            Id = 7,
                            Apellidos = "Jiménez",
                            Documento = "321321321",
                            FechaNacimiento = new DateTime(2001, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Valentina",
                            Telefono = "3163213213"
                        },
                        new
                        {
                            Id = 8,
                            Apellidos = "López",
                            Documento = "654654654",
                            FechaNacimiento = new DateTime(1985, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Sebastián",
                            Telefono = "3136546546"
                        },
                        new
                        {
                            Id = 9,
                            Apellidos = "Torres",
                            Documento = "987987987",
                            FechaNacimiento = new DateTime(2002, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Camila",
                            Telefono = "3179879879"
                        },
                        new
                        {
                            Id = 10,
                            Apellidos = "Ruiz",
                            Documento = "741741741",
                            FechaNacimiento = new DateTime(1996, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Daniel",
                            Telefono = "3187417417"
                        },
                        new
                        {
                            Id = 11,
                            Apellidos = "Mendoza",
                            Documento = "852852852",
                            FechaNacimiento = new DateTime(1994, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Manuela",
                            Telefono = "3148528528"
                        },
                        new
                        {
                            Id = 12,
                            Apellidos = "Suárez",
                            Documento = "963963963",
                            FechaNacimiento = new DateTime(1991, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Tomás",
                            Telefono = "3199639639"
                        },
                        new
                        {
                            Id = 13,
                            Apellidos = "Moreno",
                            Documento = "159159159",
                            FechaNacimiento = new DateTime(2003, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Isabella",
                            Telefono = "3201591591"
                        },
                        new
                        {
                            Id = 14,
                            Apellidos = "Castro",
                            Documento = "753753753",
                            FechaNacimiento = new DateTime(1987, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Julián",
                            Telefono = "3227537537"
                        },
                        new
                        {
                            Id = 15,
                            Apellidos = "Ríos",
                            Documento = "951951951",
                            FechaNacimiento = new DateTime(1992, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Gabriela",
                            Telefono = "3239519519"
                        },
                        new
                        {
                            Id = 16,
                            Apellidos = "Peña",
                            Documento = "357357357",
                            FechaNacimiento = new DateTime(1989, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Felipe",
                            Telefono = "3243573573"
                        },
                        new
                        {
                            Id = 17,
                            Apellidos = "Ortega",
                            Documento = "258258258",
                            FechaNacimiento = new DateTime(1998, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Daniela",
                            Telefono = "3252582582"
                        },
                        new
                        {
                            Id = 18,
                            Apellidos = "Vargas",
                            Documento = "654321654",
                            FechaNacimiento = new DateTime(1990, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Santiago",
                            Telefono = "3266543216"
                        },
                        new
                        {
                            Id = 19,
                            Apellidos = "Silva",
                            Documento = "369369369",
                            FechaNacimiento = new DateTime(1997, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Mariana",
                            Telefono = "3273693693"
                        },
                        new
                        {
                            Id = 20,
                            Apellidos = "Castaño",
                            Documento = "147147147",
                            FechaNacimiento = new DateTime(2001, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Nombres = "Alejandro",
                            Telefono = "3281471471"
                        });
                });

            modelBuilder.Entity("IpsCitasMedicasBackend.Models.Cita", b =>
                {
                    b.HasOne("IpsCitasMedicasBackend.Models.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medico");
                });
#pragma warning restore 612, 618
        }
    }
}
