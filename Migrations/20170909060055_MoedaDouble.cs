using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ValemobiWeb.Migrations
{
    public partial class MoedaDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Preco",
                table: "Mercadoria",
                type: "float8",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Preco",
                table: "Mercadoria",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float8");
        }
    }
}
