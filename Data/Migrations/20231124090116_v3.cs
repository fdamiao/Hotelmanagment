using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotelmanagment.Data.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    CodigoCLi = table.Column<int>(type: "INTEGER", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Ntelefone = table.Column<string>(type: "TEXT", nullable: false),
                    Nacionalidade = table.Column<string>(type: "TEXT", nullable: false),
                    DataCreat = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Usercreat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Codigo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
