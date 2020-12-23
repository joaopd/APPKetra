using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppKetra.InfraData.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SA2",
                columns: table => new
                {
                    NumFornece = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SA2", x => x.NumFornece);
                });

            migrationBuilder.CreateTable(
                name: "SB1",
                columns: table => new
                {
                    NumProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SB1", x => x.NumProduto);
                });

            migrationBuilder.CreateTable(
                name: "SC7",
                columns: table => new
                {
                    NumPedido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumProduto = table.Column<int>(type: "int", nullable: false),
                    NumFornece = table.Column<int>(type: "int", nullable: false),
                    ValTotal = table.Column<float>(type: "real", nullable: false),
                    DtEmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValUnit = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SC7", x => x.NumPedido);
                });

            migrationBuilder.CreateTable(
                name: "SCR",
                columns: table => new
                {
                    Num = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumAprov = table.Column<int>(type: "int", nullable: false),
                    Situac = table.Column<int>(type: "int", nullable: false),
                    DtLiberac = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SCR", x => x.Num);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SA2");

            migrationBuilder.DropTable(
                name: "SB1");

            migrationBuilder.DropTable(
                name: "SC7");

            migrationBuilder.DropTable(
                name: "SCR");
        }
    }
}
