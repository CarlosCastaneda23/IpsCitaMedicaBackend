using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IpsCitasMedicasBackend.Migrations
{
    /// <inheritdoc />
    public partial class SeedCitasPacientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Estado", "FechaHora" },
                values: new object[] { "Disponible", new DateTime(2025, 4, 6, 11, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaHora",
                value: new DateTime(2025, 4, 8, 14, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Citas",
                columns: new[] { "Id", "Especialidad", "Estado", "FechaHora", "MedicoId" },
                values: new object[,]
                {
                    { 5, "Medicina General", "Disponible", new DateTime(2025, 4, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 6, "Odontología", "Disponible", new DateTime(2025, 4, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 7, "Medicina General", "Disponible", new DateTime(2025, 4, 11, 13, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 8, "Odontologia", "Disponible", new DateTime(2025, 4, 12, 8, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 9, "Medicina General", "Disponible", new DateTime(2025, 4, 13, 16, 45, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 10, "Odontología", "Disponible", new DateTime(2025, 4, 14, 9, 30, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 11, "Medicina General", "Disponible", new DateTime(2025, 4, 15, 11, 15, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, "Odontologia", "Disponible", new DateTime(2025, 4, 16, 14, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 13, "Medicina General", "Disponible", new DateTime(2025, 4, 17, 12, 30, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, "Odontología", "Disponible", new DateTime(2025, 4, 18, 10, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, "Medicina General", "Disponible", new DateTime(2025, 4, 19, 8, 45, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, "Odontologia", "Disponible", new DateTime(2025, 4, 20, 13, 30, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 17, "Medicina General", "Disponible", new DateTime(2025, 4, 21, 15, 45, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 18, "Odontología", "Disponible", new DateTime(2025, 4, 22, 9, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 19, "Medicina General", "Disponible", new DateTime(2025, 4, 23, 10, 30, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 20, "Odontologia", "Disponible", new DateTime(2025, 4, 24, 11, 45, 0, 0, DateTimeKind.Unspecified), 4 }
                });

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Especialidad",
                value: "Odontologia");

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Especialidad",
                value: "Medicina General");

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Especialidad",
                value: "Odontologia");

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Especialidad",
                value: "Medicina General");

            migrationBuilder.InsertData(
                table: "Medicos",
                columns: new[] { "Id", "Especialidad", "Nombre" },
                values: new object[,]
                {
                    { 5, "Odontologia", "Dr. Sergio Rojas" },
                    { 6, "Medicina General", "Dra. Paula Ruiz" },
                    { 7, "Odontologia", "Dr. Mario Torres" },
                    { 8, "Medicina General", "Dra. Diana Castro" },
                    { 9, "Odontologia", "Dr. Andrés Vélez" },
                    { 10, "Medicina General", "Dra. Lorena Mendoza" },
                    { 11, "Odontologia", "Dr. Esteban Naranjo" },
                    { 12, "Medicina General", "Dra. Silvia Cárdenas" },
                    { 13, "Odontologia", "Dr. Felipe Gómez" },
                    { 14, "Medicina General", "Dra. Marcela Duarte" },
                    { 15, "Odontologia", "Dr. Pedro Lozano" },
                    { 16, "Medicina General", "Dra. Claudia Ramírez" },
                    { 17, "Odontologia", "Dr. Ricardo Torres" },
                    { 18, "Medicina General", "Dra. Patricia Ortiz" },
                    { 19, "Odontologia", "Dr. Julián Arias" },
                    { 20, "Medicina General", "Dra. Carolina Silva" }
                });

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "Id", "Apellidos", "Documento", "FechaNacimiento", "Nombres", "Telefono" },
                values: new object[,]
                {
                    { 4, "Pérez", "123123123", new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrés", "3101231231" },
                    { 5, "Rodríguez", "456456456", new DateTime(1993, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lucía", "3124564567" },
                    { 6, "Hernández", "789789789", new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mateo", "3117897897" },
                    { 7, "Jiménez", "321321321", new DateTime(2001, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Valentina", "3163213213" },
                    { 8, "López", "654654654", new DateTime(1985, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sebastián", "3136546546" },
                    { 9, "Torres", "987987987", new DateTime(2002, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Camila", "3179879879" },
                    { 10, "Ruiz", "741741741", new DateTime(1996, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", "3187417417" },
                    { 11, "Mendoza", "852852852", new DateTime(1994, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manuela", "3148528528" },
                    { 12, "Suárez", "963963963", new DateTime(1991, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomás", "3199639639" },
                    { 13, "Moreno", "159159159", new DateTime(2003, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isabella", "3201591591" },
                    { 14, "Castro", "753753753", new DateTime(1987, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Julián", "3227537537" },
                    { 15, "Ríos", "951951951", new DateTime(1992, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriela", "3239519519" },
                    { 16, "Peña", "357357357", new DateTime(1989, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felipe", "3243573573" },
                    { 17, "Ortega", "258258258", new DateTime(1998, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniela", "3252582582" },
                    { 18, "Vargas", "654321654", new DateTime(1990, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Santiago", "3266543216" },
                    { 19, "Silva", "369369369", new DateTime(1997, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mariana", "3273693693" },
                    { 20, "Castaño", "147147147", new DateTime(2001, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alejandro", "3281471471" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Estado", "FechaHora" },
                values: new object[] { "Ocupado", new DateTime(2025, 4, 6, 15, 30, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Citas",
                keyColumn: "Id",
                keyValue: 4,
                column: "FechaHora",
                value: new DateTime(2025, 4, 8, 13, 45, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Especialidad",
                value: "Medicina General");

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Especialidad",
                value: "Odontologia");

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Especialidad",
                value: "Medicina General");

            migrationBuilder.UpdateData(
                table: "Medicos",
                keyColumn: "Id",
                keyValue: 4,
                column: "Especialidad",
                value: "Odontologia");
        }
    }
}
