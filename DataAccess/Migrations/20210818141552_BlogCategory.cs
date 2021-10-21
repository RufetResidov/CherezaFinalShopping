using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class BlogCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BlogCategoryID",
                table: "Blogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BlogCategory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategory", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_BlogCategoryID",
                table: "Blogs",
                column: "BlogCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogs_BlogCategory_BlogCategoryID",
                table: "Blogs",
                column: "BlogCategoryID",
                principalTable: "BlogCategory",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogs_BlogCategory_BlogCategoryID",
                table: "Blogs");

            migrationBuilder.DropTable(
                name: "BlogCategory");

            migrationBuilder.DropIndex(
                name: "IX_Blogs_BlogCategoryID",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "BlogCategoryID",
                table: "Blogs");
        }
    }
}
