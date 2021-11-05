using Microsoft.EntityFrameworkCore.Migrations;

namespace ShowProduct.DataAccess.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "EMailAddress",
                table: "Comments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EMailAddress",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
