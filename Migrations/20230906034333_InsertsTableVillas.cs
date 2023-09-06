using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Udemy1_API.Migrations
{
    /// <inheritdoc />
    public partial class InsertsTableVillas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[] { 1, "", "Detalle de la Villa...", new DateTime(2023, 9, 5, 22, 43, 33, 19, DateTimeKind.Local).AddTicks(2612), new DateTime(2023, 9, 5, 22, 43, 33, 19, DateTimeKind.Local).AddTicks(2595), "", 50, "Villa Real", 5, 200.0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
