using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRMSystem.Presentation.Core.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateModified",
                table: "Products",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "UserCreated",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserModified",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_PriceID",
                table: "Products",
                column: "PriceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Prices_PriceID",
                table: "Products",
                column: "PriceID",
                principalTable: "Prices",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Prices_PriceID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_PriceID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DateModified",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UserCreated",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UserModified",
                table: "Products");
        }
    }
}
