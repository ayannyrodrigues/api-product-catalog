using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductCatalog.Infrastructure.Migrations
{
    public partial class ToInsertDataIntoCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Categories(Name, UrlImage) Values('Electronics', 'electronics.jpg')");
            migrationBuilder.Sql("Insert into Categories(Name, UrlImage) Values('Books', 'books.jpg')");
            migrationBuilder.Sql("Insert into Categories(Name, UrlImage) Values('HomeAndKitchen', 'homeAndKitchen.jpg')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Categories");
        }
    }
}
