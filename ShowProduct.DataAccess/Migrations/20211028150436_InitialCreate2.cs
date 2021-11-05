using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ShowProduct.DataAccess.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "VideoAds",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "VideoAds",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "UserLogs",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "UserLogs",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "ToDos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "ToDos",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Tags",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "Tags",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Subcategories",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "Subcategories",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "SendMails",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "SendMails",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Reports",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "Reports",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Products",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "Products",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "ProductDetails",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "ProductDetails",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Pictures",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "Pictures",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Locations",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "Locations",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Contacts",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "Contacts",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "ContactMessages",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "ContactMessages",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Comments",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "Hit",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "Comments",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "Categories",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Blogs",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "Blogs",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "BlogDetails",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "BlogDetails",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Ads",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "Ads",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Abouts",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastOperationDate",
                table: "Abouts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "VideoAds");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "UserLogs");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "Tags");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "Subcategories");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "SendMails");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "ProductDetails");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "ContactMessages");

            migrationBuilder.DropColumn(
                name: "Hit",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "BlogDetails");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "Ads");

            migrationBuilder.DropColumn(
                name: "LastOperationDate",
                table: "Abouts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "VideoAds",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "UserLogs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "ToDos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Tags",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Subcategories",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "SendMails",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Reports",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "ProductDetails",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Pictures",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Locations",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Contacts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "ContactMessages",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "BlogDetails",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Ads",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IsDeletedDate",
                table: "Abouts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
