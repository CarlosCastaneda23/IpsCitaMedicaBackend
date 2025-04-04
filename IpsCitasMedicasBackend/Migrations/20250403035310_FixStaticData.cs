using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IpsCitasMedicasBackend.Migrations
{
    /// <inheritdoc />
    public partial class FixStaticData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "Id", "Especialidad", "Nombre" },
                values: new object[,]
                {
                    { 1, "Medicina General", "Dr. Juan Pérez" },
                    { 2, "Odontología", "Dra. Ana Gómez" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "Id", "Apellidos", "Documento", "FechaNacimiento", "Nombres", "Telefono" },
                values: new object[] { 1, "Ramírez", "123456789", new DateTime(1995, 5, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", "3001234567" });

            migrationBuilder.InsertData(
                table: "Citas",
                columns: new[] { "Id", "Especialidad", "Estado", "FechaHora", "MedicoId" },
                values: new object[] { 1, "Medicina General", "Disponible", new DateTime(2025, 4, 5, 10, 0, 0, 0, DateTimeKind.Unspecified), 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
