using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotelmanagment.Data.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SalaadedSupris",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    Suprimento = table.Column<string>(type: "TEXT", nullable: false),
                    DataCreat = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Usercreat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaadedSupris", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    Tiposala = table.Column<string>(type: "TEXT", nullable: false),
                    Valor = table.Column<double>(type: "REAL", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    Fotosaloes = table.Column<string>(type: "TEXT", nullable: false),
                    DataCreat = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Usercreat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    NomeServico = table.Column<string>(type: "TEXT", nullable: false),
                    Estado = table.Column<bool>(type: "INTEGER", nullable: false),
                    DataCreat = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Usercreat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Suprimentos",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    Suprimento = table.Column<string>(type: "TEXT", nullable: false),
                    DataCreat = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Usercreat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suprimentos", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Tiposdequarto",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    Tipodquarto = table.Column<string>(type: "TEXT", nullable: false),
                    Descricao = table.Column<string>(type: "TEXT", nullable: false),
                    DataCreat = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Usercreat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tiposdequarto", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "SalasSuprimetos",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    CodSalas = table.Column<Guid>(type: "TEXT", nullable: false),
                    QuartosCodigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    SupriId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SuprimentosCodigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    SalaaddSupriCodigo = table.Column<Guid>(type: "TEXT", nullable: true),
                    DataCreat = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Usercreat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalasSuprimetos", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_SalasSuprimetos_SalaadedSupris_SalaaddSupriCodigo",
                        column: x => x.SalaaddSupriCodigo,
                        principalTable: "SalaadedSupris",
                        principalColumn: "Codigo");
                    table.ForeignKey(
                        name: "FK_SalasSuprimetos_SalasSuprimetos_SuprimentosCodigo",
                        column: x => x.SuprimentosCodigo,
                        principalTable: "SalasSuprimetos",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalasSuprimetos_Salas_QuartosCodigo",
                        column: x => x.QuartosCodigo,
                        principalTable: "Salas",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    QuartoId = table.Column<Guid>(type: "TEXT", nullable: false),
                    QuartosCodigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    Adultos = table.Column<int>(type: "INTEGER", nullable: false),
                    Menores = table.Column<int>(type: "INTEGER", nullable: false),
                    DataInicio = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Dias = table.Column<int>(type: "INTEGER", nullable: false),
                    Total = table.Column<double>(type: "REAL", nullable: false),
                    Valorpago = table.Column<double>(type: "REAL", nullable: false),
                    VolorApagar = table.Column<double>(type: "REAL", nullable: false),
                    Tipo = table.Column<int>(type: "INTEGER", nullable: false),
                    DataCreat = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Usercreat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "quartos",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nquarto = table.Column<int>(type: "INTEGER", nullable: false),
                    Tipodquarto = table.Column<Guid>(type: "TEXT", nullable: false),
                    tiposdequartoCodigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    Nocupantes = table.Column<int>(type: "INTEGER", nullable: false),
                    Voip = table.Column<int>(type: "INTEGER", nullable: false),
                    Preco = table.Column<double>(type: "REAL", nullable: false),
                    Desponibilidade = table.Column<int>(type: "INTEGER", nullable: false),
                    Localizacao = table.Column<string>(type: "TEXT", nullable: false),
                    Tipodecamas = table.Column<int>(type: "INTEGER", nullable: false),
                    Fotodoquarto = table.Column<string>(type: "TEXT", nullable: false),
                    BookingCodigo = table.Column<Guid>(type: "TEXT", nullable: true),
                    DataCreat = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Usercreat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quartos", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_quartos_Bookings_BookingCodigo",
                        column: x => x.BookingCodigo,
                        principalTable: "Bookings",
                        principalColumn: "Codigo");
                    table.ForeignKey(
                        name: "FK_quartos_Tiposdequarto_tiposdequartoCodigo",
                        column: x => x.tiposdequartoCodigo,
                        principalTable: "Tiposdequarto",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuartosSuprimetos",
                columns: table => new
                {
                    Codigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    QuratosID = table.Column<Guid>(type: "TEXT", nullable: false),
                    QuartosCodigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    SupriId = table.Column<Guid>(type: "TEXT", nullable: false),
                    SuprimentosCodigo = table.Column<Guid>(type: "TEXT", nullable: false),
                    DataCreat = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Usercreat = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuartosSuprimetos", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_QuartosSuprimetos_Suprimentos_SuprimentosCodigo",
                        column: x => x.SuprimentosCodigo,
                        principalTable: "Suprimentos",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuartosSuprimetos_quartos_QuartosCodigo",
                        column: x => x.QuartosCodigo,
                        principalTable: "quartos",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_QuartosCodigo",
                table: "Bookings",
                column: "QuartosCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_quartos_BookingCodigo",
                table: "quartos",
                column: "BookingCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_quartos_tiposdequartoCodigo",
                table: "quartos",
                column: "tiposdequartoCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_QuartosSuprimetos_QuartosCodigo",
                table: "QuartosSuprimetos",
                column: "QuartosCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_QuartosSuprimetos_SuprimentosCodigo",
                table: "QuartosSuprimetos",
                column: "SuprimentosCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_SalasSuprimetos_QuartosCodigo",
                table: "SalasSuprimetos",
                column: "QuartosCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_SalasSuprimetos_SalaaddSupriCodigo",
                table: "SalasSuprimetos",
                column: "SalaaddSupriCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_SalasSuprimetos_SuprimentosCodigo",
                table: "SalasSuprimetos",
                column: "SuprimentosCodigo");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_quartos_QuartosCodigo",
                table: "Bookings",
                column: "QuartosCodigo",
                principalTable: "quartos",
                principalColumn: "Codigo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_quartos_QuartosCodigo",
                table: "Bookings");

            migrationBuilder.DropTable(
                name: "QuartosSuprimetos");

            migrationBuilder.DropTable(
                name: "SalasSuprimetos");

            migrationBuilder.DropTable(
                name: "Servicos");

            migrationBuilder.DropTable(
                name: "Suprimentos");

            migrationBuilder.DropTable(
                name: "SalaadedSupris");

            migrationBuilder.DropTable(
                name: "Salas");

            migrationBuilder.DropTable(
                name: "quartos");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Tiposdequarto");
        }
    }
}
