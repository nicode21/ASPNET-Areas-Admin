using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Elearn_BackEnd.Migrations
{
    public partial class AddAuthorImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorImage",
                table: "CourchesAuthor",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorImage",
                table: "CourchesAuthor");
        }
    }
}
