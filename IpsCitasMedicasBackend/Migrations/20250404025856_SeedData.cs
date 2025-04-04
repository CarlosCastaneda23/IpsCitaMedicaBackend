using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IpsCitasMedicasBackend.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Citas",
                columns: new[] { "Id", "Especialidad", "Estado", "FechaHora", "MedicoId" },
                values: new object[] { 2, "Odontología", "Ocupado", new DateTime(2025, 4, 6, 15, 30, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Especialidad",
                value: "Odontologia");

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "Id", "Especialidad", "Nombre" },
                values: new object[,]
                {
                    { 3, "Medicina General", "Dr. Luis Martínez" },
                    { 4, "Odontologia", "Dra. Camila López" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "Id", "Apellidos", "Documento", "FechaNacimiento", "Nombres", "Telefono" },
                values: new object[,]
                {
                    { 2, "Gómez", "987654321", new DateTime(1988, 8, 15, 8, 30, 0, 0, DateTimeKind.Unspecified), "Laura", "3019876543" },
                    { 3, "Fernández", "1122334455", new DateTime(2000, 12, 25, 14, 15, 0, 0, DateTimeKind.Unspecified), "Sofía", "3152223344" }
                });

            migrationBuilder.InsertData(
                table: "Citas",
                columns: new[] { "Id", "Especialidad", "Estado", "FechaHora", "MedicoId" },
                values: new object[,]
                {
                    { 3, "Medicina General", "Disponible", new DateTime(2025, 4, 7, 9, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "Odontologia", "Disponible", new DateTime(2025, 4, 8, 13, 45, 0, 0, DateTimeKind.Unspecified), 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Especialidad",
                value: "Odontología");
        }
    }
}
